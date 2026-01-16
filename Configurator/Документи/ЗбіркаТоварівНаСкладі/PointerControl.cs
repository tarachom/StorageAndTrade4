

/*     
        ЗбіркаТоварівНаСкладі_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ЗбіркаТоварівНаСкладі_PointerControl : PointerControl
{
    event EventHandler<ЗбіркаТоварівНаСкладі_Pointer> PointerChanged;

    public ЗбіркаТоварівНаСкладі_PointerControl()
    {
        pointer = new ЗбіркаТоварівНаСкладі_Pointer();
        WidthPresentation = 300;
        Caption = $"{ЗбіркаТоварівНаСкладі_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ЗбіркаТоварівНаСкладі_Pointer pointer;
    public ЗбіркаТоварівНаСкладі_Pointer Pointer
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
        ЗбіркаТоварівНаСкладі_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ЗбіркаТоварівНаСкладі_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗбіркаТоварівНаСкладі_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    