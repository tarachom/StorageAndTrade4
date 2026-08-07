

/*     
        КласифікаторОдиницьВиміру_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_SdafAZLMxX2bg5jQXJsYw")]
public partial class КласифікаторОдиницьВиміру_PointerTablePartCell : PointerTablePartCell
{
    public static КласифікаторОдиницьВиміру_PointerTablePartCell New() => NewWithProperties([]);

    КласифікаторОдиницьВиміру_Pointer pointer = new();
    public КласифікаторОдиницьВиміру_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            Presentation = pointer.Name;
        }
    }

    public async Task GetPresentation() => Presentation = !pointer.IsEmpty() ? await pointer.GetPresentation() : "";

    async Task PointerChange(UniqueID? p)
    {
        Pointer = new КласифікаторОдиницьВиміру_Pointer(p ?? new UniqueID());
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

        КласифікаторОдиницьВиміру_ШвидкийВибір page = КласифікаторОдиницьВиміру_ШвидкийВибір.New();
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
    