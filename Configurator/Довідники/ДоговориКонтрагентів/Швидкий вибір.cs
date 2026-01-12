
/*     
        ДоговориКонтрагентів_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.ДоговориКонтрагентів_ЗаписиШвидкийВибір;
using Функції = StorageAndTrade.ДоговориКонтрагентів_Функції;

namespace StorageAndTrade;

class ДоговориКонтрагентів_ШвидкийВибір : DirectoryFormJournalSmall
{
    
    public Контрагенти_PointerControl Власник = new Контрагенти_PointerControl() { Caption = "Контрагент:" };
    
    
    public ДоговориКонтрагентів_ШвидкийВибір() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ДоговориКонтрагентів_Const.POINTER;
        KeyForSetting = ".Small";
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

    protected override async ValueTask OpenPageList(UnigueID? unigueID = null)
    {
        await Функції.OpenPageList(unigueID, CallBack_OnSelectPointer);
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
}
    