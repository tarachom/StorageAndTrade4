
/*     
        НовийДовідник_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("NovyiDovidnyk_PointerControl")]
public partial class НовийДовідник_PointerControl : PointerControl
{
    public static НовийДовідник_PointerControl New() => NewWithProperties([]);

    event EventHandler<НовийДовідник_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{НовийДовідник_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = !pointer.IsEmpty() ? await pointer.GetPresentation() : "";
    }

    НовийДовідник_Pointer pointer = new();
    public НовийДовідник_Pointer Pointer
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

        НовийДовідник_ШвидкийВибір page = НовийДовідник_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new НовийДовідник_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new НовийДовідник_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    