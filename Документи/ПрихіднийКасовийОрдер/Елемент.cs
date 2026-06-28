
/*
        ПрихіднийКасовийОрдер_Елемент.cs
        Елемент
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;

using GeneratedCode.Константи;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using Функції = StorageAndTrade.ПрихіднийКасовийОрдер_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_fZGeAS8l6nGinTYuGzmiQ")]
partial class ПрихіднийКасовийОрдер_Елемент : DocumentFormElement
{
    public ПрихіднийКасовийОрдер_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = СтаттяРухуКоштів_PointerControl.New();
    Каси_PointerControl КасаВідправник = Каси_PointerControl.New();
    NumericControl Курс = NumericControl.New();
    Entry Коментар = Entry.New();
    NumericControl СумаДокументу = NumericControl.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "Проводки" 
    ПрихіднийКасовийОрдер_ТабличнаЧастина_Проводки Проводки = ПрихіднийКасовийОрдер_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(ПрихіднийКасовийОрдер_Const.FULLNAME, НомерДок, ДатаДок);
        CreateField(HBoxTop, null, ВідобразитиВБухгалтерськомуОбліку);
        CreateField(Interface.CommentBox, "Коментар:", Коментар);

        // Таблична частина "Проводки"
        Проводки.HeightRequest = 300;
        Interface.Notebook.InsertPage(Проводки, Label.New("Проводки"), 0);

        Interface.Notebook.SetCurrentPage(0);

        //НомерДок:
        НомерДок.WidthRequest = 100;

        //Організація:
        Організація.Caption = "Організація";
        Організація.WidthPresentation = 300;

        //Каса:
        Каса.Caption = "Каса";
        Каса.WidthPresentation = 300;

        //ГосподарськаОперація:
        {
            List<ГосподарськіОперації> list = [
                ГосподарськіОперації.ПоступленняОплатиВідКлієнта,
                ГосподарськіОперації.ПоступленняКоштівЗІншоїКаси,
                ГосподарськіОперації.ПоступленняКоштівЗБанку,
                ГосподарськіОперації.ПоверненняКоштівПостачальнику,
                ГосподарськіОперації.ІншіДоходи
            ];

            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List()
                .Where(x => list.Contains(x.Value)))
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            ГосподарськаОперація.Active = 0;
            ГосподарськаОперація.AddController(FunctionForComboBox.DisableScrolling());
            ГосподарськаОперація.OnChanged += (_, _) =>
            {
                switch (ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId))
                {
                    case ГосподарськіОперації.ПоступленняКоштівЗІншоїКаси:
                        {
                            КасаВідправник.Sensitive = true;
                            Курс.Sensitive = true;
                            Контрагент.Sensitive = false;
                            Договір.Sensitive = false;
                            БанківськийРахунок.Sensitive = false;

                            break;
                        }
                    case ГосподарськіОперації.ПоступленняКоштівЗБанку:
                        {
                            КасаВідправник.Sensitive = false;
                            Курс.Sensitive = false;
                            Контрагент.Sensitive = false;
                            Договір.Sensitive = false;
                            БанківськийРахунок.Sensitive = true;

                            break;
                        }
                    default:
                        {
                            КасаВідправник.Sensitive = false;
                            Курс.Sensitive = false;
                            Контрагент.Sensitive = true;
                            Договір.Sensitive = true;
                            БанківськийРахунок.Sensitive = false;

                            break;
                        }
                }
            };
        }

        //Основа:
        Основа.BoundConfType = "Документи.ПрихіднийКасовийОрдер.Основа";

        //Контрагент:
        Контрагент.Caption = "Контрагент";
        Контрагент.WidthPresentation = 300;

        //Договір:
        Договір.Caption = "Договір";
        Договір.WidthPresentation = 300;

        //БанківськийРахунок:
        БанківськийРахунок.Caption = "Банківський рахунок";
        БанківськийРахунок.WidthPresentation = 300;

        //Валюта:
        Валюта.Caption = "Валюта";
        Валюта.WidthPresentation = 300;

        //СтаттяРухуКоштів:
        СтаттяРухуКоштів.Caption = "Стаття руху коштів";
        СтаттяРухуКоштів.WidthPresentation = 300;

        //КасаВідправник:
        КасаВідправник.Caption = "Каса відправник";
        КасаВідправник.WidthPresentation = 300;

        //Коментар:
        Коментар.WidthRequest = 920;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;
    }

    public static ПрихіднийКасовийОрдер_Елемент New()
    {
        ПрихіднийКасовийОрдер_Елемент element = NewWithProperties([]);
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

        //Валюта
        CreateField(vBox, null, Валюта);
    }

    void CreateTopEnd(Box vBox)
    {
        //ГосподарськаОперація
        CreateField(vBox, "Господарська операція:", ГосподарськаОперація);

        //Каса
        CreateField(vBox, null, Каса);

        //КасаВідправник
        CreateField(vBox, null, КасаВідправник);

        //БанківськийРахунок
        CreateField(vBox, null, БанківськийРахунок);

        //СумаДокументу & Курс
        CreateField(CreateField(vBox, "Сума:", СумаДокументу), "Курс:", Курс);
    }

    void CreateBottomStart(Box vBox)
    {
        //Автор
        CreateField(vBox, null, Автор);

        //Основа
        CreateField(vBox, null, Основа);
    }

    void CreateBottomEnd(Box vBox)
    {
        //СтаттяРухуКоштів
        CreateField(vBox, null, СтаттяРухуКоштів);
    }

    #endregion

    #region Присвоєння / зчитування значень

    public override async Task AssignValue()
    {
        if (IsNew)
        {
            Елемент.Організація = await ЗначенняТипові.ОсновнаОрганізація();
            Елемент.Валюта = await ЗначенняТипові.ОсновнаВалюта();
            Елемент.Каса = await ЗначенняТипові.ОсновнаКаса(); ;
            Елемент.Контрагент = await ЗначенняТипові.ОсновнийПостачальник();
            Елемент.БанківськийРахунок = await ЗначенняТипові.ОсновнийБанківськийРахунок();
        }

        if (IsNew || Елемент.ГосподарськаОперація == 0)
            Елемент.ГосподарськаОперація = ГосподарськіОперації.ПоступленняОплатиВідКлієнта;

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        Каса.Pointer = Елемент.Каса;
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        Основа.Pointer = Елемент.Основа;
        Контрагент.Pointer = Елемент.Контрагент;
        Договір.Pointer = Елемент.Договір;
        БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
        Валюта.Pointer = Елемент.Валюта;
        СтаттяРухуКоштів.Pointer = Елемент.СтаттяРухуКоштів;
        КасаВідправник.Pointer = Елемент.КасаВідправник;
        Курс.Value = Елемент.Курс;
        Коментар.SetText(Елемент.Коментар);
        СумаДокументу.Value = Елемент.СумаДокументу;
        Автор.Pointer = Елемент.Автор;
        ВідобразитиВБухгалтерськомуОбліку.Active = Елемент.ВідобразитиВБухгалтерськомуОбліку;

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
        Елемент.Каса = Каса.Pointer;
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.Основа = Основа.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.СтаттяРухуКоштів = СтаттяРухуКоштів.Pointer;
        Елемент.КасаВідправник = КасаВідправник.Pointer;
        Елемент.Курс = Курс.Value;
        Елемент.Коментар = Коментар.GetText();
        Елемент.СумаДокументу = СумаДокументу.Value;
        Елемент.Автор = Автор.Pointer;
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
        CommonForms_DocumentMovementThroughRegisters.Create(new ПрихіднийКасовийОрдер_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
