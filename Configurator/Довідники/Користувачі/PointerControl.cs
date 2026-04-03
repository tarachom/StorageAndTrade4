
/*     
        Користувачі_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_Ghmu8BrA20ugzhwN7KqMlQ")]
public partial class Користувачі_PointerControl : PointerControl
{
    event EventHandler<Користувачі_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{Користувачі_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static Користувачі_PointerControl New() => NewWithProperties([]);

    Користувачі_Pointer pointer = new();
    public Користувачі_Pointer Pointer
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

    

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        Користувачі_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new Користувачі_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new Користувачі_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    