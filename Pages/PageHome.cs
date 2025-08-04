/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;

class PageHome : Form
{
    public PageHome()
    {
        //Uri uri = new Uri("about:blank");

        LinkButton linkButton = LinkButton.New("");
        linkButton.OnActivateLink += (a, f) =>
        {
            Console.WriteLine(1);
            return true;
        };

        linkButton.Label = "TEXT";

        Append(linkButton);

        Box box1 = Box.New(Orientation.Vertical, 0);
        Box box2 = Box.New(Orientation.Vertical, 0);

        Paned paned = Paned.New(Orientation.Horizontal);
        paned.Position = 800;
        paned.StartChild = box1;
        paned.EndChild = box2;

        Append(paned);

        Entry entry = Entry.New();
        Switch @switch = Switch.New();
        TextView textView = TextView.New();

        TextView textView2 = TextView.New();
        ProgressBar progressBar = ProgressBar.New();

        CreateField(box1, "Field", entry);

        CreateField(box1, "Caption", @switch, Align.End, true);

        CreateFieldView(box1, "TextView", textView, 500, 500);

        CreateTablePart(box2, "Table1", progressBar);
        CreateTablePart(box2, "Table2", textView2);
    }
}
