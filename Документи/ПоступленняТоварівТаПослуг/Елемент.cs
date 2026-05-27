
/*
        ПоступленняТоварівТаПослуг_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.ПоступленняТоварівТаПослуг_Функції;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_kO8uTjFfbkaiGIuUihNDOA")]
partial class ПоступленняТоварівТаПослуг_Елемент : DocumentFormElement
{
    public ПоступленняТоварівТаПослуг_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    ЗамовленняПостачальнику_PointerControl ЗамовленняПостачальнику = ЗамовленняПостачальнику_PointerControl.New();
    DateTimeControl ДатаОплати = DateTimeControl.New();
    ComboBoxText ФормаОплати = ComboBoxText.New();
    CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = БанківськіРахункиОрганізацій_PointerControl.New();
    Entry НомерВхідногоДокументу = Entry.New();
    DateTimeControl ДатаВхідногоДокументу = DateTimeControl.New();
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    DateTimeControl ДатаПоверненняТари = DateTimeControl.New();
    ComboBoxText СпосібДоставки = ComboBoxText.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    NumericControl Курс = NumericControl.New();
    IntegerControl Кратність = IntegerControl.New();
    TimeControl ЧасДоставкиЗ = TimeControl.New();
    TimeControl ЧасДоставкиДо = TimeControl.New();
    СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = СтаттяРухуКоштів_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Entry Коментар = Entry.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари Товари = ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПоступленняТоварівТаПослуг_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        NotebookTablePart.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => x.Value == ГосподарськіОперації.ЗакупівляВПостачальника))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ГосподарськаОперація.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //ЗамовленняПостачальнику:
        ЗамовленняПостачальнику.Caption = "ЗамовленняПостачальнику";
        ЗамовленняПостачальнику.WidthPresentation = 300;

        //ДатаОплати:
        ДатаОплати.OnlyDate = true;

        //ФормаОплати:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                ФормаОплати.Append(field.Value.ToString(), field.Name);

            ФормаОплати.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ФормаОплати.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        //БанківськийРахунокОрганізації:
        БанківськийРахунокОрганізації.Caption = "БанківськийРахунокОрганізації";
        БанківськийРахунокОрганізації.WidthPresentation = 300;

        //НомерВхідногоДокументу:
        НомерВхідногоДокументу.WidthRequest = 300;

        //ДатаВхідногоДокументу:
        ДатаВхідногоДокументу.OnlyDate = true;

        //БанківськийРахунокКонтрагента:
        БанківськийРахунокКонтрагента.Caption = "БанківськийРахунокКонтрагента";
        БанківськийРахунокКонтрагента.WidthPresentation = 300;

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //ДатаПоверненняТари:
        ДатаПоверненняТари.OnlyDate = true;

        //СпосібДоставки:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            СпосібДоставки.Active = 0;

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            СпосібДоставки.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //СтаттяРухуКоштів:
        СтаттяРухуКоштів.Caption = "СтаттяРухуКоштів";
        СтаттяРухуКоштів.WidthPresentation = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //Основа:
        Основа.BoundConfType = "Документи.ПоступленняТоварівТаПослуг.Основа";

        //Коментар:
        Коментар.WidthRequest = 920;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Менеджер:
        Менеджер.Caption = "Менеджер";
        Менеджер.WidthPresentation = 300;
    }

    public static ПоступленняТоварівТаПослуг_Елемент New()
    {
        ПоступленняТоварівТаПослуг_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    protected override void CreateTopStart(Box vBox)
    {
        //Організація
        CreateField(vBox, null, Організація);

        //Контрагент
        CreateField(vBox, null, Контрагент);
        Контрагент.AfterSelectFunc = async () => await Контрагент.ПривязкаДоДоговору(Договір);

        //Договір
        CreateField(vBox, null, Договір);
        Договір.BeforeClickOpenFunc = () => Договір.Власник = Контрагент.Pointer;
    }

    protected override void CreateTopEnd(Box vBox)
    {
        //Склад
        CreateField(vBox, null, Склад);

        //Каса
        CreateField(vBox, null, Каса);

        //Валюта
        CreateField(vBox, null, Валюта);
    }

    protected override void CreateBottomStart(Box vBox)
    {
        //ЗамовленняПостачальнику
        CreateField(vBox, null, ЗамовленняПостачальнику);

        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //Підрозділ
        CreateField(vBox, null, Підрозділ);

        //БанківськийрахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        //БанківськийрахунокОрганізації
        CreateField(vBox, null, БанківськийРахунокОрганізації);

        //СтаттяРухуКоштів
        CreateField(vBox, null, СтаттяРухуКоштів);

        //Автор
        CreateField(vBox, null, Автор);

        //Менеджер
        CreateField(vBox, null, Менеджер);

        //Основа
        CreateField(vBox, null, Основа);
    }

    protected override void CreateBottomEnd(Box vBox)
    {
        //ФормаОплати
        CreateField(vBox, "Форма оплати:", ФормаОплати);

        //ДатаОплати
        CreateField(vBox, "Дата оплати:", ДатаОплати);

        //Узгоджений та ВернутиТару
        CreateField(CreateField(vBox, null, Узгоджений), null, ПовернутиТару);

        //ДатаПоверненняТари
        CreateField(vBox, "Дата повернення тари:", ДатаПоверненняТари);

        //НомерВхідногоДокументу
        CreateField(vBox, "Номер вхід. док:", НомерВхідногоДокументу);

        //ДатаВхідногоДокументу
        CreateField(vBox, "Дата вхід. док:", ДатаВхідногоДокументу);

        //Курс та Кратність
        CreateField(CreateField(vBox, "Курс:", Курс), "Кратність:", Кратність);

        //СпосібДоставки
        CreateField(vBox, "Спосіб доставки:", СпосібДоставки);

        //ЧасДоставки
        CreateField(CreateField(vBox, "Час доставки з", ЧасДоставкиЗ), "до", ЧасДоставкиДо);
    }

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = ЗначенняТипові.ОсновнаОрганізація_Const;
            Елемент.Валюта = ЗначенняТипові.ОсновнаВалюта_Const;
            Елемент.Каса = ЗначенняТипові.ОсновнаКаса_Const;
            Елемент.Склад = ЗначенняТипові.ОсновнийСклад_Const;
            Елемент.Контрагент = ЗначенняТипові.ОсновнийПостачальник_Const;
            Елемент.Підрозділ = ЗначенняТипові.ОсновнийПідрозділ_Const;
            Елемент.БанківськийРахунокОрганізації = ЗначенняТипові.ОсновнийБанківськийРахунок_Const;
        }

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
        Автор.Pointer = Елемент.Автор;
        Менеджер.Pointer = Елемент.Менеджер;
        Коментар.SetText(Елемент.Коментар);        

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        await Товари.LoadRecords();

        if (IsNew)
        {
            //Основний договір
            Контрагент.AfterSelectFunc?.Invoke();
        }
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
        Елемент.Автор = Автор.Pointer;
        Елемент.Менеджер = Менеджер.Pointer;
        Елемент.Коментар = Коментар.GetText();

        Елемент.СумаДокументу = Товари.СумаДокументу();
    }

    #endregion

    protected override async Task<bool> Save()
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПоступленняТоварівТаПослуг_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
