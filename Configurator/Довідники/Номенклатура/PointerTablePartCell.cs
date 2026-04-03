

/*     
        Номенклатура_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_HA5lZ6Mcr0mIpkPds5Rjlw")]
public partial class Номенклатура_PointerTablePartCell : PointerTablePartCell
{
    public static Номенклатура_PointerTablePartCell New() => NewWithProperties([]);

    Номенклатура_Pointer pointer = new();
    public Номенклатура_Pointer Pointer
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
        Pointer = new Номенклатура_Pointer(p ?? new UniqueID());
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
        Номенклатура_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = pointer.UniqueID,
            CallBack_OnSelectPointer = async p => 
            {
                await PointerChange(p);
                AfterSelectFunc?.Invoke();
            }
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
    