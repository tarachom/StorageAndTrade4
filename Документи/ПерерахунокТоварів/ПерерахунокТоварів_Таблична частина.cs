/*
        ПерерахунокТоварів_ТабличнаЧастина_Товари.cs
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

[GObject.Subclass<DocumentFormTablePart>("PererakhunokTovariv_TablePart_Tovary")]
partial class ПерерахунокТоварів_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Модель даних

    [GObject.Subclass<GObject.Object>("PererakhunokTovariv_TablePart_Tovary_ItemRow")]
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


        /* ХарактеристикаНоменклатури */
        public ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури
        {
            get => ХарактеристикаНоменклатури_;
            set
            {
                if (!ХарактеристикаНоменклатури_.Equals(value))
                {
                    ХарактеристикаНоменклатури_ = value;
                    Сhanged_ХарактеристикаНоменклатури?.Invoke();
                }
            }
        }
        ХарактеристикиНоменклатури_Pointer ХарактеристикаНоменклатури_ = new();
        public Action? Сhanged_ХарактеристикаНоменклатури { get; set; } = null;


        /* Коєфіціент */
        public decimal Коєфіціент
        {
            get => Коєфіціент_;
            set
            {
                if (!Коєфіціент_.Equals(value))
                {
                    Коєфіціент_ = value;
                    Сhanged_Коєфіціент?.Invoke();
                }
            }
        }
        decimal Коєфіціент_ = 0;
        public Action? Сhanged_Коєфіціент { get; set; } = null;


        /* КоєфіціентФакт */
        public decimal КоєфіціентФакт
        {
            get => КоєфіціентФакт_;
            set
            {
                if (!КоєфіціентФакт_.Equals(value))
                {
                    КоєфіціентФакт_ = value;
                    Сhanged_КоєфіціентФакт?.Invoke();
                }
            }
        }
        decimal КоєфіціентФакт_ = 0;
        public Action? Сhanged_КоєфіціентФакт { get; set; } = null;


        /* Пакування */
        public ПакуванняОдиниціВиміру_Pointer Пакування
        {
            get => Пакування_;
            set
            {
                if (!Пакування_.Equals(value))
                {
                    Пакування_ = value;
                    Сhanged_Пакування?.Invoke();
                }
            }
        }
        ПакуванняОдиниціВиміру_Pointer Пакування_ = new();
        public Action? Сhanged_Пакування { get; set; } = null;


        /* Кількість */
        public decimal Кількість
        {
            get => Кількість_;
            set
            {
                if (!Кількість_.Equals(value))
                {
                    Кількість_ = value;
                    Сhanged_Кількість?.Invoke();
                }
            }
        }
        decimal Кількість_ = 0;
        public Action? Сhanged_Кількість { get; set; } = null;


        /* КількістьФакт */
        public decimal КількістьФакт
        {
            get => КількістьФакт_;
            set
            {
                if (!КількістьФакт_.Equals(value))
                {
                    КількістьФакт_ = value;
                    Сhanged_КількістьФакт?.Invoke();
                }
            }
        }
        decimal КількістьФакт_ = 0;
        public Action? Сhanged_КількістьФакт { get; set; } = null;


        /* Коментар */
        public string Коментар
        {
            get => Коментар_;
            set
            {
                if (!Коментар_.Equals(value))
                {
                    Коментар_ = value;
                    Сhanged_Коментар?.Invoke();
                }
            }
        }
        string Коментар_ = "";
        public Action? Сhanged_Коментар { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Номенклатура = Номенклатура.Copy();
            row.ХарактеристикаНоменклатури = ХарактеристикаНоменклатури.Copy();
            row.Коєфіціент = Коєфіціент;
            row.КоєфіціентФакт = КоєфіціентФакт;
            row.Пакування = Пакування.Copy();
            row.Кількість = Кількість;
            row.КількістьФакт = КількістьФакт;
            row.Коментар = Коментар;

            return row;
        }
    }

    #endregion

    #region Функції

    static Task ПісляДодаванняНового(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_Коєфіціент(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_КоєфіціентФакт(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_Кількість(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_КількістьФакт(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_Коментар(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_Номенклатура(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_ХарактеристикаНоменклатури(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_Пакування(ItemRow row) => Task.CompletedTask;

    #endregion

    public ПерерахунокТоварів_Object? ЕлементВласник { get; set; }

    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static ПерерахунокТоварів_ТабличнаЧастина_Товари New()
    {
        ПерерахунокТоварів_ТабличнаЧастина_Товари tablePart = NewWithProperties([]);
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

            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //ХарактеристикаНоменклатури
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ХарактеристикиНоменклатури_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ХарактеристикиНоменклатури_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.BeforeClickOpenFunc = () => cell.Власник = row.Номенклатура;

                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.ХарактеристикаНоменклатури = cell.Pointer;
                    await ПісляЗміни_ХарактеристикаНоменклатури(row);
                };
                (row.Сhanged_ХарактеристикаНоменклатури = () => cell.Pointer = row.ХарактеристикаНоменклатури).Invoke(); //<- Із моделі в комірку 

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ХарактеристикиНоменклатури_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.BeforeClickOpenFunc = null;
                            
                cell.OnSelect = null;   
                        
                row.Сhanged_ХарактеристикаНоменклатури = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Характеристика", factory);
            column.Resizable = true;

            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Коєфіціент
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
                    row.Коєфіціент = cell.Value;
                    await ПісляЗміни_Коєфіціент(row);
                };
                (row.Сhanged_Коєфіціент = () => cell.Value = row.Коєфіціент).Invoke(); //<- Із моделі в комірку 

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Коєфіціент = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Пак", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КоєфіціентФакт
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
                    row.КоєфіціентФакт = cell.Value;
                    await ПісляЗміни_КоєфіціентФакт(row);
                };
                (row.Сhanged_КоєфіціентФакт = () => cell.Value = row.КоєфіціентФакт).Invoke(); //<- Із моделі в комірку 

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_КоєфіціентФакт = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Пак факт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //Пакування
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ПакуванняОдиниціВиміру_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ПакуванняОдиниціВиміру_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.BeforeClickOpenFunc = () => cell.Власник = row.Номенклатура;

                cell.OnSelect = async () => //Із комірки в модель ->
                {
                    row.Пакування = cell.Pointer;
                    await ПісляЗміни_Пакування(row);
                };
                (row.Сhanged_Пакування = () => cell.Pointer = row.Пакування).Invoke(); //<- Із моделі в комірку 

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ПакуванняОдиниціВиміру_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.BeforeClickOpenFunc = null;
                            
                cell.OnSelect = null;   
                        
                row.Сhanged_Пакування = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Пакування", factory);
            column.Resizable = true;

            column.FixedWidth = 200;

            Grid.AppendColumn(column);
        }

        //Кількість
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
                    row.Кількість = cell.Value;
                    await ПісляЗміни_Кількість(row);
                };
                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke(); //<- Із моделі в комірку 

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Кількість = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //КількістьФакт
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
                    row.КількістьФакт = cell.Value;
                    await ПісляЗміни_КількістьФакт(row);
                };
                (row.Сhanged_КількістьФакт = () => cell.Value = row.КількістьФакт).Invoke(); //<- Із моделі в комірку 

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not NumericTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_КількістьФакт = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість факт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //Коментар
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

                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.Коментар = cell.Value;
                    await ПісляЗміни_Коментар(row);
                };
                (row.Сhanged_Коментар = () => cell.Value = row.Коментар).Invoke(); //<- Із моделі в комірку 

            };
            factory.OnUnbind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not TextTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;
                
                cell.OnСhanged = null;
                        
                row.Сhanged_Коментар = null;
            };
            ColumnViewColumn column = ColumnViewColumn.New("Коментар", factory);
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

    //З таб частин в модель
    ItemRow[] ToItemRows(List<ПерерахунокТоварів_Товари_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.НомерРядка = x.НомерРядка;
        row.Номенклатура = x.Номенклатура;
        row.ХарактеристикаНоменклатури = x.ХарактеристикаНоменклатури;
        row.Коєфіціент = x.Коєфіціент;
        row.КоєфіціентФакт = x.КоєфіціентФакт;
        row.Пакування = x.Пакування;
        row.Кількість = x.Кількість;
        row.КількістьФакт = x.КількістьФакт;
        row.Коментар = x.Коментар;

        return row;
    })];

    //З моделі в таб частину
    List<ПерерахунокТоварів_Товари_TablePart.Record> ToRecords()
    {
        List<ПерерахунокТоварів_Товари_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    НомерРядка = row.НомерРядка,
                    Номенклатура = row.Номенклатура,
                    ХарактеристикаНоменклатури = row.ХарактеристикаНоменклатури,
                    Коєфіціент = row.Коєфіціент,
                    КоєфіціентФакт = row.КоєфіціентФакт,
                    Пакування = row.Пакування,
                    Кількість = row.Кількість,
                    КількістьФакт = row.КількістьФакт,
                    Коментар = row.Коментар,

                });
        return rows;
    }

    public override async Task LoadRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.FillJoin([ПерерахунокТоварів_Товари_TablePart.НомерРядка,]);
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