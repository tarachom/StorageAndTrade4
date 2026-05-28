

/*     
        КоригуванняНезавершеногоВиробництва_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_km6eAS8RZnynv2jODh0Zw")]
public partial class КоригуванняНезавершеногоВиробництва_PointerControl : PointerControl
{
    event EventHandler<КоригуванняНезавершеногоВиробництва_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{КоригуванняНезавершеногоВиробництва_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static КоригуванняНезавершеногоВиробництва_PointerControl New() => NewWithProperties([]);

    КоригуванняНезавершеногоВиробництва_Pointer pointer = new();
    public КоригуванняНезавершеногоВиробництва_Pointer Pointer
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

        КоригуванняНезавершеногоВиробництва_ШвидкийВибір page = КоригуванняНезавершеногоВиробництва_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new КоригуванняНезавершеногоВиробництва_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new КоригуванняНезавершеногоВиробництва_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    