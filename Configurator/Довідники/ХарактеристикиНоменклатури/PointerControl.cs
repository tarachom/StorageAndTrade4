
/*     
        ХарактеристикиНоменклатури_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

public class ХарактеристикиНоменклатури_PointerControl : PointerControl
{
    event EventHandler<ХарактеристикиНоменклатури_Pointer> PointerChanged;

    public ХарактеристикиНоменклатури_PointerControl()
    {
        pointer = new ХарактеристикиНоменклатури_Pointer();
        WidthPresentation = 300;
        Caption = $"{ХарактеристикиНоменклатури_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    ХарактеристикиНоменклатури_Pointer pointer;
    public ХарактеристикиНоменклатури_Pointer Pointer
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

    
    public Номенклатура_Pointer Власник { get; set; } = new Номенклатура_Pointer();
    

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        ХарактеристикиНоменклатури_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new ХарактеристикиНоменклатури_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        page.Власник.Pointer = Власник;
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ХарактеристикиНоменклатури_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    