
/*
        Користувачі_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_WT6EiQO5EE65QE4NYAmIew")]
partial class Користувачі_Елемент : DirectoryFormElement
{
    public Користувачі_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    ФізичніОсоби_PointerControl ФізичнаОсоба = ФізичніОсоби_PointerControl.New();
    Entry Коментар = Entry.New();

    #endregion

    #region TabularParts

    // Таблична частина "Контакти"
    Користувачі_ТабличнаЧастина_Контакти Контакти = Користувачі_ТабличнаЧастина_Контакти.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // ФізичнаОсоба:
        ФізичнаОсоба.Caption = "Фізична особа";
        ФізичнаОсоба.WidthPresentation = 300;

        // Коментар:
        Коментар.WidthRequest = 300;
    }

    public static Користувачі_Елемент New()
    {
        Користувачі_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {

        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // ФізичнаОсоба
        CreateField(vBox, null, ФізичнаОсоба);

        // Коментар
        CreateField(vBox, "Коментар:", Коментар);
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
        ФізичнаОсоба.Pointer = Елемент.ФізичнаОсоба;
        Коментар.SetText(Елемент.Коментар);

        // Таблична частина "Контакти"
        Контакти.ЕлементВласник = Елемент;
        await Контакти.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.ФізичнаОсоба = ФізичнаОсоба.Pointer;
        Елемент.Коментар = Коментар.GetText();
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
