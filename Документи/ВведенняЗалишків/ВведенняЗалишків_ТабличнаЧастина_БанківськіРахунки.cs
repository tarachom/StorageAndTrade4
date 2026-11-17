/*
        ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("VvedenniaZalyshkiv_TablePart_BankivskiRakhunky")]
partial class ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки : DocumentFormTablePart
{
    #region Модель даних

    [GObject.Subclass<GObject.Object>("VvedenniaZalyshkiv_TablePart_BankivskiRakhunky_ItemRow")]
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
        public Action? Сhanged_БанківськийРахунок { get; set; } = null;


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
            row.БанківськийРахунок = БанківськийРахунок.Copy();
            row.Сума = Сума;

            return row;
        }
    }

    #endregion

    #region Функції

    Task ПісляЗміни_БанківськийРахунок(ItemRow row)
    {
        return Task.CompletedTask;
    }

    void ПісляЗміни_Сума(ItemRow row)
    {
        Підсумок.Recount();
    }

    #endregion

    public ВведенняЗалишків_Object? ЕлементВласник { get; set; }
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());
    TotalControl Підсумок = TotalControl.New();

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;

        //
        // Підсумки
        //

        model.OnItemsChanged += (_, _) => Підсумок.Recount();
        Підсумок.QuantifyFunc = () =>
        {
            decimal Сума = 0;

            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                    Сума += row.Сума;
            }

            return new("Сума: <b>{0}</b>", Сума);
        };

        Append(Підсумок);
    }

    public static ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки New()
    {
        ВведенняЗалишків_ТабличнаЧастина_БанківськіРахунки tablePart = NewWithProperties([]);
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

                cell.OnSelect = async () =>
                {
                    row.БанківськийРахунок = cell.Pointer;
                    await ПісляЗміни_БанківськийРахунок(row);
                };

                (row.Сhanged_БанківськийРахунок = () => cell.Pointer = row.БанківськийРахунок).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not БанківськіРахункиОрганізацій_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnSelect = null;   
                        
                row.Сhanged_БанківськийРахунок = null;
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

                cell.OnСhanged = () =>
                {
                    row.Сума = cell.Value;
                    ПісляЗміни_Сума(row);
                };

                (row.Сhanged_Сума = () => cell.Value = row.Сума).Invoke();

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
            column.FixedWidth = 150;

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
    ItemRow[] ToItemRows(List<ВведенняЗалишків_БанківськіРахунки_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.БанківськийРахунок = x.БанківськийРахунок;
        row.Сума = x.Сума;
        
        return row;
    })];

    //З моделі в таб частину
    List<ВведенняЗалишків_БанківськіРахунки_TablePart.Record> ToRecords()
    {
        List<ВведенняЗалишків_БанківськіРахунки_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    БанківськийРахунок = row.БанківськийРахунок,
                    Сума = row.Сума,
                    
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        if (ЕлементВласник != null) 
        {
            ЕлементВласник.БанківськіРахунки_TablePart.FillJoin([ВведенняЗалишків_БанківськіРахунки_TablePart.НомерРядка,]);
            await ЕлементВласник.БанківськіРахунки_TablePart.Read();
            
            UpdateStore(ToItemRows(ЕлементВласник.БанківськіРахунки_TablePart.Records));
        }
    }

    public override async Task SaveRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.БанківськіРахунки_TablePart.Records.Clear();
            ЕлементВласник.БанківськіРахунки_TablePart.Records.AddRange(ToRecords());
            await ЕлементВласник.БанківськіРахунки_TablePart.Save(true);
            UpdateStore(ToItemRows(ЕлементВласник.БанківськіРахунки_TablePart.Records));
        }
    }

    public override async Task<bool> NewRecord()
    {
        Store.Append(ItemRow.New());
        return true;
    }
}