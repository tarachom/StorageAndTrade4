
/*
        ЗамовленняКлієнта_Елемент.cs
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
using Функції = StorageAndTrade.ЗамовленняКлієнта_Функції;

namespace StorageAndTrade;

class ЗамовленняКлієнта_Елемент : DocumentFormElement
{
    public ЗамовленняКлієнта_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new() { WidthRequest = 500 };
                    DateTimeControl ДатаДок = new();
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 500 };
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 500 };
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 500 };
            NumericControl СумаДокументу = new();
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 500 };
            ComboBoxText Статус = new ComboBoxText();
            CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
            ComboBoxText ФормаОплати = new ComboBoxText();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = new() { Caption = "БанківськийРахунок", WidthPresentation = 500 };
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = new() { Caption = "БанківськийРахунокКонтрагента", WidthPresentation = 500 };
            Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 500 };
            NumericControl СумаАвансуДоЗабезпечення = new();
            NumericControl СумаПередоплатиДоВідгрузки = new();
            DateTimeControl ДатаВідгрузки = new(){ OnlyDate = true };
            Entry АдресаДоставки = new() { WidthRequest = 500 };
                    ComboBoxText ГосподарськаОперація = new ComboBoxText();
            ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 500 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            Користувачі_PointerControl Автор = new() { Caption = "Автор", WidthPresentation = 500 };
            ComboBoxText СпосібДоставки = new ComboBoxText();
            TimeControl ЧасДоставкиЗ = new();
            TimeControl ЧасДоставкиДо = new();
            CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
            DateTimeControl ДатаПоверненняТари = new(){ OnlyDate = true };
            Entry Коментар = new() { WidthRequest = 500 };
                    Користувачі_PointerControl Менеджер = new() { Caption = "Менеджер", WidthPresentation = 500 };
            Entry КлючовіСловаДляПошуку = new() { WidthRequest = 500 };
                    CompositePointerControl Основа = new() { BoundConfType = "Документи.ЗамовленняКлієнта.Основа" };
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ЗамовленняКлієнта_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ЗамовленняКлієнта_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ЗамовленняКлієнта_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари" 
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиЗамовленьКлієнтів_List())
                Статус.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            Статус.AddController(controller);
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
        
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Організація
            CreateField(vBox, null, Організація);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // СумаДокументу
            CreateField(vBox, "СумаДокументу:", СумаДокументу);
                        
            // Склад
            CreateField(vBox, null, Склад);
                
            // Статус
            CreateField(vBox, "Статус:", Статус);
                
            // Узгоджений
            CreateField(vBox, null, Узгоджений);
                
            // ФормаОплати
            CreateField(vBox, "ФормаОплати:", ФормаОплати);
                
            // БанківськийРахунок
            CreateField(vBox, null, БанківськийРахунок);
                
            // БанківськийРахунокКонтрагента
            CreateField(vBox, null, БанківськийРахунокКонтрагента);
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // СумаАвансуДоЗабезпечення
            CreateField(vBox, "СумаАвансуДоЗабезпечення:", СумаАвансуДоЗабезпечення);
                        
            // СумаПередоплатиДоВідгрузки
            CreateField(vBox, "СумаПередоплатиДоВідгрузки:", СумаПередоплатиДоВідгрузки);
                        
            // ДатаВідгрузки
            CreateField(vBox, "ДатаВідгрузки:", ДатаВідгрузки);
                        
            // АдресаДоставки
            CreateField(vBox, "АдресаДоставки:", АдресаДоставки);
                        
            // ГосподарськаОперація
            CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Автор
            CreateField(vBox, null, Автор);
                
            // СпосібДоставки
            CreateField(vBox, "СпосібДоставки:", СпосібДоставки);
                
            // ЧасДоставкиЗ
            CreateField(vBox, "ЧасДоставкиЗ:", ЧасДоставкиЗ);
                        
            // ЧасДоставкиДо
            CreateField(vBox, "ЧасДоставкиДо:", ЧасДоставкиДо);
                        
            // ПовернутиТару
            CreateField(vBox, null, ПовернутиТару);
                
            // ДатаПоверненняТари
            CreateField(vBox, "ДатаПоверненняТари:", ДатаПоверненняТари);
                        
            // Менеджер
            CreateField(vBox, null, Менеджер);
                
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
                Контрагент.Pointer = Елемент.Контрагент;
                Організація.Pointer = Елемент.Організація;
                Валюта.Pointer = Елемент.Валюта;
                СумаДокументу.Value = Елемент.СумаДокументу;
                Склад.Pointer = Елемент.Склад;
                Статус.ActiveId = Елемент.Статус.ToString();
                Узгоджений.Active = Елемент.Узгоджений;
                ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
                БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
                БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
                Каса.Pointer = Елемент.Каса;
                СумаАвансуДоЗабезпечення.Value = Елемент.СумаАвансуДоЗабезпечення;
                СумаПередоплатиДоВідгрузки.Value = Елемент.СумаПередоплатиДоВідгрузки;
                ДатаВідгрузки.Value = Елемент.ДатаВідгрузки;
                АдресаДоставки.SetText(Елемент.АдресаДоставки);
                        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Договір.Pointer = Елемент.Договір;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Автор.Pointer = Елемент.Автор;
                СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
                ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
                ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
                ПовернутиТару.Active = Елемент.ПовернутиТару;
                ДатаПоверненняТари.Value = Елемент.ДатаПоверненняТари;
                Коментар.SetText(Елемент.Коментар);
                        Менеджер.Pointer = Елемент.Менеджер;
                КлючовіСловаДляПошуку.SetText(Елемент.КлючовіСловаДляПошуку);
                        Основа.Pointer = Елемент.Основа;
                
            // Таблична частина "Товари" 
            Товари.ЕлементВласник = Елемент; 
            await Товари.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Організація = Організація.Pointer;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.СумаДокументу = СумаДокументу.Value;
                Елемент.Склад = Склад.Pointer;
                Елемент.Статус = ПсевдонімиПерелічення.СтатусиЗамовленьКлієнтів_FindByName(Статус.ActiveId);
                Елемент.Узгоджений = Узгоджений.Active;
                Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
                Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
                Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.СумаАвансуДоЗабезпечення = СумаАвансуДоЗабезпечення.Value;
                Елемент.СумаПередоплатиДоВідгрузки = СумаПередоплатиДоВідгрузки.Value;
                Елемент.ДатаВідгрузки = ДатаВідгрузки.Value;
                Елемент.АдресаДоставки = АдресаДоставки.GetText();
                        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Договір = Договір.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Автор = Автор.Pointer;
                Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
                Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
                Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
                Елемент.ПовернутиТару = ПовернутиТару.Active;
                Елемент.ДатаПоверненняТари = ДатаПоверненняТари.Value;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Менеджер = Менеджер.Pointer;
                Елемент.КлючовіСловаДляПошуку = КлючовіСловаДляПошуку.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Валюта.Pointer.Назва} {Склад.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {БанківськийРахунокКонтрагента.Pointer.Назва} {Каса.Pointer.Назва} {Договір.Pointer.Назва} {Підрозділ.Pointer.Назва} {Автор.Pointer.Назва} {Менеджер.Pointer.Назва}"
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ЗамовленняКлієнта_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    