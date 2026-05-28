

/*     
        СписанняВитратМайбутніхПеріодів_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_W6eAarPS3SPG57dUtvloA")]
public partial class СписанняВитратМайбутніхПеріодів_PointerControl : PointerControl
{
    event EventHandler<СписанняВитратМайбутніхПеріодів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{СписанняВитратМайбутніхПеріодів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static СписанняВитратМайбутніхПеріодів_PointerControl New() => NewWithProperties([]);

    СписанняВитратМайбутніхПеріодів_Pointer pointer = new();
    public СписанняВитратМайбутніхПеріодів_Pointer Pointer
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

        СписанняВитратМайбутніхПеріодів_ШвидкийВибір page = СписанняВитратМайбутніхПеріодів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new СписанняВитратМайбутніхПеріодів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new СписанняВитратМайбутніхПеріодів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    