
/*
        РеалізаціяТоварівТаПослуг_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.РеалізаціяТоварівТаПослуг_Функції;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_pnJ6TYpSP0yOx9MHzWxgg")]
partial class РеалізаціяТоварівТаПослуг_Елемент : DocumentFormElement
{
    public РеалізаціяТоварівТаПослуг_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = БанківськіРахункиОрганізацій_PointerControl.New();
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
    DateTimeControl ДатаОплати = DateTimeControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
    ЗамовленняКлієнта_PointerControl ЗамовленняКлієнта = ЗамовленняКлієнта_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    ComboBoxText ФормаОплати = ComboBoxText.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    ComboBoxText Статус = ComboBoxText.New();
    NumericControl СумаПередоплати = NumericControl.New();
    NumericControl СумаПередоплатиЗаТару = NumericControl.New();
    ComboBoxText СпосібДоставки = ComboBoxText.New();
    TimeControl ЧасДоставкиЗ = TimeControl.New();
    TimeControl ЧасДоставкиДо = TimeControl.New();
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    DateTimeControl ДатаПоверненняТари = DateTimeControl.New();
    NumericControl Курс = NumericControl.New();
    IntegerControl Кратність = IntegerControl.New();
    Entry Коментар = Entry.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    РеалізаціяТоварівТаПослуг_ТабличнаЧастина_Товари Товари = РеалізаціяТоварівТаПослуг_ТабличнаЧастина_Товари.New();

    // Таблична частина "Проводки" 
    РеалізаціяТоварівТаПослуг_ТабличнаЧастина_Проводки Проводки = РеалізаціяТоварівТаПослуг_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(РеалізаціяТоварівТаПослуг_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(HBoxComment, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        NotebookTablePart.InsertPage(Товари, Label.New("Товари"), 0);

        // Таблична частина "Проводки"
        Проводки.HeightRequest = 300;
        NotebookTablePart.InsertPage(Проводки, Label.New("Проводки"), 1);

        NotebookTablePart.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 300;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //БанківськийРахунокОрганізації:
        БанківськийРахунокОрганізації.Caption = "БанківськийРахунокОрганізації";
        БанківськийРахунокОрганізації.WidthPresentation = 300;

        //БанківськийРахунокКонтрагента:
        БанківськийРахунокКонтрагента.Caption = "БанківськийРахунокКонтрагента";
        БанківськийРахунокКонтрагента.WidthPresentation = 300;

        //ДатаОплати:
        ДатаОплати.OnlyDate = true;

        //ЗамовленняКлієнта:
        ЗамовленняКлієнта.Caption = "ЗамовленняКлієнта";
        ЗамовленняКлієнта.WidthPresentation = 300;

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //ФормаОплати:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                ФормаОплати.Append(field.Value.ToString(), field.Name);
;
            ФормаОплати.AddController(FunctionForComboBox.DisableScrolling());
        }

        //ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
        }

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //Основа:
        Основа.BoundConfType = "Документи.РеалізаціяТоварівТаПослуг.Основа";

        //Статус:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиРеалізаціїТоварівТаПослуг_List())
                Статус.Append(field.Value.ToString(), field.Name);

            Статус.AddController(FunctionForComboBox.DisableScrolling());
        }

        //СпосібДоставки:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            СпосібДоставки.AddController(FunctionForComboBox.DisableScrolling());
        }

        //ДатаПоверненняТари:
        ДатаПоверненняТари.OnlyDate = true;

        //Коментар:
        Коментар.WidthRequest = 1200;
    }

    public static РеалізаціяТоварівТаПослуг_Елемент New()
    {
        РеалізаціяТоварівТаПослуг_Елемент element = NewWithProperties([]);
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
        //Каса
        CreateField(vBox, null, Каса);

        //Валюта
        CreateField(vBox, null, Валюта);

        //Склад
        CreateField(vBox, null, Склад);
    }

    protected override void CreateBottomStart(Box vBox)
    {
        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //Підрозділ
        CreateField(vBox, null, Підрозділ);

        //БанківськийрахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        //БанківськийрахунокОрганізації
        CreateField(vBox, null, БанківськийРахунокОрганізації);

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

        //Курс та Кратність
        CreateField(CreateField(vBox, "Курс:", Курс), "Кратність:", Кратність);

        //Узгоджений та ПовернутиТару
        CreateField(vBox, null, ПовернутиТару);

        //ДатаПоверненняТари
        CreateField(vBox, "Дата повернення тари:", ДатаПоверненняТари);

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
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
            Елемент.Валюта = await ЗначенняТипові.ОсновнаВалюта();
            Елемент.Каса = await ЗначенняТипові.ОсновнаКаса();
            Елемент.Склад = await ЗначенняТипові.ОсновнийСклад();
            Елемент.Контрагент = await ЗначенняТипові.ОсновнийПокупець();
            Елемент.Підрозділ = await ЗначенняТипові.ОсновнийПідрозділ();
            Елемент.БанківськийРахунокОрганізації = await ЗначенняТипові.ОсновнийБанківськийРахунок();

            Елемент.Курс = 1;
            Елемент.Кратність = 1;
        }

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
        Автор.Pointer = Елемент.Автор;
        Менеджер.Pointer = Елемент.Менеджер;
        ВідобразитиВБухгалтерськомуОбліку.Active = Елемент.ВідобразитиВБухгалтерськомуОбліку;

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        await Товари.LoadRecords();

        // Таблична частина "Проводки" 
        Проводки.ЕлементВласник = Елемент;
        await Проводки.LoadRecords();

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
        Елемент.Автор = Автор.Pointer;
        Елемент.Менеджер = Менеджер.Pointer;
        Елемент.ВідобразитиВБухгалтерськомуОбліку = ВідобразитиВБухгалтерськомуОбліку.Active;
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
                await Проводки.SaveRecords(); // Таблична частина "Проводки"

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
        CommonForms_DocumentMovementThroughRegisters.Create(new РеалізаціяТоварівТаПослуг_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
