

/*     
        РухКоштівККМ.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.РухКоштівККМ_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class РухКоштівККМ_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public РухКоштівККМ_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = РухКоштівККМ_Const.TYPENAME;
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
    