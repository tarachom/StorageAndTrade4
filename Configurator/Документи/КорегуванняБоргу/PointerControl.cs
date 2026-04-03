

/*     
        КорегуванняБоргу_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_eKZbUxSMi0KiUsn8fNNCXA")]
public partial class КорегуванняБоргу_PointerControl : PointerControl
{
    event EventHandler<КорегуванняБоргу_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{КорегуванняБоргу_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static КорегуванняБоргу_PointerControl New() => NewWithProperties([]);

    КорегуванняБоргу_Pointer pointer = new();
    public КорегуванняБоргу_Pointer Pointer
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
        КорегуванняБоргу_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UniqueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new КорегуванняБоргу_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new КорегуванняБоргу_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    