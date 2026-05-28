

/*     
        ЗвітКомісіонераПроПродажТоварів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_CcUI4OM0mJKTJ4wvgqZQ")]
public partial class ЗвітКомісіонераПроПродажТоварів_PointerControl : PointerControl
{
    event EventHandler<ЗвітКомісіонераПроПродажТоварів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ЗвітКомісіонераПроПродажТоварів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ЗвітКомісіонераПроПродажТоварів_PointerControl New() => NewWithProperties([]);

    ЗвітКомісіонераПроПродажТоварів_Pointer pointer = new();
    public ЗвітКомісіонераПроПродажТоварів_Pointer Pointer
    {
        get => pointer;
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

        ЗвітКомісіонераПроПродажТоварів_ШвидкийВибір page = ЗвітКомісіонераПроПродажТоварів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ЗвітКомісіонераПроПродажТоварів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ЗвітКомісіонераПроПродажТоварів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    