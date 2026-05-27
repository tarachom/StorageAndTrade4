

/*     
        ПоступленняТоварівТаПослуг_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_EyEZ6KQK0GR4yG1DGDEGQ")]
public partial class ПоступленняТоварівТаПослуг_PointerTablePartCell : PointerTablePartCell
{
    public static ПоступленняТоварівТаПослуг_PointerTablePartCell New() => NewWithProperties([]);

    ПоступленняТоварівТаПослуг_Pointer pointer = new();
    public ПоступленняТоварівТаПослуг_Pointer Pointer
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
        Pointer = new ПоступленняТоварівТаПослуг_Pointer(p ?? new UniqueID());
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

        ПоступленняТоварівТаПослуг_ШвидкийВибір page = ПоступленняТоварівТаПослуг_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = pointer.UniqueID;
        page.CallBack_OnSelectPointer = async p => 
        {
            await PointerChange(p);
            AfterSelectFunc?.Invoke();
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
    