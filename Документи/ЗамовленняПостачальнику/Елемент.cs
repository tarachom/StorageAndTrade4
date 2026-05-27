
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

[GObject.Subclass<DocumentFormElement>("Element_qheZqSUJikOD2ltGdglJ1Q")]
partial class ЗамовленняПостачальнику_Елемент : DocumentFormElement
{
    public ЗамовленняПостачальнику_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            DateTimeControl ДатаПоступлення = DateTimeControl.New();
            Entry АдресаДоставкиДляПостачальника = Entry.New();
                    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
            ComboBoxText СпосібДоставки = ComboBoxText.New();
            TimeControl ЧасДоставкиЗ = TimeControl.New();
            TimeControl ЧасДоставкиДо = TimeControl.New();
            Entry АдресаДоставки = Entry.New();
                    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            ComboBoxText Статус = ComboBoxText.New();
            ComboBoxText ФормаОплати = ComboBoxText.New();
            Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            Entry Коментар = Entry.New();
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ЗамовленняПостачальнику_ТабличнаЧастина_Товари Товари = ЗамовленняПостачальнику_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ЗамовленняПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.WidthRequest = 500;
            Товари.HeightRequest = 300;
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 300;
                        
            //ДатаДок:
            
            //Контрагент:
            Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
            //Каса:
            Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
            //БанківськийРахунок:
            БанківськийРахунок.Caption = "БанківськийРахунок";
                    БанківськийРахунок.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //Договір:
            Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                
            //ДатаПоступлення:
            ДатаПоступлення.OnlyDate = true;
                
            //АдресаДоставкиДляПостачальника:
            АдресаДоставкиДляПостачальника.WidthRequest = 300;
                        
            //ПовернутиТару:
            
            //СпосібДоставки:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                    СпосібДоставки.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                СпосібДоставки.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                
            //ЧасДоставкиЗ:
            
            //ЧасДоставкиДо:
            
            //АдресаДоставки:
            АдресаДоставки.WidthRequest = 300;
                        
            //ГосподарськаОперація:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                    ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                ГосподарськаОперація.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                
            //Статус:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.СтатусиЗамовленьПостачальникам_List())
                    Статус.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                Статус.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                
            //ФормаОплати:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                    ФормаОплати.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                ФормаОплати.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                
            //Менеджер:
            Менеджер.Caption = "Менеджер";
                    Менеджер.WidthPresentation = 300;
                
            //Основа:
            Основа.BoundConfType = "Документи.ЗамовленняПостачальнику.Основа";
                
            //Коментар:
            Коментар.WidthRequest = 300;
                        
    }

    public static ЗамовленняПостачальнику_Елемент New()
    {
        ЗамовленняПостачальнику_Елемент element = NewWithProperties([]);
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
        
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Організація
            CreateField(vBox, null, Організація);
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // БанківськийРахунок
            CreateField(vBox, null, БанківськийРахунок);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // Договір
            CreateField(vBox, null, Договір);
                
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
                
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        
    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        НомерДок.SetText(Елемент.НомерДок);
                        ДатаДок.Value = Елемент.ДатаДок;
                Контрагент.Pointer = Елемент.Контрагент;
                Організація.Pointer = Елемент.Організація;
                Склад.Pointer = Елемент.Склад;
                Валюта.Pointer = Елемент.Валюта;
                Каса.Pointer = Елемент.Каса;
                БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
                Підрозділ.Pointer = Елемент.Підрозділ;
                Договір.Pointer = Елемент.Договір;
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
                Елемент.Каса = Каса.Pointer;
                Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Договір = Договір.Pointer;
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
                        
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Склад.Pointer.Назва} {Валюта.Pointer.Назва} {Каса.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {Підрозділ.Pointer.Назва} {Договір.Pointer.Назва} {Менеджер.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗамовленняПостачальнику_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    