
/*
        ПоступленняТоварівТаПослуг_Елемент.cs
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
using Функції = StorageAndTrade.ПоступленняТоварівТаПослуг_Функції;

namespace StorageAndTrade;

class ПоступленняТоварівТаПослуг_Елемент : DocumentFormElement
{
    public ПоступленняТоварівТаПослуг_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new() { WidthRequest = 500 };
                    DateTimeControl ДатаДок = new();
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 500 };
            ComboBoxText ГосподарськаОперація = new ComboBoxText();
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 500 };
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 500 };
            NumericControl СумаДокументу = new();
            ЗамовленняПостачальнику_PointerControl ЗамовленняПостачальнику = new() { Caption = "ЗамовленняПостачальнику", WidthPresentation = 500 };
            DateTimeControl ДатаОплати = new(){ OnlyDate = true };
            ComboBoxText ФормаОплати = new ComboBoxText();
            CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = new() { Caption = "БанківськийРахунокОрганізації", WidthPresentation = 500 };
            Entry НомерВхідногоДокументу = new() { WidthRequest = 500 };
                    DateTimeControl ДатаВхідногоДокументу = new(){ OnlyDate = true };
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = new() { Caption = "БанківськийРахунокКонтрагента", WidthPresentation = 500 };
            ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 500 };
            Користувачі_PointerControl Автор = new() { Caption = "Автор", WidthPresentation = 500 };
            CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
            DateTimeControl ДатаПоверненняТари = new(){ OnlyDate = true };
            ComboBoxText СпосібДоставки = new ComboBoxText();
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 500 };
            NumericControl Курс = new();
            IntegerControl Кратність = new();
            TimeControl ЧасДоставкиЗ = new();
            TimeControl ЧасДоставкиДо = new();
            Користувачі_PointerControl Менеджер = new() { Caption = "Менеджер", WidthPresentation = 500 };
            СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = new() { Caption = "СтаттяРухуКоштів", WidthPresentation = 500 };
            Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 500 };
            CompositePointerControl Основа = new() { BoundConfType = "Документи.ПоступленняТоварівТаПослуг.Основа" };
            Entry Коментар = new() { WidthRequest = 500 };
                    Entry КлючовіСловаДляПошуку = new() { WidthRequest = 500 };
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ПоступленняТоварівТаПослуг_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ПоступленняТоварівТаПослуг_Const.FULLNAME, НомерДок, ДатаДок);
        
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
            foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                ФормаОплати.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ФормаОплати.AddController(controller);
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
        
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // ГосподарськаОперація
            CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // СумаДокументу
            CreateField(vBox, "СумаДокументу:", СумаДокументу);
                        
            // ЗамовленняПостачальнику
            CreateField(vBox, null, ЗамовленняПостачальнику);
                
            // ДатаОплати
            CreateField(vBox, "ДатаОплати:", ДатаОплати);
                        
            // ФормаОплати
            CreateField(vBox, "ФормаОплати:", ФормаОплати);
                
            // Узгоджений
            CreateField(vBox, null, Узгоджений);
                
            // БанківськийРахунокОрганізації
            CreateField(vBox, null, БанківськийРахунокОрганізації);
                
            // НомерВхідногоДокументу
            CreateField(vBox, "НомерВхідногоДокументу:", НомерВхідногоДокументу);
                        
            // ДатаВхідногоДокументу
            CreateField(vBox, "ДатаВхідногоДокументу:", ДатаВхідногоДокументу);
                        
            // БанківськийРахунокКонтрагента
            CreateField(vBox, null, БанківськийРахунокКонтрагента);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // Автор
            CreateField(vBox, null, Автор);
                
            // ПовернутиТару
            CreateField(vBox, null, ПовернутиТару);
                
            // ДатаПоверненняТари
            CreateField(vBox, "ДатаПоверненняТари:", ДатаПоверненняТари);
                        
            // СпосібДоставки
            CreateField(vBox, "СпосібДоставки:", СпосібДоставки);
                
            // Організація
            CreateField(vBox, null, Організація);
                
            // Курс
            CreateField(vBox, "Курс:", Курс);
                        
            // Кратність
            CreateField(vBox, "Кратність:", Кратність);
                        
            // ЧасДоставкиЗ
            CreateField(vBox, "ЧасДоставкиЗ:", ЧасДоставкиЗ);
                        
            // ЧасДоставкиДо
            CreateField(vBox, "ЧасДоставкиДо:", ЧасДоставкиДо);
                        
            // Менеджер
            CreateField(vBox, null, Менеджер);
                
            // СтаттяРухуКоштів
            CreateField(vBox, null, СтаттяРухуКоштів);
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // Основа
            CreateField(vBox, null, Основа);
                
            // КлючовіСловаДляПошуку
            CreateField(vBox, "КлючовіСловаДляПошуку:", КлючовіСловаДляПошуку);
                        
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
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Підрозділ.Pointer = Елемент.Підрозділ;
                Склад.Pointer = Елемент.Склад;
                Контрагент.Pointer = Елемент.Контрагент;
                СумаДокументу.Value = Елемент.СумаДокументу;
                ЗамовленняПостачальнику.Pointer = Елемент.ЗамовленняПостачальнику;
                ДатаОплати.Value = Елемент.ДатаОплати;
                ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
                Узгоджений.Active = Елемент.Узгоджений;
                БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
                НомерВхідногоДокументу.SetText(Елемент.НомерВхідногоДокументу);
                        ДатаВхідногоДокументу.Value = Елемент.ДатаВхідногоДокументу;
                БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
                Договір.Pointer = Елемент.Договір;
                Автор.Pointer = Елемент.Автор;
                ПовернутиТару.Active = Елемент.ПовернутиТару;
                ДатаПоверненняТари.Value = Елемент.ДатаПоверненняТари;
                СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
                Організація.Pointer = Елемент.Організація;
                Курс.Value = Елемент.Курс;
                Кратність.Value = Елемент.Кратність;
                ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
                ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
                Менеджер.Pointer = Елемент.Менеджер;
                СтаттяРухуКоштів.Pointer = Елемент.СтаттяРухуКоштів;
                Каса.Pointer = Елемент.Каса;
                Основа.Pointer = Елемент.Основа;
                Коментар.SetText(Елемент.Коментар);
                        КлючовіСловаДляПошуку.SetText(Елемент.КлючовіСловаДляПошуку);
                        
            // Таблична частина "Товари" 
            Товари.ЕлементВласник = Елемент; 
            await Товари.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Склад = Склад.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.СумаДокументу = СумаДокументу.Value;
                Елемент.ЗамовленняПостачальнику = ЗамовленняПостачальнику.Pointer;
                Елемент.ДатаОплати = ДатаОплати.Value;
                Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
                Елемент.Узгоджений = Узгоджений.Active;
                Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
                Елемент.НомерВхідногоДокументу = НомерВхідногоДокументу.GetText();
                        Елемент.ДатаВхідногоДокументу = ДатаВхідногоДокументу.Value;
                Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.Автор = Автор.Pointer;
                Елемент.ПовернутиТару = ПовернутиТару.Active;
                Елемент.ДатаПоверненняТари = ДатаПоверненняТари.Value;
                Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
                Елемент.Організація = Організація.Pointer;
                Елемент.Курс = Курс.Value;
                Елемент.Кратність = Кратність.Value;
                Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
                Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
                Елемент.Менеджер = Менеджер.Pointer;
                Елемент.СтаттяРухуКоштів = СтаттяРухуКоштів.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.Основа = Основа.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.КлючовіСловаДляПошуку = КлючовіСловаДляПошуку.GetText();
                        
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Валюта.Pointer.Назва} {Підрозділ.Pointer.Назва} {Склад.Pointer.Назва} {Контрагент.Pointer.Назва} {ЗамовленняПостачальнику.Pointer.Назва} {БанківськийРахунокОрганізації.Pointer.Назва} {БанківськийРахунокКонтрагента.Pointer.Назва} {Договір.Pointer.Назва} {Автор.Pointer.Назва} {Організація.Pointer.Назва} {Менеджер.Pointer.Назва} {СтаттяРухуКоштів.Pointer.Назва} {Каса.Pointer.Назва}"
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
        catch 
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ПоступленняТоварівТаПослуг_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    