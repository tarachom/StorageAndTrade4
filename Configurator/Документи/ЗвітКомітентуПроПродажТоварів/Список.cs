

/*     
        ЗвітКомітентуПроПродажТоварів.cs
        Список
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

using ТабличнийСписок = GeneratedCode.Документи.ТабличніСписки.ЗвітКомітентуПроПродажТоварів_Записи;
using Функції = StorageAndTrade.ЗвітКомітентуПроПродажТоварів_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormJournalFull>("List_jm6eAdyHjHGCM6X9xCOEGA")]
public partial class ЗвітКомітентуПроПродажТоварів_Список : DocumentFormJournalFull
{
    partial void Initialize()
    {
        TypeName = ЗвітКомітентуПроПродажТоварів_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50, Pages.StartingPosition.End);
    }

    public static ЗвітКомітентуПроПродажТоварів_Список New()
    {
        ЗвітКомітентуПроПродажТоварів_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    #region Override

    public override async Task LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    public override async Task UpdateRecords()
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

    protected override async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null)
    {
        await Функції.OpenPageElement(IsNew, uniqueID, CallBack_LoadRecords, CallBack_OnSelectPointer);
    }

    protected override async Task SetDeletionLabel(UniqueID uniqueID)
    {
        await Функції.SetDeletionLabel(uniqueID);
    }

    protected override async Task<UniqueID?> Copy(UniqueID uniqueID)
    {
        return await Функції.Copy(uniqueID);
    }

    protected override async Task BeforeSetValue()
    {
        await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(FormKey, Period);
    }

    protected override async void PeriodChanged()
    {
        ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(FormKey, Period.Period.ToString(), Period.DateStart, Period.DateStop);
    }

    protected override async Task SpendTheDocument(UniqueID[] uniqueID, bool spendDoc)
    {
        foreach (var uid in uniqueID)
            await Функції.SpendTheDocument(uid, spendDoc);
    }

    protected override void ReportSpendTheDocument(UniqueID[] uniqueID)
    {
        foreach (var uid in uniqueID)
            CommonForms_DocumentMovementThroughRegisters.Create(new ЗвітКомітентуПроПродажТоварів_Pointer(uid));
    }

    protected override async Task VersionsHistory(UniqueID[] uniqueID)
    {

    }

    #endregion
}
    