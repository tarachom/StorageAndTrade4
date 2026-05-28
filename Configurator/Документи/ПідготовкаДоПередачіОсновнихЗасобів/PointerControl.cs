

/*     
        ПідготовкаДоПередачіОсновнихЗасобів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_5W6eAdbHG3u2HGTQis9aFA")]
public partial class ПідготовкаДоПередачіОсновнихЗасобів_PointerControl : PointerControl
{
    event EventHandler<ПідготовкаДоПередачіОсновнихЗасобів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПідготовкаДоПередачіОсновнихЗасобів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПідготовкаДоПередачіОсновнихЗасобів_PointerControl New() => NewWithProperties([]);

    ПідготовкаДоПередачіОсновнихЗасобів_Pointer pointer = new();
    public ПідготовкаДоПередачіОсновнихЗасобів_Pointer Pointer
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

        ПідготовкаДоПередачіОсновнихЗасобів_ШвидкийВибір page = ПідготовкаДоПередачіОсновнихЗасобів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПідготовкаДоПередачіОсновнихЗасобів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПідготовкаДоПередачіОсновнихЗасобів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    