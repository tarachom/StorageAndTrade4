

/*     
        ПокупкаАбоПродажВалюти_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_5G6eAcwgUXSA6SVymLbqg")]
public partial class ПокупкаАбоПродажВалюти_PointerControl : PointerControl
{
    event EventHandler<ПокупкаАбоПродажВалюти_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПокупкаАбоПродажВалюти_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПокупкаАбоПродажВалюти_PointerControl New() => NewWithProperties([]);

    ПокупкаАбоПродажВалюти_Pointer pointer = new();
    public ПокупкаАбоПродажВалюти_Pointer Pointer
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

        ПокупкаАбоПродажВалюти_ШвидкийВибір page = ПокупкаАбоПродажВалюти_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПокупкаАбоПродажВалюти_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПокупкаАбоПродажВалюти_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    