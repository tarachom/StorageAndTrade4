
/*
        ПоступленняТоварівТаПослуг_Елемент.cs
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
using Функції = StorageAndTrade.ПоступленняТоварівТаПослуг_Функції;

namespace StorageAndTrade;

class ПоступленняТоварівТаПослуг_Елемент : DocumentFormElement
{
    public ПоступленняТоварівТаПослуг_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new();
    DateTimeControl ДатаДок = new();
    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
    ComboBoxText ГосподарськаОперація = new ComboBoxText();
    СтруктураПідприємства_PointerControl Підрозділ = new() { Caption = "Підрозділ", WidthPresentation = 300 };
    Склади_PointerControl Склад = new() { Caption = "Склад", WidthPresentation = 300 };
    Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
    ЗамовленняПостачальнику_PointerControl ЗамовленняПостачальнику = new() { Caption = "ЗамовленняПостачальнику", WidthPresentation = 300 };
    DateTimeControl ДатаОплати = new() { OnlyDate = true };
    ComboBoxText ФормаОплати = new ComboBoxText();
    CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = new() { Caption = "БанківськийРахунокОрганізації", WidthPresentation = 300 };
    Entry НомерВхідногоДокументу = new() { WidthRequest = 500 };
    DateTimeControl ДатаВхідногоДокументу = new() { OnlyDate = true };
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = new() { Caption = "БанківськийРахунокКонтрагента", WidthPresentation = 300 };
    ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    DateTimeControl ДатаПоверненняТари = new() { OnlyDate = true };
    ComboBoxText СпосібДоставки = new ComboBoxText();
    Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
    NumericControl Курс = new();
    IntegerControl Кратність = new();
    TimeControl ЧасДоставкиЗ = new();
    TimeControl ЧасДоставкиДо = new();
    СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = new() { Caption = "СтаттяРухуКоштів", WidthPresentation = 300 };
    Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
    CompositePointerControl Основа = new() { BoundConfType = "Документи.ПоступленняТоварівТаПослуг.Основа" };
    Entry Коментар = new() { WidthRequest = 1200 };

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари Товари = new() { WidthRequest = 500, HeightRequest = 300 };

    #endregion

    public ПоступленняТоварівТаПослуг_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ПоступленняТоварівТаПослуг_Const.FULLNAME, НомерДок, ДатаДок);

        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари" 
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        NotebookTablePart.SetCurrentPage(0);

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
            foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                ФормаОплати.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ФормаОплати.AddController(controller);
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
        // ГосподарськаОперація
        CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);

        // ЗамовленняПостачальнику
        CreateField(vBox, null, ЗамовленняПостачальнику);

        // ДатаОплати
        CreateField(vBox, "ДатаОплати:", ДатаОплати);

        // ФормаОплати
        CreateField(vBox, "ФормаОплати:", ФормаОплати);

        // Узгоджений
        CreateField(vBox, null, Узгоджений);

        // БанківськийРахунокОрганізації
        CreateField(vBox, null, БанківськийРахунокОрганізації);

        // НомерВхідногоДокументу
        CreateField(vBox, "НомерВхідногоДокументу:", НомерВхідногоДокументу);

        // ДатаВхідногоДокументу
        CreateField(vBox, "ДатаВхідногоДокументу:", ДатаВхідногоДокументу);

        // БанківськийРахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        // ПовернутиТару
        CreateField(vBox, null, ПовернутиТару);

        // ДатаПоверненняТари
        CreateField(vBox, "ДатаПоверненняТари:", ДатаПоверненняТари);

        // СпосібДоставки
        CreateField(vBox, "СпосібДоставки:", СпосібДоставки);

        // Курс
        CreateField(vBox, "Курс:", Курс);

        // Кратність
        CreateField(vBox, "Кратність:", Кратність);

        // ЧасДоставкиЗ
        CreateField(vBox, "ЧасДоставкиЗ:", ЧасДоставкиЗ);

        // ЧасДоставкиДо
        CreateField(vBox, "ЧасДоставкиДо:", ЧасДоставкиДо);

        // СтаттяРухуКоштів
        CreateField(vBox, null, СтаттяРухуКоштів);
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
        Валюта.Pointer = Елемент.Валюта;
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        Підрозділ.Pointer = Елемент.Підрозділ;
        Склад.Pointer = Елемент.Склад;
        Контрагент.Pointer = Елемент.Контрагент;
        ЗамовленняПостачальнику.Pointer = Елемент.ЗамовленняПостачальнику;
        ДатаОплати.Value = Елемент.ДатаОплати;
        ФормаОплати.ActiveId = Елемент.ФормаОплати.ToString();
        Узгоджений.Active = Елемент.Узгоджений;
        БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
        НомерВхідногоДокументу.SetText(Елемент.НомерВхідногоДокументу);
        ДатаВхідногоДокументу.Value = Елемент.ДатаВхідногоДокументу;
        БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
        Договір.Pointer = Елемент.Договір;
        ПовернутиТару.Active = Елемент.ПовернутиТару;
        ДатаПоверненняТари.Value = Елемент.ДатаПоверненняТари;
        СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
        Організація.Pointer = Елемент.Організація;
        Курс.Value = Елемент.Курс;
        Кратність.Value = Елемент.Кратність;
        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
        ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
        СтаттяРухуКоштів.Pointer = Елемент.СтаттяРухуКоштів;
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
        Елемент.Валюта = Валюта.Pointer;
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.ЗамовленняПостачальнику = ЗамовленняПостачальнику.Pointer;
        Елемент.ДатаОплати = ДатаОплати.Value;
        Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.ActiveId);
        Елемент.Узгоджений = Узгоджений.Active;
        Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
        Елемент.НомерВхідногоДокументу = НомерВхідногоДокументу.GetText();
        Елемент.ДатаВхідногоДокументу = ДатаВхідногоДокументу.Value;
        Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.ПовернутиТару = ПовернутиТару.Active;
        Елемент.ДатаПоверненняТари = ДатаПоверненняТари.Value;
        Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
        Елемент.Організація = Організація.Pointer;
        Елемент.Курс = Курс.Value;
        Елемент.Кратність = Кратність.Value;
        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
        Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
        Елемент.СтаттяРухуКоштів = СтаттяРухуКоштів.Pointer;
        Елемент.Каса = Каса.Pointer;
        Елемент.Основа = Основа.Pointer;
        Елемент.Коментар = Коментар.GetText();

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Валюта.Pointer.Назва} {Підрозділ.Pointer.Назва} {Склад.Pointer.Назва} {Контрагент.Pointer.Назва} {ЗамовленняПостачальнику.Pointer.Назва} {БанківськийРахунокОрганізації.Pointer.Назва} {БанківськийРахунокКонтрагента.Pointer.Назва} {Договір.Pointer.Назва} {Організація.Pointer.Назва} {СтаттяРухуКоштів.Pointer.Назва} {Каса.Pointer.Назва}"
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ПоступленняТоварівТаПослуг_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
