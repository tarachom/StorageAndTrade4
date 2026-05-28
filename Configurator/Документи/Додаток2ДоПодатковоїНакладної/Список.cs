

/*     
        Додаток2ДоПодатковоїНакладної.cs
        Список
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

using ТабличнийСписок = GeneratedCode.Документи.ТабличніСписки.Додаток2ДоПодатковоїНакладної_Записи;
using Функції = StorageAndTrade.Додаток2ДоПодатковоїНакладної_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormJournalFull>("List_OuZtXTGR0Clwsl1dv2sJw")]
public partial class Додаток2ДоПодатковоїНакладної_Список : DocumentFormJournalFull
{
    partial void Initialize()
    {
        TypeName = Додаток2ДоПодатковоїНакладної_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50, Pages.StartingPosition.End);
    }

    public static Додаток2ДоПодатковоїНакладної_Список New()
    {
        Додаток2ДоПодатковоїНакладної_Список list = NewWithProperties([]);
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
            CommonForms_DocumentMovementThroughRegisters.Create(new Додаток2ДоПодатковоїНакладної_Pointer(uid));
    }

    protected override async Task VersionsHistory(UniqueID[] uniqueID)
    {

    }

    #endregion
}
    