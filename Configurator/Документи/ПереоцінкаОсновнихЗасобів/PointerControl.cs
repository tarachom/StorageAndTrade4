

/*     
        ПереоцінкаОсновнихЗасобів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_3m6eAaUNxHCk7YJTbT4DtA")]
public partial class ПереоцінкаОсновнихЗасобів_PointerControl : PointerControl
{
    event EventHandler<ПереоцінкаОсновнихЗасобів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПереоцінкаОсновнихЗасобів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПереоцінкаОсновнихЗасобів_PointerControl New() => NewWithProperties([]);

    ПереоцінкаОсновнихЗасобів_Pointer pointer = new();
    public ПереоцінкаОсновнихЗасобів_Pointer Pointer
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

        ПереоцінкаОсновнихЗасобів_ШвидкийВибір page = ПереоцінкаОсновнихЗасобів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПереоцінкаОсновнихЗасобів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПереоцінкаОсновнихЗасобів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    