

/*     
        ВнутрішнєСпоживанняТоварів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ВнутрішнєСпоживанняТоварів_PointerControl : PointerControl
{
    event EventHandler<ВнутрішнєСпоживанняТоварів_Pointer> PointerChanged;

    public ВнутрішнєСпоживанняТоварів_PointerControl()
    {
        pointer = new ВнутрішнєСпоживанняТоварів_Pointer();
        WidthPresentation = 300;
        Caption = $"{ВнутрішнєСпоживанняТоварів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ВнутрішнєСпоживанняТоварів_Pointer pointer;
    public ВнутрішнєСпоживанняТоварів_Pointer Pointer
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
        ВнутрішнєСпоживанняТоварів_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ВнутрішнєСпоживанняТоварів_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ВнутрішнєСпоживанняТоварів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    