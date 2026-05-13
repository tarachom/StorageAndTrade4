
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

[GObject.Subclass<DirectoryFormTablePart>("TablePart_HSBxVlI93k6u56MkeDY2eg")]
partial class Користувачі_ТабличнаЧастина_Контакти : DirectoryFormTablePart
{
    #region Data
    
    [GObject.Subclass<GObject.Object>("ItemRow_HSBxVlI93k6u56MkeDY2eg")]
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

    
        /* Основа */
        public UuidAndText Основа
        {
            get => Основа_;
            set
            {
                if (!Основа_.Equals(value))
                {
                    Основа_ = value;
                    Сhanged_Основа?.Invoke();
                }
            }
        }
        UuidAndText Основа_ = new();
        public Action? Сhanged_Основа { get; set; } = null;

    

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
            row.Основа = Основа.Copy();
            
            return row;
        }
    }

    #endregion

    
    public Користувачі_Objest? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static Користувачі_ТабличнаЧастина_Контакти New()
    {
        Користувачі_ТабличнаЧастина_Контакти tablePart = NewWithProperties([]);
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
        
        //Тип
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ComboTextTablePartCell.New();
                foreach (var field in ПсевдонімиПерелічення.ТипиКонтактноїІнформації_List())
                    cell.Combo.Append(field.Value.ToString(), field.Name);
                //Заборона прокрутки списку
                EventControllerScroll contr = EventControllerScroll.New(EventControllerScrollFlags.BothAxes);
                cell.Combo.AddController(contr);
                contr.OnScroll += (_, _) => true;
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ComboTextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = () => row.Тип = ПсевдонімиПерелічення.ТипиКонтактноїІнформації_FindByName(cell.Combo.ActiveId);
                (row.Сhanged_Тип = () => cell.Value = row.Тип.ToString()).Invoke();
                    
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
                
                cell.OnСhanged = () => row.Значення = cell.Value;
                (row.Сhanged_Значення = () => cell.Value = row.Значення).Invoke();
                    
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
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = () => row.Телефон = cell.Value;
                (row.Сhanged_Телефон = () => cell.Value = row.Телефон).Invoke();
                    
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
                
                cell.OnСhanged = () => row.ЕлектроннаПошта = cell.Value;
                (row.Сhanged_ЕлектроннаПошта = () => cell.Value = row.ЕлектроннаПошта).Invoke();
                    
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
                if (args.Object is not ListItem listItem) return;
                var cell = TextTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = () => row.Країна = cell.Value;
                (row.Сhanged_Країна = () => cell.Value = row.Країна).Invoke();
                    
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
                
                cell.OnСhanged = () => row.Область = cell.Value;
                (row.Сhanged_Область = () => cell.Value = row.Область).Invoke();
                    
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
                
                cell.OnСhanged = () => row.Район = cell.Value;
                (row.Сhanged_Район = () => cell.Value = row.Район).Invoke();
                    
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
                
                cell.OnСhanged = () => row.Місто = cell.Value;
                (row.Сhanged_Місто = () => cell.Value = row.Місто).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Місто", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Основа
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = CompositePointerControlTablePartCell.New();
                
                cell.BoundConfType = "Довідники.Користувачі.Контакти.Основа";
                    
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not CompositePointerControlTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = () => row.Основа = cell.Pointer;
                (row.Сhanged_Основа = () => cell.Pointer = row.Основа).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Основа", factory);
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
            
            ЕлементВласник.Контакти_TablePart.FillJoin([Користувачі_Контакти_TablePart.НомерРядка,]);
            await ЕлементВласник.Контакти_TablePart.Read();
            
            Store.RemoveAll();
        
            foreach (var record in ЕлементВласник.Контакти_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Тип = record.Тип;
                row.Значення = record.Значення;
                row.Телефон = record.Телефон;
                row.ЕлектроннаПошта = record.ЕлектроннаПошта;
                row.Країна = record.Країна;
                row.Область = record.Область;
                row.Район = record.Район;
                row.Місто = record.Місто;
                row.Основа = record.Основа;
                
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
        ЕлементВласник.Контакти_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    ЕлементВласник.Контакти_TablePart.Records.Add(new()
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
                        Основа = row.Основа,
                        
                    });
                }
            }
            await ЕлементВласник.Контакти_TablePart.Save(true);
            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.Контакти_TablePart.Records.Select(x =>
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
                    row.Основа = x.Основа;
                    
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
    