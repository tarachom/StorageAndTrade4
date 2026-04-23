
/*
        ПерерахунокТоварів_Елемент.cs
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
using Функції = StorageAndTrade.ПерерахунокТоварів_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_axI6hzClsEGbJbEPK7G2qw")]
partial class ПерерахунокТоварів_Елемент : DocumentFormElement
{
    public ПерерахунокТоварів_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            ФізичніОсоби_PointerControl Відповідальний = ФізичніОсоби_PointerControl.New();
            Entry Коментар = Entry.New();
                    Організації_PointerControl Організація = Організації_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ПерерахунокТоварів_ТабличнаЧастина_Товари Товари = ПерерахунокТоварів_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПерерахунокТоварів_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.WidthRequest = 500;
            Товари.HeightRequest = 300;
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 100;
                        
            //ДатаДок:
            
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            //Відповідальний:
            Відповідальний.Caption = "Відповідальний";
                    Відповідальний.WidthPresentation = 300;
                
            //Коментар:
            Коментар.WidthRequest = 300;
                        
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //Основа:
            Основа.BoundConfType = "Документи.ПерерахунокТоварів.Основа";
                
    }

    public static ПерерахунокТоварів_Елемент New()
    {
        ПерерахунокТоварів_Елемент element = NewWithProperties([]);
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
        
            // Склад
            CreateField(vBox, null, Склад);
                
            // Відповідальний
            CreateField(vBox, null, Відповідальний);
                
            // Організація
            CreateField(vBox, null, Організація);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
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
                Склад.Pointer = Елемент.Склад;
                Відповідальний.Pointer = Елемент.Відповідальний;
                Коментар.SetText(Елемент.Коментар);
                        Організація.Pointer = Елемент.Організація;
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
                Елемент.Склад = Склад.Pointer;
                Елемент.Відповідальний = Відповідальний.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Організація = Організація.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Склад.Pointer.Назва} {Відповідальний.Pointer.Назва} {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПерерахунокТоварів_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    