
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
    public Контрагенти_Objest Елемент { get; init; } = new();
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
    }

    public static Контрагенти_Елемент New()
    {
        Контрагенти_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Папка
        CreateField(vBox, null, Папка);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // НазваПовна
        CreateField(vBox, "Повна назва:", НазваПовна);

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
    }

    protected override void CreateEnd(Box vBox)
    {
        // Таблична частина "Контакти"
        Контакти.WidthRequest = 500;
        Контакти.HeightRequest = 300;
        Контакти.Vexpand = false;
        CreateTablePart(vBox, "Контакти", Контакти);

        // Таблична частина "Файли"
        Файли.WidthRequest = 500;
        Файли.HeightRequest = 300;
        Файли.Vexpand = false;
        CreateTablePart(vBox, "Файли", Файли);
    }

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

        // Таблична частина "Контакти"
        Контакти.ЕлементВласник = Елемент;
        await Контакти.LoadRecords();

        // Таблична частина "Файли"
        Файли.ЕлементВласник = Елемент;
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
