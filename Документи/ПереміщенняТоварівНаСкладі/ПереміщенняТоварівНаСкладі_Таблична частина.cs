/*
        ПереміщенняТоварівНаСкладі_ТабличнаЧастина_Товари.cs
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

[GObject.Subclass<DocumentFormTablePart>("PeremishchenniaTovarivNaSkladi_TablePart_Tovary")]
partial class ПереміщенняТоварівНаСкладі_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Модель даних
    
    [GObject.Subclass<GObject.Object>("PeremishchenniaTovarivNaSkladi_TablePart_Tovary_ItemRow")]
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
            row.Коєфіціент = Коєфіціент;
            row.Пакування = Пакування.Copy();
            row.Кількість = Кількість;
            row.КоміркаВідправник = КоміркаВідправник.Copy();
            row.КоміркаОтримувач = КоміркаОтримувач.Copy();
            
            return row;
        }
    }

    #endregion

    #region Функції

    static Task ПісляДодаванняНового(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Коєфіціент(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Кількість(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Номенклатура(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_ХарактеристикаНоменклатури(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Серія(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Пакування(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_КоміркаВідправник(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_КоміркаОтримувач(ItemRow row) => Task.CompletedTask;
    

    #endregion

    
    public ПереміщенняТоварівНаСкладі_Object? ЕлементВласник { get; set; }
        
    
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
                
                (row.Сhanged_НомерРядка = () => cell.SetText(row.НомерРядка)).Invoke(); //<- Із моделі в комірку 
                    
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
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Номенклатура = cell.Pointer;
                    await ПісляЗміни_Номенклатура(row);
                };
                (row.Сhanged_Номенклатура = () => cell.Pointer = row.Номенклатура).Invoke(); //<- Із моделі в комірку 
                    
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
                
                cell.BeforeClickOpenFunc = () => cell.Власник  = row.Номенклатура;
                        
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.ХарактеристикаНоменклатури = cell.Pointer;
                    await ПісляЗміни_ХарактеристикаНоменклатури(row);
                };
                (row.Сhanged_ХарактеристикаНоменклатури = () => cell.Pointer = row.ХарактеристикаНоменклатури).Invoke(); //<- Із моделі в комірку 
                    
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
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Серія = cell.Pointer;
                    await ПісляЗміни_Серія(row);
                };
                (row.Сhanged_Серія = () => cell.Pointer = row.Серія).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not СеріїНоменклатури_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_Серія = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Серія", factory);
            column.Resizable = true;
            
            column.FixedWidth = 200;
            
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
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Коєфіціент = cell.Value;
                    await ПісляЗміни_Коєфіціент(row);
                };
                (row.Сhanged_Коєфіціент = () => cell.Value = row.Коєфіціент).Invoke(); //<- Із моделі в комірку 
                    
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
                
                cell.BeforeClickOpenFunc = () => cell.Власник  = row.Номенклатура;
                        
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Пакування = cell.Pointer;
                    await ПісляЗміни_Пакування(row);
                };
                (row.Сhanged_Пакування = () => cell.Pointer = row.Пакування).Invoke(); //<- Із моделі в комірку 
                    
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
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Кількість = cell.Value;
                    await ПісляЗміни_Кількість(row);
                };
                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke(); //<- Із моделі в комірку 
                    
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
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.КоміркаВідправник = cell.Pointer;
                    await ПісляЗміни_КоміркаВідправник(row);
                };
                (row.Сhanged_КоміркаВідправник = () => cell.Pointer = row.КоміркаВідправник).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not СкладськіКомірки_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_КоміркаВідправник = null;
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
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.КоміркаОтримувач = cell.Pointer;
                    await ПісляЗміни_КоміркаОтримувач(row);
                };
                (row.Сhanged_КоміркаОтримувач = () => cell.Pointer = row.КоміркаОтримувач).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not СкладськіКомірки_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_КоміркаОтримувач = null;
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

    //З таб частин в модель
    ItemRow[] ToItemRows(List<ПереміщенняТоварівНаСкладі_Товари_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.Номенклатура = x.Номенклатура;
        row.ХарактеристикаНоменклатури = x.ХарактеристикаНоменклатури;
        row.Серія = x.Серія;
        row.Коєфіціент = x.Коєфіціент;
        row.Пакування = x.Пакування;
        row.Кількість = x.Кількість;
        row.КоміркаВідправник = x.КоміркаВідправник;
        row.КоміркаОтримувач = x.КоміркаОтримувач;
        
        return row;
    })];

    //З моделі в таб частину
    List<ПереміщенняТоварівНаСкладі_Товари_TablePart.Record> ToRecords()
    {
        List<ПереміщенняТоварівНаСкладі_Товари_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Номенклатура = row.Номенклатура,
                    ХарактеристикаНоменклатури = row.ХарактеристикаНоменклатури,
                    Серія = row.Серія,
                    Коєфіціент = row.Коєфіціент,
                    Пакування = row.Пакування,
                    Кількість = row.Кількість,
                    КоміркаВідправник = row.КоміркаВідправник,
                    КоміркаОтримувач = row.КоміркаОтримувач,
                    
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        
        if (ЕлементВласник != null) 
        {
            
            ЕлементВласник.Товари_TablePart.FillJoin([ПереміщенняТоварівНаСкладі_Товари_TablePart.НомерРядка,]);
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
        ItemRow row = ItemRow.New();
        await ПісляДодаванняНового(row);
        
        Store.Append(row);
        return true;
    }
}