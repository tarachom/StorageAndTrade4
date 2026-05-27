

/*     
        РозміщенняНоменклатуриПоКоміркам.cs
        Список
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Документи;

using ТабличнийСписок = GeneratedCode.Документи.ТабличніСписки.РозміщенняНоменклатуриПоКоміркам_Записи;
using Функції = StorageAndTrade.РозміщенняНоменклатуриПоКоміркам_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormJournalSmall>("SmallList_wl8UvTKzQk29luhDBaiZKg")]
public partial class РозміщенняНоменклатуриПоКоміркам_ШвидкийВибір : DocumentFormJournalSmall
{
    partial void Initialize()
    {
        TypeName = РозміщенняНоменклатуриПоКоміркам_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static РозміщенняНоменклатуриПоКоміркам_ШвидкийВибір New()
    {
        РозміщенняНоменклатуриПоКоміркам_ШвидкийВибір list = NewWithProperties([]);
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

    protected override async Task OpenPageList(UniqueID? uniqueID = null)
    {
        await Функції.OpenPageList(uniqueID, CallBack_OnSelectPointer);
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
            CommonForms_DocumentMovementThroughRegisters.Create(new РозміщенняНоменклатуриПоКоміркам_Pointer(uid));
    }

    #endregion
}
    