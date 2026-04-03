
/*
        Контрагенти_ТабличнаЧастина_Файли.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

partial class Контрагенти_ТабличнаЧастина_Файли : DirectoryFormTablePart
{
    #region Data
    
    [GObject.Subclass<GObject.Object>("ItemRow_VwctdICoUOHVi4LsHwMDg")]
    public partial class ItemRow : IRowTablePart
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

    
        /* Файл */
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
        
        public GObject.Object Copy()
        {
            var itemRow = New();
            itemRow.НомерРядка = НомерРядка;
            itemRow.Файл = Файл.Copy();
            
            return itemRow;
        }
    }

    #endregion

    
    public Контрагенти_Objest? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    public Контрагенти_ТабличнаЧастина_Файли() : base(Program.BasicForm?.NotebookFunc)
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
        
        //Файл
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Файли_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Файли_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = () => row.Файл = cell.Pointer;
                (row.Сhanged_Файл = () => cell.Pointer = row.Файл).Invoke();
                    
            };
            ColumnViewColumn column = ColumnViewColumn.New("Файл", factory);
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
            
            ЕлементВласник.Файли_TablePart.FillJoin([Контрагенти_Файли_TablePart.НомерРядка,]);
            await ЕлементВласник.Файли_TablePart.Read();
            

        Store.RemoveAll();

        
        foreach (var record in ЕлементВласник.Файли_TablePart.Records)
        {
            var row = ItemRow.New();
            row.UniqueID = new(record.UID);
            row.НомерРядка = record.НомерРядка;
            row.Файл = record.Файл;
            
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
        ЕлементВласник.Файли_TablePart.Records.Clear();
        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
            {
                ЕлементВласник.Файли_TablePart.Records.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
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

                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Файл = record.Файл;
                
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
    