/*

Довідники

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<Form>]
partial class Menu_Report : Form
{
    public Popover? Popover { get; set; } = null;

    partial void Initialize()
    {
        //Список
        Box hBoxList = New(Orientation.Horizontal, 0);
        Append(hBoxList);

        Box vLeft = New(Orientation.Vertical, 0);
        hBoxList.Append(vLeft);

        {
            CreateLink(vLeft, "Номенклатура тест", async () =>
            {
                ReportTest page = ReportTest.New();
                NotebookFunc?.CreatePage("Номенклатура тест", page);
                //await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, "Бух Залишки", async () =>
            {
                ReportTest2 page = ReportTest2.New();
                NotebookFunc?.CreatePage("Бух Залишки", page);
                //await page.SetValue();

                Popover?.Hide();
            });
        }
    }

    public static Menu_Report New(Popover? popover = null)
    {
        Menu_Report page = NewWithProperties([]);
        page.Popover = popover;
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }
}