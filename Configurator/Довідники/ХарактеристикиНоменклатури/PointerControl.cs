
/*     
        ХарактеристикиНоменклатури_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_VET4icwk2kicu5Y2DeOw")]
public partial class ХарактеристикиНоменклатури_PointerControl : PointerControl
{
    event EventHandler<ХарактеристикиНоменклатури_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ХарактеристикиНоменклатури_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ХарактеристикиНоменклатури_PointerControl New() => NewWithProperties([]);

    ХарактеристикиНоменклатури_Pointer pointer = new();
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
            DirectoryPointerItem = Pointer.UniqueID,
            OpenSelect = true,
            OpenFolder = OpenFolder,
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
    