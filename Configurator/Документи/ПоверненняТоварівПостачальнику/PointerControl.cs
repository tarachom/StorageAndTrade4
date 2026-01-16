

/*     
        ПоверненняТоварівПостачальнику_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ПоверненняТоварівПостачальнику_PointerControl : PointerControl
{
    event EventHandler<ПоверненняТоварівПостачальнику_Pointer> PointerChanged;

    public ПоверненняТоварівПостачальнику_PointerControl()
    {
        pointer = new ПоверненняТоварівПостачальнику_Pointer();
        WidthPresentation = 300;
        Caption = $"{ПоверненняТоварівПостачальнику_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ПоверненняТоварівПостачальнику_Pointer pointer;
    public ПоверненняТоварівПостачальнику_Pointer Pointer
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
        ПоверненняТоварівПостачальнику_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ПоверненняТоварівПостачальнику_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПоверненняТоварівПостачальнику_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    