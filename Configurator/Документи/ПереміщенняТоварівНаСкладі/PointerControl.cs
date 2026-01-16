

/*     
        ПереміщенняТоварівНаСкладі_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ПереміщенняТоварівНаСкладі_PointerControl : PointerControl
{
    event EventHandler<ПереміщенняТоварівНаСкладі_Pointer> PointerChanged;

    public ПереміщенняТоварівНаСкладі_PointerControl()
    {
        pointer = new ПереміщенняТоварівНаСкладі_Pointer();
        WidthPresentation = 300;
        Caption = $"{ПереміщенняТоварівНаСкладі_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ПереміщенняТоварівНаСкладі_Pointer pointer;
    public ПереміщенняТоварівНаСкладі_Pointer Pointer
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
        ПереміщенняТоварівНаСкладі_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ПереміщенняТоварівНаСкладі_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПереміщенняТоварівНаСкладі_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    