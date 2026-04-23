

/*     
        РозміщенняТоварівНаСкладі.cs
        Список
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

using ТабличнийСписок = GeneratedCode.Документи.ТабличніСписки.РозміщенняТоварівНаСкладі_Записи;
using Функції = StorageAndTrade.РозміщенняТоварівНаСкладі_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormJournalFull>("List_AY5BK61UUy0PKABW6irDg")]
public partial class РозміщенняТоварівНаСкладі_Список : DocumentFormJournalFull
{
    partial void Initialize()
    {
        TypeName = РозміщенняТоварівНаСкладі_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50, Pages.StartingPosition.End);
    }

    public static РозміщенняТоварівНаСкладі_Список New()
    {
        РозміщенняТоварівНаСкладі_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
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

    protected override async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null)
    {
        await Функції.OpenPageElement(IsNew, uniqueID, CallBack_LoadRecords, CallBack_OnSelectPointer);
    }

    protected override async ValueTask SetDeletionLabel(UniqueID uniqueID)
    {
        await Функції.SetDeletionLabel(uniqueID);
    }

    protected override async ValueTask<UniqueID?> Copy(UniqueID uniqueID)
    {
        return await Функції.Copy(uniqueID);
    }

    protected override async ValueTask BeforeSetValue()
    {
        await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(FormKey, Period);
    }

    protected override async void PeriodChanged()
    {
        ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(FormKey, Period.Period.ToString(), Period.DateStart, Period.DateStop);
    }

    protected override async ValueTask SpendTheDocument(UniqueID[] uniqueID, bool spendDoc)
    {

    }

    protected override void ReportSpendTheDocument(UniqueID[] uniqueID)
    {
        foreach (var uid in uniqueID)
            CommonForms_DocumentMovementThroughRegisters.Create(new РозміщенняТоварівНаСкладі_Pointer(uid));
    }

    protected override async ValueTask VersionsHistory(UniqueID[] uniqueID)
    {

    }

    #endregion
}
    