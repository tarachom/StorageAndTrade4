

/*     
        ПакуванняОдиниціВиміру_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_P4Q35Y3XgEmBRqu1WkZGYA")]
public partial class ПакуванняОдиниціВиміру_PointerTablePartCell : PointerTablePartCell
{
    public static ПакуванняОдиниціВиміру_PointerTablePartCell New() => NewWithProperties([]);

    ПакуванняОдиниціВиміру_Pointer pointer = new();
    public ПакуванняОдиниціВиміру_Pointer Pointer
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
        Pointer = new ПакуванняОдиниціВиміру_Pointer(p ?? new UniqueID());
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

        ПакуванняОдиниціВиміру_ШвидкийВибір page = ПакуванняОдиниціВиміру_ШвидкийВибір.New();
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
    