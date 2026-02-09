

/*     
        ЗамовленняПостачальникам.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.ЗамовленняПостачальникам_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class ЗамовленняПостачальникам_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public ЗамовленняПостачальникам_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ЗамовленняПостачальникам_Const.TYPENAME;
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
    