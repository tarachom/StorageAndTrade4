

/*     
        ПланРахунків_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_EnLTchBHrkWXoL946rMpbA")]
public partial class ПланРахунків_PointerTablePartCell : PointerTablePartCell
{
    public static ПланРахунків_PointerTablePartCell New() => NewWithProperties([]);

    ПланРахунків_Pointer pointer = new();
    public ПланРахунків_Pointer Pointer
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
        Pointer = new ПланРахунків_Pointer(p ?? new UniqueID());
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

        ПланРахунків_ШвидкийВибір page = ПланРахунків_ШвидкийВибір.New();
        page.PopoverParent = popover;

        page.AllowedContentSelection = ConfigurationDirectories.HierarchicalContentType.Elements;

        page.DirectoryPointerItem = pointer.UniqueID;
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
