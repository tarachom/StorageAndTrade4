

/*     
        ЗамовленняКлієнтів.cs
        Список міні

        Табличний список - Записи
*/

using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.РегістриНакопичення;

using ТабличнийСписок = GeneratedCode.РегістриНакопичення.ДрукПроводок.ЗамовленняКлієнтів_Записи;

namespace StorageAndTrade.РегістриНакопичення;

[GObject.Subclass<RegisterAccumulationFormJournalSmall>("SmallList_U5RD5DfDBkOgM3YCfM0Wkg")]
public partial class ЗамовленняКлієнтів_СписокМіні : RegisterAccumulationFormJournalSmall
{
    partial void Initialize()
    {
        TypeName = ЗамовленняКлієнтів_Const.TYPENAME;
        ТабличнийСписок.AddColumn(this);
        SetPagesSettings(50);
    }

    public static ЗамовленняКлієнтів_СписокМіні New()
    {
        ЗамовленняКлієнтів_СписокМіні list = NewWithProperties([]);
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
    