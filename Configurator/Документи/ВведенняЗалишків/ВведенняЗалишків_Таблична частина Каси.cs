
/*
        ВведенняЗалишків_ТабличнаЧастина_Каси.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;


namespace StorageAndTrade;

class ВведенняЗалишків_ТабличнаЧастина_Каси : DocumentFormTablePart
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
        // Каса
        //
        public Каси_Pointer Каса
        {
            get => Каса_;
            set
            {
                if (!Каса_.Equals(value))
                {
                    Каса_ = value;
                    Сhanged_Каса?.Invoke();
                }
            }
        }
        Каси_Pointer Каса_ = new();
        public Action? Сhanged_Каса;

    
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
                Каса = Каса.Copy(),
                Сума = Сума,
                
            };
        }
    }

    #endregion

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public ВведенняЗалишків_ТабличнаЧастина_Каси() : base(Program.BasicForm?.NotebookFunc)
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
        
        //Каса
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new Каси_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (Каси_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.Каса = cell.Pointer;
                    (row.Сhanged_Каса = () => cell.Pointer = row.Каса).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Каса", factory);
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
            
            ЕлементВласник.Каси_TablePart.FillJoin([ВведенняЗалишків_Каси_TablePart.НомерРядка,]);
            await ЕлементВласник.Каси_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (ВведенняЗалишків_Каси_TablePart.Record record in ЕлементВласник.Каси_TablePart.Records)
        {
            Store.Append(new ItemRow()
            {
                UnigueID = new(record.UID),
                НомерРядка = record.НомерРядка,
                Каса = record.Каса,
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
        ЕлементВласник.Каси_TablePart.Records.Clear();
        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                ЕлементВласник.Каси_TablePart.Records.Add(new()
                {
                    UID = row.UnigueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Каса = row.Каса,
                    Сума = row.Сума,
                    
                });
            }
        }
        await ЕлементВласник.Каси_TablePart.Save(true);
        await LoadRecords();
        }
    }

    public override bool NewRecord()
    {
        Store.Append(new ItemRow());
        return true;
    }
}
    