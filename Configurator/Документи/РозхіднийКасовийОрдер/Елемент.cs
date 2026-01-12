
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

class РозхіднийКасовийОрдер_Елемент : DocumentFormElement
{
    public РозхіднийКасовийОрдер_Objest Елемент { get; init; } = new();

    #region Fields
    Entry НомерДок = new();
    DateTimeControl ДатаДок = new();
    Організації_PointerControl Організація = new() { Caption = "Організація", WidthPresentation = 300 };
    Каси_PointerControl Каса = new() { Caption = "Каса", WidthPresentation = 300 };
    NumericControl СумаДокументу = new();
    NumericControl СумаДокументуПоКурсу = new();
    ComboBoxText ГосподарськаОперація = new ComboBoxText();
    Організації_PointerControl ОрганізаціяОтримувач = new() { Caption = "ОрганізаціяОтримувач", WidthPresentation = 300 };
    Контрагенти_PointerControl Контрагент = new() { Caption = "Контрагент", WidthPresentation = 300 };
    ДоговориКонтрагентів_PointerControl Договір = new() { Caption = "Договір", WidthPresentation = 300 };
    БанківськіРахункиОрганізацій_PointerControl БанківськийРахунок = new() { Caption = "БанківськийРахунок", WidthPresentation = 300 };
    Валюти_PointerControl Валюта = new() { Caption = "Валюта", WidthPresentation = 300 };
    СтаттяРухуКоштів_PointerControl СтаттяРухуКоштів = new() { Caption = "СтаттяРухуКоштів", WidthPresentation = 300 };
    Каси_PointerControl КасаОтримувач = new() { Caption = "КасаОтримувач", WidthPresentation = 300 };
    NumericControl Курс = new();
    CompositePointerControl Основа = new() { BoundConfType = "Документи.РозхіднийКасовийОрдер.Основа" };
    Entry Коментар = new() { WidthRequest = 300 };
    Користувачі_PointerControl Автор = new() { Caption = "Автор", WidthPresentation = 300 };

    #endregion

    #region TabularParts

    #endregion

    public РозхіднийКасовийОрдер_Елемент() : base(Program.BasicForm?.NotebookFunc)
    {
        Element = Елемент;

        CreateDocName(РозхіднийКасовийОрдер_Const.FULLNAME, НомерДок, ДатаДок);

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

        // СумаДокументу
        CreateField(vBox, "СумаДокументу:", СумаДокументу);

        // СумаДокументуПоКурсу
        CreateField(vBox, "СумаДокументуПоКурсу:", СумаДокументуПоКурсу);

        // ГосподарськаОперація
        CreateField(vBox, "ГосподарськаОперація:", ГосподарськаОперація);

        // ОрганізаціяОтримувач
        CreateField(vBox, null, ОрганізаціяОтримувач);

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

        // КасаОтримувач
        CreateField(vBox, null, КасаОтримувач);

        // Курс
        CreateField(vBox, "Курс:", Курс);

        // Основа
        CreateField(vBox, null, Основа);

        // Автор
        CreateField(vBox, null, Автор);

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

    }


    /*string КлючовіСловаДляПошуку()
    {
        return $"\n {Організація.Pointer.Назва} {Каса.Pointer.Назва} {ОрганізаціяОтримувач.Pointer.Назва} {Контрагент.Pointer.Назва} {Договір.Pointer.Назва} {БанківськийРахунок.Pointer.Назва} {Валюта.Pointer.Назва} {СтаттяРухуКоштів.Pointer.Назва} {КасаОтримувач.Pointer.Назва} {Автор.Pointer.Назва}"
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
        //СпільніФорми_РухДокументуПоРегістрах.СформуватиЗвіт(new РозхіднийКасовийОрдер_Pointer(unigueID));
    }

    protected override async ValueTask InJournal(UnigueID unigueID)
    {
        await Функції.OpenPageList(unigueID);
    }
}
