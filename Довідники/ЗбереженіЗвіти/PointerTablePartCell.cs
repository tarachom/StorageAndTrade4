

/*     
        ЗбереженіЗвіти_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_HHuV8q818UC1JnuSmficww")]
public partial class ЗбереженіЗвіти_PointerTablePartCell : PointerTablePartCell
{
    public static ЗбереженіЗвіти_PointerTablePartCell New() => NewWithProperties([]);

    ЗбереженіЗвіти_Pointer pointer = new();
    public ЗбереженіЗвіти_Pointer Pointer
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
        Pointer = new ЗбереженіЗвіти_Pointer(p ?? new UniqueID());
        await GetPresentation();
        OnSelect?.Invoke();
    }

    
    public Користувачі_Pointer Власник { get; set; } = new Користувачі_Pointer();
    

    protected override async void Select(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        ЗбереженіЗвіти_ШвидкийВибір page = ЗбереженіЗвіти_ШвидкийВибір.New();
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
    