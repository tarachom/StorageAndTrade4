

/*     
        РозрахункиЗКлієнтами.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.РозрахункиЗКлієнтами_Записи;

namespace StorageAndTrade.РегістриНакопичення;

public class РозрахункиЗКлієнтами_СписокМіні : RegisterAccumulationFormJournalSmall
{
    public РозрахункиЗКлієнтами_СписокМіні() : base(Program.BasicForm?.NotebookFunc)
    {
        TypeName = РозрахункиЗКлієнтами_Const.TYPENAME;
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
    