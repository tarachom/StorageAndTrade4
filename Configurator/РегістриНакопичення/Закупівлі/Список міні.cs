

/*     
        Закупівлі.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.Закупівлі_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class Закупівлі_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public Закупівлі_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = Закупівлі_Const.TYPENAME;
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
    