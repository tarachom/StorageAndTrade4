
/*
        РозхіднийКасовийОрдер_Елемент.cs
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
using Функції = StorageAndTrade.РозхіднийКасовийОрдер_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormElement>("Element_f5GeASAr1naRVLaQ6YvwQ")]
partial class РозхіднийКасовийОрдер_Елемент : DocumentFormElement
{
    public РозхіднийКасовийОрдер_Object Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = Entry.New();
    DateTimeControl ДатаДок = DateTimeControl.New();
    Організації_PointerControl Організація = Організації_PointerControl.New();
    Каси_PointerControl Каса = Каси_PointerControl.New();
    NumericControl СумаДокументу = NumericControl.New();
    NumericControl СумаДокументуПоКурсу = NumericControl.New();
    ComboBoxText ГосподарськаОперація = ComboBoxText.New();
    Організації_PointerControl ОрганізаціяОтримувач = Організації_PointerControl.New();
    Контрагенти_PointerControl Контрагент = Контрагенти_PointerControl.New();
    ДоговориКонтрагентів_PointerControl Договір = ДоговориКонтрагентів_PointerControl.New();
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = БанківськіРахункиОрганізацій_PointerControl.New();
    Валюти_PointerControl Валюта = Валюти_PointerControl.New();
    СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = СтаттяРухуКоштів_PointerControl.New();
    Каси_PointerControl КасаОтримувач = Каси_PointerControl.New();
    NumericControl Курс = NumericControl.New();
    CompositePointerControl Основа = CompositePointerControl.New();
    Entry Коментар = Entry.New();
    Користувачі_PointerControl Автор = Користувачі_PointerControl.New();
    CheckButton ВідобразитиВБухгалтерськомуОбліку = CheckButton.NewWithLabel("Відобразити в бух обліку");

    #endregion

    #region TabularParts

    // Таблична частина "Проводки" 
    РозхіднийКасовийОрдер_ТабличнаЧастина_Проводки Проводки = РозхіднийКасовийОрдер_ТабличнаЧастина_Проводки.New();

    #endregion

    partial void Initialize()
    {
        Element = Елемент;

        CreateDocName(РозхіднийКасовийОрдер_Const.FULLNAME, НомерДок, ДатаДок);
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
                ГосподарськіОперації.ОплатаПостачальнику,
                ГосподарськіОперації.ВидачаКоштівВІншуКасу,
                ГосподарськіОперації.ЗдачаКоштівВБанк,
                ГосподарськіОперації.ІншіВитрати,
                ГосподарськіОперації.ПоверненняОплатиКлієнту
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
                    case ГосподарськіОперації.ВидачаКоштівВІншуКасу:
                        {
                            КасаОтримувач.Sensitive = true;
                            Курс.Sensitive = true;
                            Контрагент.Sensitive = false;
                            Договір.Sensitive = false;
                            БанківськийРахунок.Sensitive = false;

                            break;
                        }
                    case ГосподарськіОперації.ЗдачаКоштівВБанк:
                        {
                            КасаОтримувач.Sensitive = false;
                            Курс.Sensitive = false;
                            Контрагент.Sensitive = false;
                            Договір.Sensitive = false;
                            БанківськийРахунок.Sensitive = true;

                            break;
                        }
                    default:
                        {
                            КасаОтримувач.Sensitive = false;
                            Курс.Sensitive = false;
                            Контрагент.Sensitive = true;
                            Договір.Sensitive = true;
                            БанківськийРахунок.Sensitive = false;

                            break;
                        }
                }
            };
        }

        //ОрганізаціяОтримувач:
        ОрганізаціяОтримувач.Caption = "Організація отримувач";
        ОрганізаціяОтримувач.WidthPresentation = 300;

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

        //КасаОтримувач:
        КасаОтримувач.Caption = "Каса отримувач";
        КасаОтримувач.WidthPresentation = 300;

        //Основа:
        Основа.BoundConfType = "Документи.РозхіднийКасовийОрдер.Основа";

        //Коментар:
        Коментар.WidthRequest = 920;

        //Автор:
        Автор.Caption = "Автор";
        Автор.WidthPresentation = 300;
    }

    public static РозхіднийКасовийОрдер_Елемент New()
    {
        РозхіднийКасовийОрдер_Елемент element = NewWithProperties([]);
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

        //КасаОтримувач
        CreateField(vBox, null, КасаОтримувач);

        //БанківськийРахунок
        CreateField(vBox, null, БанківськийРахунок);

        //СумаДокументу та Курс
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
            Елемент.ГосподарськаОперація = ГосподарськіОперації.ОплатаПостачальнику;

        НомерДок.SetText(Елемент.НомерДок);
        ДатаДок.Value = Елемент.ДатаДок;
        Організація.Pointer = Елемент.Організація;
        Каса.Pointer = Елемент.Каса;
        СумаДокументу.Value = Елемент.СумаДокументу;
        СумаДокументуПоКурсу.Value = Елемент.СумаДокументуПоКурсу;
        ГосподарськаОперація.ActiveId = Елемент.ГосподарськаОперація.ToString();
        ОрганізаціяОтримувач.Pointer = Елемент.ОрганізаціяОтримувач;
        Контрагент.Pointer = Елемент.Контрагент;
        Договір.Pointer = Елемент.Договір;
        БанківськийРахунок.Pointer = Елемент.БанківськийРахунок;
        Валюта.Pointer = Елемент.Валюта;
        СтаттяРухуКоштів.Pointer = Елемент.СтаттяРухуКоштів;
        КасаОтримувач.Pointer = Елемент.КасаОтримувач;
        Курс.Value = Елемент.Курс;
        Основа.Pointer = Елемент.Основа;
        Коментар.SetText(Елемент.Коментар);
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
        Елемент.СумаДокументу = СумаДокументу.Value;
        Елемент.СумаДокументуПоКурсу = СумаДокументуПоКурсу.Value;
        Елемент.ГосподарськаОперація = ПсевдонімиПерелічення.ГосподарськіОперації_FindByName(ГосподарськаОперація.ActiveId);
        Елемент.ОрганізаціяОтримувач = ОрганізаціяОтримувач.Pointer;
        Елемент.Контрагент = Контрагент.Pointer;
        Елемент.Договір = Договір.Pointer;
        Елемент.БанківськийРахунок = БанківськийРахунок.Pointer;
        Елемент.Валюта = Валюта.Pointer;
        Елемент.СтаттяРухуКоштів = СтаттяРухуКоштів.Pointer;
        Елемент.КасаОтримувач = КасаОтримувач.Pointer;
        Елемент.Курс = Курс.Value;
        Елемент.Основа = Основа.Pointer;
        Елемент.Коментар = Коментар.GetText();
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
        CommonForms_DocumentMovementThroughRegisters.Create(new РозхіднийКасовийОрдер_Pointer(uniqueID));
    }

    protected override async Task InJournal(UniqueID uniqueID)
    {
        await Функції.OpenPageList(uniqueID);
    }
}
