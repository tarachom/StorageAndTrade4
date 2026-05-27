
/*
        НадлишкиТоварів_Елемент.cs
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
using Функції = StorageAndTrade.НадлишкиТоварів_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_Wnoy9v9mwEK2oe4bM3MqQ")]
partial class НадлишкиТоварів_Елемент : DocumentFormElement
{
    public НадлишкиТоварів_Objest Елемент { get; init; } = new();

    #region Fields
    Організації_PointerControl Організація = Організації_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            ВидиЦін_PointerControl ВидЦіни = ВидиЦін_PointerControl.New();
            Entry Коментар = Entry.New();
                    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        НадлишкиТоварів_ТабличнаЧастина_Товари Товари = НадлишкиТоварів_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(НадлишкиТоварів_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.WidthRequest = 500;
            Товари.HeightRequest = 300;
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            //ВидЦіни:
            ВидЦіни.Caption = "Вид ціни";
                    ВидЦіни.WidthPresentation = 300;
                
            //Коментар:
            Коментар.WidthRequest = 300;
                        
            //НомерДок:
            НомерДок.WidthRequest = 100;
                        
            //ДатаДок:
            
    }

    public static НадлишкиТоварів_Елемент New()
    {
        НадлишкиТоварів_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateTopStart(Box vBox)
    {
        
    }

    protected override void CreateTopEnd(Box vBox)
    {
        
    }

    protected override void CreateBottomStart(Box vBox)
    {
        
            // Організація
            CreateField(vBox, null, Організація);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // ВидЦіни
            CreateField(vBox, null, ВидЦіни);
                
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        Організація.Pointer = Елемент.Організація;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Склад.Pointer = Елемент.Склад;
                ВидЦіни.Pointer = Елемент.ВидЦіни;
                Коментар.SetText(Елемент.Коментар);
                        НомерДок.SetText(Елемент.НомерДок);
                        ДатаДок.Value = Елемент.ДатаДок;
                
            // Таблична частина "Товари" 
            Товари.ЕлементВласник = Елемент; 
            await Товари.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.Організація = Організація.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Склад = Склад.Pointer;
                Елемент.ВидЦіни = ВидЦіни.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва} {Склад.Pointer.Назва} {ВидЦіни.Pointer.Назва}"
         + Товари.КлючовіСловаДляПошуку();
    }*/
    

    #endregion
    
    protected override async Task<bool> Save()
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
        CommonForms_DocumentMovementThroughRegisters.Create(new НадлишкиТоварів_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    