

/*     
        ПлатіжнеДорученняВхідне_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_326eAbr4dX6zmBzHL7CfUg")]
public partial class ПлатіжнеДорученняВхідне_PointerControl : PointerControl
{
    event EventHandler<ПлатіжнеДорученняВхідне_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПлатіжнеДорученняВхідне_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПлатіжнеДорученняВхідне_PointerControl New() => NewWithProperties([]);

    ПлатіжнеДорученняВхідне_Pointer pointer = new();
    public ПлатіжнеДорученняВхідне_Pointer Pointer
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

        ПлатіжнеДорученняВхідне_ШвидкийВибір page = ПлатіжнеДорученняВхідне_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПлатіжнеДорученняВхідне_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПлатіжнеДорученняВхідне_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    