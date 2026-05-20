
/*
        Бланки_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_GhUB8IaeUKsigIwXnHhg")]
partial class Бланки_Елемент : DirectoryFormElement
{
    public Бланки_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();

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
    }

    public static Бланки_Елемент New()
    {
        Бланки_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
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
