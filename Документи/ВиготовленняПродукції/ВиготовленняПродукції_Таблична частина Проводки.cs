
/*
        ВиготовленняПродукції_ТабличнаЧастина_Проводки.cs
        Таблична Частина
*/

using Gtk;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Довідники;
using GeneratedCode.Документи;
using GeneratedCode.Перелічення;

namespace StorageAndTrade;

[GObject.Subclass<DocumentFormTablePart>("TablePart_ka6fAQEJ83Oz1tFSNpA8g")]
partial class ВиготовленняПродукції_ТабличнаЧастина_Проводки : DocumentFormTablePart
{
    #region Data

    [GObject.Subclass<GObject.Object>("ItemRow_gLifAcL7c3SQQz2Xs9hYYQ")]
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


        /* ВидПроводки */
        public ВидиПроводок ВидПроводки
        {
            get => ВидПроводки_;
            set
            {
                if (!ВидПроводки_.Equals(value))
                {
                    ВидПроводки_ = value;
                    Сhanged_ВидПроводки?.Invoke();
                }
            }
        }
        ВидиПроводок ВидПроводки_ = 0;
        public Action? Сhanged_ВидПроводки { get; set; } = null;


        /* Рахунок */
        public ПланРахунків_Pointer Рахунок
        {
            get => Рахунок_;
            set
            {
                if (!Рахунок_.Equals(value))
                {
                    Рахунок_ = value;
                    Сhanged_Рахунок?.Invoke();
                }
            }
        }
        ПланРахунків_Pointer Рахунок_ = new();
        public Action? Сhanged_Рахунок { get; set; } = null;


        /* Аналітика1 */
        public UuidAndText Аналітика1
        {
            get => Аналітика1_;
            set
            {
                if (!Аналітика1_.Equals(value))
                {
                    Аналітика1_ = value;
                    Сhanged_Аналітика1?.Invoke();
                }
            }
        }
        UuidAndText Аналітика1_ = new();
        public Action? Сhanged_Аналітика1 { get; set; } = null;


        /* Аналітика2 */
        public UuidAndText Аналітика2
        {
            get => Аналітика2_;
            set
            {
                if (!Аналітика2_.Equals(value))
                {
                    Аналітика2_ = value;
                    Сhanged_Аналітика2?.Invoke();
                }
            }
        }
        UuidAndText Аналітика2_ = new();
        public Action? Сhanged_Аналітика2 { get; set; } = null;


        /* Аналітика3 */
        public UuidAndText Аналітика3
        {
            get => Аналітика3_;
            set
            {
                if (!Аналітика3_.Equals(value))
                {
                    Аналітика3_ = value;
                    Сhanged_Аналітика3?.Invoke();
                }
            }
        }
        UuidAndText Аналітика3_ = new();
        public Action? Сhanged_Аналітика3 { get; set; } = null;


        /* Податки */
        public ВидиПодатків_Pointer Податки
        {
            get => Податки_;
            set
            {
                if (!Податки_.Equals(value))
                {
                    Податки_ = value;
                    Сhanged_Податки?.Invoke();
                }
            }
        }
        ВидиПодатків_Pointer Податки_ = new();
        public Action? Сhanged_Податки { get; set; } = null;


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


        /* КореспондуючийРахунок */
        public ПланРахунків_Pointer КореспондуючийРахунок
        {
            get => КореспондуючийРахунок_;
            set
            {
                if (!КореспондуючийРахунок_.Equals(value))
                {
                    КореспондуючийРахунок_ = value;
                    Сhanged_КореспондуючийРахунок?.Invoke();
                }
            }
        }
        ПланРахунків_Pointer КореспондуючийРахунок_ = new();
        public Action? Сhanged_КореспондуючийРахунок { get; set; } = null;


        /* КорАналітика1 */
        public UuidAndText КорАналітика1
        {
            get => КорАналітика1_;
            set
            {
                if (!КорАналітика1_.Equals(value))
                {
                    КорАналітика1_ = value;
                    Сhanged_КорАналітика1?.Invoke();
                }
            }
        }
        UuidAndText КорАналітика1_ = new();
        public Action? Сhanged_КорАналітика1 { get; set; } = null;


        /* КорАналітика2 */
        public UuidAndText КорАналітика2
        {
            get => КорАналітика2_;
            set
            {
                if (!КорАналітика2_.Equals(value))
                {
                    КорАналітика2_ = value;
                    Сhanged_КорАналітика2?.Invoke();
                }
            }
        }
        UuidAndText КорАналітика2_ = new();
        public Action? Сhanged_КорАналітика2 { get; set; } = null;


        /* КорАналітика3 */
        public UuidAndText КорАналітика3
        {
            get => КорАналітика3_;
            set
            {
                if (!КорАналітика3_.Equals(value))
                {
                    КорАналітика3_ = value;
                    Сhanged_КорАналітика3?.Invoke();
                }
            }
        }
        UuidAndText КорАналітика3_ = new();
        public Action? Сhanged_КорАналітика3 { get; set; } = null;



        /*
        Функції
        */

        public GObject.Object Copy()
        {
            var row = New();
            row.НомерРядка = НомерРядка;
            row.ВидПроводки = ВидПроводки;
            row.Рахунок = Рахунок.Copy();
            row.Аналітика1 = Аналітика1.Copy();
            row.Аналітика2 = Аналітика2.Copy();
            row.Аналітика3 = Аналітика3.Copy();
            row.Податки = Податки.Copy();
            row.Сума = Сума;
            row.Кількість = Кількість;
            row.КореспондуючийРахунок = КореспондуючийРахунок.Copy();
            row.КорАналітика1 = КорАналітика1.Copy();
            row.КорАналітика2 = КорАналітика2.Copy();
            row.КорАналітика3 = КорАналітика3.Copy();

            return row;
        }
    }

    #endregion

    #region Функції

    Task ПісляДодаванняНового(ItemRow row)
    {
        return Task.CompletedTask;
    }

    async Task ПісляЗміни_Рахунок(ItemRow row)
    {
        var РахунокОбєкт = await row.Рахунок.GetDirectoryObject();
        if (РахунокОбєкт != null)
        {
            row.Аналітика1 = ФункціїДляДокументів.ЗадатиТипАналітики(row.Аналітика1, РахунокОбєкт.Субконто1);
            row.Аналітика2 = ФункціїДляДокументів.ЗадатиТипАналітики(row.Аналітика2, РахунокОбєкт.Субконто2);
            row.Аналітика3 = ФункціїДляДокументів.ЗадатиТипАналітики(row.Аналітика3, РахунокОбєкт.Субконто3);
        }
    }

    async Task ПісляЗміни_КореспондуючийРахунок(ItemRow row)
    {
        var РахунокОбєкт = await row.КореспондуючийРахунок.GetDirectoryObject();
        if (РахунокОбєкт != null)
        {
            row.КорАналітика1 = ФункціїДляДокументів.ЗадатиТипАналітики(row.КорАналітика1, РахунокОбєкт.Субконто1);
            row.КорАналітика2 = ФункціїДляДокументів.ЗадатиТипАналітики(row.КорАналітика2, РахунокОбєкт.Субконто2);
            row.КорАналітика3 = ФункціїДляДокументів.ЗадатиТипАналітики(row.КорАналітика3, РахунокОбєкт.Субконто3);
        }
    }

    void ПісляЗміни_СумаАбоКількість(ItemRow row)
    {
        Підсумок.Recount();
    }

    #endregion

    public ВиготовленняПродукції_Object? ЕлементВласник { get; set; }
    public ВиготовленняПродукції_Елемент? ЕлементВласникФорма { get; set; }
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
            decimal Сума = 0, Кількість = 0;

            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    Сума += row.Сума;
                    Кількість += row.Кількість;
                }
            }

            return new("Сума: <b>{0}</b> Кількість: <b>{1}</b>", Сума, Кількість);
        };

        Append(Підсумок);

        //
        // Кнопки
        //

        {
            Separator separator = Separator.New(Orientation.Vertical);
            separator.MarginStart = 5;
            separator.MarginEnd = 10;
            HBoxToolbarTop.Append(separator);
        }

        Button button = Button.NewWithLabel("Заповнити");
        button.AddCssClass("toolbar");
        button.OnClicked += async (_, _) =>
        {
            button.Sensitive = false;

            if (Store.GetNItems() == 0)
                await ЗаповнитиПроводки();
            else
                Message.Request(NotebookFunc?.BasicForm, "Очистити табличну частину?",
                    "В табличній частині вже є дані. Щоб продовжити заповнення потрібно спочатку очистити табличну частину!",
                    async x =>
                    {
                        if (x == Message.YesNo.Yes)
                            await ЗаповнитиПроводки();
                    });

            button.Sensitive = true;
        };
        HBoxToolbarTop.Append(button);
    }

    async Task ЗаповнитиПроводки()
    {
        if (ЕлементВласник != null && ЕлементВласникФорма != null)
        {
            Store.RemoveAll();

            СтруктураПідприємства_Pointer Підрозділ = ЕлементВласникФорма.Підрозділ_Значення;

            ПланРахунків_Pointer РахунокВитрат = new();
            Статті_Pointer СтаттяВитрат = new();

            //
            // Пошук в підрозділі
            //
            {
                var ПідрозділОбєкт = await Підрозділ.GetDirectoryObject();
                if (ПідрозділОбєкт != null)
                {
                    var КатегоріяОбєкт = await ПідрозділОбєкт.Категорія.GetDirectoryObject();
                    if (КатегоріяОбєкт != null)
                    {
                        РахунокВитрат = КатегоріяОбєкт.РахунокВитрат;
                        СтаттяВитрат = КатегоріяОбєкт.СтаттяВитрат;
                    }
                }

                //Якщо не знайдено, тоді стандарний рахунок
                if (РахунокВитрат.IsEmpty())
                    РахунокВитрат = await new ПланРахунків_Select().FindByField(ПланРахунків_Const.Код, "23");

                await РахунокВитрат.GetPresentation();
            }

            //Обробка таб частини Комплектуючі
            foreach (var Рядок in ЕлементВласникФорма.Комплектуючі_Колекція())
            {
                ПланРахунків_Pointer РахунокКор = new();

                //
                // Пошук в Номенклатура або Склади
                //
                {
                    //Пошук в Номенклатура
                    Номенклатура_Object? НоменклатураОбєкт = await Рядок.Номенклатура.GetDirectoryObject();
                    if (НоменклатураОбєкт != null && !НоменклатураОбєкт.Категорія.IsEmpty())
                    {
                        Категорії_Object? КатегоріяОбєкт = await НоменклатураОбєкт.Категорія.GetDirectoryObject();
                        if (КатегоріяОбєкт != null)
                            РахунокКор = КатегоріяОбєкт.РахунокВитрат;
                    }

                    //Пошук в Склади
                    if (РахунокКор.IsEmpty() && !Рядок.Склад.IsEmpty())
                    {
                        Склади_Object? СкладОбєкт = await Рядок.Склад.GetDirectoryObject();
                        if (СкладОбєкт != null && !СкладОбєкт.Категорія.IsEmpty())
                        {
                            Категорії_Object? КатегоріяОбєкт = await СкладОбєкт.Категорія.GetDirectoryObject();
                            if (КатегоріяОбєкт != null)
                                РахунокКор = КатегоріяОбєкт.РахунокВитрат;
                        }
                    }

                    //Якщо не знайдено, тоді стандарний рахунок
                    if (РахунокКор.IsEmpty())
                        РахунокКор = await new ПланРахунків_Select().FindByField(ПланРахунків_Const.Код, "201");

                    await РахунокКор.GetPresentation();
                }

                //Кредит
                {
                    var row = ItemRow.New();
                    row.ВидПроводки = ВидиПроводок.Кредит;
                    row.Рахунок = РахунокКор;
                    row.Аналітика1 = new UuidAndText(Рядок.Склад);
                    row.Аналітика2 = new UuidAndText(Рядок.Номенклатура);
                    row.Сума = 100;
                    row.Кількість = Рядок.Кількість;
                    row.КореспондуючийРахунок = РахунокВитрат;
                    row.КорАналітика1 = new UuidAndText(Підрозділ);
                    row.КорАналітика2 = new UuidAndText(СтаттяВитрат);

                    Store.Append(row);
                }

                //Дебет
                {
                    var row = ItemRow.New();
                    row.ВидПроводки = ВидиПроводок.Дебет;
                    row.Рахунок = РахунокВитрат;
                    row.Аналітика1 = new UuidAndText(Підрозділ);
                    row.Аналітика2 = new UuidAndText(СтаттяВитрат);
                    row.Сума = 0;
                    row.Кількість = Рядок.Кількість;
                    row.КореспондуючийРахунок = РахунокКор;
                    row.КорАналітика1 = new UuidAndText(Рядок.Склад);
                    row.КорАналітика2 = new UuidAndText(Рядок.Номенклатура);

                    Store.Append(row);
                }
            }

            //Обробка таб частини ГотовийВиріб
            foreach (var Рядок in ЕлементВласникФорма.ГотовийВиріб_Колекція())
            {
                ПланРахунків_Pointer РахунокКор = new();

                //
                // Пошук в Номенклатура або Склади
                //
                {
                    //Пошук в Номенклатура
                    Номенклатура_Object? НоменклатураОбєкт = await Рядок.Номенклатура.GetDirectoryObject();
                    if (НоменклатураОбєкт != null && !НоменклатураОбєкт.Категорія.IsEmpty())
                    {
                        Категорії_Object? КатегоріяОбєкт = await НоменклатураОбєкт.Категорія.GetDirectoryObject();
                        if (КатегоріяОбєкт != null)
                            РахунокКор = КатегоріяОбєкт.РахунокВитрат;
                    }

                    //Пошук в Склади
                    if (РахунокКор.IsEmpty() && !Рядок.Склад.IsEmpty())
                    {
                        Склади_Object? СкладОбєкт = await Рядок.Склад.GetDirectoryObject();
                        if (СкладОбєкт != null && !СкладОбєкт.Категорія.IsEmpty())
                        {
                            Категорії_Object? КатегоріяОбєкт = await СкладОбєкт.Категорія.GetDirectoryObject();
                            if (КатегоріяОбєкт != null)
                                РахунокКор = КатегоріяОбєкт.РахунокВитрат;
                        }
                    }

                    //Якщо не знайдено, тоді стандарний рахунок
                    if (РахунокКор.IsEmpty())
                        РахунокКор = await new ПланРахунків_Select().FindByField("Код", "26");

                    await РахунокКор.GetPresentation();
                }

                //Кредит
                {
                    var row = ItemRow.New();
                    row.ВидПроводки = ВидиПроводок.Кредит;
                    row.Рахунок = РахунокВитрат;
                    row.Аналітика1 = new UuidAndText(Підрозділ);
                    row.Аналітика2 = new UuidAndText(СтаттяВитрат);
                    row.Сума = 0;
                    row.Кількість = Рядок.Кількість;
                    row.КореспондуючийРахунок = РахунокКор;
                    row.КорАналітика1 = new UuidAndText(Рядок.Склад);
                    row.КорАналітика2 = new UuidAndText(Рядок.Номенклатура);

                    Store.Append(row);
                }

                //Дебет
                {
                    var row = ItemRow.New();
                    row.ВидПроводки = ВидиПроводок.Дебет;
                    row.Рахунок = РахунокКор;
                    row.Аналітика1 = new UuidAndText(Рядок.Склад);
                    row.Аналітика2 = new UuidAndText(Рядок.Номенклатура);
                    row.Сума = 0;
                    row.Кількість = Рядок.Кількість;
                    row.КореспондуючийРахунок = РахунокВитрат;
                    row.КорАналітика1 = new UuidAndText(Підрозділ);
                    row.КорАналітика2 = new UuidAndText(СтаттяВитрат);

                    Store.Append(row);
                }
            }
        }
    }

    public static ВиготовленняПродукції_ТабличнаЧастина_Проводки New()
    {
        ВиготовленняПродукції_ТабличнаЧастина_Проводки tablePart = NewWithProperties([]);
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

        //ВидПроводки
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = DropDownTablePartCell.NewWithValues(ПсевдонімиПерелічення.ВидиПроводок_Dict());

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not DropDownTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnСhanged = () => row.ВидПроводки = ПсевдонімиПерелічення.ВидиПроводок_FindByName(cell.Value);
                (row.Сhanged_ВидПроводки = () => cell.Value = row.ВидПроводки.ToString()).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Вид", factory);
            column.Resizable = true;

            Grid.AppendColumn(column);
        }

        //Рахунок
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ПланРахунків_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ПланРахунків_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                //Після вибору рахунку
                cell.OnSelect = async () =>
                {
                    row.Рахунок = cell.Pointer;
                    await ПісляЗміни_Рахунок(row);
                };

                (row.Сhanged_Рахунок = () => cell.Pointer = row.Рахунок).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Рахунок", factory);
            column.Resizable = true;
            column.FixedWidth = 200;

            Grid.AppendColumn(column);
        }

        //Аналітика1, Аналітика2, Аналітика3
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Група_Аналітика.New();

                cell.Аналітика1.BoundConfType = "Документи.ВиготовленняПродукції.Проводки.Аналітика1";
                cell.Аналітика2.BoundConfType = "Документи.ВиготовленняПродукції.Проводки.Аналітика2";
                cell.Аналітика3.BoundConfType = "Документи.ВиготовленняПродукції.Проводки.Аналітика3";

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Група_Аналітика cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.Аналітика1.OnSelect = () => row.Аналітика1 = cell.Аналітика1.Pointer;
                (row.Сhanged_Аналітика1 = () => cell.Аналітика1.Pointer = row.Аналітика1).Invoke();

                cell.Аналітика2.OnSelect = () => row.Аналітика2 = cell.Аналітика2.Pointer;
                (row.Сhanged_Аналітика2 = () => cell.Аналітика2.Pointer = row.Аналітика2).Invoke();

                cell.Аналітика3.OnSelect = () => row.Аналітика3 = cell.Аналітика3.Pointer;
                (row.Сhanged_Аналітика3 = () => cell.Аналітика3.Pointer = row.Аналітика3).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Аналітика 1\nАналітика 2\nАналітика 3", factory);
            column.Resizable = true;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //Податки
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ВидиПодатків_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ВидиПодатків_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.OnSelect = () => row.Податки = cell.Pointer;
                (row.Сhanged_Податки = () => cell.Pointer = row.Податки).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Податки", factory);
            column.Resizable = true;
            column.Visible = false;
            column.FixedWidth = 300;

            Grid.AppendColumn(column);
        }

        //КореспондуючийРахунок
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = ПланРахунків_PointerTablePartCell.New();

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not ПланРахунків_PointerTablePartCell cell) return;
                if (listItem.Item is not ItemRow row) return;

                //Після вибору рахунку
                cell.OnSelect = async () =>
                {
                    row.КореспондуючийРахунок = cell.Pointer;
                    await ПісляЗміни_КореспондуючийРахунок(row);
                };

                (row.Сhanged_КореспондуючийРахунок = () => cell.Pointer = row.КореспондуючийРахунок).Invoke();
            };
            ColumnViewColumn column = ColumnViewColumn.New("Кореспондуючий\nрахунок", factory);
            column.Resizable = true;
            column.FixedWidth = 200;

            Grid.AppendColumn(column);
        }

        //КорАналітика1, КорАналітика2, КорАналітика3
        {
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                var cell = Група_Аналітика.New();

                cell.Аналітика1.BoundConfType = "Документи.ВиготовленняПродукції.Проводки.КорАналітика1";
                cell.Аналітика2.BoundConfType = "Документи.ВиготовленняПродукції.Проводки.КорАналітика2";
                cell.Аналітика3.BoundConfType = "Документи.ВиготовленняПродукції.Проводки.КорАналітика3";

                listItem.Child = cell;
            };
            factory.OnBind += (_, args) =>
            {
                if (args.Object is not ListItem listItem) return;
                if (listItem.Child is not Група_Аналітика cell) return;
                if (listItem.Item is not ItemRow row) return;

                cell.Аналітика1.OnSelect = () => row.КорАналітика1 = cell.Аналітика1.Pointer;
                (row.Сhanged_КорАналітика1 = () => cell.Аналітика1.Pointer = row.КорАналітика1).Invoke();

                cell.Аналітика2.OnSelect = () => row.КорАналітика2 = cell.Аналітика2.Pointer;
                (row.Сhanged_КорАналітика2 = () => cell.Аналітика2.Pointer = row.КорАналітика2).Invoke();

                cell.Аналітика3.OnSelect = () => row.КорАналітика3 = cell.Аналітика3.Pointer;
                (row.Сhanged_КорАналітика3 = () => cell.Аналітика3.Pointer = row.КорАналітика3).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кор аналітика 1\nКор аналітика 2\nКор аналітика 3", factory);
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
                    ПісляЗміни_СумаАбоКількість(row);
                };

                (row.Сhanged_Сума = () => cell.Value = row.Сума).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Сума", factory);
            column.Resizable = true;
            column.FixedWidth = 100;

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

                cell.OnСhanged = () =>
                {
                    row.Кількість = cell.Value;
                    ПісляЗміни_СумаАбоКількість(row);
                };

                (row.Сhanged_Кількість = () => cell.Value = row.Кількість).Invoke();

            };
            ColumnViewColumn column = ColumnViewColumn.New("Кількість", factory);
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
            ЕлементВласник.Проводки_TablePart.FillJoin([ВиготовленняПродукції_Проводки_TablePart.НомерРядка,]);
            await ЕлементВласник.Проводки_TablePart.Read();

            Store.RemoveAll();

            foreach (var record in ЕлементВласник.Проводки_TablePart.Records)
            {
                var row = ItemRow.New();
                row.UniqueID = new(record.UID);
                row.НомерРядка = record.НомерРядка;
                row.ВидПроводки = record.ВидПроводки;
                row.Рахунок = record.Рахунок;
                row.Аналітика1 = record.Аналітика1;
                row.Аналітика2 = record.Аналітика2;
                row.Аналітика3 = record.Аналітика3;
                row.Податки = record.Податки;
                row.Сума = record.Сума;
                row.Кількість = record.Кількість;
                row.КореспондуючийРахунок = record.КореспондуючийРахунок;
                row.КорАналітика1 = record.КорАналітика1;
                row.КорАналітика2 = record.КорАналітика2;
                row.КорАналітика3 = record.КорАналітика3;

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
            ЕлементВласник.Проводки_TablePart.Records.Clear();
            for (uint i = 0; i <= Store.GetNItems(); i++)
            {
                ItemRow? row = (ItemRow?)Store.GetObject(i);
                if (row != null)
                {
                    ЕлементВласник.Проводки_TablePart.Records.Add(new()
                    {
                        UID = row.UniqueID.UGuid,
                        НомерРядка = row.НомерРядка,
                        ВидПроводки = row.ВидПроводки,
                        Рахунок = row.Рахунок,
                        Аналітика1 = row.Аналітика1,
                        Аналітика2 = row.Аналітика2,
                        Аналітика3 = row.Аналітика3,
                        Податки = row.Податки,
                        Сума = row.Сума,
                        Кількість = row.Кількість,
                        КореспондуючийРахунок = row.КореспондуючийРахунок,
                        КорАналітика1 = row.КорАналітика1,
                        КорАналітика2 = row.КорАналітика2,
                        КорАналітика3 = row.КорАналітика3,
                    });
                }
            }
            await ЕлементВласник.Проводки_TablePart.Save(true);
            //Оновлення табличної частини після збереження
            {
                //Пошук виділених рядків
                Bitset bitset = Grid.Model.GetSelection();
                List<uint> selection = [];
                for (uint i = bitset.GetMinimum(); i <= bitset.GetMaximum(); i++)
                    if (Grid.Model.IsSelected(i)) selection.Add(i);

                var rows = ЕлементВласник.Проводки_TablePart.Records.Select(x =>
                {
                    var row = ItemRow.New();
                    row.UniqueID = new(x.UID);
                    row.НомерРядка = x.НомерРядка;
                    row.ВидПроводки = x.ВидПроводки;
                    row.Рахунок = x.Рахунок;
                    row.Аналітика1 = x.Аналітика1;
                    row.Аналітика2 = x.Аналітика2;
                    row.Аналітика3 = x.Аналітика3;
                    row.Податки = x.Податки;
                    row.Сума = x.Сума;
                    row.Кількість = x.Кількість;
                    row.КореспондуючийРахунок = x.КореспондуючийРахунок;
                    row.КорАналітика1 = x.КорАналітика1;
                    row.КорАналітика2 = x.КорАналітика2;
                    row.КорАналітика3 = x.КорАналітика3;

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
        ItemRow row = ItemRow.New();
        await ПісляДодаванняНового(row);

        Store.Append(row);
        return true;
    }
}
