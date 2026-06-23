
/*
        ПоверненняТоварівПостачальнику_ТабличнаЧастина_Проводки.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_142eAQ7CmHWYbc4MLTyMvA")]
partial class ПоверненняТоварівПостачальнику_ТабличнаЧастина_Проводки : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_142eAQ7CmHWYbc4MLTyMvA")]
    public partial class ItemRow : IRowSubclassTablePart
    {
        public static ItemRow New() => NewWithProperties([]);

        // Унікальний ідентифікатор
        public UniqueID UniqueID
        {
            get => UnigueID_;
            set
            {
                if (!UnigueID_.Equals(value))
                {
                    UnigueID_ = value;
                    Сhanged_UnigueID?.Invoke();
                }
            }
        }
        UniqueID UnigueID_ = new();
        public Action? Сhanged_UnigueID { get; set; } = null;


        /* НомерРядка */
        public int НомерРядка
        {
            get => НомерРядка_;
            set
            {
                if (!НомерРядка_.Equals(value))
                {
                    НомерРядка_ = value;
                    Сhanged_НомерРядка?.Invoke();
                }
            }
        }
        int НомерРядка_ = 0;
        public Action? Сhanged_НомерРядка { get; set; } = null;


        /* Рахунок */
        public ПланРахунків_Pointer Рахунок
        {
            get => Рахунок_;
            set
            {
                if (!Рахунок_.Equals(value))
                {
                    Рахунок_ = value;
                    Сhanged_Рахунок?.Invoke();
                }
            }
        }
        ПланРахунків_Pointer Рахунок_ = new();
        public Action? Сhanged_Рахунок { get; set; } = null;


        /* Аналітика1 */
        public UuidAndText Аналітика1
        {
            get => Аналітика1_;
            set
            {
                if (!Аналітика1_.Equals(value))
                {
                    Аналітика1_ = value;
                    Сhanged_Аналітика1?.Invoke();
                }
            }
        }
        UuidAndText Аналітика1_ = new();
        public Action? Сhanged_Аналітика1 { get; set; } = null;


        /* Аналітика2 */
        public UuidAndText Аналітика2
        {
            get => Аналітика2_;
            set
            {
                if (!Аналітика2_.Equals(value))
                {
                    Аналітика2_ = value;
                    Сhanged_Аналітика2?.Invoke();
                }
            }
        }
        UuidAndText Аналітика2_ = new();
        public Action? Сhanged_Аналітика2 { get; set; } = null;


        /* Аналітика3 */
        public UuidAndText Аналітика3
        {
            get => Аналітика3_;
            set
            {
                if (!Аналітика3_.Equals(value))
                {
                    Аналітика3_ = value;
                    Сhanged_Аналітика3?.Invoke();
                }
            }
        }
        UuidAndText Аналітика3_ = new();
        public Action? Сhanged_Аналітика3 { get; set; } = null;


        /* Кредит */
        public decimal Кредит
        {
            get => Кредит_;
            set
            {
                if (!Кредит_.Equals(value))
                {
                    Кредит_ = value;
                    Сhanged_Кредит?.Invoke();
                }
            }
        }
        decimal Кредит_ = 0;
        public Action? Сhanged_Кредит { get; set; } = null;


        /* Дебет */
        public decimal Дебет
        {
            get => Дебет_;
            set
            {
                if (!Дебет_.Equals(value))
                {
                    Дебет_ = value;
                    Сhanged_Дебет?.Invoke();
                }
            }
        }
        decimal Дебет_ = 0;
        public Action? Сhanged_Дебет { get; set; } = null;


        /* Податки */
        public ВидиПодатків_Pointer Податки
        {
            get => Податки_;
            set
            {
                if (!Податки_.Equals(value))
                {
                    Податки_ = value;
                    Сhanged_Податки?.Invoke();
                }
            }
        }
        ВидиПодатків_Pointer Податки_ = new();
        public Action? Сhanged_Податки { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Рахунок = Рахунок.Copy();
            row.Аналітика1 = Аналітика1.Copy();
            row.Аналітика2 = Аналітика2.Copy();
            row.Аналітика3 = Аналітика3.Copy();
            row.Кредит = Кредит;
            row.Дебет = Дебет;
            row.Податки = Податки.Copy();

            return row;
        }
    }

    #endregion

    #region Функції

    Task ПісляДодаванняНового(ItemRow row)
    {
        return Task.CompletedTask;
    }

    async Task ПісляЗміни_Рахунок(ItemRow row)
    {
        var РахунокОбєкт = await row.Рахунок.GetDirectoryObject();
        if (РахунокОбєкт != null)
        {
            row.Аналітика1 = ФункціїДляДокументів.ЗадатиТипАналітики(row.Аналітика1, РахунокОбєкт.Субконто1);
            row.Аналітика2 = ФункціїДляДокументів.ЗадатиТипАналітики(row.Аналітика2, РахунокОбєкт.Субконто2);
            row.Аналітика3 = ФункціїДляДокументів.ЗадатиТипАналітики(row.Аналітика3, РахунокОбєкт.Субконто3);
        }
    }

    void ПісляЗміни_ДебетАбоКредит(ItemRow row)
    {
        Підсумок.Recount();
    }

    #endregion

    public ПоверненняТоварівПостачальнику_Object? ЕлементВласник { get; set; }
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());
    TotalControl Підсумок = TotalControl.New();

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;

        //
        // Підсумки
        //

        model.OnItemsChanged += (_, _) => Підсумок.Recount();
        Підсумок.QuantifyFunc = () =>
        {
            decimal Дебет = 0, Кредит = 0;

            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    Дебет += row.Дебет;
                    Кредит += row.Кредит;
                }
            }

            return new("Дебет: <b>{0}</b> Кредит: <b>{1}</b>", Дебет, Кредит);
        };

        Append(Підсумок);
    }

    public static ПоверненняТоварівПостачальнику_ТабличнаЧастина_Проводки New()
    {
        ПоверненняТоварівПостачальнику_ТабличнаЧастина_Проводки tablePart = NewWithProperties([]);
        tablePart.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return tablePart;
    }

    protected override void Columns()
    {
        //НомерРядка
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = LabelTablePartCell.New();

                cell.Halign = Align.End;

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not LabelTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                (row.Сhanged_НомерРядка = () => cell.SetText(row.НомерРядка)).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("№", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //Рахунок
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ПланРахунків_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ПланРахунків_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                //Після вибору рахунку
                cell.OnSelect = async () =>
                {
                    row.Рахунок = cell.Pointer;
                    await ПісляЗміни_Рахунок(row);
                };

                (row.Сhanged_Рахунок = () => cell.Pointer = row.Рахунок).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Рахунок", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Аналітика1, Аналітика2, Аналітика3
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Група_Аналітика.New();

                cell.Аналітика1.BoundConfType = "Документи.ПоверненняТоварівПостачальнику.Проводки.Аналітика1";
                cell.Аналітика2.BoundConfType = "Документи.ПоверненняТоварівПостачальнику.Проводки.Аналітика2";
                cell.Аналітика3.BoundConfType = "Документи.ПоверненняТоварівПостачальнику.Проводки.Аналітика3";

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Група_Аналітика cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.Аналітика1.OnSelect = () => row.Аналітика1 = cell.Аналітика1.Pointer;
                (row.Сhanged_Аналітика1 = () => cell.Аналітика1.Pointer = row.Аналітика1).Invoke();

                cell.Аналітика2.OnSelect = () => row.Аналітика2 = cell.Аналітика2.Pointer;
                (row.Сhanged_Аналітика2 = () => cell.Аналітика2.Pointer = row.Аналітика2).Invoke();

                cell.Аналітика3.OnSelect = () => row.Аналітика3 = cell.Аналітика3.Pointer;
                (row.Сhanged_Аналітика3 = () => cell.Аналітика3.Pointer = row.Аналітика3).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Аналітика 1\nАналітика 2\nАналітика 3", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Податки
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ВидиПодатків_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ВидиПодатків_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = () => row.Податки = cell.Pointer;
                (row.Сhanged_Податки = () => cell.Pointer = row.Податки).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Податки", factory);
            column.Resizable = true;

            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Дебет
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = NumericTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = () =>
                {
                    row.Дебет = cell.Value;
                    ПісляЗміни_ДебетАбоКредит(row);
                };

                (row.Сhanged_Дебет = () => cell.Value = row.Дебет).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Дебет", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //Кредит
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = NumericTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = () =>
                {
                    row.Кредит = cell.Value;
                    ПісляЗміни_ДебетАбоКредит(row);
                };

                (row.Сhanged_Кредит = () => cell.Value = row.Кредит).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кредит", factory);
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

    public override async Task LoadRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Проводки_TablePart.FillJoin([ПоверненняТоварівПостачальнику_Проводки_TablePart.НомерРядка,]);
            await ЕлементВласник.Проводки_TablePart.Read();

            Store.RemoveAll();

            foreach (var record in ЕлементВласник.Проводки_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Рахунок = record.Рахунок;
                row.Аналітика1 = record.Аналітика1;
                row.Аналітика2 = record.Аналітика2;
                row.Аналітика3 = record.Аналітика3;
                row.Кредит = record.Кредит;
                row.Дебет = record.Дебет;
                row.Податки = record.Податки;

                Store.Append(row);

                if (SelectPosition > 0)
                {
                    Grid.Model.SelectItem(SelectPosition, true);
                    ScrollTo(SelectPosition);
                }
            }
        }
    }

    public override async Task SaveRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Проводки_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    ЕлементВласник.Проводки_TablePart.Records.Add(new()
                    {
                        UID = row.UniqueID.UGuid,
                        НомерРядка = row.НомерРядка,
                        Рахунок = row.Рахунок,
                        Аналітика1 = row.Аналітика1,
                        Аналітика2 = row.Аналітика2,
                        Аналітика3 = row.Аналітика3,
                        Кредит = row.Кредит,
                        Дебет = row.Дебет,
                        Податки = row.Податки,
                    });
                }
            }
            await ЕлементВласник.Проводки_TablePart.Save(true);

            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.Проводки_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.НомерРядка = x.НомерРядка;
                    row.Рахунок = x.Рахунок;
                    row.Аналітика1 = x.Аналітика1;
                    row.Аналітика2 = x.Аналітика2;
                    row.Аналітика3 = x.Аналітика3;
                    row.Кредит = x.Кредит;
                    row.Дебет = x.Дебет;
                    row.Податки = x.Податки;

                    return row;
                });

                uint count = (uint)rows.Count();

                //Оновлення всіх рядків
                Store.Splice(0, count, [.. rows], count);

                //Виділення рядків після оновлення
                foreach (var position in selection)
                    Grid.Model.SelectItem(position, false);
            }
        }
    }

    public override async Task<bool> NewRecord()
    {
        ItemRow row = ItemRow.New();
        await ПісляДодаванняНового(row);

        Store.Append(row);
        return true;
    }
}
