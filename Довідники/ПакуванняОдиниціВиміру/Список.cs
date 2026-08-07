
/*      
        ПакуванняОдиниціВиміру.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.ПакуванняОдиниціВиміру_Записи;
using Функції = StorageAndTrade.ПакуванняОдиниціВиміру_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalFull>("List_bdafAWnFVXGLfigZaovOQ")]
partial class ПакуванняОдиниціВиміру_Список : DirectoryFormJournalFull
{
    public Номенклатура_PointerControl Власник = Номенклатура_PointerControl.New();
    
    partial void Initialize()
    {
        TypeName = ПакуванняОдиниціВиміру_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        //Власник
        {
            Власник.Caption = "Номенклатура:";
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(ПакуванняОдиниціВиміру_Const.Номенклатура, Comparison.EQ, Власник.Pointer.UniqueID.UGuid)];
            Власник.AfterSelectFunc = async () =>
            {
                PagesClear();
                await LoadRecords();
            };
        }
    }

    public static ПакуванняОдиниціВиміру_Список New()
    {
        ПакуванняОдиниціВиміру_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    public override async Task LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
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

    protected override async Task OpenPageElement(bool IsNew, UniqueID? uniqueID = null)
    {
        await Функції.OpenPageElement(IsNew, uniqueID, CallBack_LoadRecords, CallBack_OnSelectPointer, Власник.Pointer);
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
    