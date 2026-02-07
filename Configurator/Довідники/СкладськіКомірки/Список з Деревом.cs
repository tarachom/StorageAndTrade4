
/*     
        СкладськіКомірки.cs 
        Список з Деревом
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.СкладськіКомірки_Записи;
using Функції = StorageAndTrade.СкладськіКомірки_Функції;

namespace StorageAndTrade;

class СкладськіКомірки_Список : DirectoryFormJournalFull
{
    СкладськіКомірки_Папки_Список Папки = new() { InsertEmptyFirstRow = true };
    
    public СкладськіПриміщення_PointerControl Власник = new() { Caption = "Приміщення:" };
    

    public СкладськіКомірки_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = СкладськіКомірки_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        //Папки
        {
            CompositeMode = true;
            AddSwitchUseHierarchy();

            Box vBox = New(Orientation.Vertical, 0);
            vBox.MarginStart = 5;
            vBox.Append(Папки);

            HPanedTable.SetEndChild(vBox);
            HPanedTable.Position = 1200;
            HPanedTable.StartChild?.MarginEnd = 5;

            Папки.CallBack_Activate = async unigueID =>
            {
                //Відбір по полю Папка
                ParentWhereList = [new(СкладськіКомірки_Const.Папка, Comparison.EQ, unigueID.UGuid)];
                if (!UseHierarchy.Active && TypeWhereState == TypeWhere.Standart)
                {
                    PagesClear();
                    await LoadRecords();
                }
            };
        }
        
        //Власник
        {
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(СкладськіКомірки_Const.Приміщення, Comparison.EQ, Власник.Pointer.UnigueID.UGuid)];
            Власник.AfterSelectFunc = async () =>
            {
                PagesClear();
                await LoadRecords();
            };
        }
        
    }
    
    protected override async ValueTask BeforeSetValue()
    {
        if (SelectPointerItem != null || DirectoryPointerItem != null)
        {
            СкладськіКомірки_Objest? Обєкт = await new СкладськіКомірки_Pointer(SelectPointerItem ?? DirectoryPointerItem ?? new UnigueID()).GetDirectoryObject();
            if (Обєкт != null) Папки.SelectPointerItem = Обєкт.Папка.UnigueID;
        }

        await Папки.SetValue();
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
    