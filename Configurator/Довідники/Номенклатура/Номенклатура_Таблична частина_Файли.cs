
/*
        Номенклатура_ТабличнаЧастина_Файли.cs
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

[GObject.Subclass<DirectoryFormTablePart>("Nomenklatura_TablePart_Faily")]
partial class Номенклатура_ТабличнаЧастина_Файли : DirectoryFormTablePart
{
    #region Модель даних
    
    [GObject.Subclass<GObject.Object>("Nomenklatura_TablePart_Faily_ItemRow")]
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

    
        /* Основний */
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
        public Action? Сhanged_Основний { get; set; } = null;

    
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
        public Action? Сhanged_Файл { get; set; } = null;

    

        /*
        Функції
        */
        
        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Основний = Основний;
            row.Файл = Файл.Copy();
            
            return row;
        }
    }

    #endregion

    #region Функції

    static Task ПісляДодаванняНового(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Основний(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Файл(ItemRow row) => Task.CompletedTask;
    

    #endregion

    
    public Номенклатура_Object? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static Номенклатура_ТабличнаЧастина_Файли New()
    {
        Номенклатура_ТабличнаЧастина_Файли tablePart = NewWithProperties([]);
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
        
        //Основний
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = CheckTablePartCell.New();
                
                cell.Halign = Align.Center;
                    
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not CheckTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Основний = cell.Value;
                    await ПісляЗміни_Основний(row);
                };
                (row.Сhanged_Основний = () => cell.Value = row.Основний).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not CheckTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Основний = null;
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
                if (args.Object is not ListItem listItem) return;
                var cell = Файли_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Файли_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Файл = cell.Pointer;
                    await ПісляЗміни_Файл(row);
                };
                (row.Сhanged_Файл = () => cell.Pointer = row.Файл).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Файли_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_Файл = null;
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

    //З таб частин в модель
    ItemRow[] ToItemRows(List<Номенклатура_Файли_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.Основний = x.Основний;
        row.Файл = x.Файл;
        
        return row;
    })];

    //З моделі в таб частину
    List<Номенклатура_Файли_TablePart.Record> ToRecords()
    {
        List<Номенклатура_Файли_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Основний = row.Основний,
                    Файл = row.Файл,
                    
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        
        if (ЕлементВласник != null) 
        {
            
            ЕлементВласник.Файли_TablePart.FillJoin([Номенклатура_Файли_TablePart.НомерРядка,]);
            await ЕлементВласник.Файли_TablePart.Read();
            
            UpdateStore(ToItemRows(ЕлементВласник.Файли_TablePart.Records));
        
        }
    }

    public override async Task SaveRecords()
    {
        
        if (ЕлементВласник != null)
        {
        ЕлементВласник.Файли_TablePart.Records.Clear();
            ЕлементВласник.Файли_TablePart.Records.AddRange(ToRecords());
            await ЕлементВласник.Файли_TablePart.Save(true);
            UpdateStore(ToItemRows(ЕлементВласник.Файли_TablePart.Records));

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
    