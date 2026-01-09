/*
        ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари.cs
        Таблична Частина
*/

namespace StorageAndTrade;

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;

public class ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    public ПоступленняТоварівТаПослуг_Objest? ЕлементВласник { get; set; }

    #region Data

    class ItemRow : RowTablePart
    {
        /// <summary>
        /// 
        /// </summary>
        public Номенклатура_Pointer Номенклатура
        {
            get => Номенклатура_;
            set
            {
                if (!Номенклатура_.Equals(value))
                {
                    Номенклатура_ = value;
                    Кількість++;
                    Сhanged_Номенклатура?.Invoke();
                }
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
                if (Кількість_ != value)
                {
                    Кількість_ = value;
                    Довжина = Кількість * 0.2m;
                    Сhanged_Кількість?.Invoke();
                }
            }
        }
        int Кількість_ = 0;
        public Action? Сhanged_Кількість;

        /// <summary>
        /// 
        /// </summary>
        public decimal Довжина
        {
            get => Довжина_;
            set
            {
                if (Довжина_ != value)
                {
                    Довжина_ = value;
                    Сhanged_Довжина?.Invoke();
                }
            }
        }
        decimal Довжина_ = 0.01m;
        public Action? Сhanged_Довжина;

        /// <summary>
        /// 
        /// </summary>
        public string Варіант
        {
            get => Варіант_;
            set
            {
                if (Варіант_ != value)
                {
                    Варіант_ = value;
                    Сhanged_Варіант?.Invoke();
                }
            }
        }
        string Варіант_ = "a";
        public Action? Сhanged_Варіант;

        /*
        Функції
        */

        /// <summary>
        /// Копіювання
        /// </summary>
        public override ItemRow Copy()
        {
            return new()
            {
                Номенклатура = Номенклатура.Copy(),
                Кількість = Кількість,
                Довжина = Довжина
            };
        }
    }

    #endregion

    /// <summary>
    /// Перевизначення сховища для нового типу даних 
    /// </summary>
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари() : base(Program.BasicForm?.NotebookFunc)
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    protected override void Columns()
    {
        //Номер рядка
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.New(null);
                cell.Halign = Align.End;
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                    (row.Сhanged_NumberRow = () => cell.SetText(row.NumberRow)).Invoke();
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
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    cell.OnSelect = async () => row.Номенклатура = cell.Pointer;
                    (row.Сhanged_Номенклатура = () => cell.Pointer = row.Номенклатура).Invoke();
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Номенклатура", factory);
            column.Resizable = true;
            column.FixedWidth = 500;
            Grid.AppendColumn(column);
        }

        //Кількість
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new IntegerTablePartCell();
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (IntegerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    cell.OnСhanged = () => row.Кількість = cell.Value;
                    (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            column.FixedWidth = 100;
            Grid.AppendColumn(column);
        }

        //Довжина
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new NumericTablePartCell();
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (NumericTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    cell.OnСhanged = () => row.Довжина = cell.Value;
                    (row.Сhanged_Довжина = () => cell.Value = row.Довжина).Invoke();
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Довжина", factory);
            column.Resizable = true;
            column.FixedWidth = 100;
            Grid.AppendColumn(column);
        }

        //Варіант
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new ComboTextTablePartCell();
                cell.Combo.Append("a", "a");
                cell.Combo.Append("b", "b");
                cell.Combo.Append("c", "c");
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (ComboTextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    cell.OnСhanged = () => row.Варіант = cell.Value;
                    (row.Сhanged_Варіант = () => cell.Value = row.Варіант).Invoke();
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Варіант", factory);
            column.Resizable = true;
            column.FixedWidth = 100;
            Grid.AppendColumn(column);
        }

        { /* Пуста колонка для заповнення вільного простору */
            ColumnViewColumn column = ColumnViewColumn.New(null, null);
            column.Resizable = true;
            column.Expand = true;
            Grid.AppendColumn(column);
        }
    }

    public override async ValueTask LoadRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.FillJoin();
            await ЕлементВласник.Товари_TablePart.Read();

            Store.RemoveAll();
            foreach (var record in ЕлементВласник.Товари_TablePart.Records)
                Store.Append(new ItemRow()
                {
                    UnigueID = new(record.UID),
                    NumberRow = record.НомерРядка,
                    Номенклатура = record.Номенклатура
                });

            if (SelectPosition > 0)
            {
                Grid.Model.SelectItem(SelectPosition, true);
                ScrollTo(SelectPosition);
            }
        }
    }

    public override async ValueTask SaveRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
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

    public override bool NewRecord()
    {
        Store.Append(new ItemRow());
        return true;
    }
}
