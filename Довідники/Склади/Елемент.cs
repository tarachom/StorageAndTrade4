
/*
        Склади_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_gEw3jfd7vkGf0YWS2mhmw")]
partial class Склади_Елемент : DirectoryFormElement
{
    public Склади_Object Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    DropDownControl ТипСкладу = DropDownControl.New();
    ФізичніОсоби_PointerControl Відповідальний = ФізичніОсоби_PointerControl.New();
    ВидиЦін_PointerControl ВидЦін = ВидиЦін_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Склади_Папки_PointerControl Папка = Склади_Папки_PointerControl.New();
    DropDownControl НалаштуванняАдресногоЗберігання = DropDownControl.New();
    Категорії_PointerControl Категорія = Категорії_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Контакти"
    Склади_ТабличнаЧастина_Контакти Контакти = Склади_ТабличнаЧастина_Контакти.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // ТипСкладу:
        ТипСкладу.Fill(ПсевдонімиПерелічення.ТипиСкладів_Dict());

        // Відповідальний:
        Відповідальний.Caption = "Відповідальний";
        Відповідальний.WidthPresentation = 300;

        // ВидЦін:
        ВидЦін.Caption = "Вид цін";
        ВидЦін.WidthPresentation = 300;

        // Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        // Папка:
        Папка.Caption = "Папка";
        Папка.WidthPresentation = 300;

        // НалаштуванняАдресногоЗберігання:
        НалаштуванняАдресногоЗберігання.Fill(ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Dict());

        // Категорія:
        Категорія.Caption = "Категорія";
        Категорія.WidthPresentation = 300;

        // Таблична частина "Контакти"
        Контакти.ЕлементВласник = Елемент;
        Контакти.WidthRequest = 500;
        Контакти.HeightRequest = 300;
        Контакти.Vexpand = false;
    }

    public static Склади_Елемент New()
    {
        Склади_Елемент element = NewWithProperties([]);
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

        // Папка
        CreateField(vBox, null, Папка);

        // ТипСкладу
        CreateField(vBox, "Тип складу:", ТипСкладу);

        // Відповідальний
        CreateField(vBox, null, Відповідальний);

        // ВидЦін
        CreateField(vBox, null, ВидЦін);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);

        // НалаштуванняАдресногоЗберігання
        CreateField(vBox, "Адресне зберігання:", НалаштуванняАдресногоЗберігання);

        // Категорія
        CreateField(vBox, null, Категорія);
    }

    void CreateEnd(Box vBox)
    {
        // Таблична частина "Контакти"
        CreateTablePart(vBox, "Контакти", Контакти);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        ТипСкладу.Value = Елемент.ТипСкладу.ToString();
        Відповідальний.Pointer = Елемент.Відповідальний;
        ВидЦін.Pointer = Елемент.ВидЦін;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Папка.Pointer = Елемент.Папка;
        НалаштуванняАдресногоЗберігання.Value = Елемент.НалаштуванняАдресногоЗберігання.ToString();
        Категорія.Pointer = Елемент.Категорія;

        // Таблична частина "Контакти"
        await Контакти.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.ТипСкладу = ПсевдонімиПерелічення.ТипиСкладів_FindByName(ТипСкладу.Value);
        Елемент.Відповідальний = Відповідальний.Pointer;
        Елемент.ВидЦін = ВидЦін.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Папка = Папка.Pointer;
        Елемент.НалаштуванняАдресногоЗберігання = ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_FindByName(НалаштуванняАдресногоЗберігання.Value);
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
