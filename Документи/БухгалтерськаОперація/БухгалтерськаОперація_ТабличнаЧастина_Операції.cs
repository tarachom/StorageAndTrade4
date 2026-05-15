
/*
        БухгалтерськаОперація_ТабличнаЧастина_Операції.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_Wc5I6l3tR0azl5Y4HtABAg")]
partial class БухгалтерськаОперація_ТабличнаЧастина_Операції : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_Wc5I6l3tR0azl5Y4HtABAg")]
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


        /* КількістьДебет */
        public decimal КількістьДебет
        {
            get => КількістьДебет_;
            set
            {
                if (!КількістьДебет_.Equals(value))
                {
                    КількістьДебет_ = value;
                    Сhanged_КількістьДебет?.Invoke();
                }
            }
        }
        decimal КількістьДебет_ = 0;
        public Action? Сhanged_КількістьДебет { get; set; } = null;


        /* ВалютаДебет */
        public Валюти_Pointer ВалютаДебет
        {
            get => ВалютаДебет_;
            set
            {
                if (!ВалютаДебет_.Equals(value))
                {
                    ВалютаДебет_ = value;
                    Сhanged_ВалютаДебет?.Invoke();
                }
            }
        }
        Валюти_Pointer ВалютаДебет_ = new();
        public Action? Сhanged_ВалютаДебет { get; set; } = null;

        /* КурсВалютиДебет */
        public decimal КурсВалютиДебет
        {
            get => КурсВалютиДебет_;
            set
            {
                if (!КурсВалютиДебет_.Equals(value))
                {
                    КурсВалютиДебет_ = value;
                    Сhanged_КурсВалютиДебет?.Invoke();
                }
            }
        }
        decimal КурсВалютиДебет_ = 0;
        public Action? Сhanged_КурсВалютиДебет { get; set; } = null;

        /* СумаВВалютіДебет */
        public decimal СумаВВалютіДебет
        {
            get => СумаВВалютіДебет_;
            set
            {
                if (!СумаВВалютіДебет_.Equals(value))
                {
                    СумаВВалютіДебет_ = value;
                    Сhanged_СумаВВалютіДебет?.Invoke();
                }
            }
        }
        decimal СумаВВалютіДебет_ = 0;
        public Action? Сhanged_СумаВВалютіДебет { get; set; } = null;


        /* СумаПОДебет */
        public decimal СумаПОДебет
        {
            get => СумаПОДебет_;
            set
            {
                if (!СумаПОДебет_.Equals(value))
                {
                    СумаПОДебет_ = value;
                    Сhanged_СумаПОДебет?.Invoke();
                }
            }
        }
        decimal СумаПОДебет_ = 0;
        public Action? Сhanged_СумаПОДебет { get; set; } = null;


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


        /* КількістьКредит */
        public decimal КількістьКредит
        {
            get => КількістьКредит_;
            set
            {
                if (!КількістьКредит_.Equals(value))
                {
                    КількістьКредит_ = value;
                    Сhanged_КількістьКредит?.Invoke();
                }
            }
        }
        decimal КількістьКредит_ = 0;
        public Action? Сhanged_КількістьКредит { get; set; } = null;


        /* ВалютаКредит */
        public Валюти_Pointer ВалютаКредит
        {
            get => ВалютаКредит_;
            set
            {
                if (!ВалютаКредит_.Equals(value))
                {
                    ВалютаКредит_ = value;
                    Сhanged_ВалютаКредит?.Invoke();
                }
            }
        }
        Валюти_Pointer ВалютаКредит_ = new();
        public Action? Сhanged_ВалютаКредит { get; set; } = null;

        /* КурсВалютиКредит */
        public decimal КурсВалютиКредит
        {
            get => КурсВалютиКредит_;
            set
            {
                if (!КурсВалютиКредит_.Equals(value))
                {
                    КурсВалютиКредит_ = value;
                    Сhanged_КурсВалютиКредит?.Invoke();
                }
            }
        }
        decimal КурсВалютиКредит_ = 0;
        public Action? Сhanged_КурсВалютиКредит { get; set; } = null;

        /* СумаВВалютіКредит */
        public decimal СумаВВалютіКредит
        {
            get => СумаВВалютіКредит_;
            set
            {
                if (!СумаВВалютіКредит_.Equals(value))
                {
                    СумаВВалютіКредит_ = value;
                    Сhanged_СумаВВалютіКредит?.Invoke();
                }
            }
        }
        decimal СумаВВалютіКредит_ = 0;
        public Action? Сhanged_СумаВВалютіКредит { get; set; } = null;


        /* СумаПОКредит */
        public decimal СумаПОКредит
        {
            get => СумаПОКредит_;
            set
            {
                if (!СумаПОКредит_.Equals(value))
                {
                    СумаПОКредит_ = value;
                    Сhanged_СумаПОКредит?.Invoke();
                }
            }
        }
        decimal СумаПОКредит_ = 0;
        public Action? Сhanged_СумаПОКредит { get; set; } = null;


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

        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.ДатаЗапису = ДатаЗапису;
            row.Рахунок = Рахунок.Copy();
            row.Аналітика1 = Аналітика1.Copy();
            row.Аналітика2 = Аналітика2.Copy();
            row.Аналітика3 = Аналітика3.Copy();
            row.Дебет = Дебет;
            row.КількістьДебет = КількістьДебет;
            row.ВалютаДебет = ВалютаДебет.Copy();
            row.КурсВалютиДебет = КурсВалютиДебет;
            row.СумаВВалютіДебет = СумаВВалютіДебет;
            row.СумаПОДебет = СумаПОДебет;
            row.Кредит = Кредит;
            row.КількістьКредит = КількістьКредит;
            row.ВалютаКредит = ВалютаКредит.Copy();
            row.КурсВалютиКредит = КурсВалютиКредит;
            row.СумаВВалютіКредит = СумаВВалютіКредит;
            row.СумаПОКредит = СумаПОКредит;
            row.Коментар = Коментар;
            row.КореспондуючийРахунок = КореспондуючийРахунок.Copy();
            row.КорАналітика1 = КорАналітика1.Copy();
            row.КорАналітика2 = КорАналітика2.Copy();
            row.КорАналітика3 = КорАналітика3.Copy();
            row.Податок = Податок.Copy();
            row.СумаПодатку = СумаПодатку;
            row.Журнал = Журнал.Copy();
            row.ТипБухОперації = ТипБухОперації.Copy();

            return row;
        }
    }

    #endregion

    #region Controls

    [GObject.Subclass<Box>("CompositeGroup_Wc5I6l3tR0azl5Y4HtABAg")]
    public partial class Група_Аналітика : Box
    {
        public static Група_Аналітика New() => NewWithProperties([]);

        partial void Initialize()
        {
            SetOrientation(Orientation.Vertical);

            Append(Аналітика1);
            Append(Аналітика2);
            Append(Аналітика3);
        }

        public CompositePointerControlTablePartCell Аналітика1 { get; } = CompositePointerControlTablePartCell.New();
        public CompositePointerControlTablePartCell Аналітика2 { get; } = CompositePointerControlTablePartCell.New();
        public CompositePointerControlTablePartCell Аналітика3 { get; } = CompositePointerControlTablePartCell.New();
    }

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

    public БухгалтерськаОперація_Objest? ЕлементВласник { get; set; }

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static БухгалтерськаОперація_ТабличнаЧастина_Операції New()
    {
        БухгалтерськаОперація_ТабличнаЧастина_Операції tablePart = NewWithProperties([]);
        tablePart.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return tablePart;
    }

    /// <summary>
    /// Функція формує значення для реквізитів Аналітика які залежать від реквізиту Рахунок
    /// </summary>
    /// <param name="Аналітика">Значення реквізиту аналітика</param>
    /// <param name="Субконто">Тип даних</param>
    static UuidAndText ЗадатиТипАналітики(UuidAndText Аналітика, string Субконто)
    {
        return !string.IsNullOrEmpty(Субконто) && Аналітика.Text == Субконто ?
            //Якщо тип не зімінився, залишаю також значення
            new(Аналітика.Uuid, Субконто) :
            //Тільки тип задається
            new(Субконто);
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

                cell.OnСhanged = () => row.ДатаЗапису = cell.Value;
                (row.Сhanged_ДатаЗапису = () => cell.Value = row.ДатаЗапису).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Дата", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

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

                    var РахунокОбєкт = await row.Рахунок.GetDirectoryObject();
                    if (РахунокОбєкт != null)
                    {
                        row.Аналітика1 = ЗадатиТипАналітики(row.Аналітика1, РахунокОбєкт.Субконто1);
                        row.Аналітика2 = ЗадатиТипАналітики(row.Аналітика2, РахунокОбєкт.Субконто2);
                        row.Аналітика3 = ЗадатиТипАналітики(row.Аналітика3, РахунокОбєкт.Субконто3);
                    }
                };

                (row.Сhanged_Рахунок = () => cell.Pointer = row.Рахунок).Invoke();
            };
            ColumnViewColumn column = ColumnViewColumn.New("Рахунок Дт", factory);
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

                cell.OnСhanged = () => row.Дебет = cell.Value;
                (row.Сhanged_Дебет = () => cell.Value = row.Дебет).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Дебет", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КількістьДебет
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

                cell.OnСhanged = () => row.КількістьДебет = cell.Value;
                (row.Сhanged_КількістьДебет = () => cell.Value = row.КількістьДебет).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість Дт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //ВалютаДебет, СумаВВалютіДебет, СумаПОДебет
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

                cell.Валюта.OnSelect = () => row.ВалютаДебет = cell.Валюта.Pointer;
                (row.Сhanged_ВалютаДебет = () => cell.Валюта.Pointer = row.ВалютаДебет).Invoke();

                cell.СумаВВалюті.OnСhanged = () => row.СумаВВалютіДебет = cell.СумаВВалюті.Value;
                (row.Сhanged_СумаВВалютіДебет = () => cell.СумаВВалюті.Value = row.СумаВВалютіДебет).Invoke();

                cell.СумаПО.OnСhanged = () => row.СумаПОДебет = cell.СумаПО.Value;
                (row.Сhanged_СумаПОДебет = () => cell.СумаПО.Value = row.СумаПОДебет).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Валюта Дт\nСума в валюті Дт\nСума ПО Дт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КурсВалютиДебет
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

                cell.OnСhanged = () => row.КурсВалютиДебет = cell.Value;
                (row.Сhanged_КурсВалютиДебет = () => cell.Value = row.КурсВалютиДебет).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Курс валюти Дт", factory);
            column.Resizable = true;

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

                cell.OnСhanged = () => row.Кредит = cell.Value;
                (row.Сhanged_Кредит = () => cell.Value = row.Кредит).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кредит", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КількістьКредит
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

                cell.OnСhanged = () => row.КількістьКредит = cell.Value;
                (row.Сhanged_КількістьКредит = () => cell.Value = row.КількістьКредит).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість Кт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //ВалютаКредит, СумаВВалютіКредит, СумаПОКредит
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

                cell.Валюта.OnSelect = () => row.ВалютаКредит = cell.Валюта.Pointer;
                (row.Сhanged_ВалютаКредит = () => cell.Валюта.Pointer = row.ВалютаКредит).Invoke();

                cell.СумаВВалюті.OnСhanged = () => row.СумаВВалютіКредит = cell.СумаВВалюті.Value;
                (row.Сhanged_СумаВВалютіКредит = () => cell.СумаВВалюті.Value = row.СумаВВалютіКредит).Invoke();

                cell.СумаПО.OnСhanged = () => row.СумаПОКредит = cell.СумаПО.Value;
                (row.Сhanged_СумаПОКредит = () => cell.СумаПО.Value = row.СумаПОКредит).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Валюта Кт\nСума в валюті Кт\nСума ПО Кт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КурсВалютиКредит
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

                cell.OnСhanged = () => row.КурсВалютиКредит = cell.Value;
                (row.Сhanged_КурсВалютиКредит = () => cell.Value = row.КурсВалютиКредит).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Курс валюти Кт", factory);
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

                    var РахунокОбєкт = await row.КореспондуючийРахунок.GetDirectoryObject();
                    if (РахунокОбєкт != null)
                    {
                        row.КорАналітика1 = ЗадатиТипАналітики(row.КорАналітика1, РахунокОбєкт.Субконто1);
                        row.КорАналітика2 = ЗадатиТипАналітики(row.КорАналітика2, РахунокОбєкт.Субконто2);
                        row.КорАналітика3 = ЗадатиТипАналітики(row.КорАналітика3, РахунокОбєкт.Субконто3);
                    }
                };

                (row.Сhanged_КореспондуючийРахунок = () => cell.Pointer = row.КореспондуючийРахунок).Invoke();
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кореспондуючий рахунок", factory);
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

    public override async ValueTask LoadRecords()
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
                row.Аналітика1 = record.Аналітика1;
                row.Аналітика2 = record.Аналітика2;
                row.Аналітика3 = record.Аналітика3;
                row.Дебет = record.Дебет;
                row.КількістьДебет = record.КількістьДебет;
                row.ВалютаДебет = record.ВалютаДебет;
                row.КурсВалютиДебет = record.КурсВалютиДебет;
                row.СумаВВалютіДебет = record.СумаВВалютіДебет;
                row.СумаПОДебет = record.СумаПОДебет;
                row.Кредит = record.Кредит;
                row.КількістьКредит = record.КількістьКредит;
                row.ВалютаКредит = record.ВалютаКредит;
                row.КурсВалютиКредит = record.КурсВалютиКредит;
                row.СумаВВалютіКредит = record.СумаВВалютіКредит;
                row.СумаПОКредит = record.СумаПОКредит;
                row.Коментар = record.Коментар;
                row.КореспондуючийРахунок = record.КореспондуючийРахунок;
                row.КорАналітика1 = record.КорАналітика1;
                row.КорАналітика2 = record.КорАналітика2;
                row.КорАналітика3 = record.КорАналітика3;
                row.Податок = record.Податок;
                row.СумаПодатку = record.СумаПодатку;
                row.Журнал = record.Журнал;
                row.ТипБухОперації = record.ТипБухОперації;

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
                        Аналітика1 = row.Аналітика1,
                        Аналітика2 = row.Аналітика2,
                        Аналітика3 = row.Аналітика3,
                        Дебет = row.Дебет,
                        КількістьДебет = row.КількістьДебет,
                        ВалютаДебет = row.ВалютаДебет,
                        КурсВалютиДебет = row.КурсВалютиДебет,
                        СумаВВалютіДебет = row.СумаВВалютіДебет,
                        СумаПОДебет = row.СумаПОДебет,
                        Кредит = row.Кредит,
                        КількістьКредит = row.КількістьКредит,
                        ВалютаКредит = row.ВалютаКредит,
                        КурсВалютиКредит = row.КурсВалютиКредит,
                        СумаВВалютіКредит = row.СумаВВалютіКредит,
                        СумаПОКредит = row.СумаПОКредит,
                        Коментар = row.Коментар,
                        КореспондуючийРахунок = row.КореспондуючийРахунок,
                        КорАналітика1 = row.КорАналітика1,
                        КорАналітика2 = row.КорАналітика2,
                        КорАналітика3 = row.КорАналітика3,
                        Податок = row.Податок,
                        СумаПодатку = row.СумаПодатку,
                        Журнал = row.Журнал,
                        ТипБухОперації = row.ТипБухОперації,
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
                    row.Аналітика1 = x.Аналітика1;
                    row.Аналітика2 = x.Аналітика2;
                    row.Аналітика3 = x.Аналітика3;
                    row.Дебет = x.Дебет;
                    row.КількістьДебет = x.КількістьДебет;
                    row.ВалютаДебет = x.ВалютаДебет;
                    row.КурсВалютиДебет = x.КурсВалютиДебет;
                    row.СумаВВалютіДебет = x.СумаВВалютіДебет;
                    row.СумаПОДебет = x.СумаПОДебет;
                    row.Кредит = x.Кредит;
                    row.КількістьКредит = x.КількістьКредит;
                    row.ВалютаКредит = x.ВалютаКредит;
                    row.КурсВалютиКредит = x.КурсВалютиКредит;
                    row.СумаВВалютіКредит = x.СумаВВалютіКредит;
                    row.СумаПОКредит = x.СумаПОКредит;
                    row.Коментар = x.Коментар;
                    row.КореспондуючийРахунок = x.КореспондуючийРахунок;
                    row.КорАналітика1 = x.КорАналітика1;
                    row.КорАналітика2 = x.КорАналітика2;
                    row.КорАналітика3 = x.КорАналітика3;
                    row.Податок = x.Податок;
                    row.СумаПодатку = x.СумаПодатку;
                    row.Журнал = x.Журнал;
                    row.ТипБухОперації = x.ТипБухОперації;

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
        ItemRow row = ItemRow.New();
        row.ДатаЗапису = DateTime.Now;

        Store.Append(row);

        return true;
    }
}
