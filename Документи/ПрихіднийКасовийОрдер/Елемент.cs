
/*
        ПрихіднийКасовийОрдер_Елемент.cs
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
using Функції = StorageAndTrade.ПрихіднийКасовийОрдер_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_a3Wqsyxy0yTsHW6hOYm0A")]
partial class ПрихіднийКасовийОрдер_Елемент : DocumentFormElement
{
    public ПрихіднийКасовийОрдер_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = СтаттяРухуКоштів_PointerControl.New();
            Каси_PointerControl КасаВідправник = Каси_PointerControl.New();
            NumericControl Курс = NumericControl.New();
            Entry Коментар = Entry.New();
                    NumericControl СумаДокументу = NumericControl.New();
            
    #endregion

    #region TabularParts
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПрихіднийКасовийОрдер_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            //НомерДок:
            НомерДок.WidthRequest = 300;
                        
            //ДатаДок:
            
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Каса:
            Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
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
                
            //Основа:
            Основа.BoundConfType = "Документи.ПрихіднийКасовийОрдер.Основа";
                
            //Контрагент:
            Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                
            //Договір:
            Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                
            //БанківськийРахунок:
            БанківськийРахунок.Caption = "БанківськийРахунок";
                    БанківськийРахунок.WidthPresentation = 300;
                
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
            //СтаттяРухуКоштів:
            СтаттяРухуКоштів.Caption = "СтаттяРухуКоштів";
                    СтаттяРухуКоштів.WidthPresentation = 300;
                
            //КасаВідправник:
            КасаВідправник.Caption = "КасаВідправник";
                    КасаВідправник.WidthPresentation = 300;
                
            //Курс:
            
            //Коментар:
            Коментар.WidthRequest = 300;
                        
            //СумаДокументу:
            
    }

    public static ПрихіднийКасовийОрдер_Елемент New()
    {
        ПрихіднийКасовийОрдер_Елемент element = NewWithProperties([]);
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
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // ГосподарськаОперація
            CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);
                
            // Основа
            CreateField(vBox, null, Основа);
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // БанківськийРахунок
            CreateField(vBox, null, БанківськийРахунок);
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // СтаттяРухуКоштів
            CreateField(vBox, null, СтаттяРухуКоштів);
                
            // КасаВідправник
            CreateField(vBox, null, КасаВідправник);
                
            // Курс
            CreateField(vBox, "Курс:", Курс);
                        
            // СумаДокументу
            CreateField(vBox, "СумаДокументу:", СумаДокументу);
                        
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
                Каса.Pointer = Елемент.Каса;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Основа.Pointer = Елемент.Основа;
                Контрагент.Pointer = Елемент.Контрагент;
                Договір.Pointer = Елемент.Договір;
                БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
                Валюта.Pointer = Елемент.Валюта;
                СтаттяРухуКоштів.Pointer = Елемент.СтаттяРухуКоштів;
                КасаВідправник.Pointer = Елемент.КасаВідправник;
                Курс.Value = Елемент.Курс;
                Коментар.SetText(Елемент.Коментар);
                        СумаДокументу.Value = Елемент.СумаДокументу;
                
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Організація = Організація.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Основа = Основа.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.СтаттяРухуКоштів = СтаттяРухуКоштів.Pointer;
                Елемент.КасаВідправник = КасаВідправник.Pointer;
                Елемент.Курс = Курс.Value;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.СумаДокументу = СумаДокументу.Value;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Каса.Pointer.Назва} {Контрагент.Pointer.Назва} {Договір.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {Валюта.Pointer.Назва} {СтаттяРухуКоштів.Pointer.Назва} {КасаВідправник.Pointer.Назва}"
        ;
    }*/
    

    #endregion
    
    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if(await Елемент.Save())
            {
                
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПрихіднийКасовийОрдер_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    