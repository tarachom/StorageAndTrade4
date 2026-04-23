
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

[GObject.Subclass<DocumentFormElement>("Element_RoxXBGXgDki6DYvfFkYuvg")]
partial class ПоверненняТоварівПостачальнику_Елемент : DocumentFormElement
{
    public ПоверненняТоварівПостачальнику_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = БанківськіРахункиОрганізацій_PointerControl.New();
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            ComboBoxText СпосібДоставки = ComboBoxText.New();
            Entry АдресДоставки = Entry.New();
                    TimeControl ЧасДоставкиЗ = TimeControl.New();
            TimeControl ЧасДоставкиДо = TimeControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            Entry Коментар = Entry.New();
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ПоверненняТоварівПостачальнику_ТабличнаЧастина_Товари Товари = ПоверненняТоварівПостачальнику_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПоверненняТоварівПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.WidthRequest = 500;
            Товари.HeightRequest = 300;
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 100;
                        
            //ДатаДок:
            
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Контрагент:
            Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
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
                
            //БанківськийРахунокОрганізації:
            БанківськийРахунокОрганізації.Caption = "Банківський рахунок організації";
                    БанківськийРахунокОрганізації.WidthPresentation = 300;
                
            //БанківськийРахунокКонтрагента:
            БанківськийРахунокКонтрагента.Caption = "Банківський рахунок контрагента";
                    БанківськийРахунокКонтрагента.WidthPresentation = 300;
                
            //Договір:
            Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                
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
                
            //АдресДоставки:
            АдресДоставки.WidthRequest = 300;
                        
            //ЧасДоставкиЗ:
            
            //ЧасДоставкиДо:
            
            //Каса:
            Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
            //Основа:
            Основа.BoundConfType = "Документи.ПоверненняТоварівПостачальнику.Основа";
                
            //Коментар:
            Коментар.WidthRequest = 300;
                        
    }

    public static ПоверненняТоварівПостачальнику_Елемент New()
    {
        ПоверненняТоварівПостачальнику_Елемент element = NewWithProperties([]);
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПоверненняТоварівПостачальнику_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    