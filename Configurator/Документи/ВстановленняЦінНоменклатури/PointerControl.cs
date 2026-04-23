

/*     
        ВстановленняЦінНоменклатури_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_jjHFCAiu70y3DI950jhoLg")]
public partial class ВстановленняЦінНоменклатури_PointerControl : PointerControl
{
    event EventHandler<ВстановленняЦінНоменклатури_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ВстановленняЦінНоменклатури_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ВстановленняЦінНоменклатури_PointerControl New() => NewWithProperties([]);

    ВстановленняЦінНоменклатури_Pointer pointer = new();
    public ВстановленняЦінНоменклатури_Pointer Pointer
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

        ВстановленняЦінНоменклатури_ШвидкийВибір page = ВстановленняЦінНоменклатури_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ВстановленняЦінНоменклатури_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ВстановленняЦінНоменклатури_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    