/*

Стартова сторінка

*/

namespace StorageAndTrade;

using InterfaceGtk4;
using AccountingSoftware;
using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Номенклатура_Записи;
using Функції = Номенклатура_Функції;

partial class PageHome2 : DocumentJournal
{
    public PageHome2()
    {
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(100);
    }

    public override async ValueTask SetValue()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    public override async ValueTask LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
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

    }

    protected override async void PeriodChanged()
    {

    }

    protected override async ValueTask SpendTheDocument(UnigueID unigueID, bool spendDoc)
    {

    }

    protected override void ReportSpendTheDocument(UnigueID unigueID)
    {

    }
}
