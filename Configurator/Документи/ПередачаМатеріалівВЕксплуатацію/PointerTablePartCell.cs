

/*     
        ПередачаМатеріалівВЕксплуатацію_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_n26eAXRmaX2d9q6pn45ZQ")]
public partial class ПередачаМатеріалівВЕксплуатацію_PointerTablePartCell : PointerTablePartCell
{
    public static ПередачаМатеріалівВЕксплуатацію_PointerTablePartCell New() => NewWithProperties([]);

    ПередачаМатеріалівВЕксплуатацію_Pointer pointer = new();
    public ПередачаМатеріалівВЕксплуатацію_Pointer Pointer
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
        Pointer = new ПередачаМатеріалівВЕксплуатацію_Pointer(p ?? new UniqueID());
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

        ПередачаМатеріалівВЕксплуатацію_ШвидкийВибір page = ПередачаМатеріалівВЕксплуатацію_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = pointer.UniqueID;
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
    