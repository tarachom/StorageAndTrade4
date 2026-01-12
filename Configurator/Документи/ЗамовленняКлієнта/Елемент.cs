
/*
        ЗамовленняКлієнта_Елемент.cs
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
using Функції = StorageAndTrade.ЗамовленняКлієнта_Функції;

namespace StorageAndTrade;

class ЗамовленняКлієнта_Елемент : DocumentFormElement
{
    public ЗамовленняКлієнта_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new();
    DateTimeControl ДатаДок = new();
    Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
    Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
    Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 300 };
    ComboBoxText Статус = new ComboBoxText();
    CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
    ComboBoxText ФормаОплати = new ComboBoxText();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = new() { Caption = "БанківськийРахунок", WidthPresentation = 300 };
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = new() { Caption = "БанківськийРахунокКонтрагента", WidthPresentation = 300 };
    Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
    NumericControl СумаАвансуДоЗабезпечення = new();
    NumericControl СумаПередоплатиДоВідгрузки = new();
    DateTimeControl ДатаВідгрузки = new() { OnlyDate = true };
    Entry АдресаДоставки = new() { WidthRequest = 300 };
    ComboBoxText ГосподарськаОперація = new ComboBoxText();
    ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
    СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
    ComboBoxText СпосібДоставки = new ComboBoxText();
    TimeControl ЧасДоставкиЗ = new();
    TimeControl ЧасДоставкиДо = new();
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    DateTimeControl ДатаПоверненняТари = new() { OnlyDate = true };
    Entry Коментар = new() { WidthRequest = 1200 };
    CompositePointerControl Основа = new() { BoundConfType = "Документи.ЗамовленняКлієнта.Основа" };

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ЗамовленняКлієнта_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };

    #endregion

    public ЗамовленняКлієнта_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ЗамовленняКлієнта_Const.FULLNAME, НомерДок, ДатаДок);

        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари" 
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        NotebookTablePart.SetCurrentPage(0);

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
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            СпосібДоставки.AddController(controller);
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
        // Статус
        CreateField(vBox, "Статус:", Статус);

        // Узгоджений
        CreateField(vBox, null, Узгоджений);

        // ФормаОплати
        CreateField(vBox, "ФормаОплати:", ФормаОплати);

        // БанківськийРахунок
        CreateField(vBox, null, БанківськийРахунок);

        // БанківськийРахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        // СумаАвансуДоЗабезпечення
        CreateField(vBox, "СумаАвансуДоЗабезпечення:", СумаАвансуДоЗабезпечення);

        // СумаПередоплатиДоВідгрузки
        CreateField(vBox, "СумаПередоплатиДоВідгрузки:", СумаПередоплатиДоВідгрузки);

        // ДатаВідгрузки
        CreateField(vBox, "ДатаВідгрузки:", ДатаВідгрузки);

        // АдресаДоставки
        CreateField(vBox, "АдресаДоставки:", АдресаДоставки);

        // ГосподарськаОперація
        CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);

        // СпосібДоставки
        CreateField(vBox, "СпосібДоставки:", СпосібДоставки);

        // ЧасДоставкиЗ
        CreateField(vBox, "ЧасДоставкиЗ:", ЧасДоставкиЗ);

        // ЧасДоставкиДо
        CreateField(vBox, "ЧасДоставкиДо:", ЧасДоставкиДо);

        // ПовернутиТару
        CreateField(vBox, null, ПовернутиТару);

        // ДатаПоверненняТари
        CreateField(vBox, "ДатаПоверненняТари:", ДатаПоверненняТари);
    }

    protected override void CreateBottomEnd(Box vBox)
    {
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
        Валюта.Pointer = Елемент.Валюта;
        Склад.Pointer = Елемент.Склад;
        Статус.ActiveId = Елемент.Статус.ToString();
        Узгоджений.Active = Елемент.Узгоджений;
        ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
        БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
        БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
        Каса.Pointer = Елемент.Каса;
        СумаАвансуДоЗабезпечення.Value = Елемент.СумаАвансуДоЗабезпечення;
        СумаПередоплатиДоВідгрузки.Value = Елемент.СумаПередоплатиДоВідгрузки;
        ДатаВідгрузки.Value = Елемент.ДатаВідгрузки;
        АдресаДоставки.SetText(Елемент.АдресаДоставки);
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        Договір.Pointer = Елемент.Договір;
        Підрозділ.Pointer = Елемент.Підрозділ;
        СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
        ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
        ПовернутиТару.Active = Елемент.ПовернутиТару;
        ДатаПоверненняТари.Value = Елемент.ДатаПоверненняТари;
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
        Елемент.Узгоджений = Узгоджений.Active;
        Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
        Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
        Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
        Елемент.Каса = Каса.Pointer;
        Елемент.СумаАвансуДоЗабезпечення = СумаАвансуДоЗабезпечення.Value;
        Елемент.СумаПередоплатиДоВідгрузки = СумаПередоплатиДоВідгрузки.Value;
        Елемент.ДатаВідгрузки = ДатаВідгрузки.Value;
        Елемент.АдресаДоставки = АдресаДоставки.GetText();
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.Договір = Договір.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
        Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
        Елемент.ПовернутиТару = ПовернутиТару.Active;
        Елемент.ДатаПоверненняТари = ДатаПоверненняТари.Value;
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ЗамовленняКлієнта_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
