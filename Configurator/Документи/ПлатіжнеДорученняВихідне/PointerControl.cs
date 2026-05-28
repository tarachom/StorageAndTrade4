

/*     
        ПлатіжнеДорученняВихідне_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_4W6eAVeUUH6bqK9sTnGFbQ")]
public partial class ПлатіжнеДорученняВихідне_PointerControl : PointerControl
{
    event EventHandler<ПлатіжнеДорученняВихідне_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПлатіжнеДорученняВихідне_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПлатіжнеДорученняВихідне_PointerControl New() => NewWithProperties([]);

    ПлатіжнеДорученняВихідне_Pointer pointer = new();
    public ПлатіжнеДорученняВихідне_Pointer Pointer
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

        ПлатіжнеДорученняВихідне_ШвидкийВибір page = ПлатіжнеДорученняВихідне_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПлатіжнеДорученняВихідне_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПлатіжнеДорученняВихідне_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    