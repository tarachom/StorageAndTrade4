
/*
        БухгалтерськаОперація_ТабличнаЧастина_Операції.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Перелічення;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_Wc5I6l3tR0azl5Y4HtABAg")]
partial class БухгалтерськаОперація_ТабличнаЧастина_Операції : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_NrefAf5WQn2qUPT4C4Ig0w")]
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


        /* ДатаЗапису */
        public DateTime ДатаЗапису
        {
            get => ДатаЗапису_;
            set
            {
                if (!ДатаЗапису_.Equals(value))
                {
                    ДатаЗапису_ = value;
                    Сhanged_ДатаЗапису?.Invoke();
                }
            }
        }
        DateTime ДатаЗапису_ = DateTime.MinValue;
        public Action? Сhanged_ДатаЗапису { get; set; } = null;


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


        /* ВидПроводки */
        public ВидиПроводок ВидПроводки
        {
            get => ВидПроводки_;
            set
            {
                if (!ВидПроводки_.Equals(value))
                {
                    ВидПроводки_ = value;
                    Сhanged_ВидПроводки?.Invoke();
                }
            }
        }
        ВидиПроводок ВидПроводки_ = 0;
        public Action? Сhanged_ВидПроводки { get; set; } = null;


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


        /* КореспондуючийРахунок */
        public ПланРахунків_Pointer КореспондуючийРахунок
        {
            get => КореспондуючийРахунок_;
            set
            {
                if (!КореспондуючийРахунок_.Equals(value))
                {
                    КореспондуючийРахунок_ = value;
                    Сhanged_КореспондуючийРахунок?.Invoke();
                }
            }
        }
        ПланРахунків_Pointer КореспондуючийРахунок_ = new();
        public Action? Сhanged_КореспондуючийРахунок { get; set; } = null;


        /* КорАналітика1 */
        public UuidAndText КорАналітика1
        {
            get => КорАналітика1_;
            set
            {
                if (!КорАналітика1_.Equals(value))
                {
                    КорАналітика1_ = value;
                    Сhanged_КорАналітика1?.Invoke();
                }
            }
        }
        UuidAndText КорАналітика1_ = new();
        public Action? Сhanged_КорАналітика1 { get; set; } = null;


        /* КорАналітика2 */
        public UuidAndText КорАналітика2
        {
            get => КорАналітика2_;
            set
            {
                if (!КорАналітика2_.Equals(value))
                {
                    КорАналітика2_ = value;
                    Сhanged_КорАналітика2?.Invoke();
                }
            }
        }
        UuidAndText КорАналітика2_ = new();
        public Action? Сhanged_КорАналітика2 { get; set; } = null;


        /* КорАналітика3 */
        public UuidAndText КорАналітика3
        {
            get => КорАналітика3_;
            set
            {
                if (!КорАналітика3_.Equals(value))
                {
                    КорАналітика3_ = value;
                    Сhanged_КорАналітика3?.Invoke();
                }
            }
        }
        UuidAndText КорАналітика3_ = new();
        public Action? Сhanged_КорАналітика3 { get; set; } = null;


        /* Податок */
        public ВидиПодатків_Pointer Податок
        {
            get => Податок_;
            set
            {
                if (!Податок_.Equals(value))
                {
                    Податок_ = value;
                    Сhanged_Податок?.Invoke();
                }
            }
        }
        ВидиПодатків_Pointer Податок_ = new();
        public Action? Сhanged_Податок { get; set; } = null;


        /* СумаПодатку */
        public decimal СумаПодатку
        {
            get => СумаПодатку_;
            set
            {
                if (!СумаПодатку_.Equals(value))
                {
                    СумаПодатку_ = value;
                    Сhanged_СумаПодатку?.Invoke();
                }
            }
        }
        decimal СумаПодатку_ = 0;
        public Action? Сhanged_СумаПодатку { get; set; } = null;


        /* Журнал */
        public ВидиЖурналів_Pointer Журнал
        {
            get => Журнал_;
            set
            {
                if (!Журнал_.Equals(value))
                {
                    Журнал_ = value;
                    Сhanged_Журнал?.Invoke();
                }
            }
        }
        ВидиЖурналів_Pointer Журнал_ = new();
        public Action? Сhanged_Журнал { get; set; } = null;


        /* ТипБухОперації */
        public ТипиБухОперацій_Pointer ТипБухОперації
        {
            get => ТипБухОперації_;
            set
            {
                if (!ТипБухОперації_.Equals(value))
                {
                    ТипБухОперації_ = value;
                    Сhanged_ТипБухОперації?.Invoke();
                }
            }
        }
        ТипиБухОперацій_Pointer ТипБухОперації_ = new();
        public Action? Сhanged_ТипБухОперації { get; set; } = null;


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


        /* Валюта */
        public Валюти_Pointer Валюта
        {
            get => Валюта_;
            set
            {
                if (!Валюта_.Equals(value))
                {
                    Валюта_ = value;
                    Сhanged_Валюта?.Invoke();
                }
            }
        }
        Валюти_Pointer Валюта_ = new();
        public Action? Сhanged_Валюта { get; set; } = null;


        /* СумаВВалюті */
        public decimal СумаВВалюті
        {
            get => СумаВВалюті_;
            set
            {
                if (!СумаВВалюті_.Equals(value))
                {
                    СумаВВалюті_ = value;
                    Сhanged_СумаВВалюті?.Invoke();
                }
            }
        }
        decimal СумаВВалюті_ = 0;
        public Action? Сhanged_СумаВВалюті { get; set; } = null;


        /* СумаПО */
        public decimal СумаПО
        {
            get => СумаПО_;
            set
            {
                if (!СумаПО_.Equals(value))
                {
                    СумаПО_ = value;
                    Сhanged_СумаПО?.Invoke();
                }
            }
        }
        decimal СумаПО_ = 0;
        public Action? Сhanged_СумаПО { get; set; } = null;


        /* КурсВалюти */
        public decimal КурсВалюти
        {
            get => КурсВалюти_;
            set
            {
                if (!КурсВалюти_.Equals(value))
                {
                    КурсВалюти_ = value;
                    Сhanged_КурсВалюти?.Invoke();
                }
            }
        }
        decimal КурсВалюти_ = 0;
        public Action? Сhanged_КурсВалюти { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.ДатаЗапису = ДатаЗапису;
            row.Рахунок = Рахунок.Copy();
            row.ВидПроводки = ВидПроводки;
            row.Аналітика1 = Аналітика1.Copy();
            row.Аналітика2 = Аналітика2.Copy();
            row.Аналітика3 = Аналітика3.Copy();
            row.Коментар = Коментар;
            row.КореспондуючийРахунок = КореспондуючийРахунок.Copy();
            row.КорАналітика1 = КорАналітика1.Copy();
            row.КорАналітика2 = КорАналітика2.Copy();
            row.КорАналітика3 = КорАналітика3.Copy();
            row.Податок = Податок.Copy();
            row.СумаПодатку = СумаПодатку;
            row.Журнал = Журнал.Copy();
            row.ТипБухОперації = ТипБухОперації.Copy();
            row.Сума = Сума;
            row.Кількість = Кількість;
            row.Валюта = Валюта.Copy();
            row.СумаВВалюті = СумаВВалюті;
            row.СумаПО = СумаПО;
            row.КурсВалюти = КурсВалюти;

            return row;
        }
    }

    #endregion

    #region Controls

    [GObject.Subclass<Box>("Group_Wc5I6l3tR0azl5Y4HtABAg")]
    public partial class Група_ВалютаТаСуми : Box
    {
        public static Група_ВалютаТаСуми New() => NewWithProperties([]);

        partial void Initialize()
        {
            SetOrientation(Orientation.Vertical);

            Append(Валюта);
            Append(СумаВВалюті);
            Append(СумаПО);
        }

        public Валюти_PointerTablePartCell Валюта { get; } = Валюти_PointerTablePartCell.New();
        public NumericTablePartCell СумаВВалюті { get; } = NumericTablePartCell.New();
        public NumericTablePartCell СумаПО { get; } = NumericTablePartCell.New();
    }

    #endregion

    #region Функції

    Task ПісляДодаванняНового(ItemRow row)
    {
        row.ДатаЗапису = DateTime.Now;
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

    async Task ПісляЗміни_КореспондуючийРахунок(ItemRow row)
    {
        var РахунокОбєкт = await row.КореспондуючийРахунок.GetDirectoryObject();
        if (РахунокОбєкт != null)
        {
            row.КорАналітика1 = ФункціїДляДокументів.ЗадатиТипАналітики(row.КорАналітика1, РахунокОбєкт.Субконто1);
            row.КорАналітика2 = ФункціїДляДокументів.ЗадатиТипАналітики(row.КорАналітика2, РахунокОбєкт.Субконто2);
            row.КорАналітика3 = ФункціїДляДокументів.ЗадатиТипАналітики(row.КорАналітика3, РахунокОбєкт.Субконто3);
        }
    }

    #endregion

    public БухгалтерськаОперація_Object? ЕлементВласник { get; set; }
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
            /*
            decimal Сума = 0;

            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                    Сума += row.Сума;
            }
            */

            return new();
        };

        Append(Підсумок);
    }

    public static БухгалтерськаОперація_ТабличнаЧастина_Операції New()
    {
        БухгалтерськаОперація_ТабличнаЧастина_Операції tablePart = NewWithProperties([]);
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

        //ДатаЗапису
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = DateTimeTablePartCell.New();
                cell.OnlyDate = true;

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DateTimeTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                //-> В модель
                cell.OnСhanged = () => row.ДатаЗапису = cell.Value;

                //<- З моделі
                (row.Сhanged_ДатаЗапису = () => cell.Value = row.ДатаЗапису).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Дата", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //ВидПроводки
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = DropDownTablePartCell.NewWithValues(ПсевдонімиПерелічення.ВидиПроводок_Dict());

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DropDownTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = () => row.ВидПроводки = ПсевдонімиПерелічення.ВидиПроводок_FindByName(cell.Value);
                (row.Сhanged_ВидПроводки = () => cell.Value = row.ВидПроводки.ToString()).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Вид", factory);
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
            column.FixedWidth = 200;

            Grid.AppendColumn(column);
        }

        //Аналітика1, Аналітика2, Аналітика3
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Група_Аналітика.New();

                cell.Аналітика1.BoundConfType = "Документи.БухгалтерськаОперація.Операції.Аналітика1";
                cell.Аналітика2.BoundConfType = "Документи.БухгалтерськаОперація.Операції.Аналітика2";
                cell.Аналітика3.BoundConfType = "Документи.БухгалтерськаОперація.Операції.Аналітика3";

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

                cell.OnСhanged = () => row.Сума = cell.Value;
                (row.Сhanged_Сума = () => cell.Value = row.Сума).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Сума", factory);
            column.Resizable = true;

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

                cell.OnСhanged = () => row.Кількість = cell.Value;
                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість Дт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //Валюта, СумаВВалюті, СумаПО
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Група_ВалютаТаСуми.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Група_ВалютаТаСуми cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.Валюта.OnSelect = () => row.Валюта = cell.Валюта.Pointer;
                (row.Сhanged_Валюта = () => cell.Валюта.Pointer = row.Валюта).Invoke();

                cell.СумаВВалюті.OnСhanged = () => row.СумаВВалюті = cell.СумаВВалюті.Value;
                (row.Сhanged_СумаВВалюті = () => cell.СумаВВалюті.Value = row.СумаВВалюті).Invoke();

                cell.СумаПО.OnСhanged = () => row.СумаПО = cell.СумаПО.Value;
                (row.Сhanged_СумаПО = () => cell.СумаПО.Value = row.СумаПО).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Валюта\nСума в валюті\nСума ПО", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КурсВалюти
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

                cell.OnСhanged = () => row.КурсВалюти = cell.Value;
                (row.Сhanged_КурсВалюти = () => cell.Value = row.КурсВалюти).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Курс валюти", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КореспондуючийРахунок
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
                    row.КореспондуючийРахунок = cell.Pointer;
                    await ПісляЗміни_КореспондуючийРахунок(row);
                };

                (row.Сhanged_КореспондуючийРахунок = () => cell.Pointer = row.КореспондуючийРахунок).Invoke();
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кореспондуючий\nрахунок", factory);
            column.Resizable = true;
            column.FixedWidth = 200;

            Grid.AppendColumn(column);
        }

        //КорАналітика1, КорАналітика2, КорАналітика3
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Група_Аналітика.New();

                cell.Аналітика1.BoundConfType = "Документи.БухгалтерськаОперація.Операції.КорАналітика1";
                cell.Аналітика2.BoundConfType = "Документи.БухгалтерськаОперація.Операції.КорАналітика2";
                cell.Аналітика3.BoundConfType = "Документи.БухгалтерськаОперація.Операції.КорАналітика3";

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Група_Аналітика cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.Аналітика1.OnSelect = () => row.КорАналітика1 = cell.Аналітика1.Pointer;
                (row.Сhanged_КорАналітика1 = () => cell.Аналітика1.Pointer = row.КорАналітика1).Invoke();

                cell.Аналітика2.OnSelect = () => row.КорАналітика2 = cell.Аналітика2.Pointer;
                (row.Сhanged_КорАналітика2 = () => cell.Аналітика2.Pointer = row.КорАналітика2).Invoke();

                cell.Аналітика3.OnSelect = () => row.КорАналітика3 = cell.Аналітика3.Pointer;
                (row.Сhanged_КорАналітика3 = () => cell.Аналітика3.Pointer = row.КорАналітика3).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кор аналітика 1\nКор аналітика 2\nКор аналітика 3", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Податок
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

                cell.OnSelect = () => row.Податок = cell.Pointer;
                (row.Сhanged_Податок = () => cell.Pointer = row.Податок).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Податок", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //СумаПодатку
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

                cell.OnСhanged = () => row.СумаПодатку = cell.Value;
                (row.Сhanged_СумаПодатку = () => cell.Value = row.СумаПодатку).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Сума податку", factory);
            column.Resizable = true;
            column.FixedWidth = 150;

            Grid.AppendColumn(column);
        }

        //Журнал
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ВидиЖурналів_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ВидиЖурналів_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = () => row.Журнал = cell.Pointer;
                (row.Сhanged_Журнал = () => cell.Pointer = row.Журнал).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Журнал", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //ТипБухОперації
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ТипиБухОперацій_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ТипиБухОперацій_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = () => row.ТипБухОперації = cell.Pointer;
                (row.Сhanged_ТипБухОперації = () => cell.Pointer = row.ТипБухОперації).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Тип бух операції", factory);
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

    public override async Task LoadRecords()
    {

        if (ЕлементВласник != null)
        {

            ЕлементВласник.Операції_TablePart.FillJoin([БухгалтерськаОперація_Операції_TablePart.НомерРядка,]);
            await ЕлементВласник.Операції_TablePart.Read();

            Store.RemoveAll();

            foreach (var record in ЕлементВласник.Операції_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.ДатаЗапису = record.ДатаЗапису;
                row.Рахунок = record.Рахунок;
                row.ВидПроводки = record.ВидПроводки;
                row.Аналітика1 = record.Аналітика1;
                row.Аналітика2 = record.Аналітика2;
                row.Аналітика3 = record.Аналітика3;
                row.Коментар = record.Коментар;
                row.КореспондуючийРахунок = record.КореспондуючийРахунок;
                row.КорАналітика1 = record.КорАналітика1;
                row.КорАналітика2 = record.КорАналітика2;
                row.КорАналітика3 = record.КорАналітика3;
                row.Податок = record.Податок;
                row.СумаПодатку = record.СумаПодатку;
                row.Журнал = record.Журнал;
                row.ТипБухОперації = record.ТипБухОперації;
                row.Сума = record.Сума;
                row.Кількість = record.Кількість;
                row.Валюта = record.Валюта;
                row.СумаВВалюті = record.СумаВВалюті;
                row.СумаПО = record.СумаПО;
                row.КурсВалюти = record.КурсВалюти;

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
            ЕлементВласник.Операції_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    ЕлементВласник.Операції_TablePart.Records.Add(new()
                    {
                        UID = row.UniqueID.UGuid,
                        НомерРядка = row.НомерРядка,
                        ДатаЗапису = row.ДатаЗапису,
                        Рахунок = row.Рахунок,
                        ВидПроводки = row.ВидПроводки,
                        Аналітика1 = row.Аналітика1,
                        Аналітика2 = row.Аналітика2,
                        Аналітика3 = row.Аналітика3,
                        Коментар = row.Коментар,
                        КореспондуючийРахунок = row.КореспондуючийРахунок,
                        КорАналітика1 = row.КорАналітика1,
                        КорАналітика2 = row.КорАналітика2,
                        КорАналітика3 = row.КорАналітика3,
                        Податок = row.Податок,
                        СумаПодатку = row.СумаПодатку,
                        Журнал = row.Журнал,
                        ТипБухОперації = row.ТипБухОперації,
                        Сума = row.Сума,
                        Кількість = row.Кількість,
                        Валюта = row.Валюта,
                        СумаВВалюті = row.СумаВВалюті,
                        СумаПО = row.СумаПО,
                        КурсВалюти = row.КурсВалюти,

                    });
                }
            }
            await ЕлементВласник.Операції_TablePart.Save(true);
            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.Операції_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.НомерРядка = x.НомерРядка;
                    row.ДатаЗапису = x.ДатаЗапису;
                    row.Рахунок = x.Рахунок;
                    row.ВидПроводки = x.ВидПроводки;
                    row.Аналітика1 = x.Аналітика1;
                    row.Аналітика2 = x.Аналітика2;
                    row.Аналітика3 = x.Аналітика3;
                    row.Коментар = x.Коментар;
                    row.КореспондуючийРахунок = x.КореспондуючийРахунок;
                    row.КорАналітика1 = x.КорАналітика1;
                    row.КорАналітика2 = x.КорАналітика2;
                    row.КорАналітика3 = x.КорАналітика3;
                    row.Податок = x.Податок;
                    row.СумаПодатку = x.СумаПодатку;
                    row.Журнал = x.Журнал;
                    row.ТипБухОперації = x.ТипБухОперації;
                    row.Сума = x.Сума;
                    row.Кількість = x.Кількість;
                    row.Валюта = x.Валюта;
                    row.СумаВВалюті = x.СумаВВалюті;
                    row.СумаПО = x.СумаПО;
                    row.КурсВалюти = x.КурсВалюти;

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
