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
    public PageHome2()
    {
        Console.WriteLine(1);
        try
        {
            ТабличніСписки.Організації_Записи.AddColumns(out ColumnView columnView);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error");
            Console.WriteLine(ex.Message);
        }

        /*
        var store = Gio.ListStore.New(Row.GetGType());

        SingleSelection model = SingleSelection.New(store);
        model.Autoselect = true;

        ColumnView columnView = ColumnView.New(model);
        columnView.Hexpand = columnView.Vexpand = true;

        //Image
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnBind += (factory, e) =>
            {
                ListItem listitem = (ListItem)e.Object;
                listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
            };

            ColumnViewColumn column = ColumnViewColumn.New("", factory);
            columnView.AppendColumn(column);
        }

        Append(columnView);

        store.Append(new Row(){});
        */
    }

    public void SetValue()
    {

    }
}
