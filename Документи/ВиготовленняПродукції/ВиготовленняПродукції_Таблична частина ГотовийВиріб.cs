
/*
        ВиготовленняПродукції_ТабличнаЧастина_ГотовийВиріб.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_ia6fAY0DO3unvv5urPdQ")]
partial class ВиготовленняПродукції_ТабличнаЧастина_ГотовийВиріб : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_ia6fAY0DO3unvv5urPdQ")]
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


        /* Артикул */
        public string Артикул
        {
            get => Артикул_;
            set
            {
                if (!Артикул_.Equals(value))
                {
                    Артикул_ = value;
                    Сhanged_Артикул?.Invoke();
                }
            }
        }
        string Артикул_ = "";
        public Action? Сhanged_Артикул { get; set; } = null;


        /* Номенклатура */
        public Номенклатура_Pointer Номенклатура
        {
            get => Номенклатура_;
            set
            {
                if (!Номенклатура_.Equals(value))
                {
                    Номенклатура_ = value;
                    Сhanged_Номенклатура?.Invoke();
                }
            }
        }
        Номенклатура_Pointer Номенклатура_ = new();
        public Action? Сhanged_Номенклатура { get; set; } = null;


        /* ХарактеристикаНоменклатури */
        public ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури
        {
            get => ХарактеристикаНоменклатури_;
            set
            {
                if (!ХарактеристикаНоменклатури_.Equals(value))
                {
                    ХарактеристикаНоменклатури_ = value;
                    Сhanged_ХарактеристикаНоменклатури?.Invoke();
                }
            }
        }
        ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури_ = new();
        public Action? Сhanged_ХарактеристикаНоменклатури { get; set; } = null;


        /* Замовлення */
        public ЗамовленняКлієнта_Pointer Замовлення
        {
            get => Замовлення_;
            set
            {
                if (!Замовлення_.Equals(value))
                {
                    Замовлення_ = value;
                    Сhanged_Замовлення?.Invoke();
                }
            }
        }
        ЗамовленняКлієнта_Pointer Замовлення_ = new();
        public Action? Сhanged_Замовлення { get; set; } = null;


        /* Склад */
        public Склади_Pointer Склад
        {
            get => Склад_;
            set
            {
                if (!Склад_.Equals(value))
                {
                    Склад_ = value;
                    Сhanged_Склад?.Invoke();
                }
            }
        }
        Склади_Pointer Склад_ = new();
        public Action? Сhanged_Склад { get; set; } = null;


        /* ОдиницяВиміру */
        public ПакуванняОдиниціВиміру_Pointer ОдиницяВиміру
        {
            get => ОдиницяВиміру_;
            set
            {
                if (!ОдиницяВиміру_.Equals(value))
                {
                    ОдиницяВиміру_ = value;
                    Сhanged_ОдиницяВиміру?.Invoke();
                }
            }
        }
        ПакуванняОдиниціВиміру_Pointer ОдиницяВиміру_ = new();
        public Action? Сhanged_ОдиницяВиміру { get; set; } = null;


        /* Кількість */
        public decimal Кількість
        {
            get => Кількість_;
            set
            {
                if (!Кількість_.Equals(value))
                {
                    Кількість_ = value;
                    Сhanged_Кількість?.Invoke();
                }
            }
        }
        decimal Кількість_ = 0;
        public Action? Сhanged_Кількість { get; set; } = null;


        /* Коментар */
        public string Коментар
        {
            get => Коментар_;
            set
            {
                if (!Коментар_.Equals(value))
                {
                    Коментар_ = value;
                    Сhanged_Коментар?.Invoke();
                }
            }
        }
        string Коментар_ = "";
        public Action? Сhanged_Коментар { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Артикул = Артикул;
            row.Номенклатура = Номенклатура.Copy();
            row.ХарактеристикаНоменклатури = ХарактеристикаНоменклатури.Copy();
            row.Замовлення = Замовлення.Copy();
            row.Склад = Склад.Copy();
            row.ОдиницяВиміру = ОдиницяВиміру.Copy();
            row.Кількість = Кількість;
            row.Коментар = Коментар;

            return row;
        }
    }

    #endregion

    #region Функції

    Task ПісляДодаванняНового(ItemRow row)
    {
        row.Кількість = 1;
        return Task.CompletedTask;
    }

    async Task ПісляЗміни_Артикул(ItemRow row)
    {
        if (row.Номенклатура.IsEmpty() && row.Артикул.Trim().Length > 3)
        {
            Номенклатура_Pointer Вказівник = await new Номенклатура_Select().FindByField(Номенклатура_Const.Артикул, row.Артикул.Trim(), "LOWER");
            if (!Вказівник.IsEmpty())
            {
                row.Номенклатура = Вказівник;
                await ПісляЗміни_Номенклатура(row);
            }
        }
    }

    async Task ПісляЗміни_Номенклатура(ItemRow row)
    {
        Номенклатура_Object? обєкт = await row.Номенклатура.GetDirectoryObject();
        if (обєкт != null && !обєкт.ОдиницяВиміру.IsEmpty())
        {
            await обєкт.ОдиницяВиміру.GetPresentation();
            row.ОдиницяВиміру = обєкт.ОдиницяВиміру;

            await ПісляЗміни_Пакування(row);
        }
    }

    Task ПісляЗміни_ХарактеристикаНоменклатури(ItemRow row)
    {
        return Task.CompletedTask;
    }

    Task ПісляЗміни_Пакування(ItemRow row)
    {
        return Task.CompletedTask;
    }

    Task ПісляЗміни_Замовлення(ItemRow row)
    {
        return Task.CompletedTask;
    }

    Task ПісляЗміни_Склад(ItemRow row)
    {
        return Task.CompletedTask;
    }

    void ПісляЗміни_Кількість(ItemRow row)
    {

    }

    #endregion

    public ВиготовленняПродукції_Object? ЕлементВласник { get; set; }
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static ВиготовленняПродукції_ТабличнаЧастина_ГотовийВиріб New()
    {
        ВиготовленняПродукції_ТабличнаЧастина_ГотовийВиріб tablePart = NewWithProperties([]);
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

        //Артикул
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = async () =>
                {
                    row.Артикул = cell.Value;
                    await ПісляЗміни_Артикул(row);
                };

                (row.Сhanged_Артикул = () => cell.Value = row.Артикул).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Артикул", factory);
            column.Resizable = true;
            column.FixedWidth = 200;

            Grid.AppendColumn(column);
        }

        //Номенклатура
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Номенклатура_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Номенклатура_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = async () =>
                {
                    row.Номенклатура = cell.Pointer;
                    await ПісляЗміни_Номенклатура(row);
                };

                (row.Сhanged_Номенклатура = () => cell.Pointer = row.Номенклатура).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Номенклатура", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //ХарактеристикаНоменклатури
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ХарактеристикиНоменклатури_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ХарактеристикиНоменклатури_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.BeforeClickOpenFunc = async () => cell.Власник = row.Номенклатура;
                cell.OnSelect = async () =>
                {
                    row.ХарактеристикаНоменклатури = cell.Pointer;
                    await ПісляЗміни_ХарактеристикаНоменклатури(row);
                };

                (row.Сhanged_ХарактеристикаНоменклатури = () => cell.Pointer = row.ХарактеристикаНоменклатури).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Характеристика", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //ОдиницяВиміру
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ПакуванняОдиниціВиміру_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ПакуванняОдиниціВиміру_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = async () =>
                {
                    row.ОдиницяВиміру = cell.Pointer;
                    await ПісляЗміни_Пакування(row);
                };

                (row.Сhanged_ОдиницяВиміру = () => cell.Pointer = row.ОдиницяВиміру).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Пакування", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //Кількість
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
                    row.Кількість = cell.Value;
                    ПісляЗміни_Кількість(row);
                };

                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //Замовлення
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ЗамовленняКлієнта_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ЗамовленняКлієнта_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = async () =>
                {
                    row.Замовлення = cell.Pointer;
                    await ПісляЗміни_Замовлення(row);
                };

                (row.Сhanged_Замовлення = () => cell.Pointer = row.Замовлення).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Замовлення", factory);
            column.Resizable = true;

            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Склад
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Склади_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Склади_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = async () =>
                {
                    row.Склад = cell.Pointer;
                    await ПісляЗміни_Склад(row);
                };

                (row.Сhanged_Склад = () => cell.Pointer = row.Склад).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Склад", factory);
            column.Resizable = true;

            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Коментар
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = () => row.Коментар = cell.Value;
                (row.Сhanged_Коментар = () => cell.Value = row.Коментар).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Коментар", factory);
            column.Resizable = true;
            column.FixedWidth = 500;

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
            ЕлементВласник.ГотовийВиріб_TablePart.FillJoin([ВиготовленняПродукції_ГотовийВиріб_TablePart.НомерРядка,]);
            await ЕлементВласник.ГотовийВиріб_TablePart.Read();

            Store.RemoveAll();

            foreach (var record in ЕлементВласник.ГотовийВиріб_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Артикул = record.Артикул;
                row.Номенклатура = record.Номенклатура;
                row.ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури;
                row.Замовлення = record.Замовлення;
                row.Склад = record.Склад;
                row.ОдиницяВиміру = record.ОдиницяВиміру;
                row.Кількість = record.Кількість;
                row.Коментар = record.Коментар;

                Store.Append(row);

                if (SelectPosition > 0)
                {
                    Grid.Model.SelectItem(SelectPosition, true);
                    ScrollTo(SelectPosition);
                }
            }
        }
    }

    /// <summary>
    /// Функція повертає рядки табличної частини
    /// </summary>
    public List<ВиготовленняПродукції_ГотовийВиріб_TablePart.Record> GetRecords()
    {
        List<ВиготовленняПродукції_ГотовийВиріб_TablePart.Record> records = [];

        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
                records.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Артикул = row.Артикул,
                    Номенклатура = row.Номенклатура,
                    ХарактеристикаНоменклатури = row.ХарактеристикаНоменклатури,
                    Замовлення = row.Замовлення,
                    Склад = row.Склад,
                    ОдиницяВиміру = row.ОдиницяВиміру,
                    Кількість = row.Кількість,
                    Коментар = row.Коментар,
                });
        }

        return records;
    }

    public override async Task SaveRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.ГотовийВиріб_TablePart.Records.Clear();
            ЕлементВласник.ГотовийВиріб_TablePart.Records.AddRange(GetRecords());
            await ЕлементВласник.ГотовийВиріб_TablePart.Save(true);

            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.ГотовийВиріб_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.НомерРядка = x.НомерРядка;
                    row.Артикул = x.Артикул;
                    row.Номенклатура = x.Номенклатура;
                    row.ХарактеристикаНоменклатури = x.ХарактеристикаНоменклатури;
                    row.Замовлення = x.Замовлення;
                    row.Склад = x.Склад;
                    row.ОдиницяВиміру = x.ОдиницяВиміру;
                    row.Кількість = x.Кількість;
                    row.Коментар = x.Коментар;

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
        ItemRow itemRow = ItemRow.New();
        await ПісляДодаванняНового(itemRow);

        Store.Append(itemRow);
        return true;
    }
}
