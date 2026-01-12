
/*
        ПрихіднийКасовийОрдер_Елемент.cs
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
using Функції = StorageAndTrade.ПрихіднийКасовийОрдер_Функції;

namespace StorageAndTrade;

class ПрихіднийКасовийОрдер_Елемент : DocumentFormElement
{
    public ПрихіднийКасовийОрдер_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new();
    DateTimeControl ДатаДок = new();
    Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
    Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
    ComboBoxText ГосподарськаОперація = new ComboBoxText();
    CompositePointerControl Основа = new() { BoundConfType = "Документи.ПрихіднийКасовийОрдер.Основа" };
    Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
    ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = new() { Caption = "БанківськийРахунок", WidthPresentation = 300 };
    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
    СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = new() { Caption = "СтаттяРухуКоштів", WidthPresentation = 300 };
    Каси_PointerControl КасаВідправник = new() { Caption = "КасаВідправник", WidthPresentation = 300 };
    NumericControl Курс = new();
    Entry Коментар = new() { WidthRequest = 300 };
    NumericControl СумаДокументу = new();

    #endregion

    #region TabularParts

    #endregion

    public ПрихіднийКасовийОрдер_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(ПрихіднийКасовийОрдер_Const.FULLNAME, НомерДок, ДатаДок);

        CreateField(HBoxComment, "Коментар:", Коментар);

        {
            //Заповнення списку
            foreach (var field in ПсевдонімиПерелічення.ГосподарськіОперації_List())
                ГосподарськаОперація.Append(field.Value.ToString(), field.Name);

            //Заборона прокрутки списку
            EventControllerScroll controller = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
            ГосподарськаОперація.AddController(controller);
            controller.OnScroll += (_, _) => true;
        }

    }

    protected override void CreateTopStart(Box vBox)
    {

    }

    protected override void CreateTopEnd(Box vBox)
    {

    }

    protected override void CreateBottomStart(Box vBox)
    {

        // Організація
        CreateField(vBox, null, Організація);

        // Каса
        CreateField(vBox, null, Каса);

        // ГосподарськаОперація
        CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);

        // Основа
        CreateField(vBox, null, Основа);

        // Контрагент
        CreateField(vBox, null, Контрагент);

        // Договір
        CreateField(vBox, null, Договір);

        // БанківськийРахунок
        CreateField(vBox, null, БанківськийРахунок);

        // Валюта
        CreateField(vBox, null, Валюта);

        // СтаттяРухуКоштів
        CreateField(vBox, null, СтаттяРухуКоштів);

        // КасаВідправник
        CreateField(vBox, null, КасаВідправник);

        // Курс
        CreateField(vBox, "Курс:", Курс);

        // СумаДокументу
        CreateField(vBox, "СумаДокументу:", СумаДокументу);

    }

    protected override void CreateBottomEnd(Box vBox)
    {

    }

    #region Присвоєння / зчитування значень

    public override async ValueTask AssignValue()
    {
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

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Каса.Pointer.Назва} {Контрагент.Pointer.Назва} {Договір.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {Валюта.Pointer.Назва} {СтаттяРухуКоштів.Pointer.Назва} {КасаВідправник.Pointer.Назва}"
        ;
    }*/


    #endregion

    protected override async ValueTask<bool> Save()
    {
        bool isSaved = false;
        try
        {
            if (await Елемент.Save())
            {

                isSaved = true;
            }
        }
        catch (Exception ex)
        {
            //ФункціїДляПовідомлень.ДодатиПовідомлення(Елемент.GetBasis(), Caption, ex);
        }
        return isSaved;
    }

    protected override async ValueTask<bool> SpendTheDocument(bool spendDoc)
    {
        if (spendDoc)
        {
            bool isSpend = await Елемент.SpendTheDocument(Елемент.ДатаДок);
            //if (!isSpend) ФункціїДляПовідомлень.ПоказатиПовідомлення(Елемент.UnigueID);
            return isSpend;
        }
        else
        {
            await Елемент.ClearSpendTheDocument();
            return true;
        }
    }

    protected override void ReportSpendTheDocument(UnigueID unigueID)
    {
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new ПрихіднийКасовийОрдер_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
