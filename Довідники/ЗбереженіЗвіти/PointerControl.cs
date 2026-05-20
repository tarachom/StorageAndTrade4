
/*     
        ЗбереженіЗвіти_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_0i3afSF7fkCZCWKdEkAs7w")]
public partial class ЗбереженіЗвіти_PointerControl : PointerControl
{
    event EventHandler<ЗбереженіЗвіти_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ЗбереженіЗвіти_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ЗбереженіЗвіти_PointerControl New() => NewWithProperties([]);

    ЗбереженіЗвіти_Pointer pointer = new();
    public ЗбереженіЗвіти_Pointer Pointer
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

    
    public Користувачі_Pointer Власник { get; set; } = new Користувачі_Pointer();
    

    public ConfigurationDirectories.HierarchicalContentType? AllowedContentSelection { get; set; }

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        ЗбереженіЗвіти_ШвидкийВибір page = ЗбереженіЗвіти_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ЗбереженіЗвіти_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        
        page.Власник.Pointer = Власник;
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗбереженіЗвіти_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    