
/*     
        Контрагенти.cs 
        Список з Деревом
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Контрагенти_Записи;
using Функції = StorageAndTrade.Контрагенти_Функції;

namespace StorageAndTrade;

class Контрагенти_Список : DirectoryFormJournalFull
{
    Контрагенти_Папки_Список Папки = new() { InsertEmptyFirstRow = true };
    

    public Контрагенти_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = Контрагенти_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        //Папки
        {
            CompositeMode = true;

            Box vBox = New(Orientation.Vertical, 0);
            vBox.MarginStart = 5;
            vBox.Append(Папки);

            HPanedTable.SetEndChild(vBox);
            HPanedTable.Position = 1200;
            HPanedTable.StartChild?.MarginEnd = 5;

            Папки.CallBack_Activate = async unigueID =>
            {
                //Відбір по полю Папка
                ParentWhereList = [new(Контрагенти_Const.Папка, Comparison.EQ, unigueID.UGuid)];
                if (TypeWhereState == TypeWhere.Standart)
                {
                    PagesClear();
                    await LoadRecords();
                }
            };
        }
    }
    
    protected override async ValueTask BeforeSetValue()
    {
        if (SelectPointerItem != null || DirectoryPointerItem != null)
        {
            Контрагенти_Objest? Обєкт = await new Контрагенти_Pointer(SelectPointerItem ?? DirectoryPointerItem ?? new UnigueID()).GetDirectoryObject();
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
    