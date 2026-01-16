
/*
        АктВиконанихРобіт_Елемент.cs
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
using Функції = StorageAndTrade.АктВиконанихРобіт_Функції;

namespace StorageAndTrade;

class АктВиконанихРобіт_Елемент : DocumentFormElement
{
    public АктВиконанихРобіт_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new() { WidthRequest = 100 };
                    DateTimeControl ДатаДок = new();
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
            ЗамовленняКлієнта_PointerControl ЗамовленняКлієнта = new() { Caption = "Замовлення клієнта", WidthPresentation = 300 };
            Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
            NumericControl СумаДокументу = new();
            ComboBoxText ФормаОплати = new ComboBoxText();
            ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
            ComboBoxText ГосподарськаОперація = new ComboBoxText();
            Entry Коментар = new() { WidthRequest = 300 };
                    CompositePointerControl Основа = new() { BoundConfType = "Документи.АктВиконанихРобіт.Основа" };
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Послуги" 
        АктВиконанихРобіт_ТабличнаЧастина_Послуги Послуги = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public АктВиконанихРобіт_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(АктВиконанихРобіт_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Послуги" 
            NotebookTablePart.InsertPage(Послуги, Label.New("Послуги"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                ФормаОплати.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ФормаОплати.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ГосподарськаОперація.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
    }

    protected override void CreateTopStart(Box vBox)
    {
        
    }

    protected override void CreateTopEnd(Box vBox)
    {
        
    }

    protected override void CreateBottomStart(Box vBox)
    {
        
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // ЗамовленняКлієнта
            CreateField(vBox, null, ЗамовленняКлієнта);
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Організація
            CreateField(vBox, null, Організація);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // СумаДокументу
            CreateField(vBox, "Сума документу:", СумаДокументу);
                        
            // ФормаОплати
            CreateField(vBox, "Форма оплати:", ФормаОплати);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // ГосподарськаОперація
            CreateField(vBox, "Господарська операція:", ГосподарськаОперація);
                
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
                Валюта.Pointer = Елемент.Валюта;
                ЗамовленняКлієнта.Pointer = Елемент.ЗамовленняКлієнта;
                Каса.Pointer = Елемент.Каса;
                Контрагент.Pointer = Елемент.Контрагент;
                Організація.Pointer = Елемент.Організація;
                Підрозділ.Pointer = Елемент.Підрозділ;
                СумаДокументу.Value = Елемент.СумаДокументу;
                ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
                Договір.Pointer = Елемент.Договір;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Коментар.SetText(Елемент.Коментар);
                        Основа.Pointer = Елемент.Основа;
                
            // Таблична частина "Послуги" 
            Послуги.ЕлементВласник = Елемент; 
            await Послуги.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.ЗамовленняКлієнта = ЗамовленняКлієнта.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Організація = Організація.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.СумаДокументу = СумаДокументу.Value;
                Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
                Елемент.Договір = Договір.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Валюта.Pointer.Назва} {ЗамовленняКлієнта.Pointer.Назва} {Каса.Pointer.Назва} {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва} {Договір.Pointer.Назва}"
         + Послуги.КлючовіСловаДляПошуку();
    }*/
    

    #endregion
    
    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if(await Елемент.Save())
            {
                await Послуги.SaveRecords(); // Таблична частина "Послуги"
                
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new АктВиконанихРобіт_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    