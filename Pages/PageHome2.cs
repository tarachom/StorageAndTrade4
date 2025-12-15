/*

Стартова сторінка

*/

using Gtk;
using GObject;

using InterfaceGtk4;
using AccountingSoftware;
using ТабличніСписки = GeneratedCode.Довідники.ТабличніСписки;

partial class PageHome2 : Form
{
    Gio.ListStore store;

    public PageHome2()
    {
        ScrolledWindow scrolled = ScrolledWindow.New();
        scrolled.Vexpand = scrolled.Hexpand = true;

        ColumnView columnView = ColumnView.New(null);
        columnView.ShowRowSeparators = true;
        columnView.ShowColumnSeparators = true;

        scrolled.Child = columnView;

        //columnView.Hexpand = columnView.Vexpand = true;

        store = ТабличніСписки.Номенклатура_Записи.Create(columnView);

        Append(scrolled);

        Label label = Label.New("...");
        Append(label);

        Button button = Button.NewWithLabel("Test");
        Append(button);

        button.OnClicked += (sender, arrg) =>
        {
            SingleSelection model = (SingleSelection)columnView.Model;
            var obj = model.SelectedItem;
            if (obj != null)
            {
                var row = (DirectoryRow)obj;
                label.SetText(row.UID.ToString() + " = " + row.Fields["Назва"]);
            }
        };
    }

    public async void SetValue()
    {
        await ТабличніСписки.Номенклатура_Записи.LoadRecords(store);


    }
}
