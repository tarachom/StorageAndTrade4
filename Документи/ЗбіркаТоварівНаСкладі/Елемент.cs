
/*
        ЗбіркаТоварівНаСкладі_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using Функції = StorageAndTrade.ЗбіркаТоварівНаСкладі_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_Re7llDhK3kuy1G7fnlByQ")]
partial class ЗбіркаТоварівНаСкладі_Елемент : DocumentFormElement
{
    public ЗбіркаТоварівНаСкладі_Object Елемент { get; init; } = new();

    #region Fields
    DateTimeControl ДатаДок = DateTimeControl.New();
    Entry НомерДок = Entry.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    РеалізаціяТоварівТаПослуг_PointerControl ДокументРеалізації = РеалізаціяТоварівТаПослуг_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ЗбіркаТоварівНаСкладі_ТабличнаЧастина_Товари Товари = ЗбіркаТоварівНаСкладі_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ЗбіркаТоварівНаСкладі_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        Interface.Notebook.InsertPage(Товари, Label.New("Товари"), 0);
        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Коментар:
        Коментар.WidthRequest = 300;

        //Основа:
        Основа.BoundConfType = "Документи.ЗбіркаТоварівНаСкладі.Основа";

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //ДокументРеалізації:
        ДокументРеалізації.Caption = "Документ реалізації";
        ДокументРеалізації.WidthPresentation = 300;

    }

    public static ЗбіркаТоварівНаСкладі_Елемент New()
    {
        ЗбіркаТоварівНаСкладі_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DocumentElement Interface = FunctionForInterfaces.ForDocument();

    protected override void BuildInterface()
    {
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

        // Основа
        CreateField(vBox, null, Основа);

        // Склад
        CreateField(vBox, null, Склад);

        // Автор
        CreateField(vBox, null, Автор);

        // Організація
        CreateField(vBox, null, Організація);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);

        // ДокументРеалізації
        CreateField(vBox, null, ДокументРеалізації);

    }

    void CreateBottomEnd(Box vBox)
    {

    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        ДатаДок.Value = Елемент.ДатаДок;
        НомерДок.SetText(Елемент.НомерДок);
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;
        Склад.Pointer = Елемент.Склад;
        Автор.Pointer = Елемент.Автор;
        Організація.Pointer = Елемент.Організація;
        Підрозділ.Pointer = Елемент.Підрозділ;
        ДокументРеалізації.Pointer = Елемент.ДокументРеалізації;

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        await Товари.LoadRecords();

    }

    protected override void GetValue()
    {
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.Автор = Автор.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.ДокументРеалізації = ДокументРеалізації.Pointer;

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Склад.Pointer.Назва} {Автор.Pointer.Назва} {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва} {ДокументРеалізації.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗбіркаТоварівНаСкладі_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
