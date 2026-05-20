
/*     
        Співробітники_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_m63SNVQ4e0Oq0BrlMgzksQ")]
public partial class Співробітники_PointerControl : PointerControl
{
    event EventHandler<Співробітники_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{Співробітники_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static Співробітники_PointerControl New() => NewWithProperties([]);

    Співробітники_Pointer pointer = new();
    public Співробітники_Pointer Pointer
    {
        get
        {
            return pointer;
        }
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

        Співробітники_ШвидкийВибір page = Співробітники_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new Співробітники_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new Співробітники_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    