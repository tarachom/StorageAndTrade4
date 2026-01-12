
/*     
        ПартіяТоварівКомпозит_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

public class ПартіяТоварівКомпозит_PointerControl : PointerControl
{
    event EventHandler<ПартіяТоварівКомпозит_Pointer> PointerChanged;

    public ПартіяТоварівКомпозит_PointerControl()
    {
        pointer = new ПартіяТоварівКомпозит_Pointer();
        WidthPresentation = 300;
        Caption = $"{ПартіяТоварівКомпозит_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ПартіяТоварівКомпозит_Pointer pointer;
    public ПартіяТоварівКомпозит_Pointer Pointer
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
        ПартіяТоварівКомпозит_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ПартіяТоварівКомпозит_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПартіяТоварівКомпозит_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    