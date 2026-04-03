
/*
        ЗакриттяЗамовленняПостачальнику_Елемент.cs
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
using Функції = StorageAndTrade.ЗакриттяЗамовленняПостачальнику_Функції;

namespace StorageAndTrade;

class ЗакриттяЗамовленняПостачальнику_Елемент : DocumentFormElement
{
    public ЗакриттяЗамовленняПостачальнику_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
                    DateTimeControl ДатаДок = DateTimeControl.New();
            Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
            Організації_PointerControl Організація = Організації_PointerControl.New();
            Валюти_PointerControl Валюта = Валюти_PointerControl.New();
            ComboBoxText ПричинаЗакриттяЗамовлення = ComboBoxText.New();
            Склади_PointerControl Склад = Склади_PointerControl.New();
            Каси_PointerControl Каса = Каси_PointerControl.New();
            ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
            Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
            Entry Коментар = Entry.New();
                    CompositePointerControl Основа = CompositePointerControl.New();
            
    #endregion

    #region TabularParts
    
        // Таблична частина "Товари" 
        ЗакриттяЗамовленняПостачальнику_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };
    
    #endregion

    public ЗакриттяЗамовленняПостачальнику_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ЗакриттяЗамовленняПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
        
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
                
            {
                //Заповнення списку
                foreach (var field in ПсевдонімиПерелічення.ПричиниЗакриттяЗамовленняПостачальнику_List())
                    ПричинаЗакриттяЗамовлення.Append(field.Value.ToString(), field.Name);

                //Заборона прокрутки списку
                EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                ПричинаЗакриттяЗамовлення.AddController(controller);
                controller.OnScroll += (_, _) => true;
            }
                Склад.Caption = "Склад";
                    Склад.WidthPresentation = 300;
                Каса.Caption = "Каса";
                    Каса.WidthPresentation = 300;
                Договір.Caption = "Договір";
                    Договір.WidthPresentation = 300;
                Автор.Caption = "Автор";
                    Автор.WidthPresentation = 300;
                Коментар.WidthRequest = 300;
                        Основа.BoundConfType = "Документи.ЗакриттяЗамовленняПостачальнику.Основа";
                
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
                
            // ПричинаЗакриттяЗамовлення
            CreateField(vBox, "Причина закриття замовлення:", ПричинаЗакриттяЗамовлення);
                
            // Склад
            CreateField(vBox, null, Склад);
                
            // Каса
            CreateField(vBox, null, Каса);
                
            // Договір
            CreateField(vBox, null, Договір);
                
            // Автор
            CreateField(vBox, null, Автор);
                
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
                ПричинаЗакриттяЗамовлення.ActiveId = Елемент.ПричинаЗакриттяЗамовлення.ToString();
                Склад.Pointer = Елемент.Склад;
                Каса.Pointer = Елемент.Каса;
                Договір.Pointer = Елемент.Договір;
                Автор.Pointer = Елемент.Автор;
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
                Елемент.ПричинаЗакриттяЗамовлення = ПсевдонімиПерелічення.ПричиниЗакриттяЗамовленняПостачальнику_FindByName(ПричинаЗакриттяЗамовлення.ActiveId);
                Елемент.Склад = Склад.Pointer;
                Елемент.Каса = Каса.Pointer;
                Елемент.Договір = Договір.Pointer;
                Елемент.Автор = Автор.Pointer;
                Елемент.Коментар = Коментар.GetText();
                        Елемент.Основа = Основа.Pointer;
                
    }

    
    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Валюта.Pointer.Назва} {Склад.Pointer.Назва} {Каса.Pointer.Назва} {Договір.Pointer.Назва} {Автор.Pointer.Назва}"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗакриттяЗамовленняПостачальнику_Pointer(uniqueID));
    }

    protected override async ValueTask InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
    