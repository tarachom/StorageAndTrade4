
/*     
        Організації_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_QUcIriZFB06zhg6h5S4vYw")]
public partial class Організації_PointerControl : PointerControl
{
    event EventHandler<Організації_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{Організації_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static Організації_PointerControl New() => NewWithProperties([]);

    Організації_Pointer pointer = new();
    public Організації_Pointer Pointer
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
        Організації_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new Організації_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new Організації_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    