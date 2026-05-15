
/*
        АктВиконанихРобіт_Елемент.cs
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
using Функції = StorageAndTrade.АктВиконанихРобіт_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_zn6GqeUKrkyghG9wP5QktQ")]
partial class АктВиконанихРобіт_Елемент : DocumentFormElement
{
    public АктВиконанихРобіт_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            ЗамовленняКлієнта_PointerControl ЗамовленняКлієнта = ЗамовленняКлієнта_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            NumericControl СумаДокументу = NumericControl.New();
            ComboBoxText ФормаОплати = ComboBoxText.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            Entry Коментар = Entry.New();
                    CompositePointerControl Основа = CompositePointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Послуги" 
        АктВиконанихРобіт_ТабличнаЧастина_Послуги Послуги = АктВиконанихРобіт_ТабличнаЧастина_Послуги.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(АктВиконанихРобіт_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Послуги"
            Послуги.WidthRequest = 500;
            Послуги.HeightRequest = 300;
            NotebookTablePart.InsertPage(Послуги, Label.New("Послуги"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 100;
                        
            //ДатаДок:
            
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
            //ЗамовленняКлієнта:
            ЗамовленняКлієнта.Caption = "Замовлення клієнта";
                    ЗамовленняКлієнта.WidthPresentation = 300;
                
            //Каса:
            Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
            //Контрагент:
            Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //СумаДокументу:
            
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
            Основа.BoundConfType = "Документи.АктВиконанихРобіт.Основа";
                
    }

    public static АктВиконанихРобіт_Елемент New()
    {
        АктВиконанихРобіт_Елемент element = NewWithProperties([]);
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
                
            // ЗамовленняКлієнта
            CreateField(vBox, null, ЗамовленняКлієнта);
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
            // Організація
            CreateField(vBox, null, Організація);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // СумаДокументу
            CreateField(vBox, "Сума документу:", СумаДокументу);
                        
            // ФормаОплати
            CreateField(vBox, "Форма оплати:", ФормаОплати);
                
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
                Валюта.Pointer = Елемент.Валюта;
                ЗамовленняКлієнта.Pointer = Елемент.ЗамовленняКлієнта;
                Каса.Pointer = Елемент.Каса;
                Контрагент.Pointer = Елемент.Контрагент;
                Організація.Pointer = Елемент.Організація;
                Підрозділ.Pointer = Елемент.Підрозділ;
                СумаДокументу.Value = Елемент.СумаДокументу;
                ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
                Договір.Pointer = Елемент.Договір;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Коментар.SetText(Елемент.Коментар);
                        Основа.Pointer = Елемент.Основа;
                
            // Таблична частина "Послуги" 
            Послуги.ЕлементВласник = Елемент; 
            await Послуги.LoadRecords();
        
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
                        Елемент.ДатаДок = ДатаДок.Value;
                Елемент.Валюта = Валюта.Pointer;
                Елемент.ЗамовленняКлієнта = ЗамовленняКлієнта.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Організація = Організація.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.СумаДокументу = СумаДокументу.Value;
                Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
                Елемент.Договір = Договір.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Валюта.Pointer.Назва} {ЗамовленняКлієнта.Pointer.Назва} {Каса.Pointer.Назва} {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Підрозділ.Pointer.Назва} {Договір.Pointer.Назва}"
         + Послуги.КлючовіСловаДляПошуку();
    }*/
    

    #endregion
    
    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if(await Елемент.Save())
            {
                await Послуги.SaveRecords(); // Таблична частина "Послуги"
                
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
        CommonForms_DocumentMovementThroughRegisters.Create(new АктВиконанихРобіт_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    