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

    #region Data

    class Row : RowTablePart
    {
        /// <summary>
        /// 
        /// </summary>
        public Номенклатура_Pointer Номенклатура
        {
            get => Номенклатура_;
            set
            {
                Номенклатура_ = value;
                Кількість++;
                Сhanged_Номенклатура?.Invoke();
            }
        }
        Номенклатура_Pointer Номенклатура_ = new();
        public Action? Сhanged_Номенклатура;

        /// <summary>
        /// 
        /// </summary>
        public int Кількість
        {
            get => Кількість_;
            set
            {
                Кількість_ = value;
                Довжина = Кількість * 0.2m;
                Сhanged_Кількість?.Invoke();
            }
        }
        int Кількість_ = 1;
        public Action? Сhanged_Кількість;

        /// <summary>
        /// 
        /// </summary>
        public decimal Довжина
        {
            get => Довжина_;
            set
            {
                Довжина_ = value;
                Сhanged_Довжина?.Invoke();
            }
        }
        decimal Довжина_ = 0.01m;
        public Action? Сhanged_Довжина;
    }

    #endregion

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
                LabelTablePartCell labelControl = LabelTablePartCell.New(null);
                labelControl.Halign = Align.End;
                listItem.Child = labelControl;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                LabelTablePartCell? labelControl = (LabelTablePartCell?)listItem.Child;
                Row? row = (Row?)listItem.Item;
                if (labelControl != null && row != null)
                    labelControl.SetText(row.NumberRow);
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
                Номенклатура_PointerTablePartCell cell = new();
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (Номенклатура_PointerTablePartCell?)listItem.Child;
                Row? row = (Row?)listItem.Item;
                if (cell != null && row != null)
                {
                    cell.Pointer = row.Номенклатура;
                    cell.OnSelect = async () => row.Номенклатура = cell.Pointer;
                    row.Сhanged_Номенклатура = () => cell.Pointer = row.Номенклатура;
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Номенклатура", factory);
            column.Resizable = true;
            Grid.AppendColumn(column);
        }

        //Кількість
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.NewFromType("integer");
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                Row? row = (Row?)listItem.Item;
                if (cell != null && row != null)
                {
                    cell.SetText(row.Кількість);
                    row.Сhanged_Кількість = () => cell.SetText(row.Кількість);
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            Grid.AppendColumn(column);
        }

        //Довжина
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.NewFromType("numeric");
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                Row? row = (Row?)listItem.Item;
                if (cell != null && row != null)
                {
                    cell.SetText(row.Довжина);
                    row.Сhanged_Довжина = () => cell.SetText(row.Довжина);
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Довжина", factory);
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
                {
                    ЕлементВласник.Товари_TablePart.Records.Add(new()
                    {
                        UID = row.UnigueID.UGuid,
                        Номенклатура = row.Номенклатура
                    });
                }
            }

            await ЕлементВласник.Товари_TablePart.Save(true);
            await LoadRecords();
        }
    }

}
