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
        ColumnView columnView = ColumnView.New(null);
        //columnView.Hexpand = columnView.Vexpand = true;

        store = ТабличніСписки.Номенклатура_Записи.Create(columnView);

        Append(columnView);

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

        

        store.Append(new Row(){});
        */
    }

    public async void SetValue()
    {
        await ТабличніСписки.Номенклатура_Записи.LoadRecords(store);
        
    }
}
