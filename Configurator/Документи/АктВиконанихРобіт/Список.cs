

/*     
        АктВиконанихРобіт.cs
        Список
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

using ТабличнийСписок = GeneratedCode.Документи.ТабличніСписки.АктВиконанихРобіт_Записи;
using Функції = StorageAndTrade.АктВиконанихРобіт_Функції;

namespace StorageAndTrade;

public class АктВиконанихРобіт_Список : DocumentFormJournalFull
{
    public АктВиконанихРобіт_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = АктВиконанихРобіт_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50, Pages.StartingPosition.End);
    }

    #region Override

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
        await Функції.OpenPageElement(IsNew, unigueID, CallBack_LoadRecords, CallBack_OnSelectPointer);
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

    #endregion
}
    