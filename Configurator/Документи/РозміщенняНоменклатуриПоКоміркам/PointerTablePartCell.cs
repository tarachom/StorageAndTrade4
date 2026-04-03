

/*     
        РозміщенняНоменклатуриПоКоміркам_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_BK722EioakCqOZGx27WaTA")]
public partial class РозміщенняНоменклатуриПоКоміркам_PointerTablePartCell : PointerTablePartCell
{
    public static РозміщенняНоменклатуриПоКоміркам_PointerTablePartCell New() => NewWithProperties([]);

    РозміщенняНоменклатуриПоКоміркам_Pointer pointer = new();
    public РозміщенняНоменклатуриПоКоміркам_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            Presentation = pointer.Name;
        }
    }

    public async ValueTask GetPresentation() => Presentation = pointer != null ? await pointer.GetPresentation() : "";

    async ValueTask PointerChange(UniqueID? p)
    {
        Pointer = new РозміщенняНоменклатуриПоКоміркам_Pointer(p ?? new UniqueID());
        await GetPresentation();
        OnSelect?.Invoke();
    }

    protected override async void Select(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        РозміщенняНоменклатуриПоКоміркам_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = pointer.UniqueID,
            CallBack_OnSelectPointer = async p => 
            {
                await PointerChange(p);
                AfterSelectFunc?.Invoke();
            }
        };

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
    