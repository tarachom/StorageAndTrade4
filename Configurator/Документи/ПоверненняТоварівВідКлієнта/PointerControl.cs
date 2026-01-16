

/*     
        ПоверненняТоварівВідКлієнта_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ПоверненняТоварівВідКлієнта_PointerControl : PointerControl
{
    event EventHandler<ПоверненняТоварівВідКлієнта_Pointer> PointerChanged;

    public ПоверненняТоварівВідКлієнта_PointerControl()
    {
        pointer = new ПоверненняТоварівВідКлієнта_Pointer();
        WidthPresentation = 300;
        Caption = $"{ПоверненняТоварівВідКлієнта_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ПоверненняТоварівВідКлієнта_Pointer pointer;
    public ПоверненняТоварівВідКлієнта_Pointer Pointer
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
        ПоверненняТоварівВідКлієнта_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ПоверненняТоварівВідКлієнта_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПоверненняТоварівВідКлієнта_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    