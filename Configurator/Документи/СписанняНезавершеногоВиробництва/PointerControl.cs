

/*     
        СписанняНезавершеногоВиробництва_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_m6eAWQ3UHCFsWK2YHi6Q")]
public partial class СписанняНезавершеногоВиробництва_PointerControl : PointerControl
{
    event EventHandler<СписанняНезавершеногоВиробництва_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{СписанняНезавершеногоВиробництва_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static СписанняНезавершеногоВиробництва_PointerControl New() => NewWithProperties([]);

    СписанняНезавершеногоВиробництва_Pointer pointer = new();
    public СписанняНезавершеногоВиробництва_Pointer Pointer
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

        СписанняНезавершеногоВиробництва_ШвидкийВибір page = СписанняНезавершеногоВиробництва_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new СписанняНезавершеногоВиробництва_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new СписанняНезавершеногоВиробництва_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    