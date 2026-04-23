

/*     
        ПоверненняТоварівВідКлієнта_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_vZrUd9oSgkWd4Kmv352Hw")]
public partial class ПоверненняТоварівВідКлієнта_PointerTablePartCell : PointerTablePartCell
{
    public static ПоверненняТоварівВідКлієнта_PointerTablePartCell New() => NewWithProperties([]);

    ПоверненняТоварівВідКлієнта_Pointer pointer = new();
    public ПоверненняТоварівВідКлієнта_Pointer Pointer
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
        Pointer = new ПоверненняТоварівВідКлієнта_Pointer(p ?? new UniqueID());
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

        ПоверненняТоварівВідКлієнта_ШвидкийВибір page = ПоверненняТоварівВідКлієнта_ШвидкийВибір.New();
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
    