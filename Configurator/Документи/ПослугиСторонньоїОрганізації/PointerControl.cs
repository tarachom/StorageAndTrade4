

/*     
        ПослугиСторонньоїОрганізації_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_5m6eAfGwHedldFXTcC1Q")]
public partial class ПослугиСторонньоїОрганізації_PointerControl : PointerControl
{
    event EventHandler<ПослугиСторонньоїОрганізації_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПослугиСторонньоїОрганізації_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПослугиСторонньоїОрганізації_PointerControl New() => NewWithProperties([]);

    ПослугиСторонньоїОрганізації_Pointer pointer = new();
    public ПослугиСторонньоїОрганізації_Pointer Pointer
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

        ПослугиСторонньоїОрганізації_ШвидкийВибір page = ПослугиСторонньоїОрганізації_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПослугиСторонньоїОрганізації_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПослугиСторонньоїОрганізації_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    