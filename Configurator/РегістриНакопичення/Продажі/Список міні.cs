

/*     
        Продажі.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.Продажі_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class Продажі_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public Продажі_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = Продажі_Const.TYPENAME;
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
    