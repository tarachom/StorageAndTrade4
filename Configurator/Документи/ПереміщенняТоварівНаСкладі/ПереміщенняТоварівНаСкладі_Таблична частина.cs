
/*
        ПереміщенняТоварівНаСкладі_ТабличнаЧастина_Товари.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_USesTQOMj0mi2zx8oNwmVw")]
partial class ПереміщенняТоварівНаСкладі_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Data
    
    [GObject.Subclass<GObject.Object>("ItemRow_USesTQOMj0mi2zx8oNwmVw")]
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

    
        /* КоміркаВідправник */
        public СкладськіКомірки_Pointer КоміркаВідправник
        {
            get => КоміркаВідправник_;
            set
            {
                if (!КоміркаВідправник_.Equals(value))
                {
                    КоміркаВідправник_ = value;
                    Сhanged_КоміркаВідправник?.Invoke();
                }
            }
        }
        СкладськіКомірки_Pointer КоміркаВідправник_ = new();
        public Action? Сhanged_КоміркаВідправник { get; set; } = null;

    
        /* КоміркаОтримувач */
        public СкладськіКомірки_Pointer КоміркаОтримувач
        {
            get => КоміркаОтримувач_;
            set
            {
                if (!КоміркаОтримувач_.Equals(value))
                {
                    КоміркаОтримувач_ = value;
                    Сhanged_КоміркаОтримувач?.Invoke();
                }
            }
        }
        СкладськіКомірки_Pointer КоміркаОтримувач_ = new();
        public Action? Сhanged_КоміркаОтримувач { get; set; } = null;

    

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
            row.КоміркаВідправник = КоміркаВідправник.Copy();
            row.КоміркаОтримувач = КоміркаОтримувач.Copy();
            
            return row;
        }
    }

    #endregion

    
    public ПереміщенняТоварівНаСкладі_Objest? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static ПереміщенняТоварівНаСкладі_ТабличнаЧастина_Товари New()
    {
        ПереміщенняТоварівНаСкладі_ТабличнаЧастина_Товари tablePart = NewWithProperties([]);
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
                
                cell.OnSelect = () => row.Номенклатура = cell.Pointer;
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
                
                cell.BeforeClickOpenFunc = () => cell.Власник  = row.Номенклатура;
                        
                cell.OnSelect = () => row.ХарактеристикаНоменклатури = cell.Pointer;
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
                
                cell.OnSelect = () => row.Серія = cell.Pointer;
                (row.Сhanged_Серія = () => cell.Pointer = row.Серія).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Серія", factory);
            column.Resizable = true;
            
            column.FixedWidth = 200;
            
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
                
                cell.OnSelect = () => row.Пакування = cell.Pointer;
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
                
                cell.OnСhanged = () => row.Кількість = cell.Value;
                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //КоміркаВідправник
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = СкладськіКомірки_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not СкладськіКомірки_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = () => row.КоміркаВідправник = cell.Pointer;
                (row.Сhanged_КоміркаВідправник = () => cell.Pointer = row.КоміркаВідправник).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Комірка відправник", factory);
            column.Resizable = true;
            
            column.FixedWidth = 300;
            
            Grid.AppendColumn(column);
        }
        
        //КоміркаОтримувач
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = СкладськіКомірки_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not СкладськіКомірки_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = () => row.КоміркаОтримувач = cell.Pointer;
                (row.Сhanged_КоміркаОтримувач = () => cell.Pointer = row.КоміркаОтримувач).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Комірка отримувач", factory);
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
            
            ЕлементВласник.Товари_TablePart.FillJoin([ПереміщенняТоварівНаСкладі_Товари_TablePart.НомерРядка,]);
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
                row.КоміркаВідправник = record.КоміркаВідправник;
                row.КоміркаОтримувач = record.КоміркаОтримувач;
                
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
                        КоміркаВідправник = row.КоміркаВідправник,
                        КоміркаОтримувач = row.КоміркаОтримувач,
                        
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
                    row.КоміркаВідправник = x.КоміркаВідправник;
                    row.КоміркаОтримувач = x.КоміркаОтримувач;
                    
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

    public override bool NewRecord()
    {
        Store.Append(ItemRow.New());
        return true;
    }
}
    