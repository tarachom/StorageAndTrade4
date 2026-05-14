

/*     
        РозміщенняНоменклатуриПоКоміркамНаСкладі.cs
        Список

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриВідомостей;

using ТабличнийСписок = GeneratedCode.РегістриВідомостей.ТабличніСписки.РозміщенняНоменклатуриПоКоміркамНаСкладі_Записи;

namespace StorageAndTrade.РегістриВідомостей;

[GObject.Subclass<RegisterInformationFormJournalBase>("List_zFEo6w9chk2oOHGRltzy3A")]
public partial class РозміщенняНоменклатуриПоКоміркамНаСкладі_Список : RegisterInformationFormJournalBase
{
    partial void Initialize()
    {
        TypeName = РозміщенняНоменклатуриПоКоміркамНаСкладі_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static РозміщенняНоменклатуриПоКоміркамНаСкладі_Список New()
    {
        РозміщенняНоменклатуриПоКоміркамНаСкладі_Список list = NewWithProperties([]);
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
    