

/*     
        ШтрихкодиНоменклатури.cs
        Список

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриВідомостей;

using ТабличнийСписок = GeneratedCode.РегістриВідомостей.ТабличніСписки.ШтрихкодиНоменклатури_Записи;

namespace StorageAndTrade.РегістриВідомостей;

[GObject.Subclass<RegisterInformationFormJournalBase>("List_1d1XTuPw9kWhNiAcZ6g3A")]
public partial class ШтрихкодиНоменклатури_Список : RegisterInformationFormJournalBase
{
    partial void Initialize()
    {
        TypeName = ШтрихкодиНоменклатури_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static ШтрихкодиНоменклатури_Список New()
    {
        ШтрихкодиНоменклатури_Список list = NewWithProperties([]);
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
    