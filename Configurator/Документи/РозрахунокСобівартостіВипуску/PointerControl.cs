

/*     
        РозрахунокСобівартостіВипуску_PointerControl.cs
        PointerControl
*/
using Gtk;
using InterfaceGtk4;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_G6eAZjoNXS7AVy0JUH1A")]
public partial class РозрахунокСобівартостіВипуску_PointerControl : PointerControl
{
    event EventHandler<РозрахунокСобівартостіВипуску_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{РозрахунокСобівартостіВипуску_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static РозрахунокСобівартостіВипуску_PointerControl New() => NewWithProperties([]);

    РозрахунокСобівартостіВипуску_Pointer pointer = new();
    public РозрахунокСобівартостіВипуску_Pointer Pointer
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

        РозрахунокСобівартостіВипуску_ШвидкийВибір page = РозрахунокСобівартостіВипуску_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DocumentPointerItem = Pointer.UniqueID;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new РозрахунокСобівартостіВипуску_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new РозрахунокСобівартостіВипуску_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    