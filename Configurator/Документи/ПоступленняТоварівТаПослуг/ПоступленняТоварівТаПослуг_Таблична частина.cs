
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

namespace StorageAndTrade;

class ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    
    public ПоступленняТоварівТаПослуг_Objest? ЕлементВласник { get; set; }
        
    
    #region Data

    class ItemRow : RowTablePart
    {
    
        //
        // НомерРядка
        //
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
        public Action? Сhanged_НомерРядка;

    
        //
        // Номенклатура
        //
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
        public Action? Сhanged_Номенклатура;

    
        //
        // ХарактеристикаНоменклатури
        //
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
        public Action? Сhanged_ХарактеристикаНоменклатури;

    
        //
        // Серія
        //
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
        public Action? Сhanged_Серія;

    
        //
        // КількістьУпаковок
        //
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
        public Action? Сhanged_КількістьУпаковок;

    
        //
        // Пакування
        //
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
        public Action? Сhanged_Пакування;

    
        //
        // Кількість
        //
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
        public Action? Сhanged_Кількість;

    
        //
        // ВидЦіни
        //
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
        public Action? Сhanged_ВидЦіни;

    
        //
        // Ціна
        //
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
        public Action? Сhanged_Ціна;

    
        //
        // Склад
        //
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
        public Action? Сhanged_Склад;

    
        //
        // Скидка
        //
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
        public Action? Сhanged_Скидка;

    
        //
        // Сума
        //
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
        public Action? Сhanged_Сума;

    
        //
        // ЗамовленняПостачальнику
        //
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
        public Action? Сhanged_ЗамовленняПостачальнику;

    

        /*
        Функції
        */
        
        public override ItemRow Copy()
        {
            return new()
            {
                НомерРядка = НомерРядка,
                Номенклатура = Номенклатура.Copy(),
                ХарактеристикаНоменклатури = ХарактеристикаНоменклатури.Copy(),
                Серія = Серія.Copy(),
                КількістьУпаковок = КількістьУпаковок,
                Пакування = Пакування.Copy(),
                Кількість = Кількість,
                ВидЦіни = ВидЦіни.Copy(),
                Ціна = Ціна,
                Склад = Склад.Copy(),
                Скидка = Скидка,
                Сума = Сума,
                ЗамовленняПостачальнику = ЗамовленняПостачальнику.Copy(),
                
            };
        }
    }

    #endregion

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public ПоступленняТоварівТаПослуг_ТабличнаЧастина_Товари() : base(Program.BasicForm?.NotebookFunc)
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    protected override void Columns()
    {
        
        //НомерРядка
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
                {
                    
                    (row.Сhanged_НомерРядка = () => cell.SetText(row.НомерРядка)).Invoke();
                        
                }
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
                ListItem listItem = (ListItem)args.Object;
                var cell = new Номенклатура_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (Номенклатура_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.Номенклатура = cell.Pointer;
                    (row.Сhanged_Номенклатура = () => cell.Pointer = row.Номенклатура).Invoke();
                        
                }
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
                ListItem listItem = (ListItem)args.Object;
                var cell = new ХарактеристикиНоменклатури_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (ХарактеристикиНоменклатури_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.ХарактеристикаНоменклатури = cell.Pointer;
                    (row.Сhanged_ХарактеристикаНоменклатури = () => cell.Pointer = row.ХарактеристикаНоменклатури).Invoke();
                        
                }
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
                ListItem listItem = (ListItem)args.Object;
                var cell = new СеріїНоменклатури_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (СеріїНоменклатури_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.Серія = cell.Pointer;
                    (row.Сhanged_Серія = () => cell.Pointer = row.Серія).Invoke();
                        
                }
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
                    
                    cell.OnСhanged = () => row.КількістьУпаковок = cell.Value;
                    (row.Сhanged_КількістьУпаковок = () => cell.Value = row.КількістьУпаковок).Invoke();
                        
                }
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
                ListItem listItem = (ListItem)args.Object;
                var cell = new ПакуванняОдиниціВиміру_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (ПакуванняОдиниціВиміру_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.Пакування = cell.Pointer;
                    (row.Сhanged_Пакування = () => cell.Pointer = row.Пакування).Invoke();
                        
                }
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
                    
                    cell.OnСhanged = () => row.Кількість = cell.Value;
                    (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //ВидЦіни
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new ВидиЦін_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (ВидиЦін_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.ВидЦіни = cell.Pointer;
                    (row.Сhanged_ВидЦіни = () => cell.Pointer = row.ВидЦіни).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Вид ціни", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ціна
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
                    
                    cell.OnСhanged = () => row.Ціна = cell.Value;
                    (row.Сhanged_Ціна = () => cell.Value = row.Ціна).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ціна", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Склад
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new Склади_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (Склади_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.Склад = cell.Pointer;
                    (row.Сhanged_Склад = () => cell.Pointer = row.Склад).Invoke();
                        
                }
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
                    
                    cell.OnСhanged = () => row.Скидка = cell.Value;
                    (row.Сhanged_Скидка = () => cell.Value = row.Скидка).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Скидка", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Сума
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
                    
                    cell.OnСhanged = () => row.Сума = cell.Value;
                    (row.Сhanged_Сума = () => cell.Value = row.Сума).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Сума", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //ЗамовленняПостачальнику
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new ЗамовленняПостачальнику_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (ЗамовленняПостачальнику_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.ЗамовленняПостачальнику = cell.Pointer;
                    (row.Сhanged_ЗамовленняПостачальнику = () => cell.Pointer = row.ЗамовленняПостачальнику).Invoke();
                        
                }
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
            Store.Append(new ItemRow()
            {
                UnigueID = new(record.UID),
                НомерРядка = record.НомерРядка,
                Номенклатура = record.Номенклатура,
                ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури,
                Серія = record.Серія,
                КількістьУпаковок = record.КількістьУпаковок,
                Пакування = record.Пакування,
                Кількість = record.Кількість,
                ВидЦіни = record.ВидЦіни,
                Ціна = record.Ціна,
                Склад = record.Склад,
                Скидка = record.Скидка,
                Сума = record.Сума,
                ЗамовленняПостачальнику = record.ЗамовленняПостачальнику,
                
            });

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
                    UID = row.UnigueID.UGuid,
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
        //Update
        {
            uint position = 0;
            foreach (var record in ЕлементВласник.Товари_TablePart.Records)
            {
                bool sel = Grid.Model.IsSelected(position);
                Store.Splice(position, 1, [new ItemRow()
                {
                    UnigueID = new(record.UID),
                    НомерРядка = record.НомерРядка,
                    Номенклатура = record.Номенклатура,
                    ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури,
                    Серія = record.Серія,
                    КількістьУпаковок = record.КількістьУпаковок,
                    Пакування = record.Пакування,
                    Кількість = record.Кількість,
                    ВидЦіни = record.ВидЦіни,
                    Ціна = record.Ціна,
                    Склад = record.Склад,
                    Скидка = record.Скидка,
                    Сума = record.Сума,
                    ЗамовленняПостачальнику = record.ЗамовленняПостачальнику,
                    
                }], 1);
                if (sel) Grid.Model.SelectItem(position, false);
                position++;
            }
        }
        }
    }

    public override bool NewRecord()
    {
        Store.Append(new ItemRow());
        return true;
    }
}
    