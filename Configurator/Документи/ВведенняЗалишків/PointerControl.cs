

/*     
        ВведенняЗалишків_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ВведенняЗалишків_PointerControl : PointerControl
{
    event EventHandler<ВведенняЗалишків_Pointer> PointerChanged;

    public ВведенняЗалишків_PointerControl()
    {
        pointer = new ВведенняЗалишків_Pointer();
        WidthPresentation = 300;
        Caption = $"{ВведенняЗалишків_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ВведенняЗалишків_Pointer pointer;
    public ВведенняЗалишків_Pointer Pointer
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
        ВведенняЗалишків_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ВведенняЗалишків_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ВведенняЗалишків_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    