
/*     
        КласифікаторОдиницьВиміру_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_SdafAe0CeHC3f8kSXzTonw")]
public partial class КласифікаторОдиницьВиміру_PointerControl : PointerControl
{
    event EventHandler<КласифікаторОдиницьВиміру_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{КласифікаторОдиницьВиміру_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = !pointer.IsEmpty() ? await pointer.GetPresentation() : "";
    }

    public static КласифікаторОдиницьВиміру_PointerControl New() => NewWithProperties([]);

    КласифікаторОдиницьВиміру_Pointer pointer = new();
    public КласифікаторОдиницьВиміру_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            PointerChanged?.Invoke(null, pointer);
        }
    }

    

    public ConfigurationDirectories.HierarchicalContentType? AllowedContentSelection { get; set; }

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        КласифікаторОдиницьВиміру_ШвидкийВибір page = КласифікаторОдиницьВиміру_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new КласифікаторОдиницьВиміру_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new КласифікаторОдиницьВиміру_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    