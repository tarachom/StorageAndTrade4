

/*     
        ПереміщенняТоварівНаСкладі_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_QzdFLSqh0FK6NkQyWlA")]
public partial class ПереміщенняТоварівНаСкладі_PointerControl : PointerControl
{
    event EventHandler<ПереміщенняТоварівНаСкладі_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПереміщенняТоварівНаСкладі_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПереміщенняТоварівНаСкладі_PointerControl New() => NewWithProperties([]);

    ПереміщенняТоварівНаСкладі_Pointer pointer = new();
    public ПереміщенняТоварівНаСкладі_Pointer Pointer
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

        ПереміщенняТоварівНаСкладі_ШвидкийВибір page = ПереміщенняТоварівНаСкладі_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПереміщенняТоварівНаСкладі_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПереміщенняТоварівНаСкладі_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    