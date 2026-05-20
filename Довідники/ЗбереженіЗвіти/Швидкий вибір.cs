
/*     
        ЗбереженіЗвіти_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.ЗбереженіЗвіти_Записи;
using Функції = StorageAndTrade.ЗбереженіЗвіти_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalSmall>("SmallList_ux0dkOPlVUCENlQKRqR2DQ")]
partial class ЗбереженіЗвіти_ШвидкийВибір : DirectoryFormJournalSmall
{
    
    public Користувачі_PointerControl Власник = Користувачі_PointerControl.New();
    
    
    partial void Initialize()
    {
        TypeName = ЗбереженіЗвіти_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
        //Власник
        {
            Власник.Caption = "Користувач:";
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(ЗбереженіЗвіти_Const.Користувач, Comparison.EQ, Власник.Pointer.UniqueID.UGuid)];
            Власник.AfterSelectFunc = async () =>
            {
                PagesClear();
                await LoadRecords();
            };
        }
        
    }

    public static ЗбереженіЗвіти_ШвидкийВибір New()
    {
        ЗбереженіЗвіти_ШвидкийВибір list = NewWithProperties([]);
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
    