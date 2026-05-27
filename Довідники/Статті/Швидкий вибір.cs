
/*     
        Статті_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Статті_Записи;
using Функції = StorageAndTrade.Статті_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalSmallTree>("SmallList_7nfAGxfC50GrPgOhbmmv8Q")]
partial class Статті_ШвидкийВибір : DirectoryFormJournalSmallTree
{
    partial void Initialize()
    {
        TypeName = Статті_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static Статті_ШвидкийВибір New()
    {
        Статті_ШвидкийВибір list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    public override async Task LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }
    
    public override async Task<List<DirectoryHierarchicalRow>> LoadChildren(UniqueID[] parents)
    {
        return await ТабличнийСписок.LoadChildren(this, parents);
    }
    
    public override DirectoryHierarchicalRow LoadEmptyChildren()
    {
        return ТабличнийСписок.LoadEmptyChildren(this);
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
        await Функції.OpenPageList(uniqueID, AllowedContentSelection, OpenFolder, CallBack_OnSelectPointer);
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
}
    