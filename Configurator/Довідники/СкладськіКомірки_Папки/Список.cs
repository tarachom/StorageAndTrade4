
/*     
        СкладськіКомірки_Папки.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.СкладськіКомірки_Папки_Записи;
using Функції = StorageAndTrade.СкладськіКомірки_Папки_Функції;

namespace StorageAndTrade;

class СкладськіКомірки_Папки_Список : DirectoryFormJournalFullTree
{
    
    public СкладськіПриміщення_PointerControl Власник = new() { Caption = "Власник:" };
    
    
    public СкладськіКомірки_Папки_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = СкладськіКомірки_Папки_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
        //Власник
        {
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(СкладськіКомірки_Папки_Const.Власник, Comparison.EQ, Власник.Pointer.UnigueID.UGuid)];
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
    