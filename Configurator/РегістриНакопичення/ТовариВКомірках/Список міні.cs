

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

[GObject.Subclass<RegisterAccumulationFormJournalSmall>("SmallList_VgDomgeP0KqjK9GK3upjQ")]
public partial class ТовариВКомірках_СписокМіні : RegisterAccumulationFormJournalSmall
{
    partial void Initialize()
    {
        TypeName = ТовариВКомірках_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static ТовариВКомірках_СписокМіні New()
    {
        ТовариВКомірках_СписокМіні list = NewWithProperties([]);
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
    