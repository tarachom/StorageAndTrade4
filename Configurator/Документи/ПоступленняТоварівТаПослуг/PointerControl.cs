

/*     
        ПоступленняТоварівТаПослуг_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class ПоступленняТоварівТаПослуг_PointerControl : PointerControl
{
    event EventHandler<ПоступленняТоварівТаПослуг_Pointer> PointerChanged;

    public ПоступленняТоварівТаПослуг_PointerControl()
    {
        pointer = new ПоступленняТоварівТаПослуг_Pointer();
        WidthPresentation = 300;
        Caption = $"{ПоступленняТоварівТаПослуг_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ПоступленняТоварівТаПослуг_Pointer pointer;
    public ПоступленняТоварівТаПослуг_Pointer Pointer
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
        ПоступленняТоварівТаПослуг_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ПоступленняТоварівТаПослуг_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПоступленняТоварівТаПослуг_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    