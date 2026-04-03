
/*     
        ПакуванняОдиниціВиміру_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_Eb3qpBPvZUOmOZHJs3xCDA")]
public partial class ПакуванняОдиниціВиміру_PointerControl : PointerControl
{
    event EventHandler<ПакуванняОдиниціВиміру_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПакуванняОдиниціВиміру_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПакуванняОдиниціВиміру_PointerControl New() => NewWithProperties([]);

    ПакуванняОдиниціВиміру_Pointer pointer = new();
    public ПакуванняОдиниціВиміру_Pointer Pointer
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
        ПакуванняОдиниціВиміру_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ПакуванняОдиниціВиміру_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПакуванняОдиниціВиміру_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    