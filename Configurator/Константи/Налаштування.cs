
/*
        OwnerType = Constant;
        OwnerBlockName = Системні.;

        НалаштуванняКористувача_ТабличнаЧастина_ПеріодиЖурналів.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Константи;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<ConstantFormTablePart>("Systemni_NalashtuvanniaKorystuvacha_TablePart_PeriodyZhurnaliv")]
partial class НалаштуванняКористувача_ТабличнаЧастина_ПеріодиЖурналів : ConstantFormTablePart
{
    #region Модель даних

    [GObject.Subclass<GObject.Object>("Systemni_NalashtuvanniaKorystuvacha_TablePart_PeriodyZhurnaliv_ItemRow")]
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


        /* Користувач */
        public Користувачі_Pointer Користувач
        {
            get => Користувач_;
            set
            {
                if (!Користувач_.Equals(value))
                {
                    Користувач_ = value;
                    Сhanged_Користувач?.Invoke();
                }
            }
        }
        Користувачі_Pointer Користувач_ = new();
        public Action? Сhanged_Користувач { get; set; } = null;


        /* Журнал */
        public string Журнал
        {
            get => Журнал_;
            set
            {
                if (!Журнал_.Equals(value))
                {
                    Журнал_ = value;
                    Сhanged_Журнал?.Invoke();
                }
            }
        }
        string Журнал_ = "";
        public Action? Сhanged_Журнал { get; set; } = null;


        /* ПеріодЗначення */
        public string ПеріодЗначення
        {
            get => ПеріодЗначення_;
            set
            {
                if (!ПеріодЗначення_.Equals(value))
                {
                    ПеріодЗначення_ = value;
                    Сhanged_ПеріодЗначення?.Invoke();
                }
            }
        }
        string ПеріодЗначення_ = "";
        public Action? Сhanged_ПеріодЗначення { get; set; } = null;


        /* ДатаСтарт */
        public DateTime ДатаСтарт
        {
            get => ДатаСтарт_;
            set
            {
                if (!ДатаСтарт_.Equals(value))
                {
                    ДатаСтарт_ = value;
                    Сhanged_ДатаСтарт?.Invoke();
                }
            }
        }
        DateTime ДатаСтарт_ = DateTime.MinValue;
        public Action? Сhanged_ДатаСтарт { get; set; } = null;


        /* ДатаСтоп */
        public DateTime ДатаСтоп
        {
            get => ДатаСтоп_;
            set
            {
                if (!ДатаСтоп_.Equals(value))
                {
                    ДатаСтоп_ = value;
                    Сhanged_ДатаСтоп?.Invoke();
                }
            }
        }
        DateTime ДатаСтоп_ = DateTime.MinValue;
        public Action? Сhanged_ДатаСтоп { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.Користувач = Користувач.Copy();
            row.Журнал = Журнал;
            row.ПеріодЗначення = ПеріодЗначення;
            row.ДатаСтарт = ДатаСтарт;
            row.ДатаСтоп = ДатаСтоп;

            return row;
        }
    }

    #endregion

    #region Функції

    static Task ПісляДодаванняНового(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_Журнал(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_ПеріодЗначення(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_Користувач(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_ДатаСтарт(ItemRow row) => Task.CompletedTask;

    static Task ПісляЗміни_ДатаСтоп(ItemRow row) => Task.CompletedTask;


    #endregion

    Системні.НалаштуванняКористувача_ПеріодиЖурналів_TablePart Таблиця { get; set; } = new();


    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;
    }

    public static НалаштуванняКористувача_ТабличнаЧастина_ПеріодиЖурналів New()
    {
        НалаштуванняКористувача_ТабличнаЧастина_ПеріодиЖурналів tablePart = NewWithProperties([]);
        tablePart.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return tablePart;
    }

    protected override void Columns()
    {

        //Користувач
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Користувачі_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Користувачі_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = async () => //Із комірки в модель
                {
                    row.Користувач = cell.Pointer;
                    await ПісляЗміни_Користувач(row);
                };
                (row.Сhanged_Користувач = () => cell.Pointer = row.Користувач).Invoke(); //Із моделі в комірку 

            };
            ColumnViewColumn column = ColumnViewColumn.New("Користувач", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //Журнал
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
                    row.Журнал = cell.Value;
                    await ПісляЗміни_Журнал(row);
                };
                (row.Сhanged_Журнал = () => cell.Value = row.Журнал).Invoke(); //<- Із моделі в комірку 

            };
            ColumnViewColumn column = ColumnViewColumn.New("Журнал", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //ПеріодЗначення
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
                    row.ПеріодЗначення = cell.Value;
                    await ПісляЗміни_ПеріодЗначення(row);
                };
                (row.Сhanged_ПеріодЗначення = () => cell.Value = row.ПеріодЗначення).Invoke(); //<- Із моделі в комірку 

            };
            ColumnViewColumn column = ColumnViewColumn.New("Період значення", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //ДатаСтарт
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = DateTimeTablePartCell.New();

                cell.OnlyDate = true;

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DateTimeTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.ДатаСтарт = cell.Value;
                    await ПісляЗміни_ДатаСтарт(row);
                };
                (row.Сhanged_ДатаСтарт = () => cell.Value = row.ДатаСтарт).Invoke(); //<- Із моделі в комірку 

            };
            ColumnViewColumn column = ColumnViewColumn.New("Дата старт", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //ДатаСтоп
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = DateTimeTablePartCell.New();

                cell.OnlyDate = true;

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DateTimeTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = async () => //Із комірки в модель ->
                {
                    row.ДатаСтоп = cell.Value;
                    await ПісляЗміни_ДатаСтоп(row);
                };
                (row.Сhanged_ДатаСтоп = () => cell.Value = row.ДатаСтоп).Invoke(); //<- Із моделі в комірку 

            };
            ColumnViewColumn column = ColumnViewColumn.New("Дата стоп", factory);
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
    ItemRow[] ToItemRows(List<Системні.НалаштуванняКористувача_ПеріодиЖурналів_TablePart.Record> records) => [.. records.Select(x =>
    {
        var row = ItemRow.New();
        row.UniqueID = new(x.UID);
        row.Користувач = x.Користувач;
        row.Журнал = x.Журнал;
        row.ПеріодЗначення = x.ПеріодЗначення;
        row.ДатаСтарт = x.ДатаСтарт;
        row.ДатаСтоп = x.ДатаСтоп;

        return row;
    })];

    //З моделі в таб частину
    List<Системні.НалаштуванняКористувача_ПеріодиЖурналів_TablePart.Record> ToRecords()
    {
        List<Системні.НалаштуванняКористувача_ПеріодиЖурналів_TablePart.Record> rows = [];
        for (uint i = 0; i <= Store.GetNItems(); i++)
            if (Store.GetObject(i) is ItemRow row)
                rows.Add(new()
                {
                    UID = row.UniqueID.UGuid,
                    Користувач = row.Користувач,
                    Журнал = row.Журнал,
                    ПеріодЗначення = row.ПеріодЗначення,
                    ДатаСтарт = row.ДатаСтарт,
                    ДатаСтоп = row.ДатаСтоп,

                });
        return rows;
    }

    public override async Task LoadRecords()
    {

        Таблиця.FillJoin();
        await Таблиця.Read();

        UpdateStore(ToItemRows(Таблиця.Records));


    }

    public override async Task SaveRecords()
    {
        Таблиця.Records.Clear();
        Таблиця.Records.AddRange(ToRecords());
        await Таблиця.Save(true);
        UpdateStore(ToItemRows(Таблиця.Records));


    }

    public override async Task<bool> NewRecord()
    {
        ItemRow row = ItemRow.New();
        await ПісляДодаванняНового(row);

        Store.Append(row);
        return true;
    }
}
