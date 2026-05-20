
/*     
        СтаттяРухуКоштів_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_MLtn64wEmCECdQRTTNnA")]
public partial class СтаттяРухуКоштів_PointerControl : PointerControl
{
    event EventHandler<СтаттяРухуКоштів_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{СтаттяРухуКоштів_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static СтаттяРухуКоштів_PointerControl New() => NewWithProperties([]);

    СтаттяРухуКоштів_Pointer pointer = new();
    public СтаттяРухуКоштів_Pointer Pointer
    {
        get
        {
            return pointer;
        }
        set
        {
            pointer = value;
            PointerChanged?.Invoke(null, pointer);
        }
    }

    

    public ConfigurationDirectories.HierarchicalContentType? AllowedContentSelection { get; set; }

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();

        СтаттяРухуКоштів_ШвидкийВибір page = СтаттяРухуКоштів_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new СтаттяРухуКоштів_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new СтаттяРухуКоштів_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    