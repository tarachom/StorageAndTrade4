
/*     
        Номенклатура.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Номенклатура_Записи;
using Функції = StorageAndTrade.Номенклатура_Функції;

namespace StorageAndTrade;

class Номенклатура_Список : DirectoryFormJournalFull
{
    Номенклатура_Папки_Список Папки = new();

    public Номенклатура_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = Номенклатура_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
        
        CompositeMode = true;

        //Папки
        {
            Box vBox = New(Orientation.Vertical, 0);
            vBox.MarginStart = 5;
            vBox.Append(Папки);

            HPanedTable.SetEndChild(vBox);
            HPanedTable.Position = 1200;

            Папки.CallBack_Activate = async unigueID =>
            {
                ParentWhereList = [new(Номенклатура_Const.Папка, Comparison.EQ, unigueID.UGuid)];
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
        await Папки.SetValue();
        Папки.CallBack_Activate?.Invoke(new UnigueID());
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
