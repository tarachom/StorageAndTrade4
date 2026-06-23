
/*
        СтаттяРухуКоштів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_Ywq4sdfH0qMFQkbNP6omQ")]
partial class СтаттяРухуКоштів_Елемент : DirectoryFormElement
{
    public СтаттяРухуКоштів_Object Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Entry КореспондуючийРахунок = Entry.New();
    ComboBoxText ВидРухуКоштів = ComboBoxText.New();
    Entry Опис = Entry.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Код:
        Код.WidthRequest = 100;

        // Назва:
        Назва.WidthRequest = 500;

        // КореспондуючийРахунок:
        КореспондуючийРахунок.WidthRequest = 300;

        // ВидРухуКоштів:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ВидиРухуКоштів_List())
                ВидРухуКоштів.Append(field.Value.ToString(), field.Name);

            ВидРухуКоштів.AddController(FunctionForComboBox.DisableScrolling());
        }

        // Опис:
        Опис.WidthRequest = 300;
    }

    public static СтаттяРухуКоштів_Елемент New()
    {
        СтаттяРухуКоштів_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DirectoryElementSmall Interface;

    protected override void BuildInterface()
    {
        Interface = FunctionForInterfaces.ForDirectorySmall();

        Append(Interface.MainBox);
        CreateStart(Interface.TopStartBox);
    }

    void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // КореспондуючийРахунок
        CreateField(vBox, "Кореспондуючий рахунок:", КореспондуючийРахунок);

        // ВидРухуКоштів
        CreateField(vBox, "Вид руху коштів:", ВидРухуКоштів);

        // Опис
        CreateField(vBox, "Опис:", Опис);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        КореспондуючийРахунок.SetText(Елемент.КореспондуючийРахунок);
        ВидРухуКоштів.ActiveId = Елемент.ВидРухуКоштів.ToString();
        Опис.SetText(Елемент.Опис);
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.КореспондуючийРахунок = КореспондуючийРахунок.GetText();
        Елемент.ВидРухуКоштів = ПсевдонімиПерелічення.ВидиРухуКоштів_FindByName(ВидРухуКоштів.ActiveId);
        Елемент.Опис = Опис.GetText();
    }

    #endregion

    protected override async Task<bool> Save()
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
