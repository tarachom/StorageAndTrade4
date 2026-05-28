

/*     
        ПередачаМатеріалівВЕксплуатацію_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_n26eAT1mmHSSSxsuPRKaQ")]
public partial class ПередачаМатеріалівВЕксплуатацію_PointerControl : PointerControl
{
    event EventHandler<ПередачаМатеріалівВЕксплуатацію_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПередачаМатеріалівВЕксплуатацію_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПередачаМатеріалівВЕксплуатацію_PointerControl New() => NewWithProperties([]);

    ПередачаМатеріалівВЕксплуатацію_Pointer pointer = new();
    public ПередачаМатеріалівВЕксплуатацію_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            PointerChanged?.Invoke(null, pointer);
        }
    }

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        ПередачаМатеріалівВЕксплуатацію_ШвидкийВибір page = ПередачаМатеріалівВЕксплуатацію_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПередачаМатеріалівВЕксплуатацію_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПередачаМатеріалівВЕксплуатацію_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    