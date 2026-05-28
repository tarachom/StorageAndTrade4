

/*     
        ЗмінаПараметрівОсновнихЗасобів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_TXXTAsmgKU64lHkX4XalHA")]
public partial class ЗмінаПараметрівОсновнихЗасобів_PointerControl : PointerControl
{
    event EventHandler<ЗмінаПараметрівОсновнихЗасобів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ЗмінаПараметрівОсновнихЗасобів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ЗмінаПараметрівОсновнихЗасобів_PointerControl New() => NewWithProperties([]);

    ЗмінаПараметрівОсновнихЗасобів_Pointer pointer = new();
    public ЗмінаПараметрівОсновнихЗасобів_Pointer Pointer
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

        ЗмінаПараметрівОсновнихЗасобів_ШвидкийВибір page = ЗмінаПараметрівОсновнихЗасобів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ЗмінаПараметрівОсновнихЗасобів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗмінаПараметрівОсновнихЗасобів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    