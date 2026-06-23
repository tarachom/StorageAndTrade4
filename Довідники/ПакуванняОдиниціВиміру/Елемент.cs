
/*
        ПакуванняОдиниціВиміру_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_SarB1K28a0uBgQ2lw3yVaQ")]
partial class ПакуванняОдиниціВиміру_Елемент : DirectoryFormElement
{
    public ПакуванняОдиниціВиміру_Object Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Entry НазваПовна = Entry.New();
    IntegerControl КількістьУпаковок = IntegerControl.New();

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

        // НазваПовна:
        НазваПовна.WidthRequest = 500;
    }

    public static ПакуванняОдиниціВиміру_Елемент New()
    {
        ПакуванняОдиниціВиміру_Елемент element = NewWithProperties([]);
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

        // НазваПовна
        CreateField(vBox, "Опис:", НазваПовна);

        // КількістьУпаковок
        CreateField(vBox, "Коефіцієнт:", КількістьУпаковок);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        НазваПовна.SetText(Елемент.НазваПовна);
        КількістьУпаковок.Value = Елемент.КількістьУпаковок;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.НазваПовна = НазваПовна.GetText();
        Елемент.КількістьУпаковок = КількістьУпаковок.Value;
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
