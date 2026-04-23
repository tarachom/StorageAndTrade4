
/*     
        Номенклатура.cs 
        Список з Деревом
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.Номенклатура_Записи;
using Функції = StorageAndTrade.Номенклатура_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalFull>("ListAndTreexYglEYUuqUaHrApMzyzRiw")]
partial class Номенклатура_Список : DirectoryFormJournalFull
{
    Номенклатура_Папки_Список Папки = Номенклатура_Папки_Список.New();
    

    partial void Initialize()
    {
        TypeName = Номенклатура_Const.POINTER;
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

            Папки.InsertEmptyFirstRow = true;
            Папки.CallBack_Activate = async uniqueID =>
            {
                //Відбір по полю Папка
                ParentWhereList = [new(Номенклатура_Const.Папка, Comparison.EQ, uniqueID.UGuid)];
                if (!UseHierarchy.Active && TypeWhereState == TypeWhere.Standart)
                {
                    PagesClear();
                    await LoadRecords();
                }
            };
        }
        
    }

    public static Номенклатура_Список New()
    {
        Номенклатура_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }
    
    protected override async ValueTask BeforeSetValue()
    {
        if (SelectPointerItem != null || DirectoryPointerItem != null)
        {
            Номенклатура_Objest? Обєкт = await new Номенклатура_Pointer(SelectPointerItem ?? DirectoryPointerItem ?? new UniqueID()).GetDirectoryObject();
            if (Обєкт != null) Папки.SelectPointerItem = Обєкт.Папка.UniqueID;
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
    