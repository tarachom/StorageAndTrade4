
/*
        ВведенняЗалишків_Елемент.cs
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
using Функції = StorageAndTrade.ВведенняЗалишків_Функції;

namespace StorageAndTrade;

class ВведенняЗалишків_Елемент : DocumentFormElement
{
    public ВведенняЗалишків_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new() { WidthRequest = 500 };
                    DateTimeControl ДатаДок = new();
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 500 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 500 };
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 500 };
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 500 };
            ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 500 };
            ComboBoxText ГосподарськаОперація = new ComboBoxText();
            Entry Коментар = new() { WidthRequest = 500 };
                    Користувачі_PointerControl Автор = new() { Caption = "Автор", WidthPresentation = 500 };
            Entry КлючовіСловаДляПошуку = new() { WidthRequest = 500 };
                    CompositePointerControl Основа = new() { BoundConfType = "Документи.ВведенняЗалишків.Основа" };
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ВведенняЗалишків_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
        // Таблична частина "Каси" 
        ВведенняЗалишків_ТабличнаЧастина_Каси Каси = new() { WidthRequest = 500, HeightRequest = 300 };
    
        // Таблична частина "БанківськіРахунки" 
        ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки БанківськіРахунки = new() { WidthRequest = 500, HeightRequest = 300 };
    
        // Таблична частина "РозрахункиЗКонтрагентами" 
        ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами РозрахункиЗКонтрагентами = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ВведенняЗалишків_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ВведенняЗалишків_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари" 
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            // Таблична частина "Каси" 
            NotebookTablePart.InsertPage(Каси, Label.New("Каси"), 1);
            
            // Таблична частина "БанківськіРахунки" 
            NotebookTablePart.InsertPage(БанківськіРахунки, Label.New("БанківськіРахунки"), 2);
            
            // Таблична частина "РозрахункиЗКонтрагентами" 
            NotebookTablePart.InsertPage(РозрахункиЗКонтрагентами, Label.New("РозрахункиЗКонтрагентами"), 3);
            
            NotebookTablePart.SetCurrentPage(0);
        
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
        
            // Організація
            CreateField(vBox, null, Організація);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // ГосподарськаОперація
            CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);
                
            // Автор
            CreateField(vBox, null, Автор);
                
            // КлючовіСловаДляПошуку
            CreateField(vBox, "КлючовіСловаДляПошуку:", КлючовіСловаДляПошуку);
                        
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
                Організація.Pointer = Елемент.Організація;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Склад.Pointer = Елемент.Склад;
                Валюта.Pointer = Елемент.Валюта;
                Контрагент.Pointer = Елемент.Контрагент;
                Договір.Pointer = Елемент.Договір;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Коментар.SetText(Елемент.Коментар);
                        Автор.Pointer = Елемент.Автор;
                КлючовіСловаДляПошуку.SetText(Елемент.КлючовіСловаДляПошуку);
                        Основа.Pointer = Елемент.Основа;
                
            // Таблична частина "Товари" 
            Товари.ЕлементВласник = Елемент; 
            await Товари.LoadRecords();
        
            // Таблична частина "Каси" 
            Каси.ЕлементВласник = Елемент; 
            await Каси.LoadRecords();
        
            // Таблична частина "БанківськіРахунки" 
            БанківськіРахунки.ЕлементВласник = Елемент; 
            await БанківськіРахунки.LoadRecords();
        
            // Таблична частина "РозрахункиЗКонтрагентами" 
            РозрахункиЗКонтрагентами.ЕлементВласник = Елемент; 
            await РозрахункиЗКонтрагентами.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Організація = Організація.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Склад = Склад.Pointer;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Автор = Автор.Pointer;
                Елемент.КлючовіСловаДляПошуку = КлючовіСловаДляПошуку.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва} {Склад.Pointer.Назва} {Валюта.Pointer.Назва} {Контрагент.Pointer.Назва} {Договір.Pointer.Назва} {Автор.Pointer.Назва}"
         + Товари.КлючовіСловаДляПошуку() + Каси.КлючовіСловаДляПошуку() + БанківськіРахунки.КлючовіСловаДляПошуку() + РозрахункиЗКонтрагентами.КлючовіСловаДляПошуку();
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
                await Каси.SaveRecords(); // Таблична частина "Каси"
                await БанківськіРахунки.SaveRecords(); // Таблична частина "БанківськіРахунки"
                await РозрахункиЗКонтрагентами.SaveRecords(); // Таблична частина "РозрахункиЗКонтрагентами"
                
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ВведенняЗалишків_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    