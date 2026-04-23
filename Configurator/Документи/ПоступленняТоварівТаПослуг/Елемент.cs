
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

[GObject.Subclass<DocumentFormElement>("Element_QmoMmUIhwUaM2yEgUAOTNg")]
partial class ПоступленняТоварівТаПослуг_Елемент : DocumentFormElement
{
    public ПоступленняТоварівТаПослуг_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            ЗамовленняПостачальнику_PointerControl ЗамовленняПостачальнику = ЗамовленняПостачальнику_PointerControl.New();
            DateTimeControl ДатаОплати = DateTimeControl.New();
            ComboBoxText ФормаОплати = ComboBoxText.New();
            CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = БанківськіРахункиОрганізацій_PointerControl.New();
            Entry НомерВхідногоДокументу = Entry.New();
                    DateTimeControl ДатаВхідногоДокументу = DateTimeControl.New();
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
            DateTimeControl ДатаПоверненняТари = DateTimeControl.New();
            ComboBoxText СпосібДоставки = ComboBoxText.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            NumericControl Курс = NumericControl.New();
            IntegerControl Кратність = IntegerControl.New();
            TimeControl ЧасДоставкиЗ = TimeControl.New();
            TimeControl ЧасДоставкиДо = TimeControl.New();
            СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = СтаттяРухуКоштів_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            Entry Коментар = Entry.New();
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари Товари = ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПоступленняТоварівТаПослуг_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.WidthRequest = 500;
            Товари.HeightRequest = 300;
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 300;
                        
            //ДатаДок:
            
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
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
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            //Контрагент:
            Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                
            //ЗамовленняПостачальнику:
            ЗамовленняПостачальнику.Caption = "ЗамовленняПостачальнику";
                    ЗамовленняПостачальнику.WidthPresentation = 300;
                
            //ДатаОплати:
            ДатаОплати.OnlyDate = true;
                
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
                
            //Узгоджений:
            
            //БанківськийРахунокОрганізації:
            БанківськийРахунокОрганізації.Caption = "БанківськийРахунокОрганізації";
                    БанківськийРахунокОрганізації.WidthPresentation = 300;
                
            //НомерВхідногоДокументу:
            НомерВхідногоДокументу.WidthRequest = 300;
                        
            //ДатаВхідногоДокументу:
            ДатаВхідногоДокументу.OnlyDate = true;
                
            //БанківськийРахунокКонтрагента:
            БанківськийРахунокКонтрагента.Caption = "БанківськийРахунокКонтрагента";
                    БанківськийРахунокКонтрагента.WidthPresentation = 300;
                
            //Договір:
            Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                
            //ПовернутиТару:
            
            //ДатаПоверненняТари:
            ДатаПоверненняТари.OnlyDate = true;
                
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
                
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Курс:
            
            //Кратність:
            
            //ЧасДоставкиЗ:
            
            //ЧасДоставкиДо:
            
            //СтаттяРухуКоштів:
            СтаттяРухуКоштів.Caption = "СтаттяРухуКоштів";
                    СтаттяРухуКоштів.WidthPresentation = 300;
                
            //Каса:
            Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
            //Основа:
            Основа.BoundConfType = "Документи.ПоступленняТоварівТаПослуг.Основа";
                
            //Коментар:
            Коментар.WidthRequest = 1200;
                        
    }

    public static ПоступленняТоварівТаПослуг_Елемент New()
    {
        ПоступленняТоварівТаПослуг_Елемент element = NewWithProperties([]);
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
                        
            // СтаттяРухуКоштів
            CreateField(vBox, null, СтаттяРухуКоштів);
                
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
                Валюта.Pointer = Елемент.Валюта;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Підрозділ.Pointer = Елемент.Підрозділ;
                Склад.Pointer = Елемент.Склад;
                Контрагент.Pointer = Елемент.Контрагент;
                ЗамовленняПостачальнику.Pointer = Елемент.ЗамовленняПостачальнику;
                ДатаОплати.Value = Елемент.ДатаОплати;
                ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
                Узгоджений.Active = Елемент.Узгоджений;
                БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
                НомерВхідногоДокументу.SetText(Елемент.НомерВхідногоДокументу);
                        ДатаВхідногоДокументу.Value = Елемент.ДатаВхідногоДокументу;
                БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
                Договір.Pointer = Елемент.Договір;
                ПовернутиТару.Active = Елемент.ПовернутиТару;
                ДатаПоверненняТари.Value = Елемент.ДатаПоверненняТари;
                СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
                Організація.Pointer = Елемент.Організація;
                Курс.Value = Елемент.Курс;
                Кратність.Value = Елемент.Кратність;
                ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
                ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
                СтаттяРухуКоштів.Pointer = Елемент.СтаттяРухуКоштів;
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
                Елемент.Валюта = Валюта.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.Склад = Склад.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.ЗамовленняПостачальнику = ЗамовленняПостачальнику.Pointer;
                Елемент.ДатаОплати = ДатаОплати.Value;
                Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
                Елемент.Узгоджений = Узгоджений.Active;
                Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
                Елемент.НомерВхідногоДокументу = НомерВхідногоДокументу.GetText();
                        Елемент.ДатаВхідногоДокументу = ДатаВхідногоДокументу.Value;
                Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.ПовернутиТару = ПовернутиТару.Active;
                Елемент.ДатаПоверненняТари = ДатаПоверненняТари.Value;
                Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
                Елемент.Організація = Організація.Pointer;
                Елемент.Курс = Курс.Value;
                Елемент.Кратність = Кратність.Value;
                Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
                Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
                Елемент.СтаттяРухуКоштів = СтаттяРухуКоштів.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.Основа = Основа.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Валюта.Pointer.Назва} {Підрозділ.Pointer.Назва} {Склад.Pointer.Назва} {Контрагент.Pointer.Назва} {ЗамовленняПостачальнику.Pointer.Назва} {БанківськийРахунокОрганізації.Pointer.Назва} {БанківськийРахунокКонтрагента.Pointer.Назва} {Договір.Pointer.Назва} {Організація.Pointer.Назва} {СтаттяРухуКоштів.Pointer.Назва} {Каса.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПоступленняТоварівТаПослуг_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    