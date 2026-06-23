
/*
        РозміщенняНоменклатуриПоКоміркам_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using Функції = StorageAndTrade.РозміщенняНоменклатуриПоКоміркам_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_nqdOTgvEPkqDRRiyTaYczQ")]
partial class РозміщенняНоменклатуриПоКоміркам_Елемент : DocumentFormElement
{
    public РозміщенняНоменклатуриПоКоміркам_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    Entry Коментар = Entry.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    РозміщенняНоменклатуриПоКоміркам_ТабличнаЧастина_Товари Товари = РозміщенняНоменклатуриПоКоміркам_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(РозміщенняНоменклатуриПоКоміркам_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        Interface.Notebook.InsertPage(Товари, Label.New("Товари"), 0);
        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 300;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Основа:
        Основа.BoundConfType = "Документи.РозміщенняНоменклатуриПоКоміркам.Основа";
    }

    public static РозміщенняНоменклатуриПоКоміркам_Елемент New()
    {
        РозміщенняНоменклатуриПоКоміркам_Елемент element = NewWithProperties([]);
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

    }

    void CreateTopEnd(Box vBox)
    {

    }

    void CreateBottomStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);

        // Склад
        CreateField(vBox, null, Склад);

        // Автор
        CreateField(vBox, null, Автор);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);

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
        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        Склад.Pointer = Елемент.Склад;
        Коментар.SetText(Елемент.Коментар);
        Автор.Pointer = Елемент.Автор;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Основа.Pointer = Елемент.Основа;

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        await Товари.LoadRecords();

    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Організація = Організація.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Автор = Автор.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Основа = Основа.Pointer;

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Склад.Pointer.Назва} {Автор.Pointer.Назва} {Підрозділ.Pointer.Назва}"
         + Товари.КлючовіСловаДляПошуку();
    }*/


    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await Товари.SaveRecords(); // Таблична частина "Товари"

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
        CommonForms_DocumentMovementThroughRegisters.Create(new РозміщенняНоменклатуриПоКоміркам_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
