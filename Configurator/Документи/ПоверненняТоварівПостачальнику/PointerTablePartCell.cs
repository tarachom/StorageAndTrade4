

/*     
        ПоверненняТоварівПостачальнику_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

[GObject.Subclass<PointerTablePartCell>("PointerTablePartCell_KoE0Kz80qjyMKhDWLaCw")]
public partial class ПоверненняТоварівПостачальнику_PointerTablePartCell : PointerTablePartCell
{
    public static ПоверненняТоварівПостачальнику_PointerTablePartCell New() => NewWithProperties([]);

    ПоверненняТоварівПостачальнику_Pointer pointer = new();
    public ПоверненняТоварівПостачальнику_Pointer Pointer
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
        Pointer = new ПоверненняТоварівПостачальнику_Pointer(p ?? new UniqueID());
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
        ПоверненняТоварівПостачальнику_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = pointer.UniqueID,
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
    