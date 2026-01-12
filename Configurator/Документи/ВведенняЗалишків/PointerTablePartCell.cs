

/*     
        ВведенняЗалишків_PointerTablePartCell.cs
        PointerTablePartCell
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;
using AccountingSoftware;

namespace StorageAndTrade;

public class ВведенняЗалишків_PointerTablePartCell : PointerTablePartCell
{
    ВведенняЗалишків_Pointer pointer = new();
    public ВведенняЗалишків_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            Presentation = pointer.Name;
        }
    }

    public async ValueTask GetPresentation() => Presentation = pointer != null ? await pointer.GetPresentation() : "";

    async ValueTask PointerChange(UnigueID? p)
    {
        Pointer = new ВведенняЗалишків_Pointer(p ?? new UnigueID());
        await GetPresentation();
        OnSelect?.Invoke();
    }

    protected override async void Select(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;

        ВведенняЗалишків_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DocumentPointerItem = pointer.UnigueID,
            CallBack_OnSelectPointer = async p => await PointerChange(p)
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override async void Clear()
    {
        await PointerChange(null);
    }
}
    