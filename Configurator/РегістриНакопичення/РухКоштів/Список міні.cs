

/*     
        РухКоштів.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.РухКоштів_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class РухКоштів_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public РухКоштів_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = РухКоштів_Const.TYPENAME;
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
    