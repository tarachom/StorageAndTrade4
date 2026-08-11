
/*
        ВиготовленняПродукції_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using Функції = StorageAndTrade.ВиготовленняПродукції_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_kq6fAecf7nWZeqTwXD0dTw")]
partial class ВиготовленняПродукції_Елемент : DocumentFormElement
{
    public ВиготовленняПродукції_Object Елемент { get; init; } = new();

    #region Fields

    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Підстава = CompositePointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Склади_PointerControl СкладКомплектуючих = Склади_PointerControl.New();

    #endregion

    #region TabularParts

    // Таблична частина "ГотовийВиріб" 
    ВиготовленняПродукції_ТабличнаЧастина_ГотовийВиріб ГотовийВиріб = ВиготовленняПродукції_ТабличнаЧастина_ГотовийВиріб.New();

    // Таблична частина "Комплектуючі" 
    ВиготовленняПродукції_ТабличнаЧастина_Комплектуючі Комплектуючі = ВиготовленняПродукції_ТабличнаЧастина_Комплектуючі.New();

    // Таблична частина "Проводки" 
    ВиготовленняПродукції_ТабличнаЧастина_Проводки Проводки = ВиготовленняПродукції_ТабличнаЧастина_Проводки.New();

    #endregion

    #region Значення полів та таб частин на зовні (тільки читання)

    public СтруктураПідприємства_Pointer Підрозділ_Значення { get => Підрозділ.Pointer; }
    public Склади_Pointer СкладКомплектуючих_Значення { get => СкладКомплектуючих.Pointer; }

    /// <summary>
    /// Функція повертає рядки табличної частини ГотовийВиріб
    /// </summary>
    public List<ВиготовленняПродукції_ГотовийВиріб_TablePart.Record> ГотовийВиріб_Колекція() => ГотовийВиріб.GetRecords();

    /// <summary>
    /// Функція повертає рядки табличної частини Комплектуючі
    /// </summary>
    public List<ВиготовленняПродукції_Комплектуючі_TablePart.Record> Комплектуючі_Колекція() => Комплектуючі.GetRecords();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ВиготовленняПродукції_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "ГотовийВиріб"
        ГотовийВиріб.HeightRequest = 300;
        ГотовийВиріб.ЕлементВласник = Елемент;
        Interface.Notebook.InsertPage(ГотовийВиріб, Label.New("Готовий виріб"), 0);

        // Таблична частина "Комплектуючі"
        Комплектуючі.HeightRequest = 300;
        Комплектуючі.ЕлементВласник = Елемент;
        Комплектуючі.ЕлементВласникФорма = this;
        Interface.Notebook.InsertPage(Комплектуючі, Label.New("Комплектуючі"), 1);

        // Таблична частина "Проводки"
        Проводки.ЕлементВласник = Елемент;
        Проводки.HeightRequest = 300;
        Проводки.ЕлементВласникФорма = this;
        Проводки.ФункціяЗберегтиДокумент = async () => { GetValue(); return await Save(); };
        Interface.Notebook.InsertPage(Проводки, Label.New("Проводки"), 2);

        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Підстава:
        Підстава.Caption = "Підстава";
        Підстава.BoundConfType = "Документи.ВиготовленняПродукції.Підстава";

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //СкладКомплектуючих:
        СкладКомплектуючих.Caption = "Склад комплектуючих";
        СкладКомплектуючих.WidthPresentation = 300;
    }

    public static ВиготовленняПродукції_Елемент New()
    {
        ВиготовленняПродукції_Елемент element = NewWithProperties([]);
        element.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return element;
    }

    #region Interface

    FunctionForInterfaces.DocumentElement Interface = FunctionForInterfaces.ForDocument();

    protected override void BuildInterface()
    {
        Append(Interface.MainBox);

        CreateTopStart(Interface.TopStartBox);
        CreateTopEnd(Interface.TopEndBox);
        CreateBottomStart(Interface.BottomStartBox);
        CreateBottomEnd(Interface.BottomEndBox);
    }

    void CreateTopStart(Box vBox)
    {
        // Організація
        CreateField(vBox, null, Організація);

        // Підрозділ
        CreateField(vBox, null, Підрозділ);
    }

    void CreateTopEnd(Box vBox)
    {
        // СкладКомплектуючих
        CreateField(vBox, null, СкладКомплектуючих);
    }

    void CreateBottomStart(Box vBox)
    {
        // Підстава
        CreateField(vBox, null, Підстава);
    }

    void CreateBottomEnd(Box vBox)
    {
        // Автор
        CreateField(vBox, null, Автор);

        // Валюта
        CreateField(vBox, null, Валюта);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
            Елемент.Валюта = await ЗначенняТипові.ОсновнаВалюта();
            Елемент.СкладКомплектуючих = await ЗначенняТипові.ОсновнийСклад();
            Елемент.Підрозділ = await ЗначенняТипові.ОсновнийПідрозділ();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Коментар.SetText(Елемент.Коментар);
        Підстава.Pointer = Елемент.Підстава;
        Організація.Pointer = Елемент.Організація;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Автор.Pointer = Елемент.Автор;
        ВідобразитиВБухгалтерськомуОбліку.Active = Елемент.ВідобразитиВБухгалтерськомуОбліку;
        Валюта.Pointer = Елемент.Валюта;
        СкладКомплектуючих.Pointer = Елемент.СкладКомплектуючих;

        // Таблична частина "ГотовийВиріб" 
        await ГотовийВиріб.LoadRecords();

        // Таблична частина "Комплектуючі" 
        await Комплектуючі.LoadRecords();

        // Таблична частина "Проводки" 
        await Проводки.LoadRecords();
    }

    protected override void GetValue()
    {
        Елемент.НомерДок = НомерДок.GetText();
        Елемент.ДатаДок = ДатаДок.Value;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Підстава = Підстава.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Автор = Автор.Pointer;
        Елемент.ВідобразитиВБухгалтерськомуОбліку = ВідобразитиВБухгалтерськомуОбліку.Active;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.СкладКомплектуючих = СкладКомплектуючих.Pointer;
    }

    #endregion

    protected override async Task<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {
                await ГотовийВиріб.SaveRecords(); // Таблична частина "ГотовийВиріб"
                await Комплектуючі.SaveRecords(); // Таблична частина "Комплектуючі"
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ВиготовленняПродукції_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
