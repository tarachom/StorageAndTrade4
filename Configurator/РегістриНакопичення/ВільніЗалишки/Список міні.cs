

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

[GObject.Subclass<RegisterAccumulationFormJournalSmall>("SmallList_OIiiB1hseUmSQ9AyNlMJ5g")]
public partial class ВільніЗалишки_СписокМіні : RegisterAccumulationFormJournalSmall
{
    partial void Initialize()
    {
        TypeName = ВільніЗалишки_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static ВільніЗалишки_СписокМіні New()
    {
        ВільніЗалишки_СписокМіні list = NewWithProperties([]);
        list.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return list;
    }

    #region Override

    public override async Task LoadRecords()
    {
        await ТабличнийСписок.LoadRecords(this);
    }

    #endregion
}
    