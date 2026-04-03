

/*     
        ЗакриттяЗамовленняКлієнта_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_tlse65upL0mtSCGq3gXuw")]
public partial class ЗакриттяЗамовленняКлієнта_PointerControl : PointerControl
{
    event EventHandler<ЗакриттяЗамовленняКлієнта_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ЗакриттяЗамовленняКлієнта_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ЗакриттяЗамовленняКлієнта_PointerControl New() => NewWithProperties([]);

    ЗакриттяЗамовленняКлієнта_Pointer pointer = new();
    public ЗакриттяЗамовленняКлієнта_Pointer Pointer
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
        ЗакриттяЗамовленняКлієнта_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UniqueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ЗакриттяЗамовленняКлієнта_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗакриттяЗамовленняКлієнта_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    