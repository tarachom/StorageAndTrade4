
/*     
        СкладськіКомірки_Папки_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.СкладськіКомірки_Папки_Записи;
using Функції = StorageAndTrade.СкладськіКомірки_Папки_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalSmallTree>("SmallList_PaWAUIDe0UiCEexJj62eiA")]
partial class СкладськіКомірки_Папки_ШвидкийВибір : DirectoryFormJournalSmallTree
{
    
    public СкладськіПриміщення_PointerControl Власник = СкладськіПриміщення_PointerControl.New();
    
    
    partial void Initialize()
    {
        TypeName = СкладськіКомірки_Папки_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
        //Власник
        {
            Власник.Caption = "Власник:";
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(СкладськіКомірки_Папки_Const.Власник, Comparison.EQ, Власник.Pointer.UniqueID.UGuid)];
            Власник.AfterSelectFunc = async () =>
            {
                PagesClear();
                await LoadRecords();
            };
        }
        
    }

    public static СкладськіКомірки_Папки_ШвидкийВибір New()
    {
        СкладськіКомірки_Папки_ШвидкийВибір list = NewWithProperties([]);
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
        await Функції.OpenPageList(uniqueID, AllowedContentSelection, OpenFolder, CallBack_OnSelectPointer, Власник.Pointer);
    }

    protected override async ValueTask OpenPageElement(bool IsNew, UniqueID? uniqueID = null)
    {
        await Функції.OpenPageElement(IsNew, uniqueID, CallBack_LoadRecords, CallBack_OnSelectPointer, Власник.Pointer);
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
    