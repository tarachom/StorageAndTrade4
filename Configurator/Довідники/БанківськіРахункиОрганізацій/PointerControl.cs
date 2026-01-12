
/*     
        БанківськіРахункиОрганізацій_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

public class БанківськіРахункиОрганізацій_PointerControl : PointerControl
{
    event EventHandler<БанківськіРахункиОрганізацій_Pointer> PointerChanged;

    public БанківськіРахункиОрганізацій_PointerControl()
    {
        pointer = new БанківськіРахункиОрганізацій_Pointer();
        WidthPresentation = 300;
        Caption = $"{БанківськіРахункиОрганізацій_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    БанківськіРахункиОрганізацій_Pointer pointer;
    public БанківськіРахункиОрганізацій_Pointer Pointer
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

    

    protected override async void OpenSelect(Button button, EventArgs args)
    {
        Popover popover = Popover.New();
        popover.SetParent(button);
        popover.WidthRequest = 800;
        popover.HeightRequest = 400;
        BeforeClickOpenFunc?.Invoke();
        БанківськіРахункиОрганізацій_ШвидкийВибір page = new()
        {
            PopoverParent = popover,
            DirectoryPointerItem = Pointer.UnigueID,
            CallBack_OnSelectPointer = selectPointer =>
            {
                Pointer = new БанківськіРахункиОрганізацій_Pointer(selectPointer);
                AfterSelectFunc?.Invoke();
            }
        };
        
        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new БанківськіРахункиОрганізацій_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }
}
    