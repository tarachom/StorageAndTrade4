

/*     
        ПрихіднийКасовийОрдер_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_QLeV2EtWNU6BFtZV2jx0w")]
public partial class ПрихіднийКасовийОрдер_PointerControl : PointerControl
{
    event EventHandler<ПрихіднийКасовийОрдер_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПрихіднийКасовийОрдер_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПрихіднийКасовийОрдер_PointerControl New() => NewWithProperties([]);

    ПрихіднийКасовийОрдер_Pointer pointer = new();
    public ПрихіднийКасовийОрдер_Pointer Pointer
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

        ПрихіднийКасовийОрдер_ШвидкийВибір page = ПрихіднийКасовийОрдер_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПрихіднийКасовийОрдер_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПрихіднийКасовийОрдер_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    