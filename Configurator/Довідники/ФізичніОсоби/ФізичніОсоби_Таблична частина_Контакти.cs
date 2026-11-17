
/*
        ФізичніОсоби_ТабличнаЧастина_Контакти.cs
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

[GObject.Subclass<DirectoryFormTablePart>("FizychniOsoby_TablePart_Kontakty")]
partial class ФізичніОсоби_ТабличнаЧастина_Контакти : DirectoryFormTablePart
{
    #region Модель даних
    
    [GObject.Subclass<GObject.Object>("FizychniOsoby_TablePart_Kontakty_ItemRow")]
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

    
        /* Тип */
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
        public Action? Сhanged_Тип { get; set; } = null;

    
        /* Значення */
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
        public Action? Сhanged_Значення { get; set; } = null;

    
        /* Телефон */
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
        public Action? Сhanged_Телефон { get; set; } = null;

    
        /* ЕлектроннаПошта */
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
        public Action? Сhanged_ЕлектроннаПошта { get; set; } = null;

    
        /* Країна */
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
        public Action? Сhanged_Країна { get; set; } = null;

    
        /* Область */
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
        public Action? Сhanged_Область { get; set; } = null;

    
        /* Район */
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
        public Action? Сhanged_Район { get; set; } = null;

    
        /* Місто */
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
        public Action? Сhanged_Місто { get; set; } = null;

    

        /*
        Функції
        */
        
        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Тип = Тип;
            row.Значення = Значення;
            row.Телефон = Телефон;
            row.ЕлектроннаПошта = ЕлектроннаПошта;
            row.Країна = Країна;
            row.Область = Область;
            row.Район = Район;
            row.Місто = Місто;
            
            return row;
        }
    }

    #endregion

    #region Функції

    static Task ПісляДодаванняНового(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Значення(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Телефон(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_ЕлектроннаПошта(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Країна(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Область(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Район(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Місто(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Тип(ItemRow row) => Task.CompletedTask;
    

    #endregion

    
    public ФізичніОсоби_Object? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static ФізичніОсоби_ТабличнаЧастина_Контакти New()
    {
        ФізичніОсоби_ТабличнаЧастина_Контакти tablePart = NewWithProperties([]);
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
        
        //Тип
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = DropDownTablePartCell.NewWithValues(ПсевдонімиПерелічення.ТипиКонтактноїІнформації_Dict());
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DropDownTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Тип = ПсевдонімиПерелічення.ТипиКонтактноїІнформації_FindByName(cell.Value);
                    await ПісляЗміни_Тип(row);
                };
                (row.Сhanged_Тип = () => cell.Value = row.Тип.ToString()).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DropDownTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Тип = null;
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
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Значення = cell.Value;
                    await ПісляЗміни_Значення(row);
                };
                (row.Сhanged_Значення = () => cell.Value = row.Значення).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Значення = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Значення", factory);
            column.Resizable = true;
            
            column.FixedWidth = 300;
            
            Grid.AppendColumn(column);
        }
        
        //Телефон
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
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Телефон = cell.Value;
                    await ПісляЗміни_Телефон(row);
                };
                (row.Сhanged_Телефон = () => cell.Value = row.Телефон).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Телефон = null;
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
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.ЕлектроннаПошта = cell.Value;
                    await ПісляЗміни_ЕлектроннаПошта(row);
                };
                (row.Сhanged_ЕлектроннаПошта = () => cell.Value = row.ЕлектроннаПошта).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_ЕлектроннаПошта = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Email", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Країна
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
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Країна = cell.Value;
                    await ПісляЗміни_Країна(row);
                };
                (row.Сhanged_Країна = () => cell.Value = row.Країна).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Країна = null;
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
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Область = cell.Value;
                    await ПісляЗміни_Область(row);
                };
                (row.Сhanged_Область = () => cell.Value = row.Область).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Область = null;
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
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Район = cell.Value;
                    await ПісляЗміни_Район(row);
                };
                (row.Сhanged_Район = () => cell.Value = row.Район).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Район = null;
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
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Місто = cell.Value;
                    await ПісляЗміни_Місто(row);
                };
                (row.Сhanged_Місто = () => cell.Value = row.Місто).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Місто = null;
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

    //З таб частин в модель
    ItemRow[] ToItemRows(List<ФізичніОсоби_Контакти_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.Тип = x.Тип;
        row.Значення = x.Значення;
        row.Телефон = x.Телефон;
        row.ЕлектроннаПошта = x.ЕлектроннаПошта;
        row.Країна = x.Країна;
        row.Область = x.Область;
        row.Район = x.Район;
        row.Місто = x.Місто;
        
        return row;
    })];

    //З моделі в таб частину
    List<ФізичніОсоби_Контакти_TablePart.Record> ToRecords()
    {
        List<ФізичніОсоби_Контакти_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Тип = row.Тип,
                    Значення = row.Значення,
                    Телефон = row.Телефон,
                    ЕлектроннаПошта = row.ЕлектроннаПошта,
                    Країна = row.Країна,
                    Область = row.Область,
                    Район = row.Район,
                    Місто = row.Місто,
                    
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        
        if (ЕлементВласник != null) 
        {
            
            ЕлементВласник.Контакти_TablePart.FillJoin([ФізичніОсоби_Контакти_TablePart.НомерРядка,]);
            await ЕлементВласник.Контакти_TablePart.Read();
            
            UpdateStore(ToItemRows(ЕлементВласник.Контакти_TablePart.Records));
        
        }
    }

    public override async Task SaveRecords()
    {
        
        if (ЕлементВласник != null)
        {
        ЕлементВласник.Контакти_TablePart.Records.Clear();
            ЕлементВласник.Контакти_TablePart.Records.AddRange(ToRecords());
            await ЕлементВласник.Контакти_TablePart.Save(true);
            UpdateStore(ToItemRows(ЕлементВласник.Контакти_TablePart.Records));

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
    