

/*     
        Закупівлі.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.Закупівлі_Записи;

namespace StorageAndTrade.РегістриНакопичення;

[GObject.Subclass<RegisterAccumulationFormJournalSmall>("SmallList_TYOoei411UyFDnAm1XCa3A")]
public partial class Закупівлі_СписокМіні : RegisterAccumulationFormJournalSmall
{
    partial void Initialize()
    {
        TypeName = Закупівлі_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static Закупівлі_СписокМіні New()
    {
        Закупівлі_СписокМіні list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    #region Override

    public override async ValueTask LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    #endregion
}
    