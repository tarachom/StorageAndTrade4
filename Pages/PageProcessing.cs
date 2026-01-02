/*

Обробки

*/

using Gtk;
using InterfaceGtk4;

namespace StorageAndTrade;

class PageProcessing : Form
{
    public PageProcessing() : base(Program.BasicForm?.NotebookFunc)
    {
        Box vBox = New(Orientation.Vertical, 0);
        Append(vBox);

        CreateLink(vBox, "Обробка", () =>
        {
            Обробка page = new();
            NotebookFunc?.CreatePage("Обробка", page);
        });
    }
}
