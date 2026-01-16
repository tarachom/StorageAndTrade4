
/*
        ПоверненняТоварівПостачальнику_Елемент.cs
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
using Функції = StorageAndTrade.ПоверненняТоварівПостачальнику_Функції;

namespace StorageAndTrade;

class ПоверненняТоварівПостачальнику_Елемент : DocumentFormElement
{
    public ПоверненняТоварівПостачальнику_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new() { WidthRequest = 100 };
                    DateTimeControl ДатаДок = new();
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 300 };
            ComboBoxText ГосподарськаОперація = new ComboBoxText();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = new() { Caption = "Банківський рахунок організації", WidthPresentation = 300 };
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = new() { Caption = "Банківський рахунок контрагента", WidthPresentation = 300 };
            ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
            ComboBoxText СпосібДоставки = new ComboBoxText();
            Entry АдресДоставки = new() { WidthRequest = 300 };
                    TimeControl ЧасДоставкиЗ = new();
            TimeControl ЧасДоставкиДо = new();
            Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
            CompositePointerControl Основа = new() { BoundConfType = "Документи.ПоверненняТоварівПостачальнику.Основа" };
            Entry Коментар = new() { WidthRequest = 300 };
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ПоверненняТоварівПостачальнику_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ПоверненняТоварівПостачальнику_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ПоверненняТоварівПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари" 
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
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
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            СпосібДоставки.AddController(controller);
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
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // ГосподарськаОперація
            CreateField(vBox, "Господарська операція:", ГосподарськаОперація);
                
            // БанківськийРахунокОрганізації
            CreateField(vBox, null, БанківськийРахунокОрганізації);
                
            // БанківськийРахунокКонтрагента
            CreateField(vBox, null, БанківськийРахунокКонтрагента);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // СпосібДоставки
            CreateField(vBox, "Спосіб доставки:", СпосібДоставки);
                
            // АдресДоставки
            CreateField(vBox, "Адрес доставки:", АдресДоставки);
                        
            // ЧасДоставкиЗ
            CreateField(vBox, "Час доставки з:", ЧасДоставкиЗ);
                        
            // ЧасДоставкиДо
            CreateField(vBox, "Час доставки до:", ЧасДоставкиДо);
                        
            // Каса
            CreateField(vBox, null, Каса);
                
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
                Контрагент.Pointer = Елемент.Контрагент;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Валюта.Pointer = Елемент.Валюта;
                Склад.Pointer = Елемент.Склад;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
                БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
                Договір.Pointer = Елемент.Договір;
                СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
                АдресДоставки.SetText(Елемент.АдресДоставки);
                        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
                ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
                Каса.Pointer = Елемент.Каса;
                Основа.Pointer = Елемент.Основа;
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
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.Склад = Склад.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
                Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
                Елемент.АдресДоставки = АдресДоставки.GetText();
                        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
                Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
                Елемент.Каса = Каса.Pointer;
                Елемент.Основа = Основа.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Контрагент.Pointer.Назва} {Підрозділ.Pointer.Назва} {Валюта.Pointer.Назва} {Склад.Pointer.Назва} {БанківськийРахунокОрганізації.Pointer.Назва} {БанківськийРахунокКонтрагента.Pointer.Назва} {Договір.Pointer.Назва} {Каса.Pointer.Назва}"
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ПоверненняТоварівПостачальнику_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    