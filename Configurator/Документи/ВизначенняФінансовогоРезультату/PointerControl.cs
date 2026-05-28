

/*     
        ВизначенняФінансовогоРезультату_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_LchTvIwFz0qU2nls3nTFgA")]
public partial class ВизначенняФінансовогоРезультату_PointerControl : PointerControl
{
    event EventHandler<ВизначенняФінансовогоРезультату_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ВизначенняФінансовогоРезультату_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ВизначенняФінансовогоРезультату_PointerControl New() => NewWithProperties([]);

    ВизначенняФінансовогоРезультату_Pointer pointer = new();
    public ВизначенняФінансовогоРезультату_Pointer Pointer
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

        ВизначенняФінансовогоРезультату_ШвидкийВибір page = ВизначенняФінансовогоРезультату_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ВизначенняФінансовогоРезультату_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ВизначенняФінансовогоРезультату_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    