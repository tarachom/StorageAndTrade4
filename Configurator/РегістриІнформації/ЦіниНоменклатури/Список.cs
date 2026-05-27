

/*     
        ЦіниНоменклатури.cs
        Список

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриВідомостей;

using ТабличнийСписок = GeneratedCode.РегістриВідомостей.ТабличніСписки.ЦіниНоменклатури_Записи;

namespace StorageAndTrade.РегістриВідомостей;

[GObject.Subclass<RegisterInformationFormJournalBase>("List_CkajSqjEk2YOceKXk7Y1A")]
public partial class ЦіниНоменклатури_Список : RegisterInformationFormJournalBase
{
    partial void Initialize()
    {
        TypeName = ЦіниНоменклатури_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static ЦіниНоменклатури_Список New()
    {
        ЦіниНоменклатури_Список list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    #region Override

    public override async Task LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    protected override void FillFilter(FilterControl filterControl)
    {
        ТабличнийСписок.CreateFilter(this);
    }

    protected override async Task BeforeSetValue()
    {
        await ФункціїНалаштуванняКористувача.ОтриматиПеріодДляЖурналу(FormKey, Period);
    }

    protected override async void PeriodChanged()
    {
        ФункціїНалаштуванняКористувача.ЗаписатиПеріодДляЖурналу(FormKey, Period.Period.ToString(), Period.DateStart, Period.DateStop);
    }

    #endregion
}
    