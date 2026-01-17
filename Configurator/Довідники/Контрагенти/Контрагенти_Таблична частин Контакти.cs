
/*
        Контрагенти_ТабличнаЧастина_Контакти.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Контрагенти_ТабличнаЧастина_Контакти : DirectoryFormTablePart
{
    
    public Контрагенти_Objest? ЕлементВласник { get; set; }
        
    
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
        // Значення
        //
        public string Значення
        {
            get => Значення_;
            set
            {
                if (!Значення_.Equals(value))
                {
                    Значення_ = value;
                    Сhanged_Значення?.Invoke();
                }
            }
        }
        string Значення_ = "";
        public Action? Сhanged_Значення;

    
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

    
        //
        // ДатаЧас
        //
        public DateTime ДатаЧас
        {
            get => ДатаЧас_;
            set
            {
                if (!ДатаЧас_.Equals(value))
                {
                    ДатаЧас_ = value;
                    Сhanged_ДатаЧас?.Invoke();
                }
            }
        }
        DateTime ДатаЧас_ = DateTime.MinValue;
        public Action? Сhanged_ДатаЧас;

    
        //
        // Дата
        //
        public DateTime Дата
        {
            get => Дата_;
            set
            {
                if (!Дата_.Equals(value))
                {
                    Дата_ = value;
                    Сhanged_Дата?.Invoke();
                }
            }
        }
        DateTime Дата_ = DateTime.MinValue;
        public Action? Сhanged_Дата;

    
        //
        // Час
        //
        public TimeSpan Час
        {
            get => Час_;
            set
            {
                if (!Час_.Equals(value))
                {
                    Час_ = value;
                    Сhanged_Час?.Invoke();
                }
            }
        }
        TimeSpan Час_ = DateTime.MinValue.TimeOfDay;
        public Action? Сhanged_Час;

    

        /*
        Функції
        */
        
        public override ItemRow Copy()
        {
            return new()
            {
                НомерРядка = НомерРядка,
                Тип = Тип,
                Значення = Значення,
                Телефон = Телефон,
                ЕлектроннаПошта = ЕлектроннаПошта,
                Країна = Країна,
                Область = Область,
                Район = Район,
                Місто = Місто,
                ДатаЧас = ДатаЧас,
                Дата = Дата,
                Час = Час,
                
            };
        }
    }

    #endregion

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public Контрагенти_ТабличнаЧастина_Контакти() : base(Program.BasicForm?.NotebookFunc)
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
                    
                    cell.OnСhanged = () => row.Тип = ПсевдонімиПерелічення.ТипиКонтактноїІнформації_FindByName(cell.Combo.ActiveId);
                    (row.Сhanged_Тип = () => cell.Value = row.Тип.ToString()).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Тип", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Значення
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new TextTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Значення = cell.Value;
                    (row.Сhanged_Значення = () => cell.Value = row.Значення).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Значення", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Телефон
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new TextTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Телефон = cell.Value;
                    (row.Сhanged_Телефон = () => cell.Value = row.Телефон).Invoke();
                        
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
                var cell = new TextTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.ЕлектроннаПошта = cell.Value;
                    (row.Сhanged_ЕлектроннаПошта = () => cell.Value = row.ЕлектроннаПошта).Invoke();
                        
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
                var cell = new TextTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Країна = cell.Value;
                    (row.Сhanged_Країна = () => cell.Value = row.Країна).Invoke();
                        
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
                var cell = new TextTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Область = cell.Value;
                    (row.Сhanged_Область = () => cell.Value = row.Область).Invoke();
                        
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
                var cell = new TextTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Район = cell.Value;
                    (row.Сhanged_Район = () => cell.Value = row.Район).Invoke();
                        
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
                var cell = new TextTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TextTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Місто = cell.Value;
                    (row.Сhanged_Місто = () => cell.Value = row.Місто).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Місто", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //ДатаЧас
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new DateTimeTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (DateTimeTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.ДатаЧас = cell.Value;
                    (row.Сhanged_ДатаЧас = () => cell.Value = row.ДатаЧас).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Дата та час", factory);
            column.Resizable = true;
            
            column.FixedWidth = 200;
            
            Grid.AppendColumn(column);
        }
        
        //Дата
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new DateTimeTablePartCell();
                
                cell.OnlyDate = true;
                    
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (DateTimeTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Дата = cell.Value;
                    (row.Сhanged_Дата = () => cell.Value = row.Дата).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Дата", factory);
            column.Resizable = true;
            
            column.FixedWidth = 100;
            
            Grid.AppendColumn(column);
        }
        
        //Час
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new TimeTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (TimeTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Час = cell.Value;
                    (row.Сhanged_Час = () => cell.Value = row.Час).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Час", factory);
            column.Resizable = true;
            
            column.FixedWidth = 100;
            
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
            
            ЕлементВласник.Контакти_TablePart.FillJoin([Контрагенти_Контакти_TablePart.НомерРядка,]);
            await ЕлементВласник.Контакти_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (var record in ЕлементВласник.Контакти_TablePart.Records)
        {
            Store.Append(new ItemRow()
            {
                UnigueID = new(record.UID),
                НомерРядка = record.НомерРядка,
                Тип = record.Тип,
                Значення = record.Значення,
                Телефон = record.Телефон,
                ЕлектроннаПошта = record.ЕлектроннаПошта,
                Країна = record.Країна,
                Область = record.Область,
                Район = record.Район,
                Місто = record.Місто,
                ДатаЧас = record.ДатаЧас,
                Дата = record.Дата,
                Час = record.Час,
                
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
                    НомерРядка = row.НомерРядка,
                    Тип = row.Тип,
                    Значення = row.Значення,
                    Телефон = row.Телефон,
                    ЕлектроннаПошта = row.ЕлектроннаПошта,
                    Країна = row.Країна,
                    Область = row.Область,
                    Район = row.Район,
                    Місто = row.Місто,
                    ДатаЧас = row.ДатаЧас,
                    Дата = row.Дата,
                    Час = row.Час,
                    
                });
            }
        }
        await ЕлементВласник.Контакти_TablePart.Save(true);
        //Update
        {
            uint position = 0;
            foreach (var record in ЕлементВласник.Контакти_TablePart.Records)
            {
                bool sel = Grid.Model.IsSelected(position);
                Store.Splice(position, 1, [new ItemRow()
                {
                    UnigueID = new(record.UID),
                    НомерРядка = record.НомерРядка,
                    Тип = record.Тип,
                    Значення = record.Значення,
                    Телефон = record.Телефон,
                    ЕлектроннаПошта = record.ЕлектроннаПошта,
                    Країна = record.Країна,
                    Область = record.Область,
                    Район = record.Район,
                    Місто = record.Місто,
                    ДатаЧас = record.ДатаЧас,
                    Дата = record.Дата,
                    Час = record.Час,
                    
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
    