
/*     
        СкладськіПриміщення_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_8IRmorjQ0G9DJqxVQVgA")]
public partial class СкладськіПриміщення_PointerControl : PointerControl
{
    event EventHandler<СкладськіПриміщення_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{СкладськіПриміщення_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static СкладськіПриміщення_PointerControl New() => NewWithProperties([]);

    СкладськіПриміщення_Pointer pointer = new();
    public СкладськіПриміщення_Pointer Pointer
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

    
    public Склади_Pointer Власник { get; set; } = new Склади_Pointer();
    

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        СкладськіПриміщення_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new СкладськіПриміщення_Pointer(selectPointer);
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
        Pointer = new СкладськіПриміщення_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    