

/*     
        Додаток2ДоПодатковоїНакладної_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_lPowax1kNkOgDtisREOXSQ")]
public partial class Додаток2ДоПодатковоїНакладної_PointerControl : PointerControl
{
    event EventHandler<Додаток2ДоПодатковоїНакладної_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{Додаток2ДоПодатковоїНакладної_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static Додаток2ДоПодатковоїНакладної_PointerControl New() => NewWithProperties([]);

    Додаток2ДоПодатковоїНакладної_Pointer pointer = new();
    public Додаток2ДоПодатковоїНакладної_Pointer Pointer
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

        Додаток2ДоПодатковоїНакладної_ШвидкийВибір page = Додаток2ДоПодатковоїНакладної_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new Додаток2ДоПодатковоїНакладної_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new Додаток2ДоПодатковоїНакладної_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    