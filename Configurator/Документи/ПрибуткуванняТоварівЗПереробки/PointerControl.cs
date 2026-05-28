

/*     
        ПрибуткуванняТоварівЗПереробки_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_626eAUV8JHq4wDJ3xJdpw")]
public partial class ПрибуткуванняТоварівЗПереробки_PointerControl : PointerControl
{
    event EventHandler<ПрибуткуванняТоварівЗПереробки_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПрибуткуванняТоварівЗПереробки_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПрибуткуванняТоварівЗПереробки_PointerControl New() => NewWithProperties([]);

    ПрибуткуванняТоварівЗПереробки_Pointer pointer = new();
    public ПрибуткуванняТоварівЗПереробки_Pointer Pointer
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

        ПрибуткуванняТоварівЗПереробки_ШвидкийВибір page = ПрибуткуванняТоварівЗПереробки_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПрибуткуванняТоварівЗПереробки_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПрибуткуванняТоварівЗПереробки_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    