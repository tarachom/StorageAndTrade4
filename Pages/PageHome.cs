/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode;

namespace StorageAndTrade;

class PageHome : Form
{
    public ActiveUsers activeUsers = new ActiveUsers(Config.Kernel, 800, 300);

    public PageHome()
    {
        {
            Box hBox = New(Orientation.Horizontal, 0);
            hBox.Append(activeUsers);
            Append(hBox);
        }

        /*
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

        DateTimeControl dateTimeControl = new() { Value = DateTime.Now };
        Append(dateTimeControl);

        TimeControl timeControl = new();
        Append(timeControl);

        NumericControl numericControl = new() { Value = 1 };
        Append(numericControl);

        IntegerControl integerControl = new() { Value = 1 };
        Append(integerControl);

        PeriodControl periodControl = new() { Period = PeriodForJournal.TypePeriod.AllPeriod, DateStart = DateTime.Now, DateStop = DateTime.Now };
        Append(periodControl);

        SearchControl searchControl = new() { MinLength = 3 };
        Append(searchControl);

        CompositePointerControl cp = new();
        Append(cp);
        */
    }

    public async ValueTask SetValue()
    {
        await Task.FromResult(true);
    }
}
