
/*
        ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;
using GeneratedCode.РегістриВідомостей;
using GeneratedCode;
using System.Text;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_EVlq3pwALUCJdjyQhjCLsQ")]
partial class ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_EVlq3pwALUCJdjyQhjCLsQ")]
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


        /* ВидЦіни */
        public ВидиЦін_Pointer ВидЦіни
        {
            get => ВидЦіни_;
            set
            {
                if (!ВидЦіни_.Equals(value))
                {
                    ВидЦіни_ = value;
                    Сhanged_ВидЦіни?.Invoke();
                }
            }
        }
        ВидиЦін_Pointer ВидЦіни_ = new();
        public Action? Сhanged_ВидЦіни { get; set; } = null;


        /* Ціна */
        public decimal Ціна
        {
            get => Ціна_;
            set
            {
                if (!Ціна_.Equals(value))
                {
                    Ціна_ = value;
                    Сhanged_Ціна?.Invoke();
                }
            }
        }
        decimal Ціна_ = 0;
        public Action? Сhanged_Ціна { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.Номенклатура = Номенклатура.Copy();
            row.ХарактеристикаНоменклатури = ХарактеристикаНоменклатури.Copy();
            row.Пакування = Пакування.Copy();
            row.ВидЦіни = ВидЦіни.Copy();
            row.Ціна = Ціна;

            return row;
        }
    }

    #endregion

    #region Функції

    Task ПісляДодаванняНового(ItemRow row)
    {
        return Task.CompletedTask;
    }

    async Task ПісляЗміни_Номенклатура(ItemRow row)
    {
        Номенклатура_Objest? обєкт = await row.Номенклатура.GetDirectoryObject();
        if (обєкт != null && !обєкт.ОдиницяВиміру.IsEmpty())
        {
            await обєкт.ОдиницяВиміру.GetPresentation();
            row.Пакування = обєкт.ОдиницяВиміру;

            await ПісляЗміни_Пакування(row);
        }
    }

    Task ПісляЗміни_ХарактеристикаНоменклатури(ItemRow row)
    {
        return Task.CompletedTask;
    }

    Task ПісляЗміни_Пакування(ItemRow row)
    {
        return Task.CompletedTask;
    }

    async Task ЗаповнитиЗДовідника()
    {
        if (ЕлементВласник != null && ЕлементВласникФорма != null)
        {
            string query = $@"
SELECT
    Номенклатура.uid AS Номенклатура,
    Номенклатура.{Номенклатура_Const.Назва} AS Номенклатура_Назва,
    Номенклатура.{Номенклатура_Const.ОдиницяВиміру} AS Пакування,
    Довідник_ПакуванняОдиниціВиміру.{ПакуванняОдиниціВиміру_Const.Назва} AS Пакування_Назва,
    (
        SELECT
            {ЦіниНоменклатури_Const.Ціна}
        FROM
            {ЦіниНоменклатури_Const.TABLE} AS ЦіниНоменклатури
        WHERE
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.Номенклатура} = Номенклатура.uid AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.ХарактеристикаНоменклатури} = '{Guid.Empty}' AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.Пакування} = Номенклатура.{Номенклатура_Const.ОдиницяВиміру} AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.ВидЦіни} = @ВидЦін AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.Валюта} = @Валюта
        ORDER BY ЦіниНоменклатури.period DESC
        LIMIT 1
    ) AS Ціна
FROM
    {Номенклатура_Const.TABLE} AS Номенклатура
    LEFT JOIN {ПакуванняОдиниціВиміру_Const.TABLE} AS Довідник_ПакуванняОдиниціВиміру ON 
        Довідник_ПакуванняОдиниціВиміру.uid = Номенклатура.{Номенклатура_Const.ОдиницяВиміру}
WHERE
    Номенклатура.{Номенклатура_Const.ТипНоменклатури} = {(int)ТипиНоменклатури.Товар} OR
    Номенклатура.{Номенклатура_Const.ТипНоменклатури} = {(int)ТипиНоменклатури.Послуга}
ORDER BY 
    Номенклатура_Назва, 
    Пакування_Назва
";

            Store.RemoveAll();

            Dictionary<string, object> paramQuery = new()
            {
                { "Валюта", ЕлементВласникФорма.Валюта_Значення.UniqueID.UGuid },
                { "ВидЦін", ЕлементВласникФорма.ВидЦіни_Значення.UniqueID.UGuid }
            };

            var recordResult = await Config.Kernel.DataBase.SelectRequest(query, paramQuery);
            foreach (Dictionary<string, object> itemListRow in recordResult.ListRow)
            {
                var row = ItemRow.New();
                row.НомерРядка = (int)Store.GetNItems() + 1;
                row.Номенклатура = new Номенклатура_Pointer(itemListRow["Номенклатура"], itemListRow["Номенклатура_Назва"]);
                row.Пакування = new ПакуванняОдиниціВиміру_Pointer(itemListRow["Пакування"], itemListRow["Пакування_Назва"]);
                row.ВидЦіни = ЕлементВласникФорма.ВидЦіни_Значення.Copy();
                row.Ціна = itemListRow["Ціна"] != DBNull.Value ? (decimal)itemListRow["Ціна"] : 0;

                Store.Append(row);
            }
        }
    }

    async Task ЗаповнитиЗРегістру()
    {
        if (ЕлементВласник != null && ЕлементВласникФорма != null)
        {
            string query = $@"
WITH register AS
(
    SELECT DISTINCT {ЦіниНоменклатури_Const.Номенклатура} AS Номенклатура,
        {ЦіниНоменклатури_Const.ХарактеристикаНоменклатури} AS ХарактеристикаНоменклатури,
        {ЦіниНоменклатури_Const.Пакування} AS Пакування,
        {ЦіниНоменклатури_Const.ВидЦіни} AS ВидЦіни
    FROM
        {ЦіниНоменклатури_Const.TABLE}
    WHERE
        {ЦіниНоменклатури_Const.Валюта} = @Валюта";

            #region WHERE

            if (!ЕлементВласникФорма.ВидЦіни_Значення.IsEmpty())
            {
                query += $@"
AND {ЦіниНоменклатури_Const.ВидЦіни} = @ВидЦін
";
            }

            #endregion

            query += $@"
)
SELECT
    register.Номенклатура,
    Довідник_Номенклатура.{Номенклатура_Const.Назва} AS Номенклатура_Назва,
    register.ХарактеристикаНоменклатури,
    Довідник_ХарактеристикиНоменклатури.{ХарактеристикиНоменклатури_Const.Назва} AS ХарактеристикаНоменклатури_Назва,
    register.Пакування,
    Довідник_ПакуванняОдиниціВиміру.{ПакуванняОдиниціВиміру_Const.Назва} AS Пакування_Назва,
    register.ВидЦіни,
    Довідник_ВидиЦін.{ВидиЦін_Const.Назва} AS ВидЦіни_Назва,
    (
        SELECT 
            {ЦіниНоменклатури_Const.Ціна}
        FROM 
            {ЦіниНоменклатури_Const.TABLE} AS ЦіниНоменклатури
        WHERE
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.Номенклатура} = register.Номенклатура AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.ХарактеристикаНоменклатури} = register.ХарактеристикаНоменклатури AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.Пакування} = register.Пакування AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.ВидЦіни} = register.ВидЦіни AND
            ЦіниНоменклатури.{ЦіниНоменклатури_Const.Валюта} = @Валюта
        ORDER BY ЦіниНоменклатури.period DESC
        LIMIT 1
    ) AS Ціна
FROM
    register

    LEFT JOIN {Номенклатура_Const.TABLE} AS Довідник_Номенклатура ON 
        Довідник_Номенклатура.uid = register.Номенклатура
    LEFT JOIN {ХарактеристикиНоменклатури_Const.TABLE} AS Довідник_ХарактеристикиНоменклатури ON 
        Довідник_ХарактеристикиНоменклатури.uid = register.ХарактеристикаНоменклатури
    LEFT JOIN {ПакуванняОдиниціВиміру_Const.TABLE} AS Довідник_ПакуванняОдиниціВиміру ON 
        Довідник_ПакуванняОдиниціВиміру.uid = register.Пакування
    LEFT JOIN {ВидиЦін_Const.TABLE} AS Довідник_ВидиЦін ON 
        Довідник_ВидиЦін.uid = register.ВидЦіни
ORDER BY
    Номенклатура_Назва, ХарактеристикаНоменклатури_Назва, Пакування_Назва, ВидЦіни_Назва
";

            Store.RemoveAll();

            Dictionary<string, object> paramQuery = new()
            {
                { "Валюта", ЕлементВласникФорма.Валюта_Значення.UniqueID.UGuid },
                { "ВидЦін", ЕлементВласникФорма.ВидЦіни_Значення.UniqueID.UGuid }
            };

            var recordResult = await Config.Kernel.DataBase.SelectRequest(query, paramQuery);
            foreach (Dictionary<string, object> itemListRow in recordResult.ListRow)
            {
                var row = ItemRow.New();
                row.НомерРядка = (int)Store.GetNItems() + 1;
                row.Номенклатура = new Номенклатура_Pointer(itemListRow["Номенклатура"], itemListRow["Номенклатура_Назва"]);
                row.Пакування = new ПакуванняОдиниціВиміру_Pointer(itemListRow["Пакування"], itemListRow["Пакування_Назва"]);
                row.ВидЦіни = new ВидиЦін_Pointer(itemListRow["ВидЦіни"], itemListRow["ВидЦіни_Назва"]);
                row.Ціна = (decimal)itemListRow["Ціна"];

                Store.Append(row);
            }
        }
    }

    #endregion

    public ВстановленняЦінНоменклатури_Objest? ЕлементВласник { get; set; }
    public ВстановленняЦінНоменклатури_Елемент? ЕлементВласникФорма { get; set; }
    protected override Gio.ListStore Store { get; } = Gio.ListStore.New(ItemRow.GetGType());

    partial void Initialize()
    {
        MultiSelection model = MultiSelection.New(Store);
        model.OnSelectionChanged += GridOnSelectionChanged;

        Grid.Model = model;

        //
        //
        //

        {
            Separator separator = Separator.New(Orientation.Vertical);
            separator.MarginStart = 5;
            separator.MarginEnd = 10;
            HBoxToolbarTop.Append(separator);
        }

        static string ШаблонКнопки(string caption) => 
$"""
<?xml version="1.0" encoding="UTF-8"?>
<interface>
    <object class="GtkButton" id="button">
        <property name="tooltip-text">{caption}</property>
        <property name="margin-end">5</property>
        <child>
            <object class="GtkBox">
                <child>
                    <object class="GtkImage">
                        <property name="margin-end">5</property>
                        <property name="icon-name">new</property>
                    </object>
                </child>
                <child>
                    <object class="GtkLabel">
                        <property name="label">{caption}</property>
                    </object>
                </child>
            </object>
        </child>
    </object>
</interface>
""";

        {

            string xml = ШаблонКнопки("Заповнити з довідника");
            Builder builder = Builder.NewFromString(xml, Encoding.UTF8.GetBytes(xml).Length);
            Button? button = (Button?)builder.GetObject("button");
            if (button != null)
            {
                button.AddCssClass("toolbar");
                button.OnClicked += async (_, _) =>
                {
                    button.Sensitive = false;
                    await ЗаповнитиЗДовідника();
                    button.Sensitive = true;
                };
                HBoxToolbarTop.Append(button);
            }

            /* Button button = Button.NewFromIconName("document-new");
             button.AddCssClass("toolbar");
             button.MarginEnd = 5;
             button.TooltipText = "Заповнити з довідника";
             button.OnClicked += async (_, _) => await ЗаповнитиЗДовідника();
             HBoxToolbarTop.Append(button);*/
        }

        {
            string xml = ШаблонКнопки("Заповнити з регістру");
            Builder builder = Builder.NewFromString(xml, Encoding.UTF8.GetBytes(xml).Length);
            Button? button = (Button?)builder.GetObject("button");
            if (button != null)
            {
                button.AddCssClass("toolbar");
                button.OnClicked += async (_, _) =>
                {
                    button.Sensitive = false;
                    await ЗаповнитиЗРегістру();
                    button.Sensitive = true;
                };
                HBoxToolbarTop.Append(button);
            }

            /*
            Button button = Button.NewFromIconName("document-new");
            button.AddCssClass("toolbar");
            button.MarginEnd = 5;
            button.TooltipText = "Заповнити з регістру";
            button.OnClicked += async (_, _) => await ЗаповнитиЗРегістру();
            HBoxToolbarTop.Append(button);*/
        }
    }

    public static ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари New()
    {
        ВстановленняЦінНоменклатури_ТабличнаЧастина_Товари tablePart = NewWithProperties([]);
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

                cell.OnSelect = async () =>
                {
                    row.Номенклатура = cell.Pointer;
                    await ПісляЗміни_Номенклатура(row);
                };

                (row.Сhanged_Номенклатура = () => cell.Pointer = row.Номенклатура).Invoke();

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

                cell.OnSelect = async () =>
                {
                    row.ХарактеристикаНоменклатури = cell.Pointer;
                    await ПісляЗміни_ХарактеристикаНоменклатури(row);
                };

                (row.Сhanged_ХарактеристикаНоменклатури = () => cell.Pointer = row.ХарактеристикаНоменклатури).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Характеристика", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

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

                cell.OnSelect = () => row.Пакування = cell.Pointer;
                (row.Сhanged_Пакування = () => cell.Pointer = row.Пакування).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Пакування", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //ВидЦіни
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ВидиЦін_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ВидиЦін_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = () => row.ВидЦіни = cell.Pointer;
                (row.Сhanged_ВидЦіни = () => cell.Pointer = row.ВидЦіни).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Вид ціни", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

            Grid.AppendColumn(column);
        }

        //Ціна
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

                cell.OnСhanged = () => row.Ціна = cell.Value;
                (row.Сhanged_Ціна = () => cell.Value = row.Ціна).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Ціна", factory);
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

    public override async Task LoadRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.FillJoin([ВстановленняЦінНоменклатури_Товари_TablePart.НомерРядка,]);
            await ЕлементВласник.Товари_TablePart.Read();

            Store.RemoveAll();

            foreach (var record in ЕлементВласник.Товари_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.Номенклатура = record.Номенклатура;
                row.ХарактеристикаНоменклатури = record.ХарактеристикаНоменклатури;
                row.Пакування = record.Пакування;
                row.ВидЦіни = record.ВидЦіни;
                row.Ціна = record.Ціна;

                Store.Append(row);

                if (SelectPosition > 0)
                {
                    Grid.Model.SelectItem(SelectPosition, true);
                    ScrollTo(SelectPosition);
                }
            }
        }
    }

    public override async Task SaveRecords()
    {
        if (ЕлементВласник != null)
        {
            ЕлементВласник.Товари_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    ЕлементВласник.Товари_TablePart.Records.Add(new()
                    {
                        UID = row.UniqueID.UGuid,
                        НомерРядка = row.НомерРядка,
                        Номенклатура = row.Номенклатура,
                        ХарактеристикаНоменклатури = row.ХарактеристикаНоменклатури,
                        Пакування = row.Пакування,
                        ВидЦіни = row.ВидЦіни,
                        Ціна = row.Ціна,

                    });
                }
            }
            await ЕлементВласник.Товари_TablePart.Save(true);

            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.Товари_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.НомерРядка = x.НомерРядка;
                    row.Номенклатура = x.Номенклатура;
                    row.ХарактеристикаНоменклатури = x.ХарактеристикаНоменклатури;
                    row.Пакування = x.Пакування;
                    row.ВидЦіни = x.ВидЦіни;
                    row.Ціна = x.Ціна;

                    return row;
                });

                uint count = (uint)rows.Count();

                //Оновлення всіх рядків
                Store.Splice(0, count, [.. rows], count);

                //Виділення рядків після оновлення
                foreach (var position in selection)
                    Grid.Model.SelectItem(position, false);

            }
        }
    }

    public override async Task<bool> NewRecord()
    {
        ItemRow itemRow = ItemRow.New();
        await ПісляДодаванняНового(itemRow);

        Store.Append(itemRow);
        return true;
    }
}
