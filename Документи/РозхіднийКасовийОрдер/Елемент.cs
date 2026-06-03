
/*
        РозхіднийКасовийОрдер_Елемент.cs
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
using Функції = StorageAndTrade.РозхіднийКасовийОрдер_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_y3DkBHyKd0ifDFQFXqNSKA")]
partial class РозхіднийКасовийОрдер_Елемент : DocumentFormElement
{
    public РозхіднийКасовийОрдер_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            NumericControl СумаДокументу = NumericControl.New();
            NumericControl СумаДокументуПоКурсу = NumericControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            Організації_PointerControl ОрганізаціяОтримувач = Організації_PointerControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = СтаттяРухуКоштів_PointerControl.New();
            Каси_PointerControl КасаОтримувач = Каси_PointerControl.New();
            NumericControl Курс = NumericControl.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            Entry Коментар = Entry.New();
                    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
            
    #endregion

    #region TabularParts
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(РозхіднийКасовийОрдер_Const.FULLNAME, НомерДок, ДатаДок);
        
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
                
            //СумаДокументу:
            
            //СумаДокументуПоКурсу:
            
            //ГосподарськаОперація:
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                    ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

                ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
            }
                
            //ОрганізаціяОтримувач:
            ОрганізаціяОтримувач.Caption = "ОрганізаціяОтримувач";
                    ОрганізаціяОтримувач.WidthPresentation = 300;
                
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
                
            //КасаОтримувач:
            КасаОтримувач.Caption = "КасаОтримувач";
                    КасаОтримувач.WidthPresentation = 300;
                
            //Курс:
            
            //Основа:
            Основа.BoundConfType = "Документи.РозхіднийКасовийОрдер.Основа";
                
            //Коментар:
            Коментар.WidthRequest = 300;
                        
            //Автор:
            Автор.Caption = "Автор";
                    Автор.WidthPresentation = 300;
                
    }

    public static РозхіднийКасовийОрдер_Елемент New()
    {
        РозхіднийКасовийОрдер_Елемент element = NewWithProperties([]);
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
                
            // СумаДокументу
            CreateField(vBox, "СумаДокументу:", СумаДокументу);
                        
            // СумаДокументуПоКурсу
            CreateField(vBox, "СумаДокументуПоКурсу:", СумаДокументуПоКурсу);
                        
            // ГосподарськаОперація
            CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);
                
            // ОрганізаціяОтримувач
            CreateField(vBox, null, ОрганізаціяОтримувач);
                
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
                
            // КасаОтримувач
            CreateField(vBox, null, КасаОтримувач);
                
            // Курс
            CreateField(vBox, "Курс:", Курс);
                        
            // Основа
            CreateField(vBox, null, Основа);
                
            // Автор
            CreateField(vBox, null, Автор);
                
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
                СумаДокументу.Value = Елемент.СумаДокументу;
                СумаДокументуПоКурсу.Value = Елемент.СумаДокументуПоКурсу;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                ОрганізаціяОтримувач.Pointer = Елемент.ОрганізаціяОтримувач;
                Контрагент.Pointer = Елемент.Контрагент;
                Договір.Pointer = Елемент.Договір;
                БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
                Валюта.Pointer = Елемент.Валюта;
                СтаттяРухуКоштів.Pointer = Елемент.СтаттяРухуКоштів;
                КасаОтримувач.Pointer = Елемент.КасаОтримувач;
                Курс.Value = Елемент.Курс;
                Основа.Pointer = Елемент.Основа;
                Коментар.SetText(Елемент.Коментар);
                        Автор.Pointer = Елемент.Автор;
                
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Організація = Організація.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.СумаДокументу = СумаДокументу.Value;
                Елемент.СумаДокументуПоКурсу = СумаДокументуПоКурсу.Value;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.ОрганізаціяОтримувач = ОрганізаціяОтримувач.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.СтаттяРухуКоштів = СтаттяРухуКоштів.Pointer;
                Елемент.КасаОтримувач = КасаОтримувач.Pointer;
                Елемент.Курс = Курс.Value;
                Елемент.Основа = Основа.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Автор = Автор.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Каса.Pointer.Назва} {ОрганізаціяОтримувач.Pointer.Назва} {Контрагент.Pointer.Назва} {Договір.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {Валюта.Pointer.Назва} {СтаттяРухуКоштів.Pointer.Назва} {КасаОтримувач.Pointer.Назва} {Автор.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new РозхіднийКасовийОрдер_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    