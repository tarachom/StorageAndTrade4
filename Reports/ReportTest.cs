
using Gtk;
using InterfaceGtk4;
using InterfaceGtk4.Report;

using AccountingSoftware;
using GeneratedCode;
using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<FormReport>("Report_9fAhQS5xLkGxSrQ4MEw9w")]
public partial class ReportTest : FormReport
{
    #region Модель

    [GObject.Subclass<GObject.Object>()]
    public partial class ItemRow
    {
        public static ItemRow New() => NewWithProperties([]);

        public Номенклатура_Pointer Номенклатура { get; set; } = new();
        public string НоменклатураКод { get; set; } = "";
        public ТипиНоменклатури ТипНоменклатури { get; set; } = 0;
        public ПакуванняОдиниціВиміру_Pointer ПакуванняОдиниціВиміру { get; set; } = new();
    }

    #endregion

    Button bRun = Button.NewWithLabel("Сформувати");

    partial void Initialize()
    {
        bRun.MarginEnd = 10;
        bRun.OnClicked += async (_, _) => await Load();
        HBoxTop.Append(bRun);
    }

    public static ReportTest New()
    {
        ReportTest page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;
        return page;
    }

    async Task Load()
    {
        string query = $@"
SELECT
    Номенклатура.uid AS Номенклатура,
    Номенклатура.{Номенклатура_Const.Назва} AS Номенклатура_Назва,
    Номенклатура.{Номенклатура_Const.Код} AS Номенклатура_Код,
    Номенклатура.{Номенклатура_Const.ТипНоменклатури} AS Номенклатура_Тип,
    Довідник_ПакуванняОдиниціВиміру.uid AS Пакування,
    Довідник_ПакуванняОдиниціВиміру.{ПакуванняОдиниціВиміру_Const.Назва} AS Пакування_Назва
FROM
    {Номенклатура_Const.TABLE} AS Номенклатура

    LEFT JOIN {ПакуванняОдиниціВиміру_Const.TABLE} AS Довідник_ПакуванняОдиниціВиміру ON 
        Довідник_ПакуванняОдиниціВиміру.uid = Номенклатура.{Номенклатура_Const.ОдиницяВиміру}
WHERE
    Номенклатура.{Номенклатура_Const.ТипНоменклатури} = {(int)ТипиНоменклатури.Товар} OR
    Номенклатура.{Номенклатура_Const.ТипНоменклатури} = {(int)ТипиНоменклатури.Послуга}
ORDER BY 
    Номенклатура_Назва, 
    Пакування_Назва
";

        SelectRequest_Record res = await Config.Kernel.DataBase.SelectRequest(query);
        var data = res.ListRow.Select(item =>
        {
            ItemRow row = ItemRow.New();
            row.Номенклатура = new(item["Номенклатура"], item["Номенклатура_Назва"]);
            row.НоменклатураКод = (string)item["Номенклатура_Код"];
            row.ТипНоменклатури = (ТипиНоменклатури)item["Номенклатура_Тип"];
            row.ПакуванняОдиниціВиміру = new(item["Пакування"], item["Пакування_Назва"]);
            return row;
        });

        Columns<ItemRow>[] columns = [
            new()
            {
                Title = "Код",
                Cell = LabelReportCell.New,
                Value = x => [x.НоменклатураКод]
            },
            new()
            {
                Title = "Тип",
                Cell = LabelReportCell.New,
                Value = x => [x.ТипНоменклатури]
            },
            new()
            {
                Title = "Номенклатура",
                Cell = PointerReportCell.New,
                Value = x => [x.Номенклатура]
            },
            new()
            {
                Title = "Пакування",
                Cell = PointerReportCell.New,
                Value = x => [x.ПакуванняОдиниціВиміру]
            },
        ];

        ReportPage report = ReportPage.New();
        report.Create(columns, data);

        NotebookFuncReport.CreatePage("Звіт 'Номенклатура'", report);
    }
}