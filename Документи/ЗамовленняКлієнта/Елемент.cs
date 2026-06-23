
/*
        ЗамовленняКлієнта_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.ЗамовленняКлієнта_Функції;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_ZI2eAW45PH2rw6Lf0pZ5Xw")]
partial class ЗамовленняКлієнта_Елемент : DocumentFormElement
{
    public ЗамовленняКлієнта_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    ComboBoxText Статус = ComboBoxText.New();
    CheckButton Узгоджений = CheckButton.NewWithLabel("Узгоджений");
    ComboBoxText ФормаОплати = ComboBoxText.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    NumericControl СумаАвансуДоЗабезпечення = NumericControl.New();
    NumericControl СумаПередоплатиДоВідгрузки = NumericControl.New();
    DateTimeControl ДатаВідгрузки = DateTimeControl.New();
    Entry АдресаДоставки = Entry.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    ComboBoxText СпосібДоставки = ComboBoxText.New();
    TimeControl ЧасДоставкиЗ = TimeControl.New();
    TimeControl ЧасДоставкиДо = TimeControl.New();
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    DateTimeControl ДатаПоверненняТари = DateTimeControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ЗамовленняКлієнта_ТабличнаЧастина_Товари Товари = ЗамовленняКлієнта_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ЗамовленняКлієнта_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        Interface.Notebook.InsertPage(Товари, Label.New("Товари"), 0);
        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 300;

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //Статус:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиЗамовленьКлієнтів_List())
                Статус.Append(field.Value.ToString(), field.Name);

            Статус.Active = 0;
            Статус.AddController(FunctionForComboBox.DisableScrolling());
        }

        //ФормаОплати:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ФормаОплати_List())
                ФормаОплати.Append(field.Value.ToString(), field.Name);

            ФормаОплати.Active = 0;
            ФормаОплати.AddController(FunctionForComboBox.DisableScrolling());
        }

        //БанківськийРахунок:
        БанківськийРахунок.Caption = "Банківський рахунок";
        БанківськийРахунок.WidthPresentation = 300;

        //БанківськийРахунокКонтрагента:
        БанківськийРахунокКонтрагента.Caption = "Банківський рахунок контрагента";
        БанківськийРахунокКонтрагента.WidthPresentation = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //ДатаВідгрузки:
        ДатаВідгрузки.OnlyDate = true;

        //АдресаДоставки:
        АдресаДоставки.WidthRequest = 300;

        //ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => x.Value == ГосподарськіОперації.ПлануванняПоЗамовленнямКлієнта))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.Active = 0;
            ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
        }

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //СпосібДоставки:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            СпосібДоставки.Active = 0;
            СпосібДоставки.AddController(FunctionForComboBox.DisableScrolling());
        }

        //ДатаПоверненняТари:
        ДатаПоверненняТари.OnlyDate = true;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.ЗамовленняКлієнта.Основа";

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Менеджер:
        Менеджер.Caption = "Менеджер";
        Менеджер.WidthPresentation = 300;
    }

    public static ЗамовленняКлієнта_Елемент New()
    {
        ЗамовленняКлієнта_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DocumentElement Interface;

    protected override void BuildInterface()
    {
        Interface = FunctionForInterfaces.ForDocument();

        Append(Interface.MainBox);

        CreateTopStart(Interface.TopStartBox);
        CreateTopEnd(Interface.TopEndBox);
        CreateBottomStart(Interface.BottomStartBox);
        CreateBottomEnd(Interface.BottomEndBox);
    }

    void CreateTopStart(Box vBox)
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

    void CreateTopEnd(Box vBox)
    {
        //Каса
        CreateField(vBox, null, Каса);

        //Валюта
        CreateField(vBox, null, Валюта);

        //Склад
        CreateField(vBox, null, Склад);
    }

    void CreateBottomStart(Box vBox)
    {
        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //Підрозділ
        CreateField(vBox, null, Підрозділ);

        //БанківськийрахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        //Автор
        CreateField(vBox, null, Автор);

        //Менеджер
        CreateField(vBox, null, Менеджер);

        // Основа
        CreateField(vBox, null, Основа);
    }

    void CreateBottomEnd(Box vBox)
    {
        //ФормаОплати
        CreateField(vBox, "Форма оплати:", ФормаОплати);

        //СпосібДоставки
        CreateField(vBox, "Спосіб доставки:", СпосібДоставки);

        //ДатаВідгрузки
        CreateField(vBox, "Дата відвантаження:", ДатаВідгрузки);

        //ЧасДоставки
        CreateField(CreateField(vBox, "Час доставки з", ЧасДоставкиЗ), "до", ЧасДоставкиДо);

        //Узгоджений & ВернутиТару
        CreateField(CreateField(vBox, null, Узгоджений), null, ПовернутиТару);

        //ДатаПоверненняТари
        CreateField(vBox, "Дата повернення тари:", ДатаПоверненняТари);
    }

    #endregion

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
        }

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
        Автор.Pointer = Елемент.Автор;
        Менеджер.Pointer = Елемент.Менеджер;

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
        Елемент.Автор = Автор.Pointer;
        Елемент.Менеджер = Менеджер.Pointer;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗамовленняКлієнта_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
