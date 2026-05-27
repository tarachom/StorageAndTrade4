/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode;

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
            hBox.Append(view);
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