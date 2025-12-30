/*

Стартова сторінка

*/

namespace StorageAndTrade;

using InterfaceGtk4;
using AccountingSoftware;

using ТабличнийСписок = GeneratedCode.Документи.ТабличніСписки.ПоступленняТоварівТаПослуг_Записи;
using Функції = ПоступленняТоварівТаПослуг_Функції;

partial class PageHome2 : DocumentJournal
{
    public PageHome2()
    {
        TypeName = GeneratedCode.Документи.ПоступленняТоварівТаПослуг_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public override async ValueTask LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    public override async ValueTask UpdateRecords()
    {
        await ТабличнийСписок.UpdateRecords(this);
    }

    protected override async void SetSearch(string searchText)
    {
        WhereList = Функції.Відбори(searchText);
    }

    protected override void FillFilter(FilterControl filterControl)
    {
        ТабличнийСписок.CreateFilter(this);
    }

    protected override async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null)
    {
        await Функції.OpenPageElement(IsNew, unigueID, CallBack_LoadRecords, null);
    }

    protected override async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        await Функції.SetDeletionLabel(unigueID);
    }

    protected override async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        return await Функції.Copy(unigueID);
    }

    protected override async ValueTask BeforeSetValue()
    {
        await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(FormKey, Period);
    }

    protected override async void PeriodChanged()
    {
        ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(FormKey, Period.Period.ToString(), Period.DateStart, Period.DateStop);
        await LoadRecords();
    }

    protected override async ValueTask SpendTheDocument(UnigueID[] unigueID, bool spendDoc)
    {

    }

    protected override void ReportSpendTheDocument(UnigueID[] unigueID)
    {

    }

    protected override async ValueTask VersionsHistory(UnigueID[] unigueID)
    {

    }

    #region Ввести на основі

    protected override NameValue<Action<UnigueID[]>>[]? SetEnterDocumentBasedMenu()
    {
        return
        [
            new ("Документ", x=>{})
        ];
    }

    #endregion

    #region Друк

    protected override NameValue<Action<UnigueID[]>>[]? SetPrintMenu()
    {
        return
        [
            new ("Друк Документ", PrintDoc),
            new ("Друк Звіт", PrintDoc)
        ];
    }

    void PrintDoc(UnigueID[] unigueIDs)
    {
        foreach (var unigueID in unigueIDs)
            Console.WriteLine(unigueID);
    }

    #endregion

    #region Експорт

    protected override NameValue<Action<UnigueID[]>>[]? SetExportMenu()
    {
        return
        [
            new("Експорт в XML", ExportDoc),
            new("Експорт в Excel", ExportDoc)
        ];
    }

    void ExportDoc(UnigueID[] unigueIDs)
    {
        foreach (var unigueID in unigueIDs)
            Console.WriteLine(unigueID);
    }

    #endregion
}
