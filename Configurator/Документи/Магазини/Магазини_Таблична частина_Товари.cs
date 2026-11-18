
/*
        Магазини_ТабличнаЧастина_Товари.cs
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

[GObject.Subclass<DocumentFormTablePart>("Mahazyny_TablePart_Tovary")]
partial class Магазини_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Модель даних
    
    [GObject.Subclass<GObject.Object>("Mahazyny_TablePart_Tovary_ItemRow")]
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

    
        /* Номенклатура */
        public Номенклатура_Pointer Номенклатура
        {
            get => Номенклатура_;
            set
            {
                if (!Номенклатура_.Equals(value))
                {
                    Номенклатура_ = value;
                    Сhanged_Номенклатура?.Invoke();
                }
            }
        }
        Номенклатура_Pointer Номенклатура_ = new();
        public Action? Сhanged_Номенклатура { get; set; } = null;

    
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
        public Action? Сhanged_Контрагент { get; set; } = null;

    

        /*
        Функції
        */
        
        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Номенклатура = Номенклатура.Copy();
            row.Контрагент = Контрагент.Copy();
            
            return row;
        }
    }

    #endregion

    #region Функції

    static Task ПісляДодаванняНового(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_НомерРядка(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Номенклатура(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Контрагент(ItemRow row) => Task.CompletedTask;
    

    #endregion

    
    public Магазини_Object? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static Магазини_ТабличнаЧастина_Товари New()
    {
        Магазини_ТабличнаЧастина_Товари tablePart = NewWithProperties([]);
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
                var cell = IntegerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not IntegerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.НомерРядка = cell.Value;
                    await ПісляЗміни_НомерРядка(row);
                };
                (row.Сhanged_НомерРядка = () => cell.Value = row.НомерРядка).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not IntegerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_НомерРядка = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Номер рядка", factory);
            column.Resizable = true;
            
            Grid.AppendColumn(column);
        }
        
        //Номенклатура
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Номенклатура_PointerTablePartCell.New();
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Номенклатура_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Номенклатура = cell.Pointer;
                    await ПісляЗміни_Номенклатура(row);
                };
                (row.Сhanged_Номенклатура = () => cell.Pointer = row.Номенклатура).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Номенклатура_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_Номенклатура = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Номенклатура", factory);
            column.Resizable = true;
            
            column.FixedWidth = 500;
            
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
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Контрагент = cell.Pointer;
                    await ПісляЗміни_Контрагент(row);
                };
                (row.Сhanged_Контрагент = () => cell.Pointer = row.Контрагент).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Контрагенти_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_Контрагент = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Контрагент", factory);
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
    ItemRow[] ToItemRows(List<Магазини_Товари_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.Номенклатура = x.Номенклатура;
        row.Контрагент = x.Контрагент;
        
        return row;
    })];

    //З моделі в таб частину
    List<Магазини_Товари_TablePart.Record> ToRecords()
    {
        List<Магазини_Товари_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Номенклатура = row.Номенклатура,
                    Контрагент = row.Контрагент,
                    
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        
        if (ЕлементВласник != null) 
        {
            
            ЕлементВласник.Товари_TablePart.FillJoin([Магазини_Товари_TablePart.НомерРядка,]);
            await ЕлементВласник.Товари_TablePart.Read();
            
            UpdateStore(ToItemRows(ЕлементВласник.Товари_TablePart.Records));
        
        }
    }

    public override async Task SaveRecords()
    {
        
        if (ЕлементВласник != null)
        {
        ЕлементВласник.Товари_TablePart.Records.Clear();
            ЕлементВласник.Товари_TablePart.Records.AddRange(ToRecords());
            await ЕлементВласник.Товари_TablePart.Save(true);
            UpdateStore(ToItemRows(ЕлементВласник.Товари_TablePart.Records));

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
    