

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

[GObject.Subclass<RegisterAccumulationFormJournalSmall>("SmallList_PDdsIQMFJECx21jBlNCGiQ")]
public partial class Продажі_СписокМіні : RegisterAccumulationFormJournalSmall
{
    partial void Initialize()
    {
        TypeName = Продажі_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static Продажі_СписокМіні New()
    {
        Продажі_СписокМіні list = NewWithProperties([]);
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
    