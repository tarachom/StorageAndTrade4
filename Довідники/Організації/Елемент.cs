
/*
        Організації_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_9mtifqQ5Z06qw0LUndwwXQ")]
partial class Організації_Елемент : DirectoryFormElement
{
    public Організації_Object Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Entry НазваПовна = Entry.New();
    Entry НазваСкорочена = Entry.New();
    DateTimeControl ДатаРеєстрації = DateTimeControl.New();
    Entry КраїнаРеєстрації = Entry.New();
    Entry СвідоцтвоСеріяНомер = Entry.New();
    Entry СвідоцтвоДатаВидачі = Entry.New();
    Організації_PointerControl Холдинг = Організації_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Контакти"
    Організації_ТабличнаЧастина_Контакти Контакти = Організації_ТабличнаЧастина_Контакти.New();

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

        // НазваСкорочена:
        НазваСкорочена.WidthRequest = 500;

        // ДатаРеєстрації:
        ДатаРеєстрації.OnlyDate = true;

        // КраїнаРеєстрації:
        КраїнаРеєстрації.WidthRequest = 300;

        // СвідоцтвоСеріяНомер:
        СвідоцтвоСеріяНомер.WidthRequest = 200;

        // СвідоцтвоДатаВидачі:
        СвідоцтвоДатаВидачі.WidthRequest = 200;

        // Холдинг:
        Холдинг.Caption = "Холдинг";
        Холдинг.WidthPresentation = 300;
    }

    public static Організації_Елемент New()
    {
        Організації_Елемент element = NewWithProperties([]);
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
        CreateField(vBox, "Назва повна:", НазваПовна);

        // НазваСкорочена
        CreateField(vBox, "Назва скорочена:", НазваСкорочена);

        // ДатаРеєстрації
        CreateField(vBox, "Дата реєстрації:", ДатаРеєстрації);

        // КраїнаРеєстрації
        CreateField(vBox, "Країна реєстрації:", КраїнаРеєстрації);

        // СвідоцтвоСеріяНомер
        CreateField(vBox, "Свідоцтво серія номер:", СвідоцтвоСеріяНомер);

        // СвідоцтвоДатаВидачі
        CreateField(vBox, "Свідоцтво дата видачі:", СвідоцтвоДатаВидачі);

        // Холдинг
        CreateField(vBox, null, Холдинг);
    }

    void CreateEnd(Box vBox)
    {
        // Таблична частина "Контакти"
        Контакти.WidthRequest = 500;
        Контакти.HeightRequest = 300;
        Контакти.Vexpand = false;
        CreateTablePart(vBox, "Контакти", Контакти);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        НазваПовна.SetText(Елемент.НазваПовна);
        НазваСкорочена.SetText(Елемент.НазваСкорочена);
        ДатаРеєстрації.Value = Елемент.ДатаРеєстрації;
        КраїнаРеєстрації.SetText(Елемент.КраїнаРеєстрації);
        СвідоцтвоСеріяНомер.SetText(Елемент.СвідоцтвоСеріяНомер);
        СвідоцтвоДатаВидачі.SetText(Елемент.СвідоцтвоДатаВидачі);
        Холдинг.Pointer = Елемент.Холдинг;

        // Таблична частина "Контакти"
        Контакти.ЕлементВласник = Елемент;
        await Контакти.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.НазваПовна = НазваПовна.GetText();
        Елемент.НазваСкорочена = НазваСкорочена.GetText();
        Елемент.ДатаРеєстрації = ДатаРеєстрації.Value;
        Елемент.КраїнаРеєстрації = КраїнаРеєстрації.GetText();
        Елемент.СвідоцтвоСеріяНомер = СвідоцтвоСеріяНомер.GetText();
        Елемент.СвідоцтвоДатаВидачі = СвідоцтвоДатаВидачі.GetText();
        Елемент.Холдинг = Холдинг.Pointer;
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
