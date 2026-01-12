

/*     
        ПрихіднийКасовийОрдер_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ПрихіднийКасовийОрдер_PointerControl : PointerControl
{
    event EventHandler<ПрихіднийКасовийОрдер_Pointer> PointerChanged;

    public ПрихіднийКасовийОрдер_PointerControl()
    {
        pointer = new ПрихіднийКасовийОрдер_Pointer();
        WidthPresentation = 300;
        Caption = $"{ПрихіднийКасовийОрдер_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ПрихіднийКасовийОрдер_Pointer pointer;
    public ПрихіднийКасовийОрдер_Pointer Pointer
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
        ПрихіднийКасовийОрдер_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ПрихіднийКасовийОрдер_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПрихіднийКасовийОрдер_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    