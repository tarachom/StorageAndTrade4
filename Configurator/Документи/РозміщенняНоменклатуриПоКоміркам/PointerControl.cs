

/*     
        РозміщенняНоменклатуриПоКоміркам_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

public class РозміщенняНоменклатуриПоКоміркам_PointerControl : PointerControl
{
    event EventHandler<РозміщенняНоменклатуриПоКоміркам_Pointer> PointerChanged;

    public РозміщенняНоменклатуриПоКоміркам_PointerControl()
    {
        pointer = new РозміщенняНоменклатуриПоКоміркам_Pointer();
        WidthPresentation = 300;
        Caption = $"{РозміщенняНоменклатуриПоКоміркам_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    РозміщенняНоменклатуриПоКоміркам_Pointer pointer;
    public РозміщенняНоменклатуриПоКоміркам_Pointer Pointer
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
        РозміщенняНоменклатуриПоКоміркам_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new РозміщенняНоменклатуриПоКоміркам_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new РозміщенняНоменклатуриПоКоміркам_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    