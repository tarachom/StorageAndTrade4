/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

class PageHome : Form
{
    public ActiveUsersView activeUsersView = new(Config.Kernel, 800, 300);
    public LockObjectsView lockObjectsView = new(800, 300);

    public PageHome() : base(Program.BasicForm?.NotebookFunc)
    {
        {
            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginBottom = 10;
            hBox.Append(activeUsersView);
            Append(hBox);
        }

        {
            Box hBox = New(Orientation.Horizontal, 0);
            hBox.Append(lockObjectsView);
            Append(hBox);
        }


    }

    public async ValueTask SetValue()
    {
        
    }
}

