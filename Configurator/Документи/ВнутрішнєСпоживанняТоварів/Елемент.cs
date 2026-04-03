
/*
        ВнутрішнєСпоживанняТоварів_Елемент.cs
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
using Функції = StorageAndTrade.ВнутрішнєСпоживанняТоварів_Функції;

namespace StorageAndTrade;

class ВнутрішнєСпоживанняТоварів_Елемент : DocumentFormElement
{
    public ВнутрішнєСпоживанняТоварів_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            Entry Коментар = Entry.New();
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ВнутрішнєСпоживанняТоварів_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ВнутрішнєСпоживанняТоварів_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ВнутрішнєСпоживанняТоварів_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари" 
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        НомерДок.WidthRequest = 100;
                        Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                Основа.BoundConfType = "Документи.ВнутрішнєСпоживанняТоварів.Основа";
                
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                    ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                ГосподарськаОперація.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                Коментар.WidthRequest = 300;
                        
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
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Основа
            CreateField(vBox, null, Основа);
                
            // ГосподарськаОперація
            CreateField(vBox, "Господарська операція:", ГосподарськаОперація);
                
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        НомерДок.SetText(Елемент.НомерДок);
                        ДатаДок.Value = Елемент.ДатаДок;
                Організація.Pointer = Елемент.Організація;
                Склад.Pointer = Елемент.Склад;
                Валюта.Pointer = Елемент.Валюта;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Основа.Pointer = Елемент.Основа;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Коментар.SetText(Елемент.Коментар);
                        
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
                Елемент.Валюта = Валюта.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Основа = Основа.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Коментар = Коментар.GetText();
                        
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Склад.Pointer.Назва} {Валюта.Pointer.Назва} {Підрозділ.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ВнутрішнєСпоживанняТоварів_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    