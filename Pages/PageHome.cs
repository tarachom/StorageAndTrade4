/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode;
using GeneratedCode.Документи;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

/// <summary>
/// Стартова сторінка
/// </summary>
[GObject.Subclass<Form>]
partial class PageHome : Form
{
    partial void Initialize()
    {
        {
            ActiveUsersView view = ActiveUsersView.New(Config.Kernel, 800, 300);

            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginBottom = 10;
            hBox.Append(view);
            Append(hBox);
        }

        {
            LockObjectsView view = LockObjectsView.New(800, 300);

            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginBottom = 10;
            hBox.Append(view);
            Append(hBox);
        }

        {
            ReportPage report = ReportPage.New();
            report.ColumnSettings =
            [
               new() { Title = "Назва 2423 4234 23 2", Cell = LabelReportCell.New, Value = x => [x.Fields["Name"]]},
               new() { Title = "Назва2", Cell = () => TwoLabelReportCell.NewWithOrientation(Orientation.Vertical), Value = x => [x.Fields["Name"], "0000"]},
               new() { Title = "Назва3", Cell = () => ThreeLabelReportCell.NewWithOrientation(Orientation.Vertical), Value = x => [x.Fields["Name"], "erter erwe", 1]},
               new() { Title = "Назва3", Cell = ThreeLabelReportCell.New, Value = x => [x.Fields["Name"], "erter erwe", 1]},
               new() { Title = "Назва4", Cell = () => PointerReportCell.NewWithType(Номенклатура_Const.POINTER), Value = x => [ new UuidAndText(Guid.CreateVersion7(), "Text") ]},
            ];

            report.Columns();

            List<ReportRow> list = [];
            ReportRow row = ReportRow.New();
            row.Fields.Add("Name", "Name name");
            list.Add(row);

            report.Fill([.. list]);

            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginBottom = 10;
            hBox.Append(report);
            Append(hBox);
        }
    }

    /// <summary>
    /// Новий об'єкт
    /// </summary>
    /// <returns>PageHome</returns>
    public static PageHome New()
    {
        PageHome page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }

    public async Task SetValue()
    {

    }
}