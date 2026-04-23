
/*
        ПоверненняТоварівВідКлієнта_Елемент.cs
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
using Функції = StorageAndTrade.ПоверненняТоварівВідКлієнта_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_5nVifQwiZUaxOyJyX05gaA")]
partial class ПоверненняТоварівВідКлієнта_Елемент : DocumentFormElement
{
    public ПоверненняТоварівВідКлієнта_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
            РеалізаціяТоварівТаПослуг_PointerControl ДокументПродажу = РеалізаціяТоварівТаПослуг_PointerControl.New();
            ComboBoxText ГосподарськаОперація = ComboBoxText.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            Entry ПричинаПовернення = Entry.New();
                    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            CompositePointerControl Основа = CompositePointerControl.New();
            Entry Коментар = Entry.New();
                    
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ПоверненняТоварівВідКлієнта_ТабличнаЧастина_Товари Товари = ПоверненняТоварівВідКлієнта_ТабличнаЧастина_Товари.New();
    
    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПоверненняТоварівВідКлієнта_Const.FULLNAME, НомерДок, ДатаДок);
        
        CreateField(HBoxComment, "Коментар:", Коментар);
        
            // Таблична частина "Товари"
            Товари.WidthRequest = 500;
            Товари.HeightRequest = 300;
            NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);
            
            NotebookTablePart.SetCurrentPage(0);
        
            //НомерДок:
            НомерДок.WidthRequest = 300;
                        
            //ДатаДок:
            
            //Організація:
            Організація.Caption = "Організація";
                    Організація.WidthPresentation = 300;
                
            //Валюта:
            Валюта.Caption = "Валюта";
                    Валюта.WidthPresentation = 300;
                
            //Склад:
            Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                
            //Підрозділ:
            Підрозділ.Caption = "Підрозділ";
                    Підрозділ.WidthPresentation = 300;
                
            //ДокументПродажу:
            ДокументПродажу.Caption = "Документ продажу";
                    ДокументПродажу.WidthPresentation = 300;
                
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
                
            //ПричинаПовернення:
            ПричинаПовернення.WidthRequest = 300;
                        
            //Контрагент:
            Контрагент.Caption = "Контрагент";
                    Контрагент.WidthPresentation = 300;
                
            //Каса:
            Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                
            //Основа:
            Основа.BoundConfType = "Документи.ПоверненняТоварівВідКлієнта.Основа";
                
            //Коментар:
            Коментар.WidthRequest = 300;
                        
    }

    public static ПоверненняТоварівВідКлієнта_Елемент New()
    {
        ПоверненняТоварівВідКлієнта_Елемент element = NewWithProperties([]);
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
                
            // Валюта
            CreateField(vBox, null, Валюта);
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // Підрозділ
            CreateField(vBox, null, Підрозділ);
                
            // ДокументПродажу
            CreateField(vBox, null, ДокументПродажу);
                
            // ГосподарськаОперація
            CreateField(vBox, "Господарська операція:", ГосподарськаОперація);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // ПричинаПовернення
            CreateField(vBox, "Причина повернення:", ПричинаПовернення);
                        
            // Контрагент
            CreateField(vBox, null, Контрагент);
                
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
                Валюта.Pointer = Елемент.Валюта;
                Склад.Pointer = Елемент.Склад;
                Підрозділ.Pointer = Елемент.Підрозділ;
                ДокументПродажу.Pointer = Елемент.ДокументПродажу;
                ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
                Договір.Pointer = Елемент.Договір;
                ПричинаПовернення.SetText(Елемент.ПричинаПовернення);
                        Контрагент.Pointer = Елемент.Контрагент;
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
                Елемент.Валюта = Валюта.Pointer;
                Елемент.Склад = Склад.Pointer;
                Елемент.Підрозділ = Підрозділ.Pointer;
                Елемент.ДокументПродажу = ДокументПродажу.Pointer;
                Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
                Елемент.Договір = Договір.Pointer;
                Елемент.ПричинаПовернення = ПричинаПовернення.GetText();
                        Елемент.Контрагент = Контрагент.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.Основа = Основа.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Валюта.Pointer.Назва} {Склад.Pointer.Назва} {Підрозділ.Pointer.Назва} {ДокументПродажу.Pointer.Назва} {Договір.Pointer.Назва} {Контрагент.Pointer.Назва} {Каса.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПоверненняТоварівВідКлієнта_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    