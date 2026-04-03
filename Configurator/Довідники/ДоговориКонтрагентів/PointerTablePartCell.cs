

/*     
        ДоговориКонтрагентів_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_x9j4LSVHIEhn07OgbMy2Q")]
public partial class ДоговориКонтрагентів_PointerTablePartCell : PointerTablePartCell
{
    public static ДоговориКонтрагентів_PointerTablePartCell New() => NewWithProperties([]);

    ДоговориКонтрагентів_Pointer pointer = new();
    public ДоговориКонтрагентів_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            Presentation = pointer.Name;
        }
    }

    public async ValueTask GetPresentation() => Presentation = pointer != null ? await pointer.GetPresentation() : "";

    async ValueTask PointerChange(UniqueID? p)
    {
        Pointer = new ДоговориКонтрагентів_Pointer(p ?? new UniqueID());
        await GetPresentation();
        OnSelect?.Invoke();
    }

    
    public Контрагенти_Pointer Власник { get; set; } = new Контрагенти_Pointer();
    

    protected override async void Select(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        ДоговориКонтрагентів_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = pointer.UniqueID,
            CallBack_OnSelectPointer = async p => 
            {
                await PointerChange(p);
                AfterSelectFunc?.Invoke();
            }
        };
        
        page.Власник.Pointer = Власник;
        

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override async void Clear()
    {
        await PointerChange(null);
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    