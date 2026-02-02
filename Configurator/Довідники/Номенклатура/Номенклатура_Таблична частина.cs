
/*
        Номенклатура_ТабличнаЧастина_Файли.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

class Номенклатура_ТабличнаЧастина_Файли : DirectoryFormTablePart
{
    
    public Номенклатура_Objest? ЕлементВласник { get; set; }
        
    
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
        // Основний
        //
        public bool Основний
        {
            get => Основний_;
            set
            {
                if (!Основний_.Equals(value))
                {
                    Основний_ = value;
                    Сhanged_Основний?.Invoke();
                }
            }
        }
        bool Основний_ = false;
        public Action? Сhanged_Основний;

    
        //
        // Файл
        //
        public Файли_Pointer Файл
        {
            get => Файл_;
            set
            {
                if (!Файл_.Equals(value))
                {
                    Файл_ = value;
                    Сhanged_Файл?.Invoke();
                }
            }
        }
        Файли_Pointer Файл_ = new();
        public Action? Сhanged_Файл;

    

        /*
        Функції
        */
        
        public override ItemRow Copy()
        {
            return new()
            {
                НомерРядка = НомерРядка,
                Основний = Основний,
                Файл = Файл.Copy(),
                
            };
        }
    }

    #endregion

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public Номенклатура_ТабличнаЧастина_Файли() : base(Program.BasicForm?.NotebookFunc)
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
        
        //Основний
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new CheckTablePartCell
                {
                    Halign = Align.Center
                };

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (CheckTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnСhanged = () => row.Основний = cell.Check.Active;
                    (row.Сhanged_Основний = () => cell.Value = row.Основний).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Основний", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Файл
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = new Файли_PointerTablePartCell();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                ListItem listItem = (ListItem)args.Object;
                var cell = (Файли_PointerTablePartCell?)listItem.Child;
                ItemRow? row = (ItemRow?)listItem.Item;
                if (cell != null && row != null)
                {
                    
                    cell.OnSelect = () => row.Файл = cell.Pointer;
                    (row.Сhanged_Файл = () => cell.Pointer = row.Файл).Invoke();
                        
                }
            };
            ColumnViewColumn column = ColumnViewColumn.New("Файл", factory);
            column.Resizable = true;
            
            column.FixedWidth = 500;
            
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
            
            ЕлементВласник.Файли_TablePart.FillJoin([Номенклатура_Файли_TablePart.НомерРядка,]);
            await ЕлементВласник.Файли_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (var record in ЕлементВласник.Файли_TablePart.Records)
        {
            Store.Append(new ItemRow()
            {
                UnigueID = new(record.UID),
                НомерРядка = record.НомерРядка,
                Основний = record.Основний,
                Файл = record.Файл,
                
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
        ЕлементВласник.Файли_TablePart.Records.Clear();
        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                ЕлементВласник.Файли_TablePart.Records.Add(new()
                {
                    UID = row.UnigueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Основний = row.Основний,
                    Файл = row.Файл,
                    
                });
            }
        }
        await ЕлементВласник.Файли_TablePart.Save(true);
        //Update
        {
            uint position = 0;
            foreach (var record in ЕлементВласник.Файли_TablePart.Records)
            {
                bool sel = Grid.Model.IsSelected(position);
                Store.Splice(position, 1, [new ItemRow()
                {
                    UnigueID = new(record.UID),
                    НомерРядка = record.НомерРядка,
                    Основний = record.Основний,
                    Файл = record.Файл,
                    
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
    