
/*
        ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки : DocumentFormTablePart
{
    
    public ВведенняЗалишків_Objest? ЕлементВласник { get; set; }
        
    
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
        // БанківськийРахунок
        //
        public БанківськіРахункиОрганізацій_Pointer БанківськийРахунок
        {
            get => БанківськийРахунок_;
            set
            {
                if (!БанківськийРахунок_.Equals(value))
                {
                    БанківськийРахунок_ = value;
                    Сhanged_БанківськийРахунок?.Invoke();
                }
            }
        }
        БанківськіРахункиОрганізацій_Pointer БанківськийРахунок_ = new();
        public Action? Сhanged_БанківськийРахунок;

    
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

    

        /*
        Функції
        */
        
        public override ItemRow Copy()
        {
            return new()
            {
                НомерРядка = НомерРядка,
                БанківськийРахунок = БанківськийРахунок.Copy(),
                Сума = Сума,
                
            };
        }
    }

    #endregion

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки() : base(Program.BasicForm?.NotebookFunc)
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
        
        //БанківськийРахунок
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new БанківськіРахункиОрганізацій_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (БанківськіРахункиОрганізацій_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.БанківськийРахунок = cell.Pointer;
                        
                    (row.Сhanged_БанківськийРахунок = () => cell.Pointer = row.БанківськийРахунок).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Банківський рахунок", factory);
            column.Resizable = true;
            
            column.FixedWidth = 300;
            
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
            
            ЕлементВласник.БанківськіРахунки_TablePart.FillJoin([ВведенняЗалишків_БанківськіРахунки_TablePart.НомерРядка,]);
            await ЕлементВласник.БанківськіРахунки_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (var record in ЕлементВласник.БанківськіРахунки_TablePart.Records)
        {
            Store.Append(new ItemRow()
            {
                UnigueID = new(record.UID),
                НомерРядка = record.НомерРядка,
                БанківськийРахунок = record.БанківськийРахунок,
                Сума = record.Сума,
                
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
        ЕлементВласник.БанківськіРахунки_TablePart.Records.Clear();
        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                ЕлементВласник.БанківськіРахунки_TablePart.Records.Add(new()
                {
                    UID = row.UnigueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    БанківськийРахунок = row.БанківськийРахунок,
                    Сума = row.Сума,
                    
                });
            }
        }
        await ЕлементВласник.БанківськіРахунки_TablePart.Save(true);
        //Update
        {
            uint position = 0;
            foreach (var record in ЕлементВласник.БанківськіРахунки_TablePart.Records)
            {
                bool sel = Grid.Model.IsSelected(position);
                Store.Splice(position, 1, [new ItemRow()
                {
                    UnigueID = new(record.UID),
                    НомерРядка = record.НомерРядка,
                    БанківськийРахунок = record.БанківськийРахунок,
                    Сума = record.Сума,
                    
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
    