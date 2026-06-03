
/*
        ФізичніОсоби_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_9nlSm2FadUCbjUqsAEDg")]
partial class ФізичніОсоби_Елемент : DirectoryFormElement
{
    public ФізичніОсоби_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    DateTimeControl ДатаНародження = DateTimeControl.New();
    ComboBoxText Стать = ComboBoxText.New();
    Entry ІПН = Entry.New();

    #endregion

    #region TabularParts

    // Таблична частина "Контакти"
    ФізичніОсоби_ТабличнаЧастина_Контакти Контакти = ФізичніОсоби_ТабличнаЧастина_Контакти.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // ДатаНародження:
        ДатаНародження.OnlyDate = true;

        // Стать:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатьФізичноїОсоби_List())
                Стать.Append(field.Value.ToString(), field.Name);
                
            Стать.AddController(FunctionForComboBox.DisableScrolling());
        }

        // ІПН:
        ІПН.WidthRequest = 200;
    }

    public static ФізичніОсоби_Елемент New()
    {
        ФізичніОсоби_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // ДатаНародження
        CreateField(vBox, "Дата народження:", ДатаНародження);

        // Стать
        CreateField(vBox, "Стать:", Стать);

        // ІПН
        CreateField(vBox, "ІПН:", ІПН);
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

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        ДатаНародження.Value = Елемент.ДатаНародження;
        Стать.ActiveId = Елемент.Стать.ToString();
        ІПН.SetText(Елемент.ІПН);

        // Таблична частина "Контакти"
        Контакти.ЕлементВласник = Елемент;
        await Контакти.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.ДатаНародження = ДатаНародження.Value;
        Елемент.Стать = ПсевдонімиПерелічення.СтатьФізичноїОсоби_FindByName(Стать.ActiveId);
        Елемент.ІПН = ІПН.GetText();
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
