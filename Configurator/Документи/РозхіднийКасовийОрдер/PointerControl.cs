

/*     
        РозхіднийКасовийОрдер_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class РозхіднийКасовийОрдер_PointerControl : PointerControl
{
    event EventHandler<РозхіднийКасовийОрдер_Pointer> PointerChanged;

    public РозхіднийКасовийОрдер_PointerControl()
    {
        pointer = new РозхіднийКасовийОрдер_Pointer();
        WidthPresentation = 300;
        Caption = $"{РозхіднийКасовийОрдер_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    РозхіднийКасовийОрдер_Pointer pointer;
    public РозхіднийКасовийОрдер_Pointer Pointer
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
        РозхіднийКасовийОрдер_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new РозхіднийКасовийОрдер_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new РозхіднийКасовийОрдер_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    