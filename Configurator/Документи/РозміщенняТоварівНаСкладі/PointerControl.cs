

/*     
        РозміщенняТоварівНаСкладі_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_WDzjhNAJBEKHh2lo9rjyDw")]
public partial class РозміщенняТоварівНаСкладі_PointerControl : PointerControl
{
    event EventHandler<РозміщенняТоварівНаСкладі_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{РозміщенняТоварівНаСкладі_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static РозміщенняТоварівНаСкладі_PointerControl New() => NewWithProperties([]);

    РозміщенняТоварівНаСкладі_Pointer pointer = new();
    public РозміщенняТоварівНаСкладі_Pointer Pointer
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
        РозміщенняТоварівНаСкладі_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UniqueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new РозміщенняТоварівНаСкладі_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new РозміщенняТоварівНаСкладі_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    