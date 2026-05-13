
/*
        БухгалтерськаОперація_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode;
using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.БухгалтерськаОперація_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_atRQpjGFYUqSI19kL6UIRQ")]
partial class БухгалтерськаОперація_Елемент : DocumentFormElement
{
    public БухгалтерськаОперація_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Entry Коментар = Entry.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Проводки" 
    БухгалтерськаОперація_ТабличнаЧастина_Операції Операції = БухгалтерськаОперація_ТабличнаЧастина_Операції.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        НомерДок.WidthRequest = 100;
        CreateDocName(БухгалтерськаОперація_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Проводки"
        Операції.WidthRequest = 500;
        Операції.HeightRequest = 300;
        NotebookTablePart.InsertPage(Операції, Label.New("Операції"), 0);
        NotebookTablePart.SetCurrentPage(0);

        //Коментар:
        Коментар.WidthRequest = 1200;

        //Основа:
        Основа.BoundConfType = "Документи.БухгалтерськаОперація.Основа";

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;
    }

    public static БухгалтерськаОперація_Елемент New()
    {
        БухгалтерськаОперація_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);
    }

    protected override void CreateTopEnd(Box vBox)
    {

    }

    protected override void CreateBottomStart(Box vBox)
    {
        // Основа
        CreateField(vBox, null, Основа);
    }

    protected override void CreateBottomEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Коментар.SetText(Елемент.Коментар);
        Організація.Pointer = Елемент.Організація;
        Основа.Pointer = Елемент.Основа;

        // Таблична частина "Проводки" 
        Операції.ЕлементВласник = Елемент;
        await Операції.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Організація = Організація.Pointer;
        Елемент.Основа = Основа.Pointer;
    }

    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Операції.SaveRecords(); // Таблична частина "Проводки"

                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async ValueTask<bool> SpendTheDocument(bool spendDoc)
    {
        if (spendDoc)
        {
            bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);
            //if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UniqueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UniqueID uniqueID)
    {
        CommonForms_DocumentMovementThroughRegisters.Create(new БухгалтерськаОперація_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
