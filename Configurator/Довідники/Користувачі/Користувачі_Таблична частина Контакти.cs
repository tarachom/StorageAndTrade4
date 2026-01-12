
/*
        Користувачі_ТабличнаЧастина_Контакти.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;


namespace StorageAndTrade;

class Користувачі_ТабличнаЧастина_Контакти : DirectoryFormTablePart
{
    
    public Користувачі_Objest? ЕлементВласник { get; set; }
        
    
    #region Data

    class ItemRow : RowTablePart
    {
    
        //
        // Тип
        //
        public ТипиКонтактноїІнформації Тип
        {
            get => Тип_;
            set
            {
                if (!Тип_.Equals(value))
                {
                    Тип_ = value;
                    Сhanged_Тип?.Invoke();
                }
            }
        }
        ТипиКонтактноїІнформації Тип_ = 0;
        public Action? Сhanged_Тип;

    
        //
        // Телефон
        //
        public string Телефон
        {
            get => Телефон_;
            set
            {
                if (!Телефон_.Equals(value))
                {
                    Телефон_ = value;
                    Сhanged_Телефон?.Invoke();
                }
            }
        }
        string Телефон_ = "";
        public Action? Сhanged_Телефон;

    
        //
        // ЕлектроннаПошта
        //
        public string ЕлектроннаПошта
        {
            get => ЕлектроннаПошта_;
            set
            {
                if (!ЕлектроннаПошта_.Equals(value))
                {
                    ЕлектроннаПошта_ = value;
                    Сhanged_ЕлектроннаПошта?.Invoke();
                }
            }
        }
        string ЕлектроннаПошта_ = "";
        public Action? Сhanged_ЕлектроннаПошта;

    
        //
        // Країна
        //
        public string Країна
        {
            get => Країна_;
            set
            {
                if (!Країна_.Equals(value))
                {
                    Країна_ = value;
                    Сhanged_Країна?.Invoke();
                }
            }
        }
        string Країна_ = "";
        public Action? Сhanged_Країна;

    
        //
        // Область
        //
        public string Область
        {
            get => Область_;
            set
            {
                if (!Область_.Equals(value))
                {
                    Область_ = value;
                    Сhanged_Область?.Invoke();
                }
            }
        }
        string Область_ = "";
        public Action? Сhanged_Область;

    
        //
        // Район
        //
        public string Район
        {
            get => Район_;
            set
            {
                if (!Район_.Equals(value))
                {
                    Район_ = value;
                    Сhanged_Район?.Invoke();
                }
            }
        }
        string Район_ = "";
        public Action? Сhanged_Район;

    
        //
        // Місто
        //
        public string Місто
        {
            get => Місто_;
            set
            {
                if (!Місто_.Equals(value))
                {
                    Місто_ = value;
                    Сhanged_Місто?.Invoke();
                }
            }
        }
        string Місто_ = "";
        public Action? Сhanged_Місто;

    

        /*
        Функції
        */
        
        public override ItemRow Copy()
        {
            return new()
            {
                Тип = Тип,
                Телефон = Телефон,
                ЕлектроннаПошта = ЕлектроннаПошта,
                Країна = Країна,
                Область = Область,
                Район = Район,
                Місто = Місто,
                
            };
        }
    }

    #endregion

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public Користувачі_ТабличнаЧастина_Контакти() : base(Program.BasicForm?.NotebookFunc)
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    protected override void Columns()
    {
        
        //Тип
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new ComboTextTablePartCell();
                foreach (var field in ПсевдонімиПерелічення.ТипиКонтактноїІнформації_List())
                    cell.Combo.Append(field.Value.ToString(), field.Name);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (ComboTextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Тип = ПсевдонімиПерелічення.ТипиКонтактноїІнформації_FindByName(cell.Value);
                    (row.Сhanged_Тип = () => cell.Value = row.Тип.ToString()).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Тип", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Телефон
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.New(null);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    (row.Сhanged_Телефон = () => cell.SetText(row.NumberRow)).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Телефон", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //ЕлектроннаПошта
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.New(null);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    (row.Сhanged_ЕлектроннаПошта = () => cell.SetText(row.NumberRow)).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("ЕлектроннаПошта", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Країна
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.New(null);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    (row.Сhanged_Країна = () => cell.SetText(row.NumberRow)).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Країна", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Область
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.New(null);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    (row.Сhanged_Область = () => cell.SetText(row.NumberRow)).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Область", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Район
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.New(null);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    (row.Сhanged_Район = () => cell.SetText(row.NumberRow)).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Район", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Місто
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = LabelTablePartCell.New(null);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (LabelTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    (row.Сhanged_Місто = () => cell.SetText(row.NumberRow)).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Місто", factory);
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
            
            ЕлементВласник.Контакти_TablePart.FillJoin([]);
            await ЕлементВласник.Контакти_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (Користувачі_Контакти_TablePart.Record record in ЕлементВласник.Контакти_TablePart.Records)
        {
            Store.Append(new ItemRow()
            {
                UnigueID = new(record.UID),
                Тип = record.Тип,
                Телефон = record.Телефон,
                ЕлектроннаПошта = record.ЕлектроннаПошта,
                Країна = record.Країна,
                Область = record.Область,
                Район = record.Район,
                Місто = record.Місто,
                
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
        ЕлементВласник.Контакти_TablePart.Records.Clear();
        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                ЕлементВласник.Контакти_TablePart.Records.Add(new()
                {
                    UID = row.UnigueID.UGuid,
                    Тип = row.Тип,
                    Телефон = row.Телефон,
                    ЕлектроннаПошта = row.ЕлектроннаПошта,
                    Країна = row.Країна,
                    Область = row.Область,
                    Район = row.Район,
                    Місто = row.Місто,
                    
                });
            }
        }
        await ЕлементВласник.Контакти_TablePart.Save(true);
        await LoadRecords();
        }
    }

    public override bool NewRecord()
    {
        Store.Append(new ItemRow());
        return true;
    }
}
    