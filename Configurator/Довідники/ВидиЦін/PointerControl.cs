
/*     
        ВидиЦін_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_ixsXYKuwm0WcI7BwsWf6Lw")]
public partial class ВидиЦін_PointerControl : PointerControl
{
    event EventHandler<ВидиЦін_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ВидиЦін_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ВидиЦін_PointerControl New() => NewWithProperties([]);

    ВидиЦін_Pointer pointer = new();
    public ВидиЦін_Pointer Pointer
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
        ВидиЦін_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ВидиЦін_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ВидиЦін_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    