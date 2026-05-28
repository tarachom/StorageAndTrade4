

/*     
        ПереміщенняМатеріалівВЕксплуатації_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_oW6eAYQvv3ai7b0umYIBA")]
public partial class ПереміщенняМатеріалівВЕксплуатації_PointerControl : PointerControl
{
    event EventHandler<ПереміщенняМатеріалівВЕксплуатації_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПереміщенняМатеріалівВЕксплуатації_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПереміщенняМатеріалівВЕксплуатації_PointerControl New() => NewWithProperties([]);

    ПереміщенняМатеріалівВЕксплуатації_Pointer pointer = new();
    public ПереміщенняМатеріалівВЕксплуатації_Pointer Pointer
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

        ПереміщенняМатеріалівВЕксплуатації_ШвидкийВибір page = ПереміщенняМатеріалівВЕксплуатації_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПереміщенняМатеріалівВЕксплуатації_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПереміщенняМатеріалівВЕксплуатації_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    