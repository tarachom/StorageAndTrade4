
/*     
        ПланРахунків_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_WNcsPMytx0aEjYuHpnLWhA")]
public partial class ПланРахунків_PointerControl : PointerControl
{
    event EventHandler<ПланРахунків_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{ПланРахунків_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static ПланРахунків_PointerControl New() => NewWithProperties([]);

    ПланРахунків_Pointer pointer = new();
    public ПланРахунків_Pointer Pointer
    {
        get => pointer;
        set
        {
            pointer = value;
            PointerChanged?.Invoke(null, pointer);
        }
    }

    public List<Where>? WhereList { get; set; }
    public ConfigurationDirectories.HierarchicalContentType? AllowedContentSelection { get; set; }

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        ПланРахунків_ШвидкийВибір page = ПланРахунків_ШвидкийВибір.New();
        page.WhereList = WhereList;
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new ПланРахунків_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new ПланРахунків_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
