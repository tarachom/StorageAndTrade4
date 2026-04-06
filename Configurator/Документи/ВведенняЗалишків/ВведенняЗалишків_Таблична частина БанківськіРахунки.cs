
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

partial class ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки : DocumentFormTablePart
{
    #region Data
    
    [GObject.Subclass<GObject.Object>("ItemRow_i07VUMHIoEWVsReWVdQpLA")]
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

    
        /* БанківськийРахунок */
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
            itemRow.БанківськийРахунок = БанківськийРахунок.Copy();
            itemRow.Сума = Сума;
            
            return itemRow;
        }
    }

    #endregion

    
    public ВведенняЗалишків_Objest? ЕлементВласник { get; set; }
        
    
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
        
        //БанківськийРахунок
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = БанківськіРахункиОрганізацій_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not БанківськіРахункиОрганізацій_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = () => row.БанківськийРахунок = cell.Pointer;
                (row.Сhanged_БанківськийРахунок = () => cell.Pointer = row.БанківськийРахунок).Invoke();
                    
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
            
            ЕлементВласник.БанківськіРахунки_TablePart.FillJoin([ВведенняЗалишків_БанківськіРахунки_TablePart.НомерРядка,]);
            await ЕлементВласник.БанківськіРахунки_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (var record in ЕлементВласник.БанківськіРахунки_TablePart.Records)
        {
            var row = ItemRow.New();
            row.UniqueID = new(record.UID);
            row.НомерРядка = record.НомерРядка;
            row.БанківськийРахунок = record.БанківськийРахунок;
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
        ЕлементВласник.БанківськіРахунки_TablePart.Records.Clear();
        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                ЕлементВласник.БанківськіРахунки_TablePart.Records.Add(new()
                {
                    UID = row.UniqueID.UGuid,
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

                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.БанківськийРахунок = record.БанківськийРахунок;
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
    