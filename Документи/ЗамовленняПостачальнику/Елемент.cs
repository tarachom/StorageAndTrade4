
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

[GObject.Subclass<DocumentFormElement>("Element_vo2eAV4uLXC87YiA2zid9g")]
partial class ЗамовленняПостачальнику_Елемент : DocumentFormElement
{
    public ЗамовленняПостачальнику_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    DateTimeControl ДатаПоступлення = DateTimeControl.New();
    Entry АдресаДоставкиДляПостачальника = Entry.New();
    CheckButton ПовернутиТару = CheckButton.NewWithLabel("ПовернутиТару");
    ComboBoxText СпосібДоставки = ComboBoxText.New();
    TimeControl ЧасДоставкиЗ = TimeControl.New();
    TimeControl ЧасДоставкиДо = TimeControl.New();
    Entry АдресаДоставки = Entry.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    ComboBoxText Статус = ComboBoxText.New();
    ComboBoxText ФормаОплати = ComboBoxText.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Entry Коментар = Entry.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ЗамовленняПостачальнику_ТабличнаЧастина_Товари Товари = ЗамовленняПостачальнику_ТабличнаЧастина_Товари.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ЗамовленняПостачальнику_Const.FULLNAME, НомерДок, ДатаДок);
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

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //БанківськийРахунок:
        БанківськийРахунок.Caption = "Банківський рахунок";
        БанківськийРахунок.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //ДатаПоступлення:
        ДатаПоступлення.OnlyDate = true;

        //АдресаДоставкиДляПостачальника:
        АдресаДоставкиДляПостачальника.WidthRequest = 300;

        //СпосібДоставки:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СпособиДоставки_List())
                СпосібДоставки.Append(field.Value.ToString(), field.Name);

            СпосібДоставки.Active = 0;
            СпосібДоставки.AddController(FunctionForComboBox.DisableScrolling());
        }

        //АдресаДоставки:
        АдресаДоставки.WidthRequest = 300;

        //ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => x.Value == ГосподарськіОперації.ПлануванняПоЗамовленнямПостачальнику))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.Active = 0;
            ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
        }

        //Статус:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.СтатусиЗамовленьПостачальникам_List())
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

        //Менеджер:
        Менеджер.Caption = "Менеджер";
        Менеджер.WidthPresentation = 300;

        //Основа:
        Основа.BoundConfType = "Документи.ЗамовленняПостачальнику.Основа";

        //Коментар:
        Коментар.WidthRequest = 920;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;
    }

    public static ЗамовленняПостачальнику_Елемент New()
    {
        ЗамовленняПостачальнику_Елемент element = NewWithProperties([]);
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
        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //Підрозділ
        CreateField(vBox, null, Підрозділ);

        //БанківськийРахунок
        CreateField(vBox, null, БанківськийРахунок);

        //Автор
        CreateField(vBox, null, Автор);

        //Менеджер
        CreateField(vBox, null, Менеджер);

        //Основа
        CreateField(vBox, null, Основа);
    }

    void CreateBottomEnd(Box vBox)
    {
        //ФормаОплати
        CreateField(vBox, "Форма оплати:", ФормаОплати);

        //ВернутиТару
        CreateField(vBox, null, ПовернутиТару);

        //ДатаПоступлення
        CreateField(vBox, "Дата поступлення:", ДатаПоступлення);

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
        }

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
        Автор.Pointer = Елемент.Автор;

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
        Елемент.Автор = Автор.Pointer;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ЗамовленняПостачальнику_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
