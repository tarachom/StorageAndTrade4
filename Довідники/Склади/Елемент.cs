
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
    public Склади_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    ComboBoxText ТипСкладу = ComboBoxText.New();
    ФізичніОсоби_PointerControl Відповідальний = ФізичніОсоби_PointerControl.New();
    ВидиЦін_PointerControl ВидЦін = ВидиЦін_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Склади_Папки_PointerControl Папка = Склади_Папки_PointerControl.New();
    ComboBoxText НалаштуванняАдресногоЗберігання = ComboBoxText.New();

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
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ТипиСкладів_List())
                ТипСкладу.Append(field.Value.ToString(), field.Name);

            ТипСкладу.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ТипСкладу.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

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
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_List())
                НалаштуванняАдресногоЗберігання.Append(field.Value.ToString(), field.Name);

            НалаштуванняАдресногоЗберігання.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            НалаштуванняАдресногоЗберігання.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
    }

    public static Склади_Елемент New()
    {
        Склади_Елемент element = NewWithProperties([]);
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

    }

    protected override void CreateEnd(Box vBox)
    {
        // Таблична частина "Контакти"
        Контакти.WidthRequest = 500;
        Контакти.HeightRequest = 300;
        Контакти.Vexpand = false;

        CreateTablePart(vBox, "Контакти", Контакти);
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        ТипСкладу.ActiveId = Елемент.ТипСкладу.ToString();
        Відповідальний.Pointer = Елемент.Відповідальний;
        ВидЦін.Pointer = Елемент.ВидЦін;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Папка.Pointer = Елемент.Папка;
        НалаштуванняАдресногоЗберігання.ActiveId = Елемент.НалаштуванняАдресногоЗберігання.ToString();

        // Таблична частина "Контакти"
        Контакти.ЕлементВласник = Елемент;
        await Контакти.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.ТипСкладу = ПсевдонімиПерелічення.ТипиСкладів_FindByName(ТипСкладу.ActiveId);
        Елемент.Відповідальний = Відповідальний.Pointer;
        Елемент.ВидЦін = ВидЦін.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Папка = Папка.Pointer;
        Елемент.НалаштуванняАдресногоЗберігання = ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_FindByName(НалаштуванняАдресногоЗберігання.ActiveId);
    }

    #endregion

    protected override async ValueTask<bool> Save()
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
