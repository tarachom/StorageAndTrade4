
/*     
        СкладськіПриміщення_ШвидкийВибір.cs
        ШвидкийВибір
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.СкладськіПриміщення_Записи;
using Функції = StorageAndTrade.СкладськіПриміщення_Функції;

namespace StorageAndTrade;

class СкладськіПриміщення_ШвидкийВибір : DirectoryFormJournalSmall
{
    
    public Склади_PointerControl Власник = new() { Caption = "Склад:" };
    
    
    public СкладськіПриміщення_ШвидкийВибір() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = СкладськіПриміщення_Const.POINTER;
        KeyForSetting = ".Small";
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
        //Власник
        {
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(СкладськіПриміщення_Const.Склад, Comparison.EQ, Власник.Pointer.UnigueID.UGuid)];
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

    protected override async ValueTask OpenPageList(UnigueID? unigueID = null)
    {
        await Функції.OpenPageList(unigueID, CallBack_OnSelectPointer);
    }

    protected override async ValueTask OpenPageElement(bool IsNew, UnigueID? unigueID = null)
    {
        await Функції.OpenPageElement(IsNew, unigueID, CallBack_LoadRecords, CallBack_OnSelectPointer);
    }

    protected override async ValueTask SetDeletionLabel(UnigueID unigueID)
    {
        await Функції.SetDeletionLabel(unigueID);
    }

    protected override async ValueTask<UnigueID?> Copy(UnigueID unigueID)
    {
        return await Функції.Copy(unigueID);
    }
}
    