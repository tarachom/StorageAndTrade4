
/*
        РеалізаціяТоварівТаПослуг_Елемент.cs
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
using Функції = StorageAndTrade.РеалізаціяТоварівТаПослуг_Функції;

namespace StorageAndTrade;

class РеалізаціяТоварівТаПослуг_Елемент : DocumentFormElement
{
    public РеалізаціяТоварівТаПослуг_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new();
    DateTimeControl ДатаДок = new();
    Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = new() { Caption = "БанківськийРахунокОрганізації", WidthPresentation = 300 };
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = new() { Caption = "БанківськийРахунокКонтрагента", WidthPresentation = 300 };
    DateTimeControl ДатаОплати = new() { OnlyDate = true };
    ЗамовленняКлієнта_PointerControl ЗамовленняКлієнта = new() { Caption = "ЗамовленняКлієнта", WidthPresentation = 300 };
    Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
    СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
    Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 300 };
    ComboBoxText ФормаОплати = new ComboBoxText();
    ComboBoxText ГосподарськаОперація = new ComboBoxText();
    Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
    ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
    CompositePointerControl Основа = new() { BoundConfType = "Документи.РеалізаціяТоварівТаПослуг.Основа" };
    ComboBoxText Статус = new ComboBoxText();
    NumericControl СумаПередоплати = new();
    NumericControl СумаПередоплатиЗаТару = new();
    ComboBoxText СпосібДоставки = new ComboBoxText();
    TimeControl ЧасДоставкиЗ = new();
    TimeControl ЧасДоставкиДо = new();
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    DateTimeControl ДатаПоверненняТари = new() { OnlyDate = true };
    NumericControl Курс = new();
    IntegerControl Кратність = new();
    Entry Коментар = new() { WidthRequest = 1200 };

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    РеалізаціяТоварівТаПослуг_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };

    #endregion

    public РеалізаціяТоварівТаПослуг_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(РеалізаціяТоварівТаПослуг_Const.FULLNAME, НомерДок, ДатаДок);

        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари" 
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        NotebookTablePart.SetCurrentPage(0);

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
            foreach (var field in ПсевдонімиПерелічення.СтатусиРеалізаціїТоварівТаПослуг_List())
                Статус.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            Статус.AddController(controller);
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
        // БанківськийРахунокОрганізації
        CreateField(vBox, null, БанківськийРахунокОрганізації);

        // БанківськийРахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        // ДатаОплати
        CreateField(vBox, "ДатаОплати:", ДатаОплати);

        // ЗамовленняКлієнта
        CreateField(vBox, null, ЗамовленняКлієнта);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);

        // ФормаОплати
        CreateField(vBox, "ФормаОплати:", ФормаОплати);

        // ГосподарськаОперація
        CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);

        // Статус
        CreateField(vBox, "Статус:", Статус);

        // СумаПередоплати
        CreateField(vBox, "СумаПередоплати:", СумаПередоплати);

        // СумаПередоплатиЗаТару
        CreateField(vBox, "СумаПередоплатиЗаТару:", СумаПередоплатиЗаТару);

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

        // Курс
        CreateField(vBox, "Курс:", Курс);

        // Кратність
        CreateField(vBox, "Кратність:", Кратність);

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
        Організація.Pointer = Елемент.Організація;
        Валюта.Pointer = Елемент.Валюта;
        БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
        БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
        ДатаОплати.Value = Елемент.ДатаОплати;
        ЗамовленняКлієнта.Pointer = Елемент.ЗамовленняКлієнта;
        Контрагент.Pointer = Елемент.Контрагент;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Склад.Pointer = Елемент.Склад;
        ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        Каса.Pointer = Елемент.Каса;
        Договір.Pointer = Елемент.Договір;
        Основа.Pointer = Елемент.Основа;
        Статус.ActiveId = Елемент.Статус.ToString();
        СумаПередоплати.Value = Елемент.СумаПередоплати;
        СумаПередоплатиЗаТару.Value = Елемент.СумаПередоплатиЗаТару;
        СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
        ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
        ПовернутиТару.Active = Елемент.ПовернутиТару;
        ДатаПоверненняТари.Value = Елемент.ДатаПоверненняТари;
        Курс.Value = Елемент.Курс;
        Кратність.Value = Елемент.Кратність;
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
        Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
        Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
        Елемент.ДатаОплати = ДатаОплати.Value;
        Елемент.ЗамовленняКлієнта = ЗамовленняКлієнта.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.Каса = Каса.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.Основа = Основа.Pointer;
        Елемент.Статус = ПсевдонімиПерелічення.СтатусиРеалізаціїТоварівТаПослуг_FindByName(Статус.ActiveId);
        Елемент.СумаПередоплати = СумаПередоплати.Value;
        Елемент.СумаПередоплатиЗаТару = СумаПередоплатиЗаТару.Value;
        Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
        Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
        Елемент.ПовернутиТару = ПовернутиТару.Active;
        Елемент.ДатаПоверненняТари = ДатаПоверненняТари.Value;
        Елемент.Курс = Курс.Value;
        Елемент.Кратність = Кратність.Value;
        Елемент.Коментар = Коментар.GetText();

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Валюта.Pointer.Назва} {БанківськийРахунокОрганізації.Pointer.Назва} {БанківськийРахунокКонтрагента.Pointer.Назва} {ЗамовленняКлієнта.Pointer.Назва} {Контрагент.Pointer.Назва} {Підрозділ.Pointer.Назва} {Склад.Pointer.Назва} {Каса.Pointer.Назва} {Договір.Pointer.Назва}"
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new РеалізаціяТоварівТаПослуг_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
