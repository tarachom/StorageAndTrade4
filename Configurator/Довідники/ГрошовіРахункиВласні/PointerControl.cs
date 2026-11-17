
/*     
        ГрошовіРахункиВласні_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("HroshoviRakhunkyVlasni_PointerControl")]
public partial class ГрошовіРахункиВласні_PointerControl : PointerControl
{
    public static ГрошовіРахункиВласні_PointerControl New() => NewWithProperties([]);

    event EventHandler<ГрошовіРахункиВласні_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ГрошовіРахункиВласні_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = !pointer.IsEmpty() ? await pointer.GetPresentation() : "";
    }

    ГрошовіРахункиВласні_Pointer pointer = new();
    public ГрошовіРахункиВласні_Pointer Pointer
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

        ГрошовіРахункиВласні_ШвидкийВибір page = ГрошовіРахункиВласні_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ГрошовіРахункиВласні_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ГрошовіРахункиВласні_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    