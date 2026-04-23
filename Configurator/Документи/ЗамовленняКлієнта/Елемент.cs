
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

[GObject.Subclass<DocumentFormElement>("Element_7C1OqgHkWQWocvs3qA6w")]
partial class ЗамовленняКлієнта_Елемент : DocumentFormElement
{
    public ЗамовленняКлієнта_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            ComboBoxText Статус = ComboBoxText.New();
            CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
            ComboBoxText ФормаОплати = ComboBoxText.New();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            NumericControl СумаАвансуДоЗабезпечення = NumericControl.New();
            NumericControl СумаПередоплатиДоВідгрузки = NumericControl.New();
            DateTimeControl ДатаВідгрузки = DateTimeControl.New();
            Entry АдресаДоставки = Entry.New();
                    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            ComboBoxText СпосібДоставки = ComboBoxText.New();
            TimeControl ЧасДоставкиЗ = TimeControl.New();
            TimeControl ЧасДоставкиДо = TimeControl.New();
            CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
            DateTimeControl ДатаПоверненняТари = DateTimeControl.New();
            Entry Коментар = Entry.New();
                    CompositePointerControl Основа = CompositePointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ЗамовленняКлієнта_ТабличнаЧастина_Товари Товари = ЗамовленняКлієнта_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ЗамовленняКлієнта_Const.FULLNAME, НомерДок, ДатаДок);
        
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
                
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            //Статус:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.СтатусиЗамовленьКлієнтів_List())
                    Статус.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                Статус.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                
            //Узгоджений:
            
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
                
            //БанківськийРахунок:
            БанківськийРахунок.Caption = "БанківськийРахунок";
                    БанківськийРахунок.WidthPresentation = 300;
                
            //БанківськийРахунокКонтрагента:
            БанківськийРахунокКонтрагента.Caption = "БанківськийРахунокКонтрагента";
                    БанківськийРахунокКонтрагента.WidthPresentation = 300;
                
            //Каса:
            Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
            //СумаАвансуДоЗабезпечення:
            
            //СумаПередоплатиДоВідгрузки:
            
            //ДатаВідгрузки:
            ДатаВідгрузки.OnlyDate = true;
                
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
                
            //Договір:
            Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
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
            
            //ПовернутиТару:
            
            //ДатаПоверненняТари:
            ДатаПоверненняТари.OnlyDate = true;
                
            //Коментар:
            Коментар.WidthRequest = 1200;
                        
            //Основа:
            Основа.BoundConfType = "Документи.ЗамовленняКлієнта.Основа";
                
    }

    public static ЗамовленняКлієнта_Елемент New()
    {
        ЗамовленняКлієнта_Елемент element = NewWithProperties([]);
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
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
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
                СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
                ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
                ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
                ПовернутиТару.Active = Елемент.ПовернутиТару;
                ДатаПоверненняТари.Value = Елемент.ДатаПоверненняТари;
                Коментар.SetText(Елемент.Коментар);
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
                Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
                Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
                Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
                Елемент.ПовернутиТару = ПовернутиТару.Active;
                Елемент.ДатаПоверненняТари = ДатаПоверненняТари.Value;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Валюта.Pointer.Назва} {Склад.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {БанківськийРахунокКонтрагента.Pointer.Назва} {Каса.Pointer.Назва} {Договір.Pointer.Назва} {Підрозділ.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗамовленняКлієнта_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    