

/*     
        ЗакриттяЗамовленняПостачальнику_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ЗакриттяЗамовленняПостачальнику_PointerControl : PointerControl
{
    event EventHandler<ЗакриттяЗамовленняПостачальнику_Pointer> PointerChanged;

    public ЗакриттяЗамовленняПостачальнику_PointerControl()
    {
        pointer = new ЗакриттяЗамовленняПостачальнику_Pointer();
        WidthPresentation = 300;
        Caption = $"{ЗакриттяЗамовленняПостачальнику_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ЗакриттяЗамовленняПостачальнику_Pointer pointer;
    public ЗакриттяЗамовленняПостачальнику_Pointer Pointer
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
        ЗакриттяЗамовленняПостачальнику_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ЗакриттяЗамовленняПостачальнику_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗакриттяЗамовленняПостачальнику_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    