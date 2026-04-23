

/*     
        РухКоштівККМ.cs
        Список

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ТабличніСписки.РухКоштівККМ_Записи;

namespace StorageAndTrade.РегістриНакопичення;

[GObject.Subclass<RegisterAccumulationFormJournalBase>("List_M1YGHbiPUUWozz5So7t7YA")]
public partial class РухКоштівККМ_Список : RegisterAccumulationFormJournalBase
{
    partial void Initialize()
    {
        TypeName = РухКоштівККМ_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static РухКоштівККМ_Список New()
    {
        РухКоштівККМ_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    #region Override

    public override async ValueTask LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    protected override void FillFilter(FilterControl filterControl)
    {
        ТабличнийСписок.CreateFilter(this);
    }

    protected override async ValueTask BeforeSetValue()
    {
        await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(FormKey, Period);
    }

    protected override async void PeriodChanged()
    {
        ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(FormKey, Period.Period.ToString(), Period.DateStart, Period.DateStop);
    }

    #endregion
}
    