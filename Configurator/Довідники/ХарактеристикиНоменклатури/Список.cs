
/*      
        ХарактеристикиНоменклатури.cs
        Список
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;

using ТабличнийСписок = GeneratedCode.Довідники.ТабличніСписки.ХарактеристикиНоменклатури_Записи;
using Функції = StorageAndTrade.ХарактеристикиНоменклатури_Функції;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormJournalFull>("List_FS6r8mZAl06vp4rWYdpAKQ")]
partial class ХарактеристикиНоменклатури_Список : DirectoryFormJournalFull
{
    
    public Номенклатура_PointerControl Власник = Номенклатура_PointerControl.New();
    
    
    partial void Initialize()
    {
        TypeName = ХарактеристикиНоменклатури_Const.POINTER;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);

        
        //Власник
        {
            Власник.Caption = "Номенклатура:";
            HBoxTop.Append(Власник);
            OwnerWhereListFunc = () => Власник.Pointer.IsEmpty() ? [] : [new(ХарактеристикиНоменклатури_Const.Номенклатура, Comparison.EQ, Власник.Pointer.UniqueID.UGuid)];
            Власник.AfterSelectFunc = async () =>
            {
                PagesClear();
                await LoadRecords();
            };
        }
        
    }

    public static ХарактеристикиНоменклатури_Список New()
    {
        ХарактеристикиНоменклатури_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
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
    