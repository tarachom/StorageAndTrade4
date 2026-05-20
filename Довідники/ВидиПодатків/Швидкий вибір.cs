
/*     
        ВидиПодатків_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.ВидиПодатків_Записи;
using Функції = StorageAndTrade.ВидиПодатків_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalSmall>("SmallList_NLWZ9JlWUmSMSNcH2usIQ")]
partial class ВидиПодатків_ШвидкийВибір : DirectoryFormJournalSmall
{
    
    
    partial void Initialize()
    {
        TypeName = ВидиПодатків_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
    }

    public static ВидиПодатків_ШвидкийВибір New()
    {
        ВидиПодатків_ШвидкийВибір list = NewWithProperties([]);
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
    