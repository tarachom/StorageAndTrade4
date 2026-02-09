

/*     
        ТовариВКомірках.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.ТовариВКомірках_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class ТовариВКомірках_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public ТовариВКомірках_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ТовариВКомірках_Const.TYPENAME;
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
    