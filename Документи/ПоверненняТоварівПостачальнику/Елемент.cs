
/*
        ПоверненняТоварівПостачальнику_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Константи;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.ПоверненняТоварівПостачальнику_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_0I2eATUh9HW7hpAGHQrSCQ")]
partial class ПоверненняТоварівПостачальнику_Елемент : DocumentFormElement
{
    public ПоверненняТоварівПостачальнику_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунокОрганізації = БанківськіРахункиОрганізацій_PointerControl.New();
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    ComboBoxText СпосібДоставки = ComboBoxText.New();
    Entry АдресДоставки = Entry.New();
    TimeControl ЧасДоставкиЗ = TimeControl.New();
    TimeControl ЧасДоставкиДо = TimeControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Entry Коментар = Entry.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ПоверненняТоварівПостачальнику_ТабличнаЧастина_Товари Товари = ПоверненняТоварівПостачальнику_ТабличнаЧастина_Товари.New();

    // Таблична частина "Проводки" 
    ПоверненняТоварівПостачальнику_ТабличнаЧастина_Проводки Проводки = ПоверненняТоварівПостачальнику_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПоверненняТоварівПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        Interface.Notebook.InsertPage(Товари, Label.New("Товари"), 0);

        // Таблична частина "Проводки"
        Проводки.HeightRequest = 300;
        Interface.Notebook.InsertPage(Проводки, Label.New("Проводки"), 1);
        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => x.Value == ГосподарськіОперації.ПоверненняТоварівПостачальнику))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.Active = 0;
            ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
        }

        //БанківськийРахунокОрганізації:
        БанківськийРахунокОрганізації.Caption = "Банківський рахунок організації";
        БанківськийРахунокОрганізації.WidthPresentation = 300;

        //БанківськийРахунокКонтрагента:
        БанківськийРахунокКонтрагента.Caption = "Банківський рахунок контрагента";
        БанківськийРахунокКонтрагента.WidthPresentation = 300;

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //СпосібДоставки:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            СпосібДоставки.Active = 0;
            СпосібДоставки.AddController(FunctionForComboBox.DisableScrolling());
        }

        //АдресДоставки:
        АдресДоставки.WidthRequest = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //Основа:
        Основа.BoundConfType = "Документи.ПоверненняТоварівПостачальнику.Основа";

        //Коментар:
        Коментар.WidthRequest = 920;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Менеджер:
        Менеджер.Caption = "Менеджер";
        Менеджер.WidthPresentation = 300;
    }

    public static ПоверненняТоварівПостачальнику_Елемент New()
    {
        ПоверненняТоварівПостачальнику_Елемент element = NewWithProperties([]);
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
        //Склад
        CreateField(vBox, null, Склад);

        //Каса
        CreateField(vBox, null, Каса);

        //Валюта
        CreateField(vBox, null, Валюта);
    }

    void CreateBottomStart(Box vBox)
    {
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

    void CreateBottomEnd(Box vBox)
    {
        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //СпосібДоставки
        CreateField(vBox, "Спосіб доставки:", СпосібДоставки);

        //ЧасДоставки
        CreateField(CreateField(vBox, "Час доставки з", ЧасДоставкиЗ), "до", ЧасДоставкиДо);
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
            Елемент.Контрагент = await ЗначенняТипові.ОсновнийПостачальник();
            Елемент.Підрозділ = await ЗначенняТипові.ОсновнийПідрозділ();
            Елемент.БанківськийРахунокОрганізації = await ЗначенняТипові.ОсновнийБанківськийРахунок();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        Контрагент.Pointer = Елемент.Контрагент;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Валюта.Pointer = Елемент.Валюта;
        Склад.Pointer = Елемент.Склад;
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        БанківськийРахунокОрганізації.Pointer = Елемент.БанківськийРахунокОрганізації;
        БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
        Договір.Pointer = Елемент.Договір;
        СпосібДоставки.ActiveId = Елемент.СпосібДоставки.ToString();
        АдресДоставки.SetText(Елемент.АдресДоставки);
        ЧасДоставкиЗ.Value = Елемент.ЧасДоставкиЗ;
        ЧасДоставкиДо.Value = Елемент.ЧасДоставкиДо;
        Каса.Pointer = Елемент.Каса;
        Основа.Pointer = Елемент.Основа;
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
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.БанківськийРахунокОрганізації = БанківськийРахунокОрганізації.Pointer;
        Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.СпосібДоставки = ПсевдонімиПерелічення.СпособиДоставки_FindByName(СпосібДоставки.ActiveId);
        Елемент.АдресДоставки = АдресДоставки.GetText();
        Елемент.ЧасДоставкиЗ = ЧасДоставкиЗ.Value;
        Елемент.ЧасДоставкиДо = ЧасДоставкиДо.Value;
        Елемент.Каса = Каса.Pointer;
        Елемент.Основа = Основа.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Автор = Автор.Pointer;
        Елемент.Менеджер = Менеджер.Pointer;
        Елемент.ВідобразитиВБухгалтерськомуОбліку = ВідобразитиВБухгалтерськомуОбліку.Active;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПоверненняТоварівПостачальнику_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
