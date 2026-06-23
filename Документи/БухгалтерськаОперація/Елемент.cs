
/*
        БухгалтерськаОперація_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using Функції = StorageAndTrade.БухгалтерськаОперація_Функції;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_atRQpjGFYUqSI19kL6UIRQ")]
partial class БухгалтерськаОперація_Елемент : DocumentFormElement
{
    public БухгалтерськаОперація_Object Елемент { get; init; } = new();

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

        CreateDocName(БухгалтерськаОперація_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Проводки"
        Операції.WidthRequest = 500;
        Операції.HeightRequest = 300;
        Interface.Notebook.InsertPage(Операції, Label.New("Операції"), 0);
        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.БухгалтерськаОперація.Основа";
    }

    public static БухгалтерськаОперація_Елемент New()
    {
        БухгалтерськаОперація_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DocumentElement Interface;

    protected override void BuildInterface()
    {
        Interface = FunctionForInterfaces.ForDocument();

        Append(Interface.MainBox);

        CreateTopStart(Interface.TopStartBox);
        CreateTopEnd(Interface.TopEndBox);
        CreateBottomStart(Interface.BottomStartBox);
        CreateBottomEnd(Interface.BottomEndBox);
    }

    void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);
    }

    void CreateTopEnd(Box vBox)
    {

    }

    void CreateBottomStart(Box vBox)
    {
        // Основа
        CreateField(vBox, null, Основа);
    }

    void CreateBottomEnd(Box vBox)
    {

    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
        }

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

    protected override async Task<bool> Save()
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
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async Task<bool> SpendTheDocument(bool spendDoc)
    {
        if (spendDoc)
        {
            bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);
            if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UniqueID);
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

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
