
/*     
        СкладськіПриміщення.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.СкладськіПриміщення_Записи;
using Функції = StorageAndTrade.СкладськіПриміщення_Функції;

namespace StorageAndTrade;

class СкладськіПриміщення_Список : DirectoryFormJournalFull
{
    
    public Склади_PointerControl Власник = Склади_PointerControl.New();
    
    
    public СкладськіПриміщення_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = СкладськіПриміщення_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
        //Власник
        {
            Власник.Caption = "Склад:";
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(СкладськіПриміщення_Const.Склад, Comparison.EQ, Власник.Pointer.UniqueID.UGuid)];
            Власник.AfterSelectFunc = async () =>
            {
                PagesClear();
                await LoadRecords();
            };
        }
        
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
    