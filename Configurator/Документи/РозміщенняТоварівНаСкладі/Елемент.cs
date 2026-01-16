
/*
        РозміщенняТоварівНаСкладі_Елемент.cs
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
using Функції = StorageAndTrade.РозміщенняТоварівНаСкладі_Функції;

namespace StorageAndTrade;

class РозміщенняТоварівНаСкладі_Елемент : DocumentFormElement
{
    public РозміщенняТоварівНаСкладі_Objest Елемент { get; init; } = new();

    #region Fields
    DateTimeControl ДатаДок = new();
            Entry НомерДок = new() { WidthRequest = 300 };
                    Entry Коментар = new() { WidthRequest = 300 };
                    CompositePointerControl Основа = new() { BoundConfType = "Документи.РозміщенняТоварівНаСкладі.Основа" };
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 300 };
            Користувачі_PointerControl Автор = new() { Caption = "Автор", WidthPresentation = 300 };
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
            ПоступленняТоварівТаПослуг_PointerControl ДокументПоступлення = new() { Caption = "Документ поступлення", WidthPresentation = 300 };
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        РозміщенняТоварівНаСкладі_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public РозміщенняТоварівНаСкладі_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(РозміщенняТоварівНаСкладі_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари" 
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
    }

    protected override void CreateTopStart(Box vBox)
    {
        
    }

    protected override void CreateTopEnd(Box vBox)
    {
        
    }

    protected override void CreateBottomStart(Box vBox)
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
                
            // ДокументПоступлення
            CreateField(vBox, null, ДокументПоступлення);
                
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        ДатаДок.Value = Елемент.ДатаДок;
                НомерДок.SetText(Елемент.НомерДок);
                        Коментар.SetText(Елемент.Коментар);
                        Основа.Pointer = Елемент.Основа;
                Склад.Pointer = Елемент.Склад;
                Автор.Pointer = Елемент.Автор;
                Організація.Pointer = Елемент.Організація;
                Підрозділ.Pointer = Елемент.Підрозділ;
                ДокументПоступлення.Pointer = Елемент.ДокументПоступлення;
                
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
                Елемент.ДокументПоступлення = ДокументПоступлення.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Склад.Pointer.Назва} {Автор.Pointer.Назва} {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва} {ДокументПоступлення.Pointer.Назва}"
         + Товари.КлючовіСловаДляПошуку();
    }*/
    

    #endregion
    
    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if(await Елемент.Save())
            {
                await Товари.SaveRecords(); // Таблична частина "Товари"
                
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
            //if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UnigueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UnigueID unigueID)
    {
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new РозміщенняТоварівНаСкладі_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    