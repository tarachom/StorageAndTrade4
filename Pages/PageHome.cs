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

        {

            Builder builder = Builder.NewFromFile("doc.xml");
            Box? box = (Box?)builder.GetObject("MainBox");
            if (box != null)
            {
                Append(box);

                CreateTopStart((Box?)builder.GetObject("TopStartBox"));
                CreateTopEnd((Box?)builder.GetObject("TopEndBox"));
                CreateBottomStart((Box?)builder.GetObject("BottomStartBox"));
                CreateBottomEnd((Box?)builder.GetObject("BottomEndBox"));

                Box? commentBox = (Box?)builder.GetObject("CommentBox");
                if (commentBox != null)
                {
                    Entry entry = Entry.New();
                    entry.WidthRequest = 920;

                    CreateField(commentBox, "Коментар", entry);
                }

                Notebook? notebook = (Notebook?)builder.GetObject("Notebook");

                if (notebook != null)
                {
                    ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари Товари = ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари.New();
                    Товари.HeightRequest = 300;
                    notebook.InsertPage(Товари, Label.New("Товари"), 0);

                    notebook.SetCurrentPage(0);
                }
            }
        }
    }

    protected void CreateTopStart(Box? vBox)
    {
        Label label = Label.New("Text 1");
        vBox?.Append(label);
    }

    protected void CreateTopEnd(Box? vBox)
    {
        Label label = Label.New("Text 2");
        vBox?.Append(label);
    }

    protected void CreateBottomStart(Box? vBox)
    {
        Label label = Label.New("Text 3");
        vBox?.Append(label);
    }

    protected void CreateBottomEnd(Box? vBox)
    {
        Label label = Label.New("Text 4");
        vBox?.Append(label);
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