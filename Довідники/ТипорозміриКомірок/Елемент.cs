
/*
        ТипорозміриКомірок_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;

using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormElement>("Element_CIv08HskkyqI69ISwzmAQ")]
partial class ТипорозміриКомірок_Елемент : DirectoryFormElement
{
    public ТипорозміриКомірок_Objest Елемент { get; init; } = new();

    #region Fields
    Entry Назва = Entry.New();
    Entry Висота = Entry.New();
    Entry Ширина = Entry.New();
    Entry Глибина = Entry.New();
    Entry Обєм = Entry.New();
    Entry Вантажопідйомність = Entry.New();

    #endregion

    #region TabularParts

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        // Назва:
        Назва.WidthRequest = 250;

        // Висота:
        Висота.WidthRequest = 100;

        // Ширина:
        Ширина.WidthRequest = 100;

        // Глибина:
        Глибина.WidthRequest = 100;

        // Обєм:
        Обєм.WidthRequest = 100;

        // Вантажопідйомність:
        Вантажопідйомність.WidthRequest = 100;
    }

    public static ТипорозміриКомірок_Елемент New()
    {
        ТипорозміриКомірок_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateStart(Box vBox)
    {
        // Назва
        CreateField(vBox, "Назва:", Назва);

        // Висота
        CreateField(vBox, "Висота:", Висота);

        // Ширина
        CreateField(vBox, "Ширина:", Ширина);

        // Глибина
        CreateField(vBox, "Глибина:", Глибина);

        // Обєм
        CreateField(vBox, "Обєм:", Обєм);

        // Вантажопідйомність
        CreateField(vBox, "Вантажопідйомність:", Вантажопідйомність);
    }

    protected override void CreateEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Назва.SetText(Елемент.Назва);
        Висота.SetText(Елемент.Висота);
        Ширина.SetText(Елемент.Ширина);
        Глибина.SetText(Елемент.Глибина);
        Обєм.SetText(Елемент.Обєм);
        Вантажопідйомність.SetText(Елемент.Вантажопідйомність);
    }

    protected override void GetValue()
    {
        Елемент.Назва = Назва.GetText();
        Елемент.Висота = Висота.GetText();
        Елемент.Ширина = Ширина.GetText();
        Елемент.Глибина = Глибина.GetText();
        Елемент.Обєм = Обєм.GetText();
        Елемент.Вантажопідйомність = Вантажопідйомність.GetText();
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
