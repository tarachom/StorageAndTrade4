
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

[GObject.Subclass<DocumentFormElement>("Element_qbk8AhVT9Ua554dv6JarkA")]
partial class ВведенняЗалишків_Елемент : DocumentFormElement
{
    public ВведенняЗалишків_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            Entry Коментар = Entry.New();
                    CompositePointerControl Основа = CompositePointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ВведенняЗалишків_ТабличнаЧастина_Товари Товари = ВведенняЗалишків_ТабличнаЧастина_Товари.New();
    
        // Таблична частина "Каси" 
        ВведенняЗалишків_ТабличнаЧастина_Каси Каси = ВведенняЗалишків_ТабличнаЧастина_Каси.New();
    
        // Таблична частина "БанківськіРахунки" 
        ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки БанківськіРахунки = ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки.New();
    
        // Таблична частина "РозрахункиЗКонтрагентами" 
        ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами РозрахункиЗКонтрагентами = ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ВведенняЗалишків_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.WidthRequest = 500;
            Товари.HeightRequest = 300;
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            // Таблична частина "Каси"
            Каси.WidthRequest = 500;
            Каси.HeightRequest = 300;
            NotebookTablePart.InsertPage(Каси, Label.New("Каси"), 1);
            
            // Таблична частина "БанківськіРахунки"
            БанківськіРахунки.WidthRequest = 500;
            БанківськіРахунки.HeightRequest = 300;
            NotebookTablePart.InsertPage(БанківськіРахунки, Label.New("Банківські рахунки"), 2);
            
            // Таблична частина "РозрахункиЗКонтрагентами"
            РозрахункиЗКонтрагентами.WidthRequest = 500;
            РозрахункиЗКонтрагентами.HeightRequest = 300;
            NotebookTablePart.InsertPage(РозрахункиЗКонтрагентами, Label.New("Розрахунки з контрагентами"), 3);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 100;
                        
            //ДатаДок:
            
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
            //Контрагент:
            Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                
            //Договір:
            Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                
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
                
            //Коментар:
            Коментар.WidthRequest = 300;
                        
            //Основа:
            Основа.BoundConfType = "Документи.ВведенняЗалишків.Основа";
                
    }

    public static ВведенняЗалишків_Елемент New()
    {
        ВведенняЗалишків_Елемент element = NewWithProperties([]);
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
            CreateField(vBox, "Господарська операція:", ГосподарськаОперація);
                
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
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва} {Склад.Pointer.Назва} {Валюта.Pointer.Назва} {Контрагент.Pointer.Назва} {Договір.Pointer.Назва}"
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
            ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async ValueTask<bool> SpendTheDocument(bool spendDoc)
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ВведенняЗалишків_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    