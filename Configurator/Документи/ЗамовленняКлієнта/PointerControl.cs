

/*     
        ЗамовленняКлієнта_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_jVVQwqWlnkOqridTCFXWg")]
public partial class ЗамовленняКлієнта_PointerControl : PointerControl
{
    event EventHandler<ЗамовленняКлієнта_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ЗамовленняКлієнта_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ЗамовленняКлієнта_PointerControl New() => NewWithProperties([]);

    ЗамовленняКлієнта_Pointer pointer = new();
    public ЗамовленняКлієнта_Pointer Pointer
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

        ЗамовленняКлієнта_ШвидкийВибір page = ЗамовленняКлієнта_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ЗамовленняКлієнта_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗамовленняКлієнта_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    