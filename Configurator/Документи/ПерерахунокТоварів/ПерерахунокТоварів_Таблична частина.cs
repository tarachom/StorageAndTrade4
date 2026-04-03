
/*
        ПерерахунокТоварів_ТабличнаЧастина_Товари.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

partial class ПерерахунокТоварів_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Data
    
    [GObject.Subclass<GObject.Object>("ItemRow_z48ei7Df5kWrQJELYHsh8A")]
    public partial class ItemRow : IRowTablePart
    {
        public static ItemRow New() => NewWithProperties([]);

        // Унікальний ідентифікатор
        public UniqueID UniqueID
        {
            get => UnigueID_;
            set
            {
                UnigueID_ = value;
                Сhanged_UnigueID?.Invoke();
            }
        }
        UniqueID UnigueID_ = new();
        public Action? Сhanged_UnigueID;

    
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
        public Action? Сhanged_НомерРядка;

    
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
        public Action? Сhanged_Номенклатура;

    
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
        public Action? Сhanged_ХарактеристикаНоменклатури;

    
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
        public Action? Сhanged_КількістьУпаковок;

    
        /* КількістьУпаковокФакт */
        public int КількістьУпаковокФакт
        {
            get => КількістьУпаковокФакт_;
            set
            {
                if (!КількістьУпаковокФакт_.Equals(value))
                {
                    КількістьУпаковокФакт_ = value;
                    Сhanged_КількістьУпаковокФакт?.Invoke();
                }
            }
        }
        int КількістьУпаковокФакт_ = 0;
        public Action? Сhanged_КількістьУпаковокФакт;

    
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
        public Action? Сhanged_Пакування;

    
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
        public Action? Сhanged_Кількість;

    
        /* КількістьФакт */
        public decimal КількістьФакт
        {
            get => КількістьФакт_;
            set
            {
                if (!КількістьФакт_.Equals(value))
                {
                    КількістьФакт_ = value;
                    Сhanged_КількістьФакт?.Invoke();
                }
            }
        }
        decimal КількістьФакт_ = 0;
        public Action? Сhanged_КількістьФакт;

    
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
        public Action? Сhanged_Коментар;

    

        /*
        Функції
        */
        
        public GObject.Object Copy()
        {
            var itemRow = New();
            itemRow.НомерРядка = НомерРядка;
            itemRow.Номенклатура = Номенклатура.Copy();
            itemRow.ХарактеристикаНоменклатури = ХарактеристикаНоменклатури.Copy();
            itemRow.КількістьУпаковок = КількістьУпаковок;
            itemRow.КількістьУпаковокФакт = КількістьУпаковокФакт;
            itemRow.Пакування = Пакування.Copy();
            itemRow.Кількість = Кількість;
            itemRow.КількістьФакт = КількістьФакт;
            itemRow.Коментар = Коментар;
            
            return itemRow;
        }
    }

    #endregion

    
    public ПерерахунокТоварів_Objest? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public ПерерахунокТоварів_ТабличнаЧастина_Товари() : base(Program.BasicForm?.NotebookFunc)
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
            ColumnViewColumn column = ColumnViewColumn.New("Пак", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //КількістьУпаковокФакт
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
                
                cell.OnСhanged = () => row.КількістьУпаковокФакт = cell.Value;
                (row.Сhanged_КількістьУпаковокФакт = () => cell.Value = row.КількістьУпаковокФакт).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Пак факт", factory);
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
        
        //КількістьФакт
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
                
                cell.OnСhanged = () => row.КількістьФакт = cell.Value;
                (row.Сhanged_КількістьФакт = () => cell.Value = row.КількістьФакт).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість факт", factory);
            column.Resizable = true;
            
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
            
            ЕлементВласник.Товари_TablePart.FillJoin([ПерерахунокТоварів_Товари_TablePart.НомерРядка,]);
            await ЕлементВласник.Товари_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (var record in ЕлементВласник.Товари_TablePart.Records)
        {
            var row = ItemRow.New();
            row.UniqueID = new(record.UID);
            row.НомерРядка = record.НомерРядка;
            row.Номенклатура = record.Номенклатура;
            row.ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури;
            row.КількістьУпаковок = record.КількістьУпаковок;
            row.КількістьУпаковокФакт = record.КількістьУпаковокФакт;
            row.Пакування = record.Пакування;
            row.Кількість = record.Кількість;
            row.КількістьФакт = record.КількістьФакт;
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
                    КількістьУпаковок = row.КількістьУпаковок,
                    КількістьУпаковокФакт = row.КількістьУпаковокФакт,
                    Пакування = row.Пакування,
                    Кількість = row.Кількість,
                    КількістьФакт = row.КількістьФакт,
                    Коментар = row.Коментар,
                    
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

                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Номенклатура = record.Номенклатура;
                row.ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури;
                row.КількістьУпаковок = record.КількістьУпаковок;
                row.КількістьУпаковокФакт = record.КількістьУпаковокФакт;
                row.Пакування = record.Пакування;
                row.Кількість = record.Кількість;
                row.КількістьФакт = record.КількістьФакт;
                row.Коментар = record.Коментар;
                
                Store.Splice(position, 1, [row], 1);
                if (sel) Grid.Model.SelectItem(position, false);
                position++;
            }
        }
        }
    }

    public override bool NewRecord()
    {
        Store.Append(ItemRow.New());
        return true;
    }
}
    