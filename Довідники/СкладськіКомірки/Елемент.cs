
/*
        СкладськіКомірки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_j7hVtXgJ302GVXOIos4bIA")]
partial class СкладськіКомірки_Елемент : DirectoryFormElement
{
    public СкладськіКомірки_Objest Елемент { get; init; } = new();

    public СкладськіПриміщення_Pointer ВласникДляНового = new();

    #region Fields
    Entry Назва = Entry.New();
    СкладськіПриміщення_PointerControl Приміщення = СкладськіПриміщення_PointerControl.New();
    СкладськіКомірки_Папки_PointerControl Папка = СкладськіКомірки_Папки_PointerControl.New();
    Entry Лінія = Entry.New();
    Entry Позиція = Entry.New();
    Entry Стелаж = Entry.New();
    Entry Ярус = Entry.New();
    ComboBoxText ТипСкладськоїКомірки = ComboBoxText.New();
    ТипорозміриКомірок_PointerControl Типорозмір = ТипорозміриКомірок_PointerControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Назва:
        Назва.WidthRequest = 500;

        // Приміщення:
        Приміщення.Caption = "Приміщення";
        Приміщення.WidthPresentation = 300;

        // Папка:
        Папка.Caption = "Папка";
        Папка.WidthPresentation = 300;

        // Лінія:
        Лінія.WidthRequest = 300;

        // Позиція:
        Позиція.WidthRequest = 300;

        // Стелаж:
        Стелаж.WidthRequest = 300;

        // Ярус:
        Ярус.WidthRequest = 300;

        // ТипСкладськоїКомірки:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиСкладськихКомірок_List())
                ТипСкладськоїКомірки.Append(field.Value.ToString(), field.Name);

            ТипСкладськоїКомірки.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипСкладськоїКомірки.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        // Типорозмір:
        Типорозмір.Caption = "Типорозмір";
        Типорозмір.WidthPresentation = 300;
    }

    public static СкладськіКомірки_Елемент New()
    {
        СкладськіКомірки_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Папка
        CreateField(vBox, null, Папка);

        // Приміщення
        CreateField(vBox, null, Приміщення);

        // Лінія
        CreateField(vBox, "Лінія:", Лінія);

        // Позиція
        CreateField(vBox, "Позиція:", Позиція);

        // Стелаж
        CreateField(vBox, "Стелаж:", Стелаж);

        // Ярус
        CreateField(vBox, "Ярус:", Ярус);

        // ТипСкладськоїКомірки
        CreateField(vBox, "Тип:", ТипСкладськоїКомірки);

        // Типорозмір
        CreateField(vBox, null, Типорозмір);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        if (IsNew)
            Елемент.Приміщення = ВласникДляНового;

        Назва.SetText(Елемент.Назва);
        Приміщення.Pointer = Елемент.Приміщення;
        Папка.Pointer = Елемент.Папка;
        Лінія.SetText(Елемент.Лінія);
        Позиція.SetText(Елемент.Позиція);
        Стелаж.SetText(Елемент.Стелаж);
        Ярус.SetText(Елемент.Ярус);
        ТипСкладськоїКомірки.ActiveId = Елемент.ТипСкладськоїКомірки.ToString();
        Типорозмір.Pointer = Елемент.Типорозмір;
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
        Елемент.Приміщення = Приміщення.Pointer;
        Елемент.Папка = Папка.Pointer;
        Елемент.Лінія = Лінія.GetText();
        Елемент.Позиція = Позиція.GetText();
        Елемент.Стелаж = Стелаж.GetText();
        Елемент.Ярус = Ярус.GetText();
        Елемент.ТипСкладськоїКомірки = ПсевдонімиПерелічення.ТипиСкладськихКомірок_FindByName(ТипСкладськоїКомірки.ActiveId);
        Елемент.Типорозмір = Типорозмір.Pointer;
    }

    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }
}
