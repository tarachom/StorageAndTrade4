
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
    Entry НомерДок = new() { WidthRequest = 100 };
                    DateTimeControl ДатаДок = new();
            Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
            Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
            Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
            ComboBoxText ПричинаЗакриттяЗамовлення = new ComboBoxText();
            Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 300 };
            Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
            ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
            Користувачі_PointerControl Автор = new() { Caption = "Автор", WidthPresentation = 300 };
            Entry Коментар = new() { WidthRequest = 300 };
                    CompositePointerControl Основа = new() { BoundConfType = "Документи.ЗакриттяЗамовленняПостачальнику.Основа" };
            
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
        
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ПричиниЗакриттяЗамовленняПостачальнику_List())
                ПричинаЗакриттяЗамовлення.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ПричинаЗакриттяЗамовлення.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }
        
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
            //if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UnigueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UnigueID unigueID)
    {
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ЗакриттяЗамовленняПостачальнику_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
    