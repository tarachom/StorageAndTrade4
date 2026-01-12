
/*
        ЗамовленняПостачальнику_Елемент.cs
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
using Функції = StorageAndTrade.ЗамовленняПостачальнику_Функції;

namespace StorageAndTrade;

class ЗамовленняПостачальнику_Елемент : DocumentFormElement
{
    public ЗамовленняПостачальнику_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new() { WidthRequest = 500 };
                    DateTimeControl ДатаДок = new();
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 500 };
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 500 };
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 500 };
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 500 };
            NumericControl СумаДокументу = new();
            Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 500 };
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = new() { Caption = "БанківськийРахунок", WidthPresentation = 500 };
            СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 500 };
            ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 500 };
            Користувачі_PointerControl Автор = new() { Caption = "Автор", WidthPresentation = 500 };
            DateTimeControl ДатаПоступлення = new(){ OnlyDate = true };
            Entry АдресаДоставкиДляПостачальника = new() { WidthRequest = 500 };
                    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
            ComboBoxText СпосібДоставки = new ComboBoxText();
            TimeControl ЧасДоставкиЗ = new();
            TimeControl ЧасДоставкиДо = new();
            Entry АдресаДоставки = new() { WidthRequest = 500 };
                    ComboBoxText ГосподарськаОперація = new ComboBoxText();
            ComboBoxText Статус = new ComboBoxText();
            ComboBoxText ФормаОплати = new ComboBoxText();
            Користувачі_PointerControl Менеджер = new() { Caption = "Менеджер", WidthPresentation = 500 };
            CompositePointerControl Основа = new() { BoundConfType = "Документи.ЗамовленняПостачальнику.Основа" };
            Entry Коментар = new() { WidthRequest = 500 };
                    Entry КлючовіСловаДляПошуку = new() { WidthRequest = 500 };
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ЗамовленняПостачальнику_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ЗамовленняПостачальнику_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ЗамовленняПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари" 
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            СпосібДоставки.AddController(controller);
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
            foreach (var field in ПсевдонімиПерелічення.СтатусиЗамовленьПостачальникам_List())
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
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // СумаДокументу
            CreateField(vBox, "СумаДокументу:", СумаДокументу);
                        
            // Каса
            CreateField(vBox, null, Каса);
                
            // БанківськийРахунок
            CreateField(vBox, null, БанківськийРахунок);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // Автор
            CreateField(vBox, null, Автор);
                
            // ДатаПоступлення
            CreateField(vBox, "ДатаПоступлення:", ДатаПоступлення);
                        
            // АдресаДоставкиДляПостачальника
            CreateField(vBox, "АдресаДоставкиДляПостачальника:", АдресаДоставкиДляПостачальника);
                        
            // ПовернутиТару
            CreateField(vBox, null, ПовернутиТару);
                
            // СпосібДоставки
            CreateField(vBox, "СпосібДоставки:", СпосібДоставки);
                
            // ЧасДоставкиЗ
            CreateField(vBox, "ЧасДоставкиЗ:", ЧасДоставкиЗ);
                        
            // ЧасДоставкиДо
            CreateField(vBox, "ЧасДоставкиДо:", ЧасДоставкиДо);
                        
            // АдресаДоставки
            CreateField(vBox, "АдресаДоставки:", АдресаДоставки);
                        
            // ГосподарськаОперація
            CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);
                
            // Статус
            CreateField(vBox, "Статус:", Статус);
                
            // ФормаОплати
            CreateField(vBox, "ФормаОплати:", ФормаОплати);
                
            // Менеджер
            CreateField(vBox, null, Менеджер);
                
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
                Контрагент.Pointer = Елемент.Контрагент;
                Організація.Pointer = Елемент.Організація;
                Склад.Pointer = Елемент.Склад;
                Валюта.Pointer = Елемент.Валюта;
                СумаДокументу.Value = Елемент.СумаДокументу;
                Каса.Pointer = Елемент.Каса;
                БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Договір.Pointer = Елемент.Договір;
                Автор.Pointer = Елемент.Автор;
                ДатаПоступлення.Value = Елемент.ДатаПоступлення;
                АдресаДоставкиДляПостачальника.SetText(Елемент.АдресаДоставкиДляПостачальника);
                        ПовернутиТару.Active = Елемент.ПовернутиТару;
                СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
                ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
                ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
                АдресаДоставки.SetText(Елемент.АдресаДоставки);
                        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Статус.ActiveId = Елемент.Статус.ToString();
                ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
                Менеджер.Pointer = Елемент.Менеджер;
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
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Організація = Організація.Pointer;
                Елемент.Склад = Склад.Pointer;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.СумаДокументу = СумаДокументу.Value;
                Елемент.Каса = Каса.Pointer;
                Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.Автор = Автор.Pointer;
                Елемент.ДатаПоступлення = ДатаПоступлення.Value;
                Елемент.АдресаДоставкиДляПостачальника = АдресаДоставкиДляПостачальника.GetText();
                        Елемент.ПовернутиТару = ПовернутиТару.Active;
                Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
                Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
                Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
                Елемент.АдресаДоставки = АдресаДоставки.GetText();
                        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Статус = ПсевдонімиПерелічення.СтатусиЗамовленьПостачальникам_FindByName(Статус.ActiveId);
                Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
                Елемент.Менеджер = Менеджер.Pointer;
                Елемент.Основа = Основа.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.КлючовіСловаДляПошуку = КлючовіСловаДляПошуку.GetText();
                        
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Склад.Pointer.Назва} {Валюта.Pointer.Назва} {Каса.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {Підрозділ.Pointer.Назва} {Договір.Pointer.Назва} {Автор.Pointer.Назва} {Менеджер.Pointer.Назва}"
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ЗамовленняПостачальнику_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    