
/*     
        ЗбереженіЗвіти_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_pZvUmPDDhki78rObkPJhcw")]
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
    

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        ЗбереженіЗвіти_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ЗбереженіЗвіти_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
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
    