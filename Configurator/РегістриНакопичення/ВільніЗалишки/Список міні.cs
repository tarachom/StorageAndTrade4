

/*     
        ВільніЗалишки.cs
        Список міні

        Табличний список - ЗаписиМіні
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.ВільніЗалишки_ЗаписиМіні;

namespace StorageAndTrade.РегістриНакопичення;

public class ВільніЗалишки_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public ВільніЗалишки_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = ВільніЗалишки_Const.TYPENAME;
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
    