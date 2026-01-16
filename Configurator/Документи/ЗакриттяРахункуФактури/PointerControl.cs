

/*     
        ЗакриттяРахункуФактури_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ЗакриттяРахункуФактури_PointerControl : PointerControl
{
    event EventHandler<ЗакриттяРахункуФактури_Pointer> PointerChanged;

    public ЗакриттяРахункуФактури_PointerControl()
    {
        pointer = new ЗакриттяРахункуФактури_Pointer();
        WidthPresentation = 300;
        Caption = $"{ЗакриттяРахункуФактури_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ЗакриттяРахункуФактури_Pointer pointer;
    public ЗакриттяРахункуФактури_Pointer Pointer
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
        ЗакриттяРахункуФактури_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ЗакриттяРахункуФактури_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗакриттяРахункуФактури_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    