
/*
        СеріїНоменклатури_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_zCf6jT2H8UaqGBUkjMrG2A")]
partial class СеріїНоменклатури_Елемент : DirectoryFormElement
{
    public СеріїНоменклатури_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Номер = Entry.New();
    Entry Коментар = Entry.New();
    DateTimeControl ДатаСтворення = DateTimeControl.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Номер:
        Номер.WidthRequest = 100;

        // Коментар:
        Коментар.WidthRequest = 500;
    }

    public static СеріїНоменклатури_Елемент New()
    {
        СеріїНоменклатури_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Номер
        CreateField(vBox, "Номер:", Номер);

        // Коментар
        CreateField(vBox, "Коментар:", Коментар);

        // ДатаСтворення
        CreateField(vBox, "Дата створення:", ДатаСтворення);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Номер.SetText(Елемент.Номер);
        Коментар.SetText(Елемент.Коментар);
        ДатаСтворення.Value = Елемент.ДатаСтворення;
    }

    protected override void GetValue()
    {
        Елемент.Номер = Номер.GetText();
        Елемент.Коментар = Коментар.GetText();
        Елемент.ДатаСтворення = ДатаСтворення.Value;
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
