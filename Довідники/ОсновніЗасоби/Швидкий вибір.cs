
/*     
        ОсновніЗасоби_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.ОсновніЗасоби_Записи;
using Функції = StorageAndTrade.ОсновніЗасоби_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalSmall>("SmallList_jPYeIJEdc0iYH3MoypEQ")]
partial class ОсновніЗасоби_ШвидкийВибір : DirectoryFormJournalSmall
{
    
    
    partial void Initialize()
    {
        TypeName = ОсновніЗасоби_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
    }

    public static ОсновніЗасоби_ШвидкийВибір New()
    {
        ОсновніЗасоби_ШвидкийВибір list = NewWithProperties([]);
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
    