/*
        КорегуванняБоргу_ТабличнаЧастина_РозрахункиЗКонтрагентами.cs
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

[GObject.Subclass<DocumentFormTablePart>("KorehuvanniaBorhu_TablePart_RozrakhunkyZKontrahentamy")]
partial class КорегуванняБоргу_ТабличнаЧастина_РозрахункиЗКонтрагентами : DocumentFormTablePart
{
    #region Модель даних
    
    [GObject.Subclass<GObject.Object>("KorehuvanniaBorhu_TablePart_RozrakhunkyZKontrahentamy_ItemRow")]
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
        public Action? Сhanged_ТипКонтрагента { get; set; } = null;

    
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
        public Action? Сhanged_Валюта { get; set; } = null;

    
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
        public Action? Сhanged_Сума { get; set; } = null;

    

        /*
        Функції
        */
        
        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.ТипКонтрагента = ТипКонтрагента;
            row.Контрагент = Контрагент.Copy();
            row.Валюта = Валюта.Copy();
            row.Сума = Сума;
            
            return row;
        }
    }

    #endregion

    #region Функції

    static Task ПісляДодаванняНового(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Сума(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_ТипКонтрагента(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Контрагент(ItemRow row) => Task.CompletedTask;
    
    static Task ПісляЗміни_Валюта(ItemRow row) => Task.CompletedTask;
    

    #endregion

    
    public КорегуванняБоргу_Object? ЕлементВласник { get; set; }
        
    
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static КорегуванняБоргу_ТабличнаЧастина_РозрахункиЗКонтрагентами New()
    {
        КорегуванняБоргу_ТабличнаЧастина_РозрахункиЗКонтрагентами tablePart = NewWithProperties([]);
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
        
        //ТипКонтрагента
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = DropDownTablePartCell.NewWithValues(ПсевдонімиПерелічення.ТипиКонтрагентів_Dict());
                
                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DropDownTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.ТипКонтрагента = ПсевдонімиПерелічення.ТипиКонтрагентів_FindByName(cell.Value);
                    await ПісляЗміни_ТипКонтрагента(row);
                };
                (row.Сhanged_ТипКонтрагента = () => cell.Value = row.ТипКонтрагента.ToString()).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DropDownTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_ТипКонтрагента = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Тип контрагента", factory);
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
                
                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Валюта = cell.Pointer;
                    await ПісляЗміни_Валюта(row);
                };
                (row.Сhanged_Валюта = () => cell.Pointer = row.Валюта).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Валюти_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_Валюта = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
            column.Resizable = true;
            
            column.FixedWidth = 100;
            
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
                
                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Сума = cell.Value;
                    await ПісляЗміни_Сума(row);
                };
                (row.Сhanged_Сума = () => cell.Value = row.Сума).Invoke(); //<- Із моделі в комірку 
                    
            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Сума = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Сума", factory);
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

    //З таб частин в модель
    ItemRow[] ToItemRows(List<КорегуванняБоргу_РозрахункиЗКонтрагентами_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.ТипКонтрагента = x.ТипКонтрагента;
        row.Контрагент = x.Контрагент;
        row.Валюта = x.Валюта;
        row.Сума = x.Сума;
        
        return row;
    })];

    //З моделі в таб частину
    List<КорегуванняБоргу_РозрахункиЗКонтрагентами_TablePart.Record> ToRecords()
    {
        List<КорегуванняБоргу_РозрахункиЗКонтрагентами_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    ТипКонтрагента = row.ТипКонтрагента,
                    Контрагент = row.Контрагент,
                    Валюта = row.Валюта,
                    Сума = row.Сума,
                    
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        
        if (ЕлементВласник != null) 
        {
            
            ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.FillJoin([КорегуванняБоргу_РозрахункиЗКонтрагентами_TablePart.НомерРядка,]);
            await ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Read();
            
            UpdateStore(ToItemRows(ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records));
        
        }
    }

    public override async Task SaveRecords()
    {
        
        if (ЕлементВласник != null)
        {
        ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records.Clear();
            ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records.AddRange(ToRecords());
            await ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Save(true);
            UpdateStore(ToItemRows(ЕлементВласник.РозрахункиЗКонтрагентами_TablePart.Records));

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