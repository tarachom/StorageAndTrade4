
/*
        ЗамовленняПостачальнику_Елемент.cs
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
using Функції = StorageAndTrade.ЗамовленняПостачальнику_Функції;

namespace StorageAndTrade;

class ЗамовленняПостачальнику_Елемент : DocumentFormElement
{
    public ЗамовленняПостачальнику_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new();
    DateTimeControl ДатаДок = new();
    Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
    Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
    Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 300 };
    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
    Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = new() { Caption = "БанківськийРахунок", WidthPresentation = 300 };
    СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
    ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
    DateTimeControl ДатаПоступлення = new() { OnlyDate = true };
    Entry АдресаДоставкиДляПостачальника = new() { WidthRequest = 300 };
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    ComboBoxText СпосібДоставки = new ComboBoxText();
    TimeControl ЧасДоставкиЗ = new();
    TimeControl ЧасДоставкиДо = new();
    Entry АдресаДоставки = new() { WidthRequest = 300 };
    ComboBoxText ГосподарськаОперація = new ComboBoxText();
    ComboBoxText Статус = new ComboBoxText();
    ComboBoxText ФормаОплати = new ComboBoxText();
    Користувачі_PointerControl Менеджер = new() { Caption = "Менеджер", WidthPresentation = 300 };
    CompositePointerControl Основа = new() { BoundConfType = "Документи.ЗамовленняПостачальнику.Основа" };
    Entry Коментар = new() { WidthRequest = 1200 };

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ЗамовленняПостачальнику_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };

    #endregion

    public ЗамовленняПостачальнику_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ЗамовленняПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);

        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари" 
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        NotebookTablePart.SetCurrentPage(0);

        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            СпосібДоставки.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ГосподарськаОперація.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиЗамовленьПостачальникам_List())
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

    }

    protected override void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);

        // Контрагент
        CreateField(vBox, null, Контрагент);

        // Договір
        CreateField(vBox, null, Договір);
    }

    protected override void CreateTopEnd(Box vBox)
    {
        // Склад
        CreateField(vBox, null, Склад);

        // Валюта
        CreateField(vBox, null, Валюта);

        // Каса
        CreateField(vBox, null, Каса);
    }

    protected override void CreateBottomStart(Box vBox)
    {
        // БанківськийРахунок
        CreateField(vBox, null, БанківськийРахунок);



        // ДатаПоступлення
        CreateField(vBox, "ДатаПоступлення:", ДатаПоступлення);

        // АдресаДоставкиДляПостачальника
        CreateField(vBox, "АдресаДоставкиДляПостачальника:", АдресаДоставкиДляПостачальника);

        // ПовернутиТару
        CreateField(vBox, null, ПовернутиТару);

        // СпосібДоставки
        CreateField(vBox, "СпосібДоставки:", СпосібДоставки);

        // ЧасДоставкиЗ
        CreateField(vBox, "ЧасДоставкиЗ:", ЧасДоставкиЗ);

        // ЧасДоставкиДо
        CreateField(vBox, "ЧасДоставкиДо:", ЧасДоставкиДо);

        // АдресаДоставки
        CreateField(vBox, "АдресаДоставки:", АдресаДоставки);

        // ГосподарськаОперація
        CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);

        // Статус
        CreateField(vBox, "Статус:", Статус);

        // ФормаОплати
        CreateField(vBox, "ФормаОплати:", ФормаОплати);
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        // Підрозділ
        CreateField(vBox, null, Підрозділ);

        // Основа
        CreateField(vBox, null, Основа);
    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Контрагент.Pointer = Елемент.Контрагент;
        Організація.Pointer = Елемент.Організація;
        Склад.Pointer = Елемент.Склад;
        Валюта.Pointer = Елемент.Валюта;
        Каса.Pointer = Елемент.Каса;
        БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Договір.Pointer = Елемент.Договір;
        ДатаПоступлення.Value = Елемент.ДатаПоступлення;
        АдресаДоставкиДляПостачальника.SetText(Елемент.АдресаДоставкиДляПостачальника);
        ПовернутиТару.Active = Елемент.ПовернутиТару;
        СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
        ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
        АдресаДоставки.SetText(Елемент.АдресаДоставки);
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        Статус.ActiveId = Елемент.Статус.ToString();
        ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
        Менеджер.Pointer = Елемент.Менеджер;
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
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.Каса = Каса.Pointer;
        Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.ДатаПоступлення = ДатаПоступлення.Value;
        Елемент.АдресаДоставкиДляПостачальника = АдресаДоставкиДляПостачальника.GetText();
        Елемент.ПовернутиТару = ПовернутиТару.Active;
        Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
        Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
        Елемент.АдресаДоставки = АдресаДоставки.GetText();
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.Статус = ПсевдонімиПерелічення.СтатусиЗамовленьПостачальникам_FindByName(Статус.ActiveId);
        Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
        Елемент.Менеджер = Менеджер.Pointer;
        Елемент.Основа = Основа.Pointer;
        Елемент.Коментар = Коментар.GetText();

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Контрагент.Pointer.Назва} {Організація.Pointer.Назва} {Склад.Pointer.Назва} {Валюта.Pointer.Назва} {Каса.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {Підрозділ.Pointer.Назва} {Договір.Pointer.Назва} {Менеджер.Pointer.Назва}"
         + Товари.КлючовіСловаДляПошуку();
    }*/


    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ЗамовленняПостачальнику_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
