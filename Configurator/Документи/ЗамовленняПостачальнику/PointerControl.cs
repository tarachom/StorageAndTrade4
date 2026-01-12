

/*     
        ЗамовленняПостачальнику_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ЗамовленняПостачальнику_PointerControl : PointerControl
{
    event EventHandler<ЗамовленняПостачальнику_Pointer> PointerChanged;

    public ЗамовленняПостачальнику_PointerControl()
    {
        pointer = new ЗамовленняПостачальнику_Pointer();
        WidthPresentation = 300;
        Caption = $"{ЗамовленняПостачальнику_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ЗамовленняПостачальнику_Pointer pointer;
    public ЗамовленняПостачальнику_Pointer Pointer
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
        ЗамовленняПостачальнику_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ЗамовленняПостачальнику_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗамовленняПостачальнику_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    