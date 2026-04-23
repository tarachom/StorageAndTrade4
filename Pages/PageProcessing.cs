/*

Обробки

*/

using Gtk;
using InterfaceGtk4;

namespace StorageAndTrade;

[GObject.Subclass<Form>]
partial class PageProcessing : Form
{
    partial void Initialize()
    {
        Box vBox = New(Orientation.Vertical, 0);
        Append(vBox);

        CreateLink(vBox, "Обробка", () =>
        {
            Обробка page = Обробка.New();
            NotebookFunc?.CreatePage("Обробка", page);
        });
    }

    public static PageProcessing New()
    {
        PageProcessing page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }
}