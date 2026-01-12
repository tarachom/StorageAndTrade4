
/*     
        ХарактеристикиНоменклатури.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.ХарактеристикиНоменклатури_Записи;
using Функції = StorageAndTrade.ХарактеристикиНоменклатури_Функції;

namespace StorageAndTrade;

class ХарактеристикиНоменклатури_Список : DirectoryFormJournalFull
{
    
    public Номенклатура_PointerControl Власник = new Номенклатура_PointerControl() { Caption = "Номенклатура:" };
    
    
    public ХарактеристикиНоменклатури_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ХарактеристикиНоменклатури_Const.POINTER;
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
}
    