/*

Обробки

*/

using Gtk;
using InterfaceGtk4;

namespace StorageAndTrade;

class PageProcessing : Form
{
    public PageProcessing() : base(Program.Form?.Notebook)
    {
        Box vBox = New(Orientation.Vertical, 0);
        Append(vBox);

        CreateLink(vBox, "Обробка", () =>
        {
            Обробка page = new();
            Notebook?.CreatePage("Обробка", page);
        });
    }
}
