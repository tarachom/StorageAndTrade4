
/*      
        Бланки.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Бланки_Записи;
using Функції = StorageAndTrade.Бланки_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalFull>("List_sos7k3IYEie5Bnhm5QTuQ")]
partial class Бланки_Список : DirectoryFormJournalFull
{
    partial void Initialize()
    {
        TypeName = Бланки_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static Бланки_Список New()
    {
        Бланки_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
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
}
    