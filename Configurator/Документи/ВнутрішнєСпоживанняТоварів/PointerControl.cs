

/*     
        ВнутрішнєСпоживанняТоварів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_VDg5soECAEKQRXzjL5xiQ")]
public partial class ВнутрішнєСпоживанняТоварів_PointerControl : PointerControl
{
    event EventHandler<ВнутрішнєСпоживанняТоварів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ВнутрішнєСпоживанняТоварів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ВнутрішнєСпоживанняТоварів_PointerControl New() => NewWithProperties([]);

    ВнутрішнєСпоживанняТоварів_Pointer pointer = new();
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

        ВнутрішнєСпоживанняТоварів_ШвидкийВибір page = ВнутрішнєСпоживанняТоварів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ВнутрішнєСпоживанняТоварів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
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
    