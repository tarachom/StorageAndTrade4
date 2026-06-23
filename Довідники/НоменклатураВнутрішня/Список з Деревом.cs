
/*     
        НоменклатураВнутрішня.cs 
        Список з Деревом
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.НоменклатураВнутрішня_Записи;
using Функції = StorageAndTrade.НоменклатураВнутрішня_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalFull>("ListAndTree_AtLGUzBKQESHVYPOVPHfWA")]
partial class НоменклатураВнутрішня_Список : DirectoryFormJournalFull
{
    НоменклатураВнутрішня_Папки_Список Папки = НоменклатураВнутрішня_Папки_Список.New();

    partial void Initialize()
    {
        TypeName = НоменклатураВнутрішня_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        //Папки
        {
            CompositeMode = true;
            AddSwitchUseHierarchy();

            Box vBox = New(Orientation.Vertical, 0);
            vBox.MarginStart = 5;
            vBox.Append(Папки);

            Widget? vBoxStart = HPanedTable.GetStartChild();
            HPanedTable.SetStartChild(vBox);
            HPanedTable.SetEndChild(vBoxStart);
            HPanedTable.Position = 300;
            HPanedTable.StartChild?.MarginEnd = 5;
            HPanedTable.EndChild?.MarginStart = 5;

            Папки.InsertEmptyFirstRow = true;
            Папки.CallBack_Activate = async uniqueID =>
            {
                //Відбір по полю Папка
                ParentWhereList = [new(НоменклатураВнутрішня_Const.Папка, Comparison.EQ, uniqueID.UGuid)];
                if (!UseHierarchy.Active && TypeWhereState == TypeWhere.Standart)
                {
                    PagesClear();
                    await LoadRecords();
                }
            };
        }
    }

    public static НоменклатураВнутрішня_Список New()
    {
        НоменклатураВнутрішня_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    protected override async Task BeforeSetValue()
    {
        if (SelectPointerItem != null || DirectoryPointerItem != null)
        {
            НоменклатураВнутрішня_Object? Обєкт = await new НоменклатураВнутрішня_Pointer(SelectPointerItem ?? DirectoryPointerItem ?? new UniqueID()).GetDirectoryObject();
            if (Обєкт != null) Папки.SelectPointerItem = Обєкт.Папка.UniqueID;
        }

        await Папки.SetValue();
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
        await Функції.OpenPageElement(IsNew, uniqueID, CallBack_LoadRecords, CallBack_OnSelectPointer);
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
