

/*     
        Контрагенти_Папки_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_RRQ9JfMsdkqB7wZLxNjJRg")]
public partial class Контрагенти_Папки_PointerTablePartCell : PointerTablePartCell
{
    public static Контрагенти_Папки_PointerTablePartCell New() => NewWithProperties([]);

    Контрагенти_Папки_Pointer pointer = new();
    public Контрагенти_Папки_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            Presentation = pointer.Name;
        }
    }

    public async Task GetPresentation() => Presentation = pointer != null ? await pointer.GetPresentation() : "";

    async Task PointerChange(UniqueID? p)
    {
        Pointer = new Контрагенти_Папки_Pointer(p ?? new UniqueID());
        await GetPresentation();
        OnSelect?.Invoke();
    }

    

    protected override async void Select(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        Контрагенти_Папки_ШвидкийВибір page = Контрагенти_Папки_ШвидкийВибір.New();
        page.PopoverParent = popover;
            
        page.DirectoryPointerItem = pointer.UniqueID;
        page.CallBack_OnSelectPointer = async p => 
        {
            await PointerChange(p);
            AfterSelectFunc?.Invoke();
        };
        

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
    