

/*     
        ЗамовленняКлієнтів.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.ЗамовленняКлієнтів_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class ЗамовленняКлієнтів_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public ЗамовленняКлієнтів_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ЗамовленняКлієнтів_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    #region Override

    public override async ValueTask LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    #endregion
}
    