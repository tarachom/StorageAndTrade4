
/*
        Контрагенти_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_jMqhqihMkKNPwAvNR6L7w")]
partial class Контрагенти_Елемент : DirectoryFormElement
{
    public Контрагенти_Object Елемент { get; init; } = new();
    public Контрагенти_Папки_Pointer РодичДляНового { get; set; } = new Контрагенти_Папки_Pointer();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Entry НазваПовна = Entry.New();
    Entry РеєстраційнийНомер = Entry.New();
    Контрагенти_Папки_PointerControl Папка = Контрагенти_Папки_PointerControl.New();
    TextView Опис = TextView.New();
    CheckButton Постачальник = CheckButton.NewWithLabel("Постачальник");
    CheckButton Покупець = CheckButton.NewWithLabel("Покупець");
    Категорії_PointerControl Категорія = Категорії_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Контакти"
    Контрагенти_ТабличнаЧастина_Контакти Контакти = Контрагенти_ТабличнаЧастина_Контакти.New();

    // Таблична частина "Файли"
    Контрагенти_ТабличнаЧастина_Файли Файли = Контрагенти_ТабличнаЧастина_Файли.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // НазваПовна:
        НазваПовна.WidthRequest = 500;

        // РеєстраційнийНомер:
        РеєстраційнийНомер.WidthRequest = 400;

        // Папка:
        Папка.Caption = "Папка";
        Папка.WidthPresentation = 300;

        // Опис:
        Опис.WrapMode = WrapMode.Word;

        // Категорія:
        Категорія.Caption = "Категорія";
        Категорія.WidthPresentation = 300;

        // Таблична частина "Контакти"
        Контакти.ЕлементВласник = Елемент;
        Контакти.WidthRequest = 500;
        Контакти.HeightRequest = 300;
        Контакти.Vexpand = false;

        // Таблична частина "Файли"
        Файли.ЕлементВласник = Елемент;
        Файли.WidthRequest = 500;
        Файли.HeightRequest = 300;
        Файли.Vexpand = false;
    }

    public static Контрагенти_Елемент New()
    {
        Контрагенти_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DirectoryElement Interface = FunctionForInterfaces.ForDirectory();

    protected override void BuildInterface()
    {
        Append(Interface.MainBox);
        CreateStart(Interface.TopStartBox);
        CreateEnd(Interface.TopEndBox);
    }

    void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // НазваПовна
        CreateField(vBox, "Повна назва:", НазваПовна);

        // Папка
        CreateField(vBox, null, Папка);

        // РеєстраційнийНомер
        CreateField(vBox, "Реєстраційний номер:", РеєстраційнийНомер);

        {
            // Постачальник
            Box hBox = CreateField(vBox, null, Постачальник);

            // Покупець
            CreateField(hBox, null, Покупець);
        }

        // Опис
        CreateFieldView(vBox, "Опис:", Опис, 500, 200);

        // Категорія
        CreateField(vBox, null, Категорія);
    }

    void CreateEnd(Box vBox)
    {
        // Таблична частина "Контакти"
        CreateTablePart(vBox, "Контакти", Контакти);

        // Таблична частина "Файли"
        CreateTablePart(vBox, "Файли", Файли);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
            Елемент.Папка = РодичДляНового;

        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        НазваПовна.SetText(Елемент.НазваПовна);
        РеєстраційнийНомер.SetText(Елемент.РеєстраційнийНомер);
        Папка.Pointer = Елемент.Папка;
        Опис.Buffer?.Text = Елемент.Опис;
        Постачальник.Active = Елемент.Постачальник;
        Покупець.Active = Елемент.Покупець;
        Категорія.Pointer = Елемент.Категорія;

        // Таблична частина "Контакти"
        await Контакти.LoadRecords();

        // Таблична частина "Файли"
        await Файли.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.НазваПовна = НазваПовна.GetText();
        Елемент.РеєстраційнийНомер = РеєстраційнийНомер.GetText();
        Елемент.Папка = Папка.Pointer;
        Елемент.Опис = Опис.Buffer?.Text ?? "";
        Елемент.Постачальник = Постачальник.Active;
        Елемент.Покупець = Покупець.Active;
        Елемент.Категорія = Категорія.Pointer;
    }

    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Контакти.SaveRecords(); // Таблична частина "Контакти"
                await Файли.SaveRecords(); // Таблична частина "Файли"

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
