
/*
        ВведенняЗалишків_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.ВведенняЗалишків_Функції;
using GeneratedCode.Константи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_PVohcj3O0ynLcwqwWKJLA")]
partial class ВведенняЗалишків_Елемент : DocumentFormElement
{
    public ВведенняЗалишків_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    ВведенняЗалишків_ТабличнаЧастина_Товари Товари = ВведенняЗалишків_ТабличнаЧастина_Товари.New();

    // Таблична частина "Каси" 
    ВведенняЗалишків_ТабличнаЧастина_Каси Каси = ВведенняЗалишків_ТабличнаЧастина_Каси.New();

    // Таблична частина "БанківськіРахунки" 
    ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки БанківськіРахунки = ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки.New();

    // Таблична частина "РозрахункиЗКонтрагентами" 
    ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами РозрахункиЗКонтрагентами = ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами.New();

    // Таблична частина "Проводки" 
    ВведенняЗалишків_ТабличнаЧастина_Проводки Проводки = ВведенняЗалишків_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ВведенняЗалишків_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Товари"
        Товари.HeightRequest = 300;
        Interface.Notebook.InsertPage(Товари, Label.New("Товари"), 0);

        // Таблична частина "Каси"
        Каси.HeightRequest = 300;
        Interface.Notebook.InsertPage(Каси, Label.New("Каси"), 1);

        // Таблична частина "БанківськіРахунки"
        БанківськіРахунки.HeightRequest = 300;
        Interface.Notebook.InsertPage(БанківськіРахунки, Label.New("Банківські рахунки"), 2);

        // Таблична частина "РозрахункиЗКонтрагентами"
        РозрахункиЗКонтрагентами.HeightRequest = 300;
        Interface.Notebook.InsertPage(РозрахункиЗКонтрагентами, Label.New("Розрахунки з контрагентами"), 3);

        // Таблична частина "Проводки"
        Проводки.HeightRequest = 300;
        Interface.Notebook.InsertPage(Проводки, Label.New("Проводки"), 4);

        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Склад:
        Склад.Caption = "Склад";
        Склад.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //ГосподарськаОперація:
        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => x.Value == ГосподарськіОперації.ВведенняЗалишків))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.Active = 0;
            ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
        }

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Основа:
        Основа.BoundConfType = "Документи.ВведенняЗалишків.Основа";
    }

    public static ВведенняЗалишків_Елемент New()
    {
        ВведенняЗалишків_Елемент element = NewWithProperties([]);
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

        //Валюта
        CreateField(vBox, null, Валюта);
    }

    void CreateBottomStart(Box vBox)
    {
        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //Підрозділ
        CreateField(vBox, null, Підрозділ);
    }

    void CreateBottomEnd(Box vBox)
    {
        //Основа
        CreateField(vBox, null, Основа);

        //Автор
        CreateField(vBox, null, Автор);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
            Елемент.Валюта = await ЗначенняТипові.ОсновнаВалюта();
            Елемент.Склад = await ЗначенняТипові.ОсновнийСклад();
            Елемент.Контрагент = await ЗначенняТипові.ОсновнийПостачальник();
            Елемент.Підрозділ = await ЗначенняТипові.ОсновнийПідрозділ();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Склад.Pointer = Елемент.Склад;
        Валюта.Pointer = Елемент.Валюта;
        Контрагент.Pointer = Елемент.Контрагент;
        Договір.Pointer = Елемент.Договір;
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        Автор.Pointer = Елемент.Автор;
        Коментар.SetText(Елемент.Коментар);
        Основа.Pointer = Елемент.Основа;
        ВідобразитиВБухгалтерськомуОбліку.Active = Елемент.ВідобразитиВБухгалтерськомуОбліку;

        // Таблична частина "Товари" 
        Товари.ЕлементВласник = Елемент;
        await Товари.LoadRecords();

        // Таблична частина "Каси" 
        Каси.ЕлементВласник = Елемент;
        await Каси.LoadRecords();

        // Таблична частина "БанківськіРахунки" 
        БанківськіРахунки.ЕлементВласник = Елемент;
        await БанківськіРахунки.LoadRecords();

        // Таблична частина "РозрахункиЗКонтрагентами" 
        РозрахункиЗКонтрагентами.ЕлементВласник = Елемент;
        await РозрахункиЗКонтрагентами.LoadRecords();

        // Таблична частина "Проводки" 
        Проводки.ЕлементВласник = Елемент;
        await Проводки.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Організація = Організація.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.Автор = Автор.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Основа = Основа.Pointer;
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
                await Каси.SaveRecords(); // Таблична частина "Каси"
                await БанківськіРахунки.SaveRecords(); // Таблична частина "БанківськіРахунки"
                await РозрахункиЗКонтрагентами.SaveRecords(); // Таблична частина "РозрахункиЗКонтрагентами"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ВведенняЗалишків_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
