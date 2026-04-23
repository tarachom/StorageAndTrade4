
/*      
        Контрагенти_Папки.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Контрагенти_Папки_Записи;
using Функції = StorageAndTrade.Контрагенти_Папки_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalFullTree>("List_58slqVNqkqsYJNhRHVCWg")]
partial class Контрагенти_Папки_Список : DirectoryFormJournalFullTree
{
    
    
    partial void Initialize()
    {
        TypeName = Контрагенти_Папки_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
    }

    public static Контрагенти_Папки_Список New()
    {
        Контрагенти_Папки_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    public override async ValueTask LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }
    
    public override async ValueTask<List<DirectoryHierarchicalRow>> LoadChildren(UniqueID parent)
    {
        return await ТабличнийСписок.LoadChildren(this, parent);
    }

    public override DirectoryHierarchicalRow LoadEmptyChildren()
    {
        return ТабличнийСписок.LoadEmptyChildren(this);
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
    