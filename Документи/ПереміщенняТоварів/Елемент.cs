
/*
        ПереміщенняТоварів_Елемент.cs
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
using Функції = StorageAndTrade.ПереміщенняТоварів_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_NkclVw6Bk2A1f10rhGyQ")]
partial class ПереміщенняТоварів_Елемент : DocumentFormElement
{
    public ПереміщенняТоварів_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = БанківськіРахункиОрганізацій_PointerControl.New();
            ВидиЦін_PointerControl ВидЦіни = ВидиЦін_PointerControl.New();
            Організації_PointerControl ОрганізаціяОтримувач = Організації_PointerControl.New();
            Користувачі_PointerControl Відповідальний = Користувачі_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            Склади_PointerControl СкладВідправник = Склади_PointerControl.New();
            Склади_PointerControl СкладОтримувач = Склади_PointerControl.New();
            ComboBoxText Статус = ComboBoxText.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            ComboBoxText СпосібДоставки = ComboBoxText.New();
            Entry АдресДоставки = Entry.New();
                    TimeControl ЧасДоставкиЗ = TimeControl.New();
            TimeControl ЧасДоставкиДо = TimeControl.New();
            Entry Коментар = Entry.New();
                    CompositePointerControl Основа = CompositePointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ПереміщенняТоварів_ТабличнаЧастина_Товари Товари = ПереміщенняТоварів_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПереміщенняТоварів_Const.FULLNAME, НомерДок, ДатаДок);
        
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
                
            //БанківськийРахунокОрганізації:
            БанківськийРахунокОрганізації.Caption = "Банківський рахунок організації";
                    БанківськийРахунокОрганізації.WidthPresentation = 300;
                
            //ВидЦіни:
            ВидЦіни.Caption = "Вид ціни";
                    ВидЦіни.WidthPresentation = 300;
                
            //ОрганізаціяОтримувач:
            ОрганізаціяОтримувач.Caption = "Організація отримувач";
                    ОрганізаціяОтримувач.WidthPresentation = 300;
                
            //Відповідальний:
            Відповідальний.Caption = "Відповідальний";
                    Відповідальний.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //СкладВідправник:
            СкладВідправник.Caption = "Склад відправник";
                    СкладВідправник.WidthPresentation = 300;
                
            //СкладОтримувач:
            СкладОтримувач.Caption = "Склад отримувач";
                    СкладОтримувач.WidthPresentation = 300;
                
            //Статус:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.СтатусиПереміщенняТоварів_List())
                    Статус.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                Статус.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                
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
            
            //Коментар:
            Коментар.WidthRequest = 300;
                        
            //Основа:
            Основа.BoundConfType = "Документи.ПереміщенняТоварів.Основа";
                
    }

    public static ПереміщенняТоварів_Елемент New()
    {
        ПереміщенняТоварів_Елемент element = NewWithProperties([]);
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
                
            // БанківськийРахунокОрганізації
            CreateField(vBox, null, БанківськийРахунокОрганізації);
                
            // ВидЦіни
            CreateField(vBox, null, ВидЦіни);
                
            // ОрганізаціяОтримувач
            CreateField(vBox, null, ОрганізаціяОтримувач);
                
            // Відповідальний
            CreateField(vBox, null, Відповідальний);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // СкладВідправник
            CreateField(vBox, null, СкладВідправник);
                
            // СкладОтримувач
            CreateField(vBox, null, СкладОтримувач);
                
            // Статус
            CreateField(vBox, "Статус:", Статус);
                
            // ГосподарськаОперація
            CreateField(vBox, "Господарська операція:", ГосподарськаОперація);
                
            // СпосібДоставки
            CreateField(vBox, "Спосіб доставки:", СпосібДоставки);
                
            // АдресДоставки
            CreateField(vBox, "Адрес доставки:", АдресДоставки);
                        
            // ЧасДоставкиЗ
            CreateField(vBox, "Час доставки з:", ЧасДоставкиЗ);
                        
            // ЧасДоставкиДо
            CreateField(vBox, "Час доставки до:", ЧасДоставкиДо);
                        
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
                Організація.Pointer = Елемент.Організація;
                БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
                ВидЦіни.Pointer = Елемент.ВидЦіни;
                ОрганізаціяОтримувач.Pointer = Елемент.ОрганізаціяОтримувач;
                Відповідальний.Pointer = Елемент.Відповідальний;
                Підрозділ.Pointer = Елемент.Підрозділ;
                СкладВідправник.Pointer = Елемент.СкладВідправник;
                СкладОтримувач.Pointer = Елемент.СкладОтримувач;
                Статус.ActiveId = Елемент.Статус.ToString();
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
                АдресДоставки.SetText(Елемент.АдресДоставки);
                        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
                ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
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
                Елемент.Організація = Організація.Pointer;
                Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
                Елемент.ВидЦіни = ВидЦіни.Pointer;
                Елемент.ОрганізаціяОтримувач = ОрганізаціяОтримувач.Pointer;
                Елемент.Відповідальний = Відповідальний.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.СкладВідправник = СкладВідправник.Pointer;
                Елемент.СкладОтримувач = СкладОтримувач.Pointer;
                Елемент.Статус = ПсевдонімиПерелічення.СтатусиПереміщенняТоварів_FindByName(Статус.ActiveId);
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
                Елемент.АдресДоставки = АдресДоставки.GetText();
                        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
                Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {БанківськийРахунокОрганізації.Pointer.Назва} {ВидЦіни.Pointer.Назва} {ОрганізаціяОтримувач.Pointer.Назва} {Відповідальний.Pointer.Назва} {Підрозділ.Pointer.Назва} {СкладВідправник.Pointer.Назва} {СкладОтримувач.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПереміщенняТоварів_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    