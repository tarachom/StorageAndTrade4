/*
        ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари.cs
        Таблична Частина
*/

namespace StorageAndTrade;

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;

public class ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари : Box
{
    public ПоступленняТоварівТаПослуг_Objest? ЕлементВласник { get; set; }

    class Row : RowTablePart
    {
        public Номенклатура_Pointer Номенклатура { get; set; } = new Номенклатура_Pointer();
    }

    Gio.ListStore Store { get; } = Gio.ListStore.New(Row.GetGType());

    ColumnView Grid { get; }

    public ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари()
    {
        SetOrientation(Orientation.Vertical);

        MultiSelection model = MultiSelection.New(Store);

        Grid = ColumnView.New(model);
        Grid.Reorderable = false;
        Columns();

        ScrolledWindow scroll = ScrolledWindow.New();
        scroll.SetPolicy(PolicyType.Automatic, PolicyType.Automatic);
        scroll.Vexpand = scroll.Hexpand = true;
        scroll.SetChild(Grid);
        Append(scroll);
    }

    void Columns()
    {
        //Номер рядка
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                LabelTablePartControl labelControl = LabelTablePartControl.New(null);
                labelControl.Halign = Align.End;
                listItem.Child = labelControl;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                LabelTablePartControl? labelControl = (LabelTablePartControl?)listItem.Child;
                Row? row = (Row?)listItem.Item;
                if (labelControl != null && row != null)
                    labelControl.SetText(row.NumberRow.ToString());
            };
            ColumnViewColumn column = ColumnViewColumn.New("№", factory);
            Grid.AppendColumn(column);
        }

        //Номенклатура
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                Номенклатура_PointerTablePartControl p = new();
                listItem.Child = p;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var p = (Номенклатура_PointerTablePartControl?)listItem.Child;
                Row? row = (Row?)listItem.Item;
                if (p != null && row != null)
                {
                    p.Pointer = row.Номенклатура;
                    p.AfterSelectFunc = () => row.Номенклатура = p.Pointer;
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Номенклатура", factory);
            column.Resizable = true;
            Grid.AppendColumn(column);
        }

        { /* Пуста колонка для заповнення вільного простору */
            ColumnViewColumn column = ColumnViewColumn.New(null, null);
            column.Resizable = true;
            column.Expand = true;
            Grid.AppendColumn(column);
        }
    }

    public async ValueTask LoadRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.FillJoin();
            await ЕлементВласник.Товари_TablePart.Read();

            Store.RemoveAll();
            foreach (var record in ЕлементВласник.Товари_TablePart.Records)
                Store.Append(new Row()
                {
                    UnigueID = new(record.UID),
                    NumberRow = record.НомерРядка,
                    Номенклатура = record.Номенклатура
                });
        }
    }

    public async ValueTask SaveRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                Row? row = (Row?)Store.GetObject(i);
                if (row != null)
                    ЕлементВласник.Товари_TablePart.Records.Add(new()
                    {
                        UID = row.UnigueID.UGuid,
                        Номенклатура = row.Номенклатура
                    });
            }

            await ЕлементВласник.Товари_TablePart.Save(true);
            await LoadRecords();
        }
    }

}
