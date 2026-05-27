
/*
        БанківськіРахункиКонтрагентів_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_85hOfF7rSES5dgDILMwBLQ")]
partial class БанківськіРахункиКонтрагентів_Елемент : DirectoryFormElement
{
    public БанківськіРахункиКонтрагентів_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Код = Entry.New();
    Entry Назва = Entry.New();
    Банки_PointerControl Банк = Банки_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    Entry НомерРахунку = Entry.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();

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

        // Банк:
        Банк.Caption = "Банк";
        Банк.WidthPresentation = 300;

        // Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        // НомерРахунку:
        НомерРахунку.WidthRequest = 300;

        // Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

    }

    public static БанківськіРахункиКонтрагентів_Елемент New()
    {
        БанківськіРахункиКонтрагентів_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Код
        CreateField(vBox, "Код:", Код);

        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Банк
        CreateField(vBox, null, Банк);

        // Контрагент
        CreateField(vBox, null, Контрагент);

        // НомерРахунку
        CreateField(vBox, "Номер рахунку:", НомерРахунку);

        // Валюта
        CreateField(vBox, null, Валюта);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Код.SetText(Елемент.Код);
        Назва.SetText(Елемент.Назва);
        Банк.Pointer = Елемент.Банк;
        Контрагент.Pointer = Елемент.Контрагент;
        НомерРахунку.SetText(Елемент.НомерРахунку);
        Валюта.Pointer = Елемент.Валюта;
    }

    protected override void GetValue()
    {
        Елемент.Код = Код.GetText();
        Елемент.Назва = Назва.GetText();
        Елемент.Банк = Банк.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.НомерРахунку = НомерРахунку.GetText();
        Елемент.Валюта = Валюта.Pointer;
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
