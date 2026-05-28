

/*     
        ПрибуткуванняТоварівВПереробку_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_6m6eAdxxXGtZj1YhqpCg")]
public partial class ПрибуткуванняТоварівВПереробку_PointerControl : PointerControl
{
    event EventHandler<ПрибуткуванняТоварівВПереробку_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПрибуткуванняТоварівВПереробку_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПрибуткуванняТоварівВПереробку_PointerControl New() => NewWithProperties([]);

    ПрибуткуванняТоварівВПереробку_Pointer pointer = new();
    public ПрибуткуванняТоварівВПереробку_Pointer Pointer
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

        ПрибуткуванняТоварівВПереробку_ШвидкийВибір page = ПрибуткуванняТоварівВПереробку_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПрибуткуванняТоварівВПереробку_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПрибуткуванняТоварівВПереробку_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    