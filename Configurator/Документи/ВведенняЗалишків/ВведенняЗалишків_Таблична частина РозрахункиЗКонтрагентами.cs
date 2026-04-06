
/*
        ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

partial class ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами : DocumentFormTablePart
{
    #region Data
    
    [GObject.Subclass<GObject.Object>("ItemRow_Ckf9mFdIkSHBuNr0DsXqg")]
    public partial class ItemRow : IRowSubclassTablePart
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

    
        /* ТипКонтрагента */
        public ТипиКонтрагентів ТипКонтрагента
        {
            get => ТипКонтрагента_;
            set
            {
                if (!ТипКонтрагента_.Equals(value))
                {
                    ТипКонтрагента_ = value;
                    Сhanged_ТипКонтрагента?.Invoke();
                }
            }
        }
        ТипиКонтрагентів ТипКонтрагента_ = 0;
        public Action? Сhanged_ТипКонтрагента;

    
        /* Контрагент */
        public Контрагенти_Pointer Контрагент
        {
            get => Контрагент_;
            set
            {
                if (!Контрагент_.Equals(value))
                {
                    Контрагент_ = value;
                    Сhanged_Контрагент?.Invoke();
                }
            }
        }
        Контрагенти_Pointer Контрагент_ = new();
        public Action? Сhanged_Контрагент;

    
        /* Валюта */
        public Валюти_Pointer Валюта
        {
            get => Валюта_;
            set
            {
                if (!Валюта_.Equals(value))
                {
                    Валюта_ = value;
                    Сhanged_Валюта?.Invoke();
                }
            }
        }
        Валюти_Pointer Валюта_ = new();
        public Action? Сhanged_Валюта;

    
        /* Сума */
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
        
        public GObject.Object Copy()
        {
            var itemRow = New();
            itemRow.НомерРядка = НомерРядка;
            itemRow.ТипКонтрагента = ТипКонтрагента;
            itemRow.Контрагент = Контрагент.Copy();
            itemRow.Валюта = Валюта.Copy();
            itemRow.Сума = Сума;
            
            return itemRow;
        }
    }

    #endregion

    
    public ВведенняЗалишків_Objest? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public ВведенняЗалишків_ТабличнаЧастина_РозрахункиЗКонтрагентами() : base(Program.BasicForm?.NotebookFunc)
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
        
        //ТипКонтрагента
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ComboTextTablePartCell.New();
                foreach (var field in ПсевдонімиПерелічення.ТипиКонтрагентів_List())
                    cell.Combo.Append(field.Value.ToString(), field.Name);
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ComboTextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = () => row.ТипКонтрагента = ПсевдонімиПерелічення.ТипиКонтрагентів_FindByName(cell.Combo.ActiveId);
                (row.Сhanged_ТипКонтрагента = () => cell.Value = row.ТипКонтрагента.ToString()).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("ТипКонтрагента", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Контрагент
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Контрагенти_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Контрагенти_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = () => row.Контрагент = cell.Pointer;
                (row.Сhanged_Контрагент = () => cell.Pointer = row.Контрагент).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Контрагент", factory);
            column.Resizable = true;
            
            column.FixedWidth = 300;
            
            Grid.AppendColumn(column);
        }
        
        //Валюта
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Валюти_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Валюти_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = () => row.Валюта = cell.Pointer;
                (row.Сhanged_Валюта = () => cell.Pointer = row.Валюта).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
            column.Resizable = true;
            
            column.FixedWidth = 200;
            
            Grid.AppendColumn(column);
        }
        
        //Сума
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
                
                cell.OnСhanged = () => row.Сума = cell.Value;
                (row.Сhanged_Сума = () => cell.Value = row.Сума).Invoke();
                    
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
            
            ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.FillJoin([ВведенняЗалишків_РозрахункиЗКонтрагентами_TablePart.НомерРядка,]);
            await ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (var record in ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records)
        {
            var row = ItemRow.New();
            row.UniqueID = new(record.UID);
            row.НомерРядка = record.НомерРядка;
            row.ТипКонтрагента = record.ТипКонтрагента;
            row.Контрагент = record.Контрагент;
            row.Валюта = record.Валюта;
            row.Сума = record.Сума;
            
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
        ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records.Clear();
        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    ТипКонтрагента = row.ТипКонтрагента,
                    Контрагент = row.Контрагент,
                    Валюта = row.Валюта,
                    Сума = row.Сума,
                    
                });
            }
        }
        await ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Save(true);
        //Update
        {
            uint position = 0;
            foreach (var record in ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records)
            {
                bool sel = Grid.Model.IsSelected(position);

                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.ТипКонтрагента = record.ТипКонтрагента;
                row.Контрагент = record.Контрагент;
                row.Валюта = record.Валюта;
                row.Сума = record.Сума;
                
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
    