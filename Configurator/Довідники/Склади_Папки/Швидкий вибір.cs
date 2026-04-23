
/*     
        Склади_Папки_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Склади_Папки_Записи;
using Функції = StorageAndTrade.Склади_Папки_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalSmallTree>("SmallList_zhsqAnUt3EKtiKgXc7VcTw")]
partial class Склади_Папки_ШвидкийВибір : DirectoryFormJournalSmallTree
{
    
    
    partial void Initialize()
    {
        TypeName = Склади_Папки_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
    }

    public static Склади_Папки_ШвидкийВибір New()
    {
        Склади_Папки_ШвидкийВибір list = NewWithProperties([]);
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

    protected override async ValueTask OpenPageList(UniqueID? uniqueID = null)
    {
        await Функції.OpenPageList(uniqueID, AllowedContentSelection, OpenFolder, CallBack_OnSelectPointer);
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
    