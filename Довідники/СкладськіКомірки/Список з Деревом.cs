
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

[GObject.Subclass<DirectoryFormJournalFull>("ListAndTreeHfyy7XuG0GK0Zba8nOeRw")]
partial class СкладськіКомірки_Список : DirectoryFormJournalFull
{
    СкладськіКомірки_Папки_Список Папки = СкладськіКомірки_Папки_Список.New();

    public СкладськіПриміщення_PointerControl Власник = СкладськіПриміщення_PointerControl.New();

    partial void Initialize()
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
                ParentWhereList = [new(СкладськіКомірки_Const.Папка, Comparison.EQ, uniqueID.UGuid)];
                if (!UseHierarchy.Active && TypeWhereState == TypeWhere.Standart)
                {
                    PagesClear();
                    await LoadRecords();
                }
            };
        }

        //Власник
        {
            Власник.Caption = "Приміщення:";
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(СкладськіКомірки_Const.Приміщення, Comparison.EQ, Власник.Pointer.UniqueID.UGuid)];
            Власник.AfterSelectFunc = async () =>
            {
                PagesClear();
                await LoadRecords();
            };
        }
    }

    public static СкладськіКомірки_Список New()
    {
        СкладськіКомірки_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    protected override async ValueTask BeforeSetValue()
    {
        if (SelectPointerItem != null || DirectoryPointerItem != null)
        {
            СкладськіКомірки_Objest? Обєкт = await new СкладськіКомірки_Pointer(SelectPointerItem ?? DirectoryPointerItem ?? new UniqueID()).GetDirectoryObject();
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
