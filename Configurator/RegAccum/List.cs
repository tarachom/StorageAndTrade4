

/*     
        ТовариНаСкладах.cs
        Список

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ТабличніСписки.ТовариНаСкладах_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class ТовариНаСкладах_Список : RegisterAccumulationFormJournalBase
{
    public ТовариНаСкладах_Список() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ТовариНаСкладах_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(100);
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
    