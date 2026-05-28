

/*     
        ПереміщенняНематеріальнихАктивів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_pG6eAcg3wnmfOAfkiqGNRw")]
public partial class ПереміщенняНематеріальнихАктивів_PointerControl : PointerControl
{
    event EventHandler<ПереміщенняНематеріальнихАктивів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПереміщенняНематеріальнихАктивів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПереміщенняНематеріальнихАктивів_PointerControl New() => NewWithProperties([]);

    ПереміщенняНематеріальнихАктивів_Pointer pointer = new();
    public ПереміщенняНематеріальнихАктивів_Pointer Pointer
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

        ПереміщенняНематеріальнихАктивів_ШвидкийВибір page = ПереміщенняНематеріальнихАктивів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПереміщенняНематеріальнихАктивів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПереміщенняНематеріальнихАктивів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    