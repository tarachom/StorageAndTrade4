

/*     
        КорегуванняБоргу_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_fF7ETzJqGUWcBocEP1Z3Ug")]
public partial class КорегуванняБоргу_PointerTablePartCell : PointerTablePartCell
{
    public static КорегуванняБоргу_PointerTablePartCell New() => NewWithProperties([]);

    КорегуванняБоргу_Pointer pointer = new();
    public КорегуванняБоргу_Pointer Pointer
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
        Pointer = new КорегуванняБоргу_Pointer(p ?? new UniqueID());
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
        КорегуванняБоргу_ШвидкийВибір page = new()
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
    