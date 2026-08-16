
/*
        РахунокФактура_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Константи;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.РахунокФактура_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_KY2eARCjH635ZM4HlA5QA")]
partial class РахунокФактура_Елемент : DocumentFormElement
{
    public РахунокФактура_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    Склади_PointerControl Склад = Склади_PointerControl.New();
    DropDownControl Статус = DropDownControl.New();
    DropDownControl ФормаОплати = DropDownControl.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
    БанківськіРахункиКонтрагентів_PointerControl БанківськийРахунокКонтрагента = БанківськіРахункиКонтрагентів_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    DropDownControl ГосподарськаОперація = DropDownControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    СтруктураПідприємства_PointerControl Підрозділ = СтруктураПідприємства_PointerControl.New();
    Entry Коментар = Entry.New();
    CompositePointerControl Підстава = CompositePointerControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    Користувачі_PointerControl Менеджер = Користувачі_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "Товари" 
    РахунокФактура_ТабличнаЧастина_Товари Товари = РахунокФактура_ТабличнаЧастина_Товари.New();

    // Таблична частина "Проводки" 
    РахунокФактура_ТабличнаЧастина_Проводки Проводки = РахунокФактура_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(РахунокФактура_Const.FULLNAME, НомерДок, ДатаДок);
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
        Статус.Fill(ПсевдонімиПерелічення.СтатусиЗамовленьКлієнтів_Dict());
        
        //ФормаОплати:
        ФормаОплати.Fill(ПсевдонімиПерелічення.ФормаОплати_Dict());
        
        //БанківськийРахунок:
        БанківськийРахунок.Caption = "Банківський рахунок";
        БанківськийРахунок.WidthPresentation = 300;

        //БанківськийРахунокКонтрагента:
        БанківськийРахунокКонтрагента.Caption = "Банківський рахунок контрагента";
        БанківськийРахунокКонтрагента.WidthPresentation = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //ГосподарськаОперація:
        {
            ГосподарськаОперація.AllowEmpty = false;
            
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => x.Value == ГосподарськіОперації.ПлануванняПоЗамовленнямКлієнта))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);
        }

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //Підрозділ:
        Підрозділ.Caption = "Підрозділ";
        Підрозділ.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Підстава:
        Підстава.BoundConfType = "Документи.РахунокФактура.Підстава";

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;

        //Менеджер:
        Менеджер.Caption = "Менеджер";
        Менеджер.WidthPresentation = 300;
    }

    public static РахунокФактура_Елемент New()
    {
        РахунокФактура_Елемент element = NewWithProperties([]);
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

        //Автор
        CreateField(vBox, null, Автор);

        //Менеджер
        CreateField(vBox, null, Менеджер);

        //Підстава
        CreateField(vBox, null, Підстава);
    }

    void CreateBottomEnd(Box vBox)
    {
        //ФормаОплати
        CreateField(vBox, "Форма оплати:", ФормаОплати);

        //БанківськийрахунокКонтрагента
        CreateField(vBox, null, БанківськийРахунокКонтрагента);

        //БанківськийрахунокОрганізації
        CreateField(vBox, null, БанківськийРахунок);
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
            Елемент.БанківськийРахунок = await ЗначенняТипові.ОсновнийБанківськийРахунок();
        }

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Контрагент.Pointer = Елемент.Контрагент;
        Організація.Pointer = Елемент.Організація;
        Валюта.Pointer = Елемент.Валюта;
        Склад.Pointer = Елемент.Склад;
        Статус.Value = Елемент.Статус.ToString();
        ФормаОплати.Value = Елемент.ФормаОплати.ToString();
        БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
        БанківськийРахунокКонтрагента.Pointer = Елемент.БанківськийРахунокКонтрагента;
        Каса.Pointer = Елемент.Каса;
        ГосподарськаОперація.Value = Елемент.ГосподарськаОперація.ToString();
        Договір.Pointer = Елемент.Договір;
        Підрозділ.Pointer = Елемент.Підрозділ;
        Коментар.SetText(Елемент.Коментар);
        Підстава.Pointer = Елемент.Підстава;
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
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Організація = Організація.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.Склад = Склад.Pointer;
        Елемент.Статус = ПсевдонімиПерелічення.СтатусиЗамовленьКлієнтів_FindByName(Статус.Value);
        Елемент.ФормаОплати = ПсевдонімиПерелічення.ФормаОплати_FindByName(ФормаОплати.Value);
        Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
        Елемент.БанківськийРахунокКонтрагента = БанківськийРахунокКонтрагента.Pointer;
        Елемент.Каса = Каса.Pointer;
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.Value);
        Елемент.Договір = Договір.Pointer;
        Елемент.Підрозділ = Підрозділ.Pointer;
        Елемент.Коментар = Коментар.GetText();
        Елемент.Підстава = Підстава.Pointer;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new РахунокФактура_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
