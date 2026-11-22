
using Gtk;
using InterfaceGtk4;
using InterfaceGtk4.Report;

using AccountingSoftware;
using GeneratedCode;
using GeneratedCode.Довідники;
using GeneratedCode.Перелічення;

using Залишки = GeneratedCode.РегістриНакопичення.БухгалтерськіОперації_Залишки_TablePart;

namespace StorageAndTrade;

[GObject.Subclass<FormReport>("Report_9fAhQS5xLkGxSrQ4MEw85")]
public partial class ReportTest2 : FormReport
{
    #region Модель

    [GObject.Subclass<GObject.Object>()]
    public partial class ItemRow
    {
        public static ItemRow New() => NewWithProperties([]);
        public DateOnly Період { get; set; }
        public Організації_Pointer Організація { get; set; } = new();
        public ПланРахунків_Pointer Рахунок { get; set; } = new();
        public Валюти_Pointer Валюта { get; set; } = new();
        public decimal Дебет { get; set; }
        public decimal Кредит { get; set; }
    }

    #endregion

    Button bRun = Button.NewWithLabel("Сформувати");

    partial void Initialize()
    {
        bRun.MarginEnd = 10;
        bRun.OnClicked += async (_, _) => await Load();
        HBoxTop.Append(bRun);
    }

    public static ReportTest2 New()
    {
        ReportTest2 page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;
        return page;
    }

    async Task Load()
    {
        string query = $@"
SELECT
    Залишки.{Залишки.Період} AS Період,

    Залишки.{Залишки.Організація} AS Організація,
    Довідник_Організації.{Організації_Const.Назва} AS Організація_Назва,

    Залишки.{Залишки.Рахунок} AS Рахунок,
    Довідник_ПланРахунків.{ПланРахунків_Const.Назва} AS Рахунок_Назва,

    Залишки.{Залишки.Валюта} AS Валюта,
    Довідник_Валюти.{Валюти_Const.Назва} AS Валюта_Назва,

    Залишки.{Залишки.Дебет} AS Дебет,
    Залишки.{Залишки.Кредит} AS Кредит
FROM
    {Залишки.TABLE} AS Залишки

    LEFT JOIN {Організації_Const.TABLE} AS Довідник_Організації ON 
        Довідник_Організації.uid = Залишки.{Залишки.Організація}

    LEFT JOIN {ПланРахунків_Const.TABLE} AS Довідник_ПланРахунків ON 
        Довідник_ПланРахунків.uid = Залишки.{Залишки.Рахунок}

    LEFT JOIN {Валюти_Const.TABLE} AS Довідник_Валюти ON 
        Довідник_Валюти.uid = Залишки.{Залишки.Валюта}

ORDER BY 
    Період
";

        SelectRequest_Record res = await Config.Kernel.DataBase.SelectRequest(query);
        var data = res.ListRow.Select(item =>
        {
            ItemRow row = ItemRow.New();
            row.Період = (DateOnly)item["Період"];
            row.Організація = new(item["Організація"], item["Організація_Назва"]);
            row.Рахунок = new(item["Рахунок"], item["Рахунок_Назва"]);
            row.Валюта = new(item["Валюта"], item["Валюта_Назва"]);
            row.Дебет = (decimal)item["Дебет"];
            row.Кредит = (decimal)item["Кредит"];
            return row;
        });

        Columns<ItemRow>[] columns = [
            new()
            {
                Title = "Період",
                Cell = LabelReportCell.New,
                Value = x => [x.Період]
            },
            new()
            {
                Title = "Організація",
                Cell = PointerReportCell.New,
                Value = x => [x.Організація]
            },
            new()
            {
                Title = "Рахунок",
                Cell = PointerReportCell.New,
                Value = x => [x.Рахунок]
            },
            new()
            {
                Title = "Валюта",
                Cell = PointerReportCell.New,
                Value = x => [x.Валюта]
            },
            new()
            {
                Title = "Дебет",
                Cell = LabelReportCell.New,
                Value = x => [x.Дебет]
            },
            new()
            {
                Title = "Кредит",
                Cell = LabelReportCell.New,
                Value = x => [x.Кредит]
            },
        ];

        ReportPage report = ReportPage.New();
        report.Create(columns, data);

        NotebookFuncReport.CreatePage("Звіт 'Залишки'", report);
    }
}