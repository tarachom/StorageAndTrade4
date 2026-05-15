
/*
        ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using GeneratedCode.Константи;
using GeneratedCode.РегістриВідомостей;
using GeneratedCode;
using GLib;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_6Ebs0xoxeEWDiGl47X9vIg")]
partial class ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_6Ebs0xoxeEWDiGl47X9vIg")]
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

        /* Серія */
        public СеріїНоменклатури_Pointer Серія
        {
            get => Серія_;
            set
            {
                if (!Серія_.Equals(value))
                {
                    Серія_ = value;
                    Сhanged_Серія?.Invoke();
                }
            }
        }
        СеріїНоменклатури_Pointer Серія_ = new();
        public Action? Сhanged_Серія { get; set; } = null;

        /* КількістьУпаковок */
        public int КількістьУпаковок
        {
            get => КількістьУпаковок_;
            set
            {
                if (!КількістьУпаковок_.Equals(value))
                {
                    КількістьУпаковок_ = value;
                    Сhanged_КількістьУпаковок?.Invoke();
                }
            }
        }
        int КількістьУпаковок_ = 0;
        public Action? Сhanged_КількістьУпаковок { get; set; } = null;

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

        /* ВидЦіни */
        public ВидиЦін_Pointer ВидЦіни
        {
            get => ВидЦіни_;
            set
            {
                if (!ВидЦіни_.Equals(value))
                {
                    ВидЦіни_ = value;
                    Сhanged_ВидЦіни?.Invoke();
                }
            }
        }
        ВидиЦін_Pointer ВидЦіни_ = new();
        public Action? Сhanged_ВидЦіни { get; set; } = null;

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

        /* Скидка */
        public decimal Скидка
        {
            get => Скидка_;
            set
            {
                if (!Скидка_.Equals(value))
                {
                    Скидка_ = value;
                    Сhanged_Скидка?.Invoke();
                }
            }
        }
        decimal Скидка_ = 0;
        public Action? Сhanged_Скидка { get; set; } = null;

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

        /* ЗамовленняПостачальнику */
        public ЗамовленняПостачальнику_Pointer ЗамовленняПостачальнику
        {
            get => ЗамовленняПостачальнику_;
            set
            {
                if (!ЗамовленняПостачальнику_.Equals(value))
                {
                    ЗамовленняПостачальнику_ = value;
                    Сhanged_ЗамовленняПостачальнику?.Invoke();
                }
            }
        }
        ЗамовленняПостачальнику_Pointer ЗамовленняПостачальнику_ = new();
        public Action? Сhanged_ЗамовленняПостачальнику { get; set; } = null;

        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Номенклатура = Номенклатура.Copy();
            row.ХарактеристикаНоменклатури = ХарактеристикаНоменклатури.Copy();
            row.Серія = Серія.Copy();
            row.КількістьУпаковок = КількістьУпаковок;
            row.Пакування = Пакування.Copy();
            row.Кількість = Кількість;
            row.ВидЦіни = ВидЦіни.Copy();
            row.Ціна = Ціна;
            row.Склад = Склад.Copy();
            row.Скидка = Скидка;
            row.Сума = Сума;
            row.ЗамовленняПостачальнику = ЗамовленняПостачальнику.Copy();

            return row;
        }
    }

    async ValueTask ПісляЗміни_Номенклатура(ItemRow row)
    {
        Номенклатура_Objest? обєкт = await row.Номенклатура.GetDirectoryObject();
        if (обєкт != null && !обєкт.ОдиницяВиміру.IsEmpty())
        {
            await обєкт.ОдиницяВиміру.GetPresentation();
            row.Пакування = обєкт.ОдиницяВиміру;

            await ПісляЗміни_Пакування(row);
        }

        await ОтриматиЦіну(row);
    }

    async ValueTask ПісляЗміни_ХарактеристикаНоменклатури(ItemRow row)
    {
        await ОтриматиЦіну(row);
    }

    async ValueTask ПісляЗміни_Серія(ItemRow row)
    {
        
    }

    async ValueTask ПісляЗміни_Пакування(ItemRow row)
    {
        if (!row.Пакування.IsEmpty())
        {
            ПакуванняОдиниціВиміру_Objest? обєкт = await row.Пакування.GetDirectoryObject();
            if (обєкт != null)
                row.КількістьУпаковок = (обєкт.КількістьУпаковок > 0) ? обєкт.КількістьУпаковок : 1;
            else
                row.КількістьУпаковок = 1;
        }

        ПісляЗміни_КількістьАбоЦіна(row);
    }

    void ПісляЗміни_КількістьАбоЦіна(ItemRow row)
    {
        row.Сума = row.Кількість * row.Ціна;

        ОбчислитиПідсумки();
    }

    void ПісляЗміни_Скидка(ItemRow row)
    {
        ОбчислитиПідсумки();
    }

    void ПісляЗміни_Сума(ItemRow row)
    {
        ОбчислитиПідсумки();
    }

    async ValueTask ОтриматиЦіну(ItemRow row)
    {
        if (row.Сума != 0)
            return;

        if (row.Номенклатура.IsEmpty())
            return;

        if (row.ВидЦіни.IsEmpty())
            return;

        string query = $@"
SELECT
    ЦіниНоменклатури.{ЦіниНоменклатури_Const.Ціна} AS Ціна
FROM 
    {ЦіниНоменклатури_Const.TABLE} AS ЦіниНоменклатури
WHERE
    ЦіниНоменклатури.{ЦіниНоменклатури_Const.ВидЦіни} = '{row.ВидЦіни.UniqueID}' AND
    ЦіниНоменклатури.{ЦіниНоменклатури_Const.Номенклатура} = '{row.Номенклатура.UniqueID}' AND
    ЦіниНоменклатури.{ЦіниНоменклатури_Const.ХарактеристикаНоменклатури} = '{row.ХарактеристикаНоменклатури.UniqueID}'
ORDER BY 
    ЦіниНоменклатури.period DESC 
LIMIT 1
";
        var recordResult = await Config.Kernel.DataBase.SelectRequest(query);
        if (recordResult.Result)
            foreach (Dictionary<string, object> listitemrow in recordResult.ListRow)
            {
                row.Ціна = (decimal)listitemrow["Ціна"];
                row.Сума = row.Кількість * row.Ціна;
            }
    }

    #endregion

    public ПоступленняТоварівТаПослуг_Objest? ЕлементВласник { get; set; }

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;
        model.OnItemsChanged += (_, _) => ОбчислитиПідсумки();

        Grid.Model = model;

        CreateBottomBlock();
    }

    #region Підсумки

    Label ПідсумокСума = Label.New(null);
    Label ПідсумокСкидка = Label.New(null);

    void CreateBottomBlock()
    {
        Box hBox = Box.New(Orientation.Horizontal, 0);
        hBox.Halign = Align.Start;

        Label label = Label.New("<b>Підсумки</b> ");
        label.UseMarkup = true;

        hBox.Append(label);

        ПідсумокСума.Selectable = true;
        hBox.Append(ПідсумокСума);

        ПідсумокСкидка.Selectable = true;
        hBox.Append(ПідсумокСкидка);

        Append(hBox);
    }

    void ОбчислитиПідсумки()
    {
        decimal Сума = 0;
        decimal Скидка = 0;

        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                Сума += row.Сума;
                Скидка += row.Скидка;
            }
        }

        ПідсумокСума.SetText($"Сума: <b>{Сума}</b>");
        ПідсумокСума.UseMarkup = true;

        ПідсумокСкидка.SetText($"Скидка: <b>{Скидка}</b>");
        ПідсумокСкидка.UseMarkup = true;
    }

    #endregion

    public static ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари New()
    {
        ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари tablePart = NewWithProperties([]);
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

                cell.BeforeClickOpenFunc = () => cell.Власник = row.Номенклатура;

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

        //Серія
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = СеріїНоменклатури_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not СеріїНоменклатури_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = async () =>
                {
                    row.Серія = cell.Pointer;
                    await ПісляЗміни_Серія(row);
                };

                (row.Сhanged_Серія = () => cell.Pointer = row.Серія).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Серія", factory);
            column.Resizable = true;

            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //КількістьУпаковок
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = IntegerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not IntegerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = () => row.КількістьУпаковок = cell.Value;
                (row.Сhanged_КількістьУпаковок = () => cell.Value = row.КількістьУпаковок).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Коєфіціент", factory);
            column.Resizable = true;

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

                cell.OnSelect = async () =>
                {
                    row.Пакування = cell.Pointer;
                    await ПісляЗміни_Пакування(row);
                };

                (row.Сhanged_Пакування = () => cell.Pointer = row.Пакування).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Пакування", factory);
            column.Resizable = true;
            column.FixedWidth = 200;

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
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //ВидЦіни
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ВидиЦін_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ВидиЦін_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = () => row.ВидЦіни = cell.Pointer;
                (row.Сhanged_ВидЦіни = () => cell.Pointer = row.ВидЦіни).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Вид ціни", factory);
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
            ColumnViewColumn column = ColumnViewColumn.New("Ціна", factory);
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
            ColumnViewColumn column = ColumnViewColumn.New("Склад", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Скидка
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
                    row.Скидка = cell.Value;
                    ПісляЗміни_Скидка(row);
                };
                (row.Сhanged_Скидка = () => cell.Value = row.Скидка).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Скидка", factory);
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
            ColumnViewColumn column = ColumnViewColumn.New("Сума", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //ЗамовленняПостачальнику
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ЗамовленняПостачальнику_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ЗамовленняПостачальнику_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = () => row.ЗамовленняПостачальнику = cell.Pointer;
                (row.Сhanged_ЗамовленняПостачальнику = () => cell.Pointer = row.ЗамовленняПостачальнику).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("ЗамовленняПостачальнику", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

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
            ЕлементВласник.Товари_TablePart.FillJoin([ПоступленняТоварівТаПослуг_Товари_TablePart.НомерРядка,]);
            await ЕлементВласник.Товари_TablePart.Read();

            Store.RemoveAll();

            foreach (var record in ЕлементВласник.Товари_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Номенклатура = record.Номенклатура;
                row.ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури;
                row.Серія = record.Серія;
                row.КількістьУпаковок = record.КількістьУпаковок;
                row.Пакування = record.Пакування;
                row.Кількість = record.Кількість;
                row.ВидЦіни = record.ВидЦіни;
                row.Ціна = record.Ціна;
                row.Склад = record.Склад;
                row.Скидка = record.Скидка;
                row.Сума = record.Сума;
                row.ЗамовленняПостачальнику = record.ЗамовленняПостачальнику;

                Store.Append(row);

                if (SelectPosition > 0)
                {
                    Grid.Model.SelectItem(SelectPosition, true);
                    ScrollTo(SelectPosition);
                }
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
                        UID = row.UniqueID.UGuid,
                        НомерРядка = row.НомерРядка,
                        Номенклатура = row.Номенклатура,
                        ХарактеристикаНоменклатури = row.ХарактеристикаНоменклатури,
                        Серія = row.Серія,
                        КількістьУпаковок = row.КількістьУпаковок,
                        Пакування = row.Пакування,
                        Кількість = row.Кількість,
                        ВидЦіни = row.ВидЦіни,
                        Ціна = row.Ціна,
                        Склад = row.Склад,
                        Скидка = row.Скидка,
                        Сума = row.Сума,
                        ЗамовленняПостачальнику = row.ЗамовленняПостачальнику,
                    });
                }
            }
            await ЕлементВласник.Товари_TablePart.Save(true);

            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.Товари_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.НомерРядка = x.НомерРядка;
                    row.Номенклатура = x.Номенклатура;
                    row.ХарактеристикаНоменклатури = x.ХарактеристикаНоменклатури;
                    row.Серія = x.Серія;
                    row.КількістьУпаковок = x.КількістьУпаковок;
                    row.Пакування = x.Пакування;
                    row.Кількість = x.Кількість;
                    row.ВидЦіни = x.ВидЦіни;
                    row.Ціна = x.Ціна;
                    row.Склад = x.Склад;
                    row.Скидка = x.Скидка;
                    row.Сума = x.Сума;
                    row.ЗамовленняПостачальнику = x.ЗамовленняПостачальнику;

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

    public override async ValueTask<bool> NewRecord()
    {
        ItemRow itemRow = ItemRow.New();

        var ВидЦіни = ЗначенняТипові.ОсновнийВидЦіниЗакупівлі_Const;
        await ВидЦіни.GetPresentation();

        itemRow.ВидЦіни = ВидЦіни;
        itemRow.Кількість = 1;

        Store.Append(itemRow);

        return true;
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
}
