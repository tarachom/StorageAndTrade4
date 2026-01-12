/*

Стартова сторінка

*/

namespace StorageAndTrade;

using InterfaceGtk4;
using AccountingSoftware;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Номенклатура_Записи;
using Функції = Номенклатура_Функції;
using Константи = GeneratedCode.Довідники.Номенклатура_Const;

partial class Номенклатура : DirectoryFormJournalFull
{
    public Номенклатура(): base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = Константи.POINTER;
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

    }

    protected override async ValueTask VersionsHistory(UnigueID[] unigueID)
    {

    }

    #region Друк

    protected override NameValue<Action<UnigueID[]>>[]? SetPrintMenu() => null;

    #endregion

    #region Експорт

    protected override NameValue<Action<UnigueID[]>>[]? SetExportMenu() => null;

    #endregion
}
