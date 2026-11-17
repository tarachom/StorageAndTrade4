

/*     
        ПакуванняОдиниціВиміру_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PakuvanniaOdynytsiVymiru_PointerTablePartCell")]
public partial class ПакуванняОдиниціВиміру_PointerTablePartCell : PointerTablePartCell
{
    public static ПакуванняОдиниціВиміру_PointerTablePartCell New() => NewWithProperties([]);

    ПакуванняОдиниціВиміру_Pointer pointer = new();
    public ПакуванняОдиниціВиміру_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            Presentation = pointer.Name;
        }
    }

    public async Task GetPresentation() => Presentation = !pointer.IsEmpty() ? await pointer.GetPresentation() : "";

    async Task PointerChange(UniqueID? p)
    {
        Pointer = new ПакуванняОдиниціВиміру_Pointer(p ?? new UniqueID());
        await GetPresentation();
        OnSelect?.Invoke();
    }

    
    public Номенклатура_Pointer Власник { get; set; } = new Номенклатура_Pointer();
    

    protected override async void Select(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        ПакуванняОдиниціВиміру_ШвидкийВибір page = ПакуванняОдиниціВиміру_ШвидкийВибір.New();
        page.PopoverParent = popover;
            
        page.DirectoryPointerItem = pointer.UniqueID;
        page.CallBack_OnSelectPointer = async p => 
        {
            await PointerChange(p);
            AfterSelectFunc?.Invoke();
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
    