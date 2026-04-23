

/*     
        ПоступленняТоварівТаПослуг_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_iGTnp1OgU0Gbv5QNhwXJhg")]
public partial class ПоступленняТоварівТаПослуг_PointerControl : PointerControl
{
    event EventHandler<ПоступленняТоварівТаПослуг_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПоступленняТоварівТаПослуг_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПоступленняТоварівТаПослуг_PointerControl New() => NewWithProperties([]);

    ПоступленняТоварівТаПослуг_Pointer pointer = new();
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

        ПоступленняТоварівТаПослуг_ШвидкийВибір page = ПоступленняТоварівТаПослуг_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПоступленняТоварівТаПослуг_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
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
    