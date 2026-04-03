
/*     
        СкладськіКомірки_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_sxyXjGYn4kWO1F5BKxPMjg")]
public partial class СкладськіКомірки_PointerControl : PointerControl
{
    event EventHandler<СкладськіКомірки_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{СкладськіКомірки_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static СкладськіКомірки_PointerControl New() => NewWithProperties([]);

    СкладськіКомірки_Pointer pointer = new();
    public СкладськіКомірки_Pointer Pointer
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

    
    public СкладськіПриміщення_Pointer Власник { get; set; } = new СкладськіПриміщення_Pointer();
    

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        СкладськіКомірки_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new СкладськіКомірки_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        page.Власник.Pointer = Власник;
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new СкладськіКомірки_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    