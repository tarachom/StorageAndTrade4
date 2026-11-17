/*
        ЗакриттяРахункуФактури_ТабличнаЧастина_Товари.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Константи;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("ZakryttiaRakhunkuFaktury_TablePart_Tovary")]
partial class ЗакриттяРахункуФактури_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Модель даних
    
    [GObject.Subclass<GObject.Object>("ZakryttiaRakhunkuFaktury_TablePart_Tovary_ItemRow")]
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


        /* Пакування */
        public ПакуванняОдиниціВиміру_Pointer Пакування
        {
            get => Пакування_;
            set
            {
                if (!Пакування_.Equals(value))
                {
                    Пакування_ = value;
                    Сhanged_Пакування?.Invoke();
                }
            }
        }
        ПакуванняОдиниціВиміру_Pointer Пакування_ = new();
        public Action? Сhanged_Пакування { get; set; } = null;


        /* Коєфіціент */
        public decimal Коєфіціент
        {
            get => Коєфіціент_;
            set
            {
                if (!Коєфіціент_.Equals(value))
                {
                    Коєфіціент_ = value;
                    Сhanged_Коєфіціент?.Invoke();
                }
            }
        }
        decimal Коєфіціент_ = 0;
        public Action? Сhanged_Коєфіціент { get; set; } = null;


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


        /* Ціна */
        public decimal Ціна
        {
            get => Ціна_;
            set
            {
                if (!Ціна_.Equals(value))
                {
                    Ціна_ = value;
                    Сhanged_Ціна?.Invoke();
                }
            }
        }
        decimal Ціна_ = 0;
        public Action? Сhanged_Ціна { get; set; } = null;


        /* Сума */
        public decimal Сума
        {
            get => Сума_;
            set
            {
                if (!Сума_.Equals(value))
                {
                    Сума_ = value;
                    Сhanged_Сума?.Invoke();
                }
            }
        }
        decimal Сума_ = 0;
        public Action? Сhanged_Сума { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Номенклатура = Номенклатура.Copy();
            row.ХарактеристикаНоменклатури = ХарактеристикаНоменклатури.Copy();
            row.Пакування = Пакування.Copy();
            row.Коєфіціент = Коєфіціент;
            row.Кількість = Кількість;
            row.Склад = Склад.Copy();
            row.Ціна = Ціна;
            row.Сума = Сума;

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

    async Task ПісляЗміни_Номенклатура(ItemRow row)
    {
        Номенклатура_Object? обєкт = await row.Номенклатура.GetDirectoryObject();
        if (обєкт != null && !обєкт.ОдиницяВиміру.IsEmpty())
        {
            await обєкт.ОдиницяВиміру.GetPresentation();
            row.Пакування = обєкт.ОдиницяВиміру;

            await ПісляЗміни_Пакування(row);
        }
    }

    Task ПісляЗміни_ХарактеристикаНоменклатури(ItemRow row)
    {
        return Task.CompletedTask;
    }

    async Task ПісляЗміни_Пакування(ItemRow row)
    {
        if (!row.Пакування.IsEmpty())
        {
            ПакуванняОдиниціВиміру_Object? обєкт = await row.Пакування.GetDirectoryObject();
            if (обєкт != null)
                row.Коєфіціент = (обєкт.Коєфіціент > 0) ? обєкт.Коєфіціент : 1;
            else
                row.Коєфіціент = 1;
        }

        ПісляЗміни_КількістьАбоЦіна(row);
    }

    void ПісляЗміни_КількістьАбоЦіна(ItemRow row)
    {
        row.Сума = row.Кількість * row.Ціна;
        Підсумок.Recount();
    }

    void ПісляЗміни_Скидка(ItemRow row)
    {
        Підсумок.Recount();
    }

    void ПісляЗміни_Сума(ItemRow row)
    {
        Підсумок.Recount();
    }

    public decimal СумаДокументу()
    {
        decimal Сума = 0;

        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
                Сума += row.Сума;
        }

        return Math.Round(Сума, 2);
    }

    #endregion

    public ЗакриттяРахункуФактури_Object? ЕлементВласник { get; set; }
    public ЗакриттяРахункуФактури_Елемент? ЕлементВласникФорма { get; set; }

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
            decimal Сума = 0;

            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                    Сума += row.Сума;
            }

            return new("Сума: <b>{0}</b>", Сума);
        };

        Append(Підсумок);

        //
        // Кнопки
        //

        {
            Separator separator = Separator.New(Orientation.Vertical);
            separator.MarginStart = 5;
            separator.MarginEnd = 10;
            HBoxToolbarTop.Append(separator);
        }

        //Заповнити
        {
            Button button = Button.NewWithLabel("Заповнити із рахунку");
            button.AddCssClass("toolbar");
            button.OnClicked += async (_, _) =>
            {
                if (Store.GetNItems() == 0 || await Message.Request(NotebookFunc?.BasicForm, "Очистити табличну частину?", "В табличній частині вже є дані. Щоб продовжити заповнення потрібно спочатку очистити табличну частину!") == Message.YesNo.Yes)
                {
                    button.Sensitive = false;
                    await Заповнити();
                    button.Sensitive = true;
                }
            };
            HBoxToolbarTop.Append(button);
        }
    }

    #region Функції обчислення

    async Task Заповнити()
    {
        if (ЕлементВласникФорма != null)
            if (!ЕлементВласникФорма.РахунокФактура_Значення.IsEmpty())
            {
                List<ItemRow> rows = [];
                int counter = 0;

                //Зчитую обєкт без таб частин
                РахунокФактура_Object? РахунокФактура = await ЕлементВласникФорма.РахунокФактура_Значення.GetDocumentObject(false);
                if (РахунокФактура != null)
                {
                    //Підготовляю склад в документі
                    await РахунокФактура.Склад.GetPresentation();

                    //Для таб частини викликаю заповнення FillJoin перед зчитуванням, щоб вказівники уже були заповнені назвами
                    РахунокФактура.Товари_TablePart.FillJoin();
                    await РахунокФактура.Товари_TablePart.Read();

                    foreach (РахунокФактура_Товари_TablePart.Record record in РахунокФактура.Товари_TablePart.Records)
                    {
                        var row = ItemRow.New();
                        row.НомерРядка = ++counter;
                        row.Номенклатура = record.Номенклатура;
                        row.ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури;
                        row.Коєфіціент = record.Коєфіціент;
                        row.Пакування = record.Пакування;
                        row.Кількість = record.Кількість;
                        row.Ціна = record.Ціна;
                        row.Сума = record.Сума;

                        //Якщо не заповнений склад в таб частині - використовую з документу
                        row.Склад = record.Склад.IsEmpty() ? РахунокФактура.Склад : record.Склад;

                        rows.Add(row);
                    }
                }

                UpdateStore([.. rows]);
            }
    }

    #endregion

    public static ЗакриттяРахункуФактури_ТабличнаЧастина_Товари New()
    {
        ЗакриттяРахункуФактури_ТабличнаЧастина_Товари tablePart = NewWithProperties([]);
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
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not LabelTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                row.Сhanged_НомерРядка = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("№", factory);
            column.Resizable = true;

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
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Номенклатура_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = null;
                row.Сhanged_Номенклатура = null;
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

                cell.BeforeClickOpenFunc = () => cell.Власник = row.Номенклатура;

                cell.OnSelect = async () =>
                {
                    row.ХарактеристикаНоменклатури = cell.Pointer;
                    await ПісляЗміни_ХарактеристикаНоменклатури(row);
                };

                (row.Сhanged_ХарактеристикаНоменклатури = () => cell.Pointer = row.ХарактеристикаНоменклатури).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ХарактеристикиНоменклатури_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.BeforeClickOpenFunc = null;
                cell.OnSelect = null;
                row.Сhanged_ХарактеристикаНоменклатури = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Характеристика", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Коєфіціент
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

                cell.OnСhanged = () => row.Коєфіціент = cell.Value;
                (row.Сhanged_Коєфіціент = () => cell.Value = row.Коєфіціент).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = null;
                row.Сhanged_Коєфіціент = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Коєфіціент", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //Пакування
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

                cell.BeforeClickOpenFunc = () => cell.Власник = row.Номенклатура;

                cell.OnSelect = async () =>
                {
                    row.Пакування = cell.Pointer;
                    await ПісляЗміни_Пакування(row);
                };

                (row.Сhanged_Пакування = () => cell.Pointer = row.Пакування).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ПакуванняОдиниціВиміру_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.BeforeClickOpenFunc = null;
                cell.OnSelect = null;
                row.Сhanged_Пакування = null;
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
                    ПісляЗміни_КількістьАбоЦіна(row);
                };

                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = null;
                row.Сhanged_Кількість = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

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

                cell.OnSelect = () => row.Склад = cell.Pointer;
                (row.Сhanged_Склад = () => cell.Pointer = row.Склад).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Склади_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = null;
                row.Сhanged_Склад = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Склад", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Ціна
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
                    row.Ціна = cell.Value;
                    ПісляЗміни_КількістьАбоЦіна(row);
                };

                (row.Сhanged_Ціна = () => cell.Value = row.Ціна).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = null;
                row.Сhanged_Ціна = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ціна", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //Сума
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
                    row.Сума = cell.Value;
                    ПісляЗміни_Сума(row);
                };

                (row.Сhanged_Сума = () => cell.Value = row.Сума).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = null;
                row.Сhanged_Сума = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Сума", factory);
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

    ItemRow[] ToItemRows(List<ЗакриттяРахункуФактури_Товари_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.Номенклатура = x.Номенклатура;
        row.ХарактеристикаНоменклатури = x.ХарактеристикаНоменклатури;
        row.Пакування = x.Пакування;
        row.Коєфіціент = x.Коєфіціент;
        row.Кількість = x.Кількість;
        row.Склад = x.Склад;
        row.Ціна = x.Ціна;
        row.Сума = x.Сума;
        
        return row;
    })];

    List<ЗакриттяРахункуФактури_Товари_TablePart.Record> ToRecords()
    {
        List<ЗакриттяРахункуФактури_Товари_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Номенклатура = row.Номенклатура,
                    ХарактеристикаНоменклатури = row.ХарактеристикаНоменклатури,
                    Пакування = row.Пакування,
                    Коєфіціент = row.Коєфіціент,
                    Кількість = row.Кількість,
                    Склад = row.Склад,
                    Ціна = row.Ціна,
                    Сума = row.Сума,
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.FillJoin([ЗакриттяРахункуФактури_Товари_TablePart.НомерРядка,]);
            await ЕлементВласник.Товари_TablePart.Read();

            UpdateStore(ToItemRows(ЕлементВласник.Товари_TablePart.Records));
        }
    }

    public override async Task SaveRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.Records.Clear();
            ЕлементВласник.Товари_TablePart.Records.AddRange(ToRecords());
            await ЕлементВласник.Товари_TablePart.Save(true);
            UpdateStore(ToItemRows(ЕлементВласник.Товари_TablePart.Records));
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