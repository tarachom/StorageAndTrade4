/*
        АвансовийЗвіт_ТабличнаЧастина_ВиданіАванси.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("AvansovyiZvit_TablePart_VydaniAvansy")]
partial class АвансовийЗвіт_ТабличнаЧастина_ВиданіАванси : DocumentFormTablePart
{
    #region Модель даних

    [GObject.Subclass<GObject.Object>("AvansovyiZvit_TablePart_VydaniAvansy_ItemRow")]
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


        /* ДокументАвансу */
        public UuidAndText ДокументАвансу
        {
            get => ДокументАвансу_;
            set
            {
                if (!ДокументАвансу_.Equals(value))
                {
                    ДокументАвансу_ = value;
                    Сhanged_ДокументАвансу?.Invoke();
                }
            }
        }
        UuidAndText ДокументАвансу_ = new();
        public Action? Сhanged_ДокументАвансу { get; set; } = null;


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
            row.ДокументАвансу = ДокументАвансу.Copy();
            row.Сума = Сума;

            return row;
        }
    }

    #endregion

    #region Функції

    Task ПісляДодаванняНового(ItemRow row)
    {
        return Task.CompletedTask;
    }

    Task ПісляЗміни_ДокументАвансу(ItemRow row)
    {
        return Task.CompletedTask;
    }

    void ПісляЗміни_Сума(ItemRow row)
    {
        Підсумок.Recount();
    }

    public decimal СумаДокументу()
    {
        decimal Сума = 0;

        for (uint i = 0; i <= Store.GetNItems(); i++)
        {
            ItemRow? row = (ItemRow?)Store.GetObject(i);
            if (row != null)
                Сума += row.Сума;
        }

        return Math.Round(Сума, 2);
    }

    #endregion

    public АвансовийЗвіт_Object? ЕлементВласник { get; set; }
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

    public static АвансовийЗвіт_ТабличнаЧастина_ВиданіАванси New()
    {
        АвансовийЗвіт_ТабличнаЧастина_ВиданіАванси tablePart = NewWithProperties([]);
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

        //ДокументАвансу
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = CompositePointerControlTablePartCell.New();

                cell.BoundConfType = "Документи.АвансовийЗвіт.ВиданіАванси.ДокументАвансу";

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not CompositePointerControlTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = async () =>
                {
                    row.ДокументАвансу = cell.Pointer;
                    await ПісляЗміни_ДокументАвансу(row);
                };

                (row.Сhanged_ДокументАвансу = () => cell.Pointer = row.ДокументАвансу).Invoke();

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not CompositePointerControlTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = null;

                row.Сhanged_ДокументАвансу = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Документ авансу", factory);
            column.Resizable = true;
            column.FixedWidth = 500;

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
    ItemRow[] ToItemRows(List<АвансовийЗвіт_ВиданіАванси_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.ДокументАвансу = x.ДокументАвансу;
        row.Сума = x.Сума;
        
        return row;
    })];

    //З моделі в таб частину
    List<АвансовийЗвіт_ВиданіАванси_TablePart.Record> ToRecords()
    {
        List<АвансовийЗвіт_ВиданіАванси_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    ДокументАвансу = row.ДокументАвансу,
                    Сума = row.Сума,
                    
                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        
        if (ЕлементВласник != null) 
        {
            
            ЕлементВласник.ВиданіАванси_TablePart.FillJoin([АвансовийЗвіт_ВиданіАванси_TablePart.НомерРядка,]);
            await ЕлементВласник.ВиданіАванси_TablePart.Read();
            
            UpdateStore(ToItemRows(ЕлементВласник.ВиданіАванси_TablePart.Records));
        
        }
    }

    public override async Task SaveRecords()
    {
        
        if (ЕлементВласник != null)
        {
        ЕлементВласник.ВиданіАванси_TablePart.Records.Clear();
            ЕлементВласник.ВиданіАванси_TablePart.Records.AddRange(ToRecords());
            await ЕлементВласник.ВиданіАванси_TablePart.Save(true);
            UpdateStore(ToItemRows(ЕлементВласник.ВиданіАванси_TablePart.Records));

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