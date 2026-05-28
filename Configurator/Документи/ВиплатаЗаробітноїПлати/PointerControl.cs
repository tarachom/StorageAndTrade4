

/*     
        ВиплатаЗаробітноїПлати_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_wEtQ2QGkUKpaH0URwgYRQ")]
public partial class ВиплатаЗаробітноїПлати_PointerControl : PointerControl
{
    event EventHandler<ВиплатаЗаробітноїПлати_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ВиплатаЗаробітноїПлати_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ВиплатаЗаробітноїПлати_PointerControl New() => NewWithProperties([]);

    ВиплатаЗаробітноїПлати_Pointer pointer = new();
    public ВиплатаЗаробітноїПлати_Pointer Pointer
    {
        get => pointer;
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

        ВиплатаЗаробітноїПлати_ШвидкийВибір page = ВиплатаЗаробітноїПлати_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ВиплатаЗаробітноїПлати_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ВиплатаЗаробітноїПлати_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    