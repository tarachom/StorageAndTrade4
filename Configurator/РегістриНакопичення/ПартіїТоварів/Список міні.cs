

/*     
        ПартіїТоварів.cs
        Список міні

        Табличний список - ЗаписиМіні
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.ПартіїТоварів_ЗаписиМіні;

namespace StorageAndTrade.РегістриНакопичення;

public class ПартіїТоварів_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public ПартіїТоварів_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ПартіїТоварів_Const.TYPENAME;
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
    