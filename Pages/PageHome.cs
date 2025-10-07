/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;

class PageHome : Form
{
    public PageHome()
    {

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
        paned.SetShrinkStartChild(false);
        paned.SetShrinkEndChild(false);
        paned.Position = 500;
        paned.StartChild = box1;
        paned.EndChild = box2;


        Append(paned);

        Entry entry = Entry.New();
        Switch @switch = Switch.New();
        TextView textView = TextView.New();


        TextView textView2 = TextView.New();
        Entry entry2 = Entry.New();

        ProgressBar progressBar = ProgressBar.New();
        progressBar.ShowText = true;

        CreateField(box1, "Field", entry);

        CreateField(box1, "Caption", @switch, Align.End, true);

        CreateFieldView(box1, null, textView, 500, 500);

        CreateTablePart(box2, "Table1", progressBar);
        CreateTablePart(box2, "Table2", entry2);

        Box box = Box.New(Orientation.Horizontal, 0);
        box1.Append(box);

        CreateLink(box, "text Text", () => { });
        CreateLink(box, "text Text", () => { });

        CreateCaptionLink(box1, "CAPTION", () => { });
        CreateCaptionLink(box1, "CAPTION");
        CreateCaptionLink(box1, "CAPTION", () => { });
        
        CreateSeparator(box1);
    }

    public void SetValue()
    {
        
    }
}
