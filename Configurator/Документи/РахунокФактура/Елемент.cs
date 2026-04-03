
/*
        РахунокФактура_Елемент.cs
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
using Функції = StorageAndTrade.РахунокФактура_Функції;

namespace StorageAndTrade;

class РахунокФактура_Елемент : DocumentFormElement
{
    public РахунокФактура_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            ComboBoxText Статус = ComboBoxText.New();
            ComboBoxText ФормаОплати = ComboBoxText.New();
            БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
            БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            Entry Коментар = Entry.New();
                    CompositePointerControl Основа = CompositePointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        РахунокФактура_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public РахунокФактура_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(РахунокФактура_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари" 
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        НомерДок.WidthRequest = 100;
                        Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
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
                БанківськийРахунок.Caption = "Банківський рахунок";
                    БанківськийРахунок.WidthPresentation = 300;
                БанківськийРахунокКонтрагента.Caption = "Банківський рахунок контрагента";
                    БанківськийРахунокКонтрагента.WidthPresentation = 300;
                Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                    ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                ГосподарськаОперація.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                Коментар.WidthRequest = 300;
                        Основа.BoundConfType = "Документи.РахунокФактура.Основа";
                
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
                
            // ФормаОплати
            CreateField(vBox, "ФормаОплати:", ФормаОплати);
                
            // БанківськийРахунок
            CreateField(vBox, null, БанківськийРахунок);
                
            // БанківськийРахунокКонтрагента
            CreateField(vBox, null, БанківськийРахунокКонтрагента);
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // ГосподарськаОперація
            CreateField(vBox, "Господарська операція:", ГосподарськаОперація);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
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
                ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
                БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
                БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
                Каса.Pointer = Елемент.Каса;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Договір.Pointer = Елемент.Договір;
                Підрозділ.Pointer = Елемент.Підрозділ;
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
                Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
                Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
                Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Договір = Договір.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new РахунокФактура_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    