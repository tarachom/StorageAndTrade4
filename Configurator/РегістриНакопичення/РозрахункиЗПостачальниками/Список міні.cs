

/*     
        РозрахункиЗПостачальниками.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.РозрахункиЗПостачальниками_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class РозрахункиЗПостачальниками_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public РозрахункиЗПостачальниками_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = РозрахункиЗПостачальниками_Const.TYPENAME;
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
    