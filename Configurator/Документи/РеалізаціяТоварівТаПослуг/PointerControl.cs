

/*     
        РеалізаціяТоварівТаПослуг_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class РеалізаціяТоварівТаПослуг_PointerControl : PointerControl
{
    event EventHandler<РеалізаціяТоварівТаПослуг_Pointer> PointerChanged;

    public РеалізаціяТоварівТаПослуг_PointerControl()
    {
        pointer = new РеалізаціяТоварівТаПослуг_Pointer();
        WidthPresentation = 300;
        Caption = $"{РеалізаціяТоварівТаПослуг_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    РеалізаціяТоварівТаПослуг_Pointer pointer;
    public РеалізаціяТоварівТаПослуг_Pointer Pointer
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
        РеалізаціяТоварівТаПослуг_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new РеалізаціяТоварівТаПослуг_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new РеалізаціяТоварівТаПослуг_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    