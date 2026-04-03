

/*     
        ВведенняЗалишків_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_YtkA2dyfA0iPxcQGL9U9Wg")]
public partial class ВведенняЗалишків_PointerControl : PointerControl
{
    event EventHandler<ВведенняЗалишків_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ВведенняЗалишків_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ВведенняЗалишків_PointerControl New() => NewWithProperties([]);

    ВведенняЗалишків_Pointer pointer = new();
    public ВведенняЗалишків_Pointer Pointer
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
        ВведенняЗалишків_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UniqueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ВведенняЗалишків_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ВведенняЗалишків_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    