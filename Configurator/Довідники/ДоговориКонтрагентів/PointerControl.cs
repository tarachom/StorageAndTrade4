
/*     
        ДоговориКонтрагентів_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

public class ДоговориКонтрагентів_PointerControl : PointerControl
{
    event EventHandler<ДоговориКонтрагентів_Pointer> PointerChanged;

    public ДоговориКонтрагентів_PointerControl()
    {
        pointer = new ДоговориКонтрагентів_Pointer();
        WidthPresentation = 300;
        Caption = $"{ДоговориКонтрагентів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ДоговориКонтрагентів_Pointer pointer;
    public ДоговориКонтрагентів_Pointer Pointer
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

    
    public Контрагенти_Pointer Власник { get; set; } = new Контрагенти_Pointer();
    

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        ДоговориКонтрагентів_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ДоговориКонтрагентів_Pointer(selectPointer);
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
        Pointer = new ДоговориКонтрагентів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    