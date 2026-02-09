

/*     
        ТовариНаСкладах.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.ТовариНаСкладах_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class ТовариНаСкладах_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public ТовариНаСкладах_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ТовариНаСкладах_Const.TYPENAME;
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
    