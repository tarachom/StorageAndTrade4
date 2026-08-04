
/*
        ВиготовленняПродукції_ТабличнаЧастина_Проводки2.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using NPOI.HSSF.Record;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_JMyfAdI4OHaubsTeizx51Q")]
partial class ВиготовленняПродукції_ТабличнаЧастина_Проводки2 : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_JMyfAdI4OHaubsTeizx51Q")]
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



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Рахунок = Рахунок.Copy();
            row.Дебет = Дебет;
            row.Кредит = Кредит;
            row.Кількість = Кількість;

            return row;
        }
    }

    #endregion

    #region Функції

    Task ПісляДодаванняНового(ItemRow row)
    {
        return Task.CompletedTask;
    }

    Task ПісляЗміни_Рахунок(ItemRow row)
    {
        return Task.CompletedTask;
    }

    void ПісляЗміни_ДебетКредитКількість(ItemRow row)
    {
        Підсумок.Recount();
    }

    #endregion

    public ВиготовленняПродукції_Object? ЕлементВласник { get; set; }
    public ВиготовленняПродукції_Елемент? ЕлементВласникФорма { get; set; }
    public Func<Task<bool>>? ФункціяЗберегтиДокумент { get; set; }

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

        //
        // Кнопки
        //

        {
            Separator separator = Separator.New(Orientation.Vertical);
            separator.MarginStart = 5;
            separator.MarginEnd = 10;
            HBoxToolbarTop.Append(separator);
        }

        Button button = Button.NewWithLabel("Заповнити");
        button.AddCssClass("toolbar");
        button.OnClicked += async (_, _) =>
        {
            button.Sensitive = false;

            if (Store.GetNItems() == 0)
                await ЗаповнитиПроводки();
            else
                Message.Request(NotebookFunc?.BasicForm, "Очистити табличну частину?",
                    "В табличній частині вже є дані. Щоб продовжити заповнення потрібно спочатку очистити табличну частину!",
                    async x =>
                    {
                        if (x == Message.YesNo.Yes)
                            await ЗаповнитиПроводки();
                    });

            button.Sensitive = true;
        };
        HBoxToolbarTop.Append(button);
    }

    async Task ЗаповнитиПроводки()
    {
        if (ЕлементВласник != null && ЕлементВласникФорма != null && ФункціяЗберегтиДокумент != null)
        {
            //Документ потрібно зберегти
            Console.WriteLine("Збережено: " + await ФункціяЗберегтиДокумент.Invoke());

            Store.RemoveAll();

            ПланРахунків_Pointer РахунокВиробництво = await ФункціїДляБух.РахунокЗПідрозділу("РахунокОбліку", ЕлементВласникФорма.Підрозділ_Значення, "23");
            decimal ЗагальнаСумаСобівартістьПартії = 0;

            //Обробка таб частини Комплектуючі
            foreach (var Рядок in ЕлементВласникФорма.Комплектуючі_Колекція())
            {
                ПланРахунків_Pointer РахунокЗапаси = await ФункціїДляБух.РахунокЗНоменклатуриАбоСкладу("РахунокОбліку", Рядок.Номенклатура, Рядок.Склад, "201");

                var recordResult = await ПроведенняДокументів.ОтриматиСписокНаявнихПартій(
                    ЕлементВласник.Організація, Рядок.Номенклатура, Рядок.ХарактеристикаНоменклатури,
                    Рядок.Серія, Рядок.Склад, Рядок.Партія, ЕлементВласник.UniqueID, ЕлементВласник.ДатаДок,
                    Рядок.Кількість);

                if (!recordResult.Result)
                {
                    Console.WriteLine($"Немає доступних партій для товару в рядку {Рядок.НомерРядка}");
                    //continue;
                }

                decimal КількістьЯкуПотрібноСписати = Рядок.Кількість;
                decimal СумаСобівартістьПартії = 0;

                foreach (Dictionary<string, object> nameRow in recordResult.ListRow)
                {
                    decimal КількістьВПартії = (decimal)nameRow["Кількість"];
                    decimal СобівартістьПартії = (decimal)nameRow["Собівартість"];

                    decimal КількістьЩоСписується = 0;
                    if (КількістьВПартії >= КількістьЯкуПотрібноСписати)
                    {
                        КількістьЩоСписується = КількістьЯкуПотрібноСписати;
                        КількістьЯкуПотрібноСписати = 0;
                    }
                    else
                    {
                        КількістьЩоСписується = КількістьВПартії;
                        КількістьЯкуПотрібноСписати -= КількістьВПартії;
                    }

                    СумаСобівартістьПартії += СобівартістьПартії * КількістьЩоСписується;
                    Console.WriteLine(СобівартістьПартії + " * " + КількістьВПартії + " = " + СумаСобівартістьПартії);

                    if (КількістьЯкуПотрібноСписати == 0)
                        break;
                }

                if (КількістьЯкуПотрібноСписати > 0)
                {
                    Console.WriteLine($"Невистачило списати {КількістьЯкуПотрібноСписати} товарів в рядку {Рядок.НомерРядка}");
                    //continue;
                }

                ЗагальнаСумаСобівартістьПартії += СумаСобівартістьПартії;

                //Кредит
                {
                    var row = ItemRow.New();
                    row.Рахунок = РахунокЗапаси;
                    row.Кредит = СумаСобівартістьПартії;
                    row.Кількість = Рядок.Кількість;

                    Store.Append(row);
                }

                //Дебет
                {
                    var row = ItemRow.New();
                    row.Рахунок = РахунокВиробництво;
                    row.Дебет = СумаСобівартістьПартії;
                    row.Кількість = 0;

                    Store.Append(row);
                }
            }

            //Обробка таб частини ГотовийВиріб
            foreach (var Рядок in ЕлементВласникФорма.ГотовийВиріб_Колекція())
            {
                ПланРахунків_Pointer РахунокЗапаси = await ФункціїДляБух.РахунокЗНоменклатуриАбоСкладу("РахунокОбліку", Рядок.Номенклатура, Рядок.Склад, "26");

                //Кредит
                {
                    var row = ItemRow.New();
                    row.Рахунок = РахунокВиробництво;
                    row.Кредит = ЗагальнаСумаСобівартістьПартії;
                    row.Кількість = 0;

                    Store.Append(row);
                }

                //Дебет
                {
                    var row = ItemRow.New();
                    row.Рахунок = РахунокЗапаси;
                    row.Дебет = ЗагальнаСумаСобівартістьПартії;
                    row.Кількість = Рядок.Кількість;

                    Store.Append(row);
                }
            }
        }
    }

    public static ВиготовленняПродукції_ТабличнаЧастина_Проводки2 New()
    {
        ВиготовленняПродукції_ТабличнаЧастина_Проводки2 tablePart = NewWithProperties([]);
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
                    ПісляЗміни_ДебетКредитКількість(row);
                };

                (row.Сhanged_Дебет = () => cell.Value = row.Дебет).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Дебет", factory);
            column.Resizable = true;
            column.FixedWidth = 150;

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
                    ПісляЗміни_ДебетКредитКількість(row);
                };

                (row.Сhanged_Кредит = () => cell.Value = row.Кредит).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кредит", factory);
            column.Resizable = true;
            column.FixedWidth = 150;

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
                    ПісляЗміни_ДебетКредитКількість(row);
                };

                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            column.FixedWidth = 150;

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
            ЕлементВласник.Проводки2_TablePart.FillJoin([ВиготовленняПродукції_Проводки2_TablePart.НомерРядка,]);
            await ЕлементВласник.Проводки2_TablePart.Read();

            Store.RemoveAll();

            foreach (var record in ЕлементВласник.Проводки2_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Рахунок = record.Рахунок;
                row.Дебет = record.Дебет;
                row.Кредит = record.Кредит;
                row.Кількість = record.Кількість;

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
            ЕлементВласник.Проводки2_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    ЕлементВласник.Проводки2_TablePart.Records.Add(new()
                    {
                        UID = row.UniqueID.UGuid,
                        НомерРядка = row.НомерРядка,
                        Рахунок = row.Рахунок,
                        Дебет = row.Дебет,
                        Кредит = row.Кредит,
                        Кількість = row.Кількість,

                    });
                }
            }
            await ЕлементВласник.Проводки2_TablePart.Save(true);
            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.Проводки2_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.НомерРядка = x.НомерРядка;
                    row.Рахунок = x.Рахунок;
                    row.Дебет = x.Дебет;
                    row.Кредит = x.Кредит;
                    row.Кількість = x.Кількість;

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
