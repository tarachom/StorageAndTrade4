

/*     
        Додаток1ДоПодатковоїНакладної_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_5gh4EmIo0ucy9EH7ZFsA")]
public partial class Додаток1ДоПодатковоїНакладної_PointerControl : PointerControl
{
    event EventHandler<Додаток1ДоПодатковоїНакладної_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{Додаток1ДоПодатковоїНакладної_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static Додаток1ДоПодатковоїНакладної_PointerControl New() => NewWithProperties([]);

    Додаток1ДоПодатковоїНакладної_Pointer pointer = new();
    public Додаток1ДоПодатковоїНакладної_Pointer Pointer
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

        Додаток1ДоПодатковоїНакладної_ШвидкийВибір page = Додаток1ДоПодатковоїНакладної_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new Додаток1ДоПодатковоїНакладної_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new Додаток1ДоПодатковоїНакладної_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    