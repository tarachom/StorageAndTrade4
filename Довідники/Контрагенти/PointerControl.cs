
/*     
        Контрагенти_PointerControl.cs
        PointerControl
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<PointerControl>("PointerControl_xxlQMlAUW0e7vH5vEtBp6g")]
public partial class Контрагенти_PointerControl : PointerControl
{
    event EventHandler<Контрагенти_Pointer>? PointerChanged;

    partial void Initialize()
    {
        WidthPresentation = 300;
        Caption = $"{Контрагенти_Const.FULLNAME}:";
        PointerChanged += async (_, pointer) => Presentation = pointer != null ? await pointer.GetPresentation() : "";
    }

    public static Контрагенти_PointerControl New() => NewWithProperties([]);

    Контрагенти_Pointer pointer = new();
    public Контрагенти_Pointer Pointer
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

        Контрагенти_ШвидкийВибір page = Контрагенти_ШвидкийВибір.New();
        page.PopoverParent = popover;
        page.DirectoryPointerItem = Pointer.UniqueID;
        page.AllowedContentSelection = AllowedContentSelection;
        page.OpenFolder = OpenFolder;
        page.CallBack_OnSelectPointer = selectPointer =>
        {
            Pointer = new Контрагенти_Pointer(selectPointer);
            AfterSelectFunc?.Invoke();
        };

        popover.SetChild(page);
        popover.Show();

        await page.SetValue();
    }

    protected override void OnClear(Button button, EventArgs args)
    {
        Pointer = new Контрагенти_Pointer();
        AfterSelectFunc?.Invoke();
        AfterClearFunc?.Invoke();
    }

    public async Task ПривязкаДоДоговору(ДоговориКонтрагентів_PointerControl Договір)
    {
        if (Договір.Pointer.IsEmpty())
        {
            ДоговориКонтрагентів_Pointer? договірКонтрагента = await ФункціїДляДокументів.ОсновнийДоговірДляКонтрагента(Pointer, ТипДоговорів.ЗПостачальниками);
            if (договірКонтрагента != null) Договір.Pointer = договірКонтрагента;
        }
        else
        {
            if (Pointer.IsEmpty())
                Договір.Pointer = new ДоговориКонтрагентів_Pointer();
            else
            {
                //Перевірити чи змінився контрагент
                ДоговориКонтрагентів_Objest? обєкт = await Договір.Pointer.GetDirectoryObject();
                if (обєкт != null)
                    if (обєкт.Контрагент != Pointer)
                    {
                        Договір.Pointer = new ДоговориКонтрагентів_Pointer();
                        AfterSelectFunc?.Invoke();
                    }
            }
        }
    }
}
