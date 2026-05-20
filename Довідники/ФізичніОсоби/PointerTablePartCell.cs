

/*     
        ФізичніОсоби_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_RxP86N15bEeSuBrOnJ9Slg")]
public partial class ФізичніОсоби_PointerTablePartCell : PointerTablePartCell
{
    public static ФізичніОсоби_PointerTablePartCell New() => NewWithProperties([]);

    ФізичніОсоби_Pointer pointer = new();
    public ФізичніОсоби_Pointer Pointer
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
        Pointer = new ФізичніОсоби_Pointer(p ?? new UniqueID());
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

        ФізичніОсоби_ШвидкийВибір page = ФізичніОсоби_ШвидкийВибір.New();
        page.PopoverParent = popover;
            
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
    