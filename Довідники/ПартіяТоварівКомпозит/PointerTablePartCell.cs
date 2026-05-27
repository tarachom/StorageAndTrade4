

/*     
        ПартіяТоварівКомпозит_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;
using NPOI.Util.Optional;
using GeneratedCode.РегістриНакопичення;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_TX0HFAhPEaKOvE8m6A")]
public partial class ПартіяТоварівКомпозит_PointerTablePartCell : PointerTablePartCell
{
    public static ПартіяТоварівКомпозит_PointerTablePartCell New() => NewWithProperties([]);

    ПартіяТоварівКомпозит_Pointer pointer = new();
    public ПартіяТоварівКомпозит_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            Presentation = pointer.Name;
        }
    }

    public async Task GetPresentation() => Presentation = pointer != null ? await pointer.GetPresentation() : "";

    async Task PointerChange(UniqueID? p)
    {
        Pointer = new ПартіяТоварівКомпозит_Pointer(p ?? new UniqueID());
        await GetPresentation();
        OnSelect?.Invoke();
    }

    public Номенклатура_Pointer? НоменклатураВідбір { get; set; } = null;
    public ХарактеристикиНоменклатури_Pointer? ХарактеристикиНоменклатуриВідбір { get; set; } = null;

    protected override async void Select(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        ПартіяТоварівКомпозит_ШвидкийВибір page = ПартіяТоварівКомпозит_ШвидкийВибір.New();
        page.PopoverParent = popover;

        page.DirectoryPointerItem = pointer.UniqueID;
        page.CallBack_OnSelectPointer = async p =>
        {
            await PointerChange(p);
            AfterSelectFunc?.Invoke();
        };

        if (НоменклатураВідбір != null && !НоменклатураВідбір.IsEmpty())
        {
            /*
            Якщо вибрана Номенклатура тоді показуємо тільки партії, які є в наявності.
            Використовується таблиця Підсумки з регістру ПартіїТоварів
            */

            //Відбір партій які є в наявності по номенклатурі
            string query = @$"
SELECT DISTINCT
    ПартіїТоварів_Підсумки.{ПартіїТоварів_Підсумки_TablePart.ПартіяТоварівКомпозит}
FROM 
    {ПартіїТоварів_Підсумки_TablePart.TABLE} AS ПартіїТоварів_Підсумки
WHERE
    ПартіїТоварів_Підсумки.{ПартіїТоварів_Підсумки_TablePart.Номенклатура} = '{НоменклатураВідбір.UniqueID}' AND
    ПартіїТоварів_Підсумки.{ПартіїТоварів_Підсумки_TablePart.Кількість} > 0
";
            //Відбір партій які є в наявності по характеристиках
            if (ХарактеристикиНоменклатуриВідбір != null && !ХарактеристикиНоменклатуриВідбір.IsEmpty())
            {
                query += @$" AND
    ПартіїТоварів_Підсумки.{ПартіїТоварів_Підсумки_TablePart.ХарактеристикаНоменклатури} = '{ХарактеристикиНоменклатуриВідбір.UniqueID}'
";
            }

            //Додатково показується партія яка вже вибрана, навіть якщо її немає в залишку через об'єднання (UNION)
            if (!Pointer.IsEmpty())
                query = @$"( {query} ) UNION ( SELECT '{Pointer.UniqueID}' )";

            page.WhereList = [new("uid", Comparison.IN, query, true)];
        }

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override async void Clear()
    {
        await PointerChange(null);
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
