
/*
        ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DirectoryFormTablePart>("TablePart_5FpHXpSIEKJw9K59Tx0Hw")]
partial class ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка : DirectoryFormTablePart
{
    #region Data
    
    [GObject.Subclass<GObject.Object>("ItemRow_5FpHXpSIEKJw9K59Tx0Hw")]
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

    
        /* А */
        public string А
        {
            get => А_;
            set
            {
                if (!А_.Equals(value))
                {
                    А_ = value;
                    Сhanged_А?.Invoke();
                }
            }
        }
        string А_ = "";
        public Action? Сhanged_А { get; set; } = null;

    
        /* Б */
        public string Б
        {
            get => Б_;
            set
            {
                if (!Б_.Equals(value))
                {
                    Б_ = value;
                    Сhanged_Б?.Invoke();
                }
            }
        }
        string Б_ = "";
        public Action? Сhanged_Б { get; set; } = null;

    
        /* В */
        public string В
        {
            get => В_;
            set
            {
                if (!В_.Equals(value))
                {
                    В_ = value;
                    Сhanged_В?.Invoke();
                }
            }
        }
        string В_ = "";
        public Action? Сhanged_В { get; set; } = null;

    
        /* Г */
        public string Г
        {
            get => Г_;
            set
            {
                if (!Г_.Equals(value))
                {
                    Г_ = value;
                    Сhanged_Г?.Invoke();
                }
            }
        }
        string Г_ = "";
        public Action? Сhanged_Г { get; set; } = null;

    
        /* Ґ */
        public string Ґ
        {
            get => Ґ_;
            set
            {
                if (!Ґ_.Equals(value))
                {
                    Ґ_ = value;
                    Сhanged_Ґ?.Invoke();
                }
            }
        }
        string Ґ_ = "";
        public Action? Сhanged_Ґ { get; set; } = null;

    
        /* Д */
        public string Д
        {
            get => Д_;
            set
            {
                if (!Д_.Equals(value))
                {
                    Д_ = value;
                    Сhanged_Д?.Invoke();
                }
            }
        }
        string Д_ = "";
        public Action? Сhanged_Д { get; set; } = null;

    
        /* Е */
        public string Е
        {
            get => Е_;
            set
            {
                if (!Е_.Equals(value))
                {
                    Е_ = value;
                    Сhanged_Е?.Invoke();
                }
            }
        }
        string Е_ = "";
        public Action? Сhanged_Е { get; set; } = null;

    
        /* Є */
        public string Є
        {
            get => Є_;
            set
            {
                if (!Є_.Equals(value))
                {
                    Є_ = value;
                    Сhanged_Є?.Invoke();
                }
            }
        }
        string Є_ = "";
        public Action? Сhanged_Є { get; set; } = null;

    
        /* Ж */
        public string Ж
        {
            get => Ж_;
            set
            {
                if (!Ж_.Equals(value))
                {
                    Ж_ = value;
                    Сhanged_Ж?.Invoke();
                }
            }
        }
        string Ж_ = "";
        public Action? Сhanged_Ж { get; set; } = null;

    
        /* З */
        public string З
        {
            get => З_;
            set
            {
                if (!З_.Equals(value))
                {
                    З_ = value;
                    Сhanged_З?.Invoke();
                }
            }
        }
        string З_ = "";
        public Action? Сhanged_З { get; set; } = null;

    
        /* И */
        public string И
        {
            get => И_;
            set
            {
                if (!И_.Equals(value))
                {
                    И_ = value;
                    Сhanged_И?.Invoke();
                }
            }
        }
        string И_ = "";
        public Action? Сhanged_И { get; set; } = null;

    
        /* І */
        public string І
        {
            get => І_;
            set
            {
                if (!І_.Equals(value))
                {
                    І_ = value;
                    Сhanged_І?.Invoke();
                }
            }
        }
        string І_ = "";
        public Action? Сhanged_І { get; set; } = null;

    
        /* Ї */
        public string Ї
        {
            get => Ї_;
            set
            {
                if (!Ї_.Equals(value))
                {
                    Ї_ = value;
                    Сhanged_Ї?.Invoke();
                }
            }
        }
        string Ї_ = "";
        public Action? Сhanged_Ї { get; set; } = null;

    
        /* Й */
        public string Й
        {
            get => Й_;
            set
            {
                if (!Й_.Equals(value))
                {
                    Й_ = value;
                    Сhanged_Й?.Invoke();
                }
            }
        }
        string Й_ = "";
        public Action? Сhanged_Й { get; set; } = null;

    
        /* К */
        public string К
        {
            get => К_;
            set
            {
                if (!К_.Equals(value))
                {
                    К_ = value;
                    Сhanged_К?.Invoke();
                }
            }
        }
        string К_ = "";
        public Action? Сhanged_К { get; set; } = null;

    
        /* Л */
        public string Л
        {
            get => Л_;
            set
            {
                if (!Л_.Equals(value))
                {
                    Л_ = value;
                    Сhanged_Л?.Invoke();
                }
            }
        }
        string Л_ = "";
        public Action? Сhanged_Л { get; set; } = null;

    
        /* М */
        public string М
        {
            get => М_;
            set
            {
                if (!М_.Equals(value))
                {
                    М_ = value;
                    Сhanged_М?.Invoke();
                }
            }
        }
        string М_ = "";
        public Action? Сhanged_М { get; set; } = null;

    
        /* Н */
        public string Н
        {
            get => Н_;
            set
            {
                if (!Н_.Equals(value))
                {
                    Н_ = value;
                    Сhanged_Н?.Invoke();
                }
            }
        }
        string Н_ = "";
        public Action? Сhanged_Н { get; set; } = null;

    
        /* О */
        public string О
        {
            get => О_;
            set
            {
                if (!О_.Equals(value))
                {
                    О_ = value;
                    Сhanged_О?.Invoke();
                }
            }
        }
        string О_ = "";
        public Action? Сhanged_О { get; set; } = null;

    
        /* П */
        public string П
        {
            get => П_;
            set
            {
                if (!П_.Equals(value))
                {
                    П_ = value;
                    Сhanged_П?.Invoke();
                }
            }
        }
        string П_ = "";
        public Action? Сhanged_П { get; set; } = null;

    
        /* Р */
        public string Р
        {
            get => Р_;
            set
            {
                if (!Р_.Equals(value))
                {
                    Р_ = value;
                    Сhanged_Р?.Invoke();
                }
            }
        }
        string Р_ = "";
        public Action? Сhanged_Р { get; set; } = null;

    
        /* С */
        public string С
        {
            get => С_;
            set
            {
                if (!С_.Equals(value))
                {
                    С_ = value;
                    Сhanged_С?.Invoke();
                }
            }
        }
        string С_ = "";
        public Action? Сhanged_С { get; set; } = null;

    
        /* Т */
        public string Т
        {
            get => Т_;
            set
            {
                if (!Т_.Equals(value))
                {
                    Т_ = value;
                    Сhanged_Т?.Invoke();
                }
            }
        }
        string Т_ = "";
        public Action? Сhanged_Т { get; set; } = null;

    
        /* У */
        public string У
        {
            get => У_;
            set
            {
                if (!У_.Equals(value))
                {
                    У_ = value;
                    Сhanged_У?.Invoke();
                }
            }
        }
        string У_ = "";
        public Action? Сhanged_У { get; set; } = null;

    
        /* Ф */
        public string Ф
        {
            get => Ф_;
            set
            {
                if (!Ф_.Equals(value))
                {
                    Ф_ = value;
                    Сhanged_Ф?.Invoke();
                }
            }
        }
        string Ф_ = "";
        public Action? Сhanged_Ф { get; set; } = null;

    
        /* Х */
        public string Х
        {
            get => Х_;
            set
            {
                if (!Х_.Equals(value))
                {
                    Х_ = value;
                    Сhanged_Х?.Invoke();
                }
            }
        }
        string Х_ = "";
        public Action? Сhanged_Х { get; set; } = null;

    
        /* Ц */
        public string Ц
        {
            get => Ц_;
            set
            {
                if (!Ц_.Equals(value))
                {
                    Ц_ = value;
                    Сhanged_Ц?.Invoke();
                }
            }
        }
        string Ц_ = "";
        public Action? Сhanged_Ц { get; set; } = null;

    
        /* Ч */
        public string Ч
        {
            get => Ч_;
            set
            {
                if (!Ч_.Equals(value))
                {
                    Ч_ = value;
                    Сhanged_Ч?.Invoke();
                }
            }
        }
        string Ч_ = "";
        public Action? Сhanged_Ч { get; set; } = null;

    
        /* Ш */
        public string Ш
        {
            get => Ш_;
            set
            {
                if (!Ш_.Equals(value))
                {
                    Ш_ = value;
                    Сhanged_Ш?.Invoke();
                }
            }
        }
        string Ш_ = "";
        public Action? Сhanged_Ш { get; set; } = null;

    
        /* Щ */
        public string Щ
        {
            get => Щ_;
            set
            {
                if (!Щ_.Equals(value))
                {
                    Щ_ = value;
                    Сhanged_Щ?.Invoke();
                }
            }
        }
        string Щ_ = "";
        public Action? Сhanged_Щ { get; set; } = null;

    
        /* Ь */
        public string Ь
        {
            get => Ь_;
            set
            {
                if (!Ь_.Equals(value))
                {
                    Ь_ = value;
                    Сhanged_Ь?.Invoke();
                }
            }
        }
        string Ь_ = "";
        public Action? Сhanged_Ь { get; set; } = null;

    
        /* Ю */
        public string Ю
        {
            get => Ю_;
            set
            {
                if (!Ю_.Equals(value))
                {
                    Ю_ = value;
                    Сhanged_Ю?.Invoke();
                }
            }
        }
        string Ю_ = "";
        public Action? Сhanged_Ю { get; set; } = null;

    
        /* Я */
        public string Я
        {
            get => Я_;
            set
            {
                if (!Я_.Equals(value))
                {
                    Я_ = value;
                    Сhanged_Я?.Invoke();
                }
            }
        }
        string Я_ = "";
        public Action? Сhanged_Я { get; set; } = null;

    

        /*
        Функції
        */
        
        public GObject.Object Copy()
        {
            var row = New();
            row.А = А;
            row.Б = Б;
            row.В = В;
            row.Г = Г;
            row.Ґ = Ґ;
            row.Д = Д;
            row.Е = Е;
            row.Є = Є;
            row.Ж = Ж;
            row.З = З;
            row.И = И;
            row.І = І;
            row.Ї = Ї;
            row.Й = Й;
            row.К = К;
            row.Л = Л;
            row.М = М;
            row.Н = Н;
            row.О = О;
            row.П = П;
            row.Р = Р;
            row.С = С;
            row.Т = Т;
            row.У = У;
            row.Ф = Ф;
            row.Х = Х;
            row.Ц = Ц;
            row.Ч = Ч;
            row.Ш = Ш;
            row.Щ = Щ;
            row.Ь = Ь;
            row.Ю = Ю;
            row.Я = Я;
            
            return row;
        }
    }

    #endregion

    
    public ЗбереженіЗвіти_Objest? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка New()
    {
        ЗбереженіЗвіти_ТабличнаЧастина_ЗвітСторінка tablePart = NewWithProperties([]);
        tablePart.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return tablePart;
    }

    protected override void Columns()
    {
        
        //А
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
                
                cell.OnСhanged = () => row.А = cell.Value;
                (row.Сhanged_А = () => cell.Value = row.А).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("А", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Б
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
                
                cell.OnСhanged = () => row.Б = cell.Value;
                (row.Сhanged_Б = () => cell.Value = row.Б).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Б", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //В
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
                
                cell.OnСhanged = () => row.В = cell.Value;
                (row.Сhanged_В = () => cell.Value = row.В).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("В", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Г
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
                
                cell.OnСhanged = () => row.Г = cell.Value;
                (row.Сhanged_Г = () => cell.Value = row.Г).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Г", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ґ
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
                
                cell.OnСhanged = () => row.Ґ = cell.Value;
                (row.Сhanged_Ґ = () => cell.Value = row.Ґ).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ґ", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Д
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
                
                cell.OnСhanged = () => row.Д = cell.Value;
                (row.Сhanged_Д = () => cell.Value = row.Д).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Д", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Е
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
                
                cell.OnСhanged = () => row.Е = cell.Value;
                (row.Сhanged_Е = () => cell.Value = row.Е).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Е", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Є
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
                
                cell.OnСhanged = () => row.Є = cell.Value;
                (row.Сhanged_Є = () => cell.Value = row.Є).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Є", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ж
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
                
                cell.OnСhanged = () => row.Ж = cell.Value;
                (row.Сhanged_Ж = () => cell.Value = row.Ж).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ж", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //З
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
                
                cell.OnСhanged = () => row.З = cell.Value;
                (row.Сhanged_З = () => cell.Value = row.З).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("З", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //И
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
                
                cell.OnСhanged = () => row.И = cell.Value;
                (row.Сhanged_И = () => cell.Value = row.И).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("И", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //І
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
                
                cell.OnСhanged = () => row.І = cell.Value;
                (row.Сhanged_І = () => cell.Value = row.І).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("І", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ї
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
                
                cell.OnСhanged = () => row.Ї = cell.Value;
                (row.Сhanged_Ї = () => cell.Value = row.Ї).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ї", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Й
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
                
                cell.OnСhanged = () => row.Й = cell.Value;
                (row.Сhanged_Й = () => cell.Value = row.Й).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Й", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //К
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
                
                cell.OnСhanged = () => row.К = cell.Value;
                (row.Сhanged_К = () => cell.Value = row.К).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("К", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Л
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
                
                cell.OnСhanged = () => row.Л = cell.Value;
                (row.Сhanged_Л = () => cell.Value = row.Л).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Л", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //М
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
                
                cell.OnСhanged = () => row.М = cell.Value;
                (row.Сhanged_М = () => cell.Value = row.М).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("М", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Н
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
                
                cell.OnСhanged = () => row.Н = cell.Value;
                (row.Сhanged_Н = () => cell.Value = row.Н).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Н", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //О
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
                
                cell.OnСhanged = () => row.О = cell.Value;
                (row.Сhanged_О = () => cell.Value = row.О).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("О", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //П
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
                
                cell.OnСhanged = () => row.П = cell.Value;
                (row.Сhanged_П = () => cell.Value = row.П).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("П", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Р
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
                
                cell.OnСhanged = () => row.Р = cell.Value;
                (row.Сhanged_Р = () => cell.Value = row.Р).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Р", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //С
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
                
                cell.OnСhanged = () => row.С = cell.Value;
                (row.Сhanged_С = () => cell.Value = row.С).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("С", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Т
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
                
                cell.OnСhanged = () => row.Т = cell.Value;
                (row.Сhanged_Т = () => cell.Value = row.Т).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Т", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //У
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
                
                cell.OnСhanged = () => row.У = cell.Value;
                (row.Сhanged_У = () => cell.Value = row.У).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("У", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ф
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
                
                cell.OnСhanged = () => row.Ф = cell.Value;
                (row.Сhanged_Ф = () => cell.Value = row.Ф).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ф", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Х
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
                
                cell.OnСhanged = () => row.Х = cell.Value;
                (row.Сhanged_Х = () => cell.Value = row.Х).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Х", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ц
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
                
                cell.OnСhanged = () => row.Ц = cell.Value;
                (row.Сhanged_Ц = () => cell.Value = row.Ц).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ц", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ч
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
                
                cell.OnСhanged = () => row.Ч = cell.Value;
                (row.Сhanged_Ч = () => cell.Value = row.Ч).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ч", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ш
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
                
                cell.OnСhanged = () => row.Ш = cell.Value;
                (row.Сhanged_Ш = () => cell.Value = row.Ш).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ш", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Щ
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
                
                cell.OnСhanged = () => row.Щ = cell.Value;
                (row.Сhanged_Щ = () => cell.Value = row.Щ).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Щ", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ь
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
                
                cell.OnСhanged = () => row.Ь = cell.Value;
                (row.Сhanged_Ь = () => cell.Value = row.Ь).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ь", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Ю
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
                
                cell.OnСhanged = () => row.Ю = cell.Value;
                (row.Сhanged_Ю = () => cell.Value = row.Ю).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Ю", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Я
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
                
                cell.OnСhanged = () => row.Я = cell.Value;
                (row.Сhanged_Я = () => cell.Value = row.Я).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Я", factory);
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

    public override async Task LoadRecords()
    {
        
        if (ЕлементВласник != null) 
        {
            
            ЕлементВласник.ЗвітСторінка_TablePart.FillJoin([]);
            await ЕлементВласник.ЗвітСторінка_TablePart.Read();
            
            Store.RemoveAll();
        
            foreach (var record in ЕлементВласник.ЗвітСторінка_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.А = record.А;
                row.Б = record.Б;
                row.В = record.В;
                row.Г = record.Г;
                row.Ґ = record.Ґ;
                row.Д = record.Д;
                row.Е = record.Е;
                row.Є = record.Є;
                row.Ж = record.Ж;
                row.З = record.З;
                row.И = record.И;
                row.І = record.І;
                row.Ї = record.Ї;
                row.Й = record.Й;
                row.К = record.К;
                row.Л = record.Л;
                row.М = record.М;
                row.Н = record.Н;
                row.О = record.О;
                row.П = record.П;
                row.Р = record.Р;
                row.С = record.С;
                row.Т = record.Т;
                row.У = record.У;
                row.Ф = record.Ф;
                row.Х = record.Х;
                row.Ц = record.Ц;
                row.Ч = record.Ч;
                row.Ш = record.Ш;
                row.Щ = record.Щ;
                row.Ь = record.Ь;
                row.Ю = record.Ю;
                row.Я = record.Я;
                
                Store.Append(row);

                if (SelectPosition > 0)
                {
                    Grid.Model.SelectItem(SelectPosition, true);
                    ScrollTo(SelectPosition);
                }
            }
        }
    }

    public override async Task SaveRecords()
    {
        
        if (ЕлементВласник != null)
        {
        ЕлементВласник.ЗвітСторінка_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    ЕлементВласник.ЗвітСторінка_TablePart.Records.Add(new()
                    {
                        UID = row.UniqueID.UGuid,
                        А = row.А,
                        Б = row.Б,
                        В = row.В,
                        Г = row.Г,
                        Ґ = row.Ґ,
                        Д = row.Д,
                        Е = row.Е,
                        Є = row.Є,
                        Ж = row.Ж,
                        З = row.З,
                        И = row.И,
                        І = row.І,
                        Ї = row.Ї,
                        Й = row.Й,
                        К = row.К,
                        Л = row.Л,
                        М = row.М,
                        Н = row.Н,
                        О = row.О,
                        П = row.П,
                        Р = row.Р,
                        С = row.С,
                        Т = row.Т,
                        У = row.У,
                        Ф = row.Ф,
                        Х = row.Х,
                        Ц = row.Ц,
                        Ч = row.Ч,
                        Ш = row.Ш,
                        Щ = row.Щ,
                        Ь = row.Ь,
                        Ю = row.Ю,
                        Я = row.Я,
                        
                    });
                }
            }
            await ЕлементВласник.ЗвітСторінка_TablePart.Save(true);
            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.ЗвітСторінка_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.А = x.А;
                    row.Б = x.Б;
                    row.В = x.В;
                    row.Г = x.Г;
                    row.Ґ = x.Ґ;
                    row.Д = x.Д;
                    row.Е = x.Е;
                    row.Є = x.Є;
                    row.Ж = x.Ж;
                    row.З = x.З;
                    row.И = x.И;
                    row.І = x.І;
                    row.Ї = x.Ї;
                    row.Й = x.Й;
                    row.К = x.К;
                    row.Л = x.Л;
                    row.М = x.М;
                    row.Н = x.Н;
                    row.О = x.О;
                    row.П = x.П;
                    row.Р = x.Р;
                    row.С = x.С;
                    row.Т = x.Т;
                    row.У = x.У;
                    row.Ф = x.Ф;
                    row.Х = x.Х;
                    row.Ц = x.Ц;
                    row.Ч = x.Ч;
                    row.Ш = x.Ш;
                    row.Щ = x.Щ;
                    row.Ь = x.Ь;
                    row.Ю = x.Ю;
                    row.Я = x.Я;
                    
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

    public override async Task<bool> NewRecord()
    {
        Store.Append(ItemRow.New());
        return true;
    }
}
    