

/*     
        КоригуванняНезавершеногоВиробництва_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_km6eAV4RdHeg1o0eFTQZmQ")]
public partial class КоригуванняНезавершеногоВиробництва_PointerTablePartCell : PointerTablePartCell
{
    public static КоригуванняНезавершеногоВиробництва_PointerTablePartCell New() => NewWithProperties([]);

    КоригуванняНезавершеногоВиробництва_Pointer pointer = new();
    public КоригуванняНезавершеногоВиробництва_Pointer Pointer
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
        Pointer = new КоригуванняНезавершеногоВиробництва_Pointer(p ?? new UniqueID());
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

        КоригуванняНезавершеногоВиробництва_ШвидкийВибір page = КоригуванняНезавершеногоВиробництва_ШвидкийВибір.New();
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
    