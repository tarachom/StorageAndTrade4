
/*
 *
 * Конфігурації ""Зберігання та Торгівля" для України"
 * Автор Тарахомин Юрій Іванович, accounting.org.ua
 * Дата конфігурації: 15.12.2025 18:50:01
 *
 *
 * Цей код згенерований в Конфігураторі 3. Шаблон Gtk4.xslt
 *
 */

using Gtk;
using GObject;
using InterfaceGtk4;
using AccountingSoftware;
using GeneratedCode.Перелічення;
using StorageAndTrade;

namespace GeneratedCode.Rows
{
    [Subclass<GObject.Object>]
    public partial class Row
    {
        public UnigueID UID { get; set; } = new();
        public bool DeletionLabel { get; set; } = false;
    }

    
    #region DIRECTORY "Організації"
        
    public partial class Row_1_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Номенклатура"
        
    public partial class Row_2_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string ОдиницяВиміру { get; set; } = "";
        
        public string ТипНоменклатури { get; set; } = "";
        
        public string Залишок { get; set; } = "";
        
        public string ВРезерві { get; set; } = "";
        
        public string ВРезервіПідЗамовлення { get; set; } = "";
        
        public string ЗалишокВКомірках { get; set; } = "";
        
    }
        
    public partial class Row_2_2 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string ОдиницяВиміру { get; set; } = "";
        
        public string Залишок { get; set; } = "";
        
        public string ВРезерві { get; set; } = "";
        
        public string ВРезервіПідЗамовлення { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Виробники"
        
    public partial class Row_3_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ВидиНоменклатури"
        
    public partial class Row_4_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ПакуванняОдиниціВиміру"
        
    public partial class Row_5_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string КількістьУпаковок { get; set; } = "";
        
        public string НазваПовна { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Валюти"
        
    public partial class Row_6_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string КороткаНазва { get; set; } = "";
        
        public string Код_R030 { get; set; } = "";
        
        public string ВиводитиКурсНаСтартову { get; set; } = "";
        
    }
        
    public partial class Row_6_2 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string КороткаНазва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Контрагенти"
        
    public partial class Row_7_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Папка { get; set; } = "";
        
        public string Постачальник { get; set; } = "";
        
        public string Покупець { get; set; } = "";
        
    }
        
    public partial class Row_7_2 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Склади"
        
    public partial class Row_8_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string ТипСкладу { get; set; } = "";
        
        public string НалаштуванняАдресногоЗберігання { get; set; } = "";
        
    }
        
    public partial class Row_8_2 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЦін"
        
    public partial class Row_9_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Валюта { get; set; } = "";
        
    }
        
    public partial class Row_9_2 : Row
    {
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЦінПостачальників"
        
    public partial class Row_10_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Користувачі"
        
    public partial class Row_11_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ФізичніОсоби"
        
    public partial class Row_12_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "СтруктураПідприємства"
        
    public partial class Row_13_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "КраїниСвіту"
        
    public partial class Row_14_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Файли"
        
    public partial class Row_15_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string НазваФайлу { get; set; } = "";
        
        public string Розмір { get; set; } = "";
        
        public string ДатаСтворення { get; set; } = "";
        
    }
        
    public partial class Row_15_2 : Row
    {
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ХарактеристикиНоменклатури"
        
    public partial class Row_16_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Номенклатура { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Залишки { get; set; } = "";
        
        public string ВРезерві { get; set; } = "";
        
        public string ВРезервіПідЗамовлення { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Номенклатура_Папки"
        
    public partial class Row_17_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Код { get; set; } = "";
        
    }
        
    public partial class Row_17_2 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Код { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Контрагенти_Папки"
        
    public partial class Row_18_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Код { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Склади_Папки"
        
    public partial class Row_19_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Код { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Каси"
        
    public partial class Row_20_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Валюта { get; set; } = "";
        
        public string Залишок { get; set; } = "";
        
    }
        
    public partial class Row_20_2 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Валюта { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "БанківськіРахункиОрганізацій"
        
    public partial class Row_21_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Валюта { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ДоговориКонтрагентів"
        
    public partial class Row_22_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Контрагент { get; set; } = "";
        
        public string ТипДоговору { get; set; } = "";
        
    }
        
    public partial class Row_22_2 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Контрагент { get; set; } = "";
        
        public string ТипДоговору { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "БанківськіРахункиКонтрагентів"
        
    public partial class Row_23_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Валюта { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "СтаттяРухуКоштів"
        
    public partial class Row_24_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Код { get; set; } = "";
        
        public string КореспондуючийРахунок { get; set; } = "";
        
        public string ВидРухуКоштів { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "СеріїНоменклатури"
        
    public partial class Row_25_1 : Row
    {
        
        public string Номер { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ПартіяТоварівКомпозит"
        
    public partial class Row_26_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Дата { get; set; } = "";
        
        public string ТипДокументу { get; set; } = "";
        
        public string ПоступленняТоварівТаПослуг { get; set; } = "";
        
        public string ВведенняЗалишків { get; set; } = "";
        
        public string Залишки { get; set; } = "";
        
    }
        
    public partial class Row_26_2 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Дата { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЗапасів"
        
    public partial class Row_27_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Банки"
        
    public partial class Row_28_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string ПовнаНазва { get; set; } = "";
        
        public string КодМФО { get; set; } = "";
        
        public string КодЄДРПОУ { get; set; } = "";
        
        public string НомерЛіцензії { get; set; } = "";
        
        public string ДатаЛіцензії { get; set; } = "";
        
        public string Статус { get; set; } = "";
        
        public string ТипНаселеногоПункту { get; set; } = "";
        
        public string УнікальнийКодБанку { get; set; } = "";
        
        public string ПоштовийІндекс { get; set; } = "";
        
        public string НазваНаселеногоПункту { get; set; } = "";
        
        public string Адреса { get; set; } = "";
        
        public string НомерТелефону { get; set; } = "";
        
        public string ДатаВідкриттяУстанови { get; set; } = "";
        
        public string ДатаЗакриттяУстанови { get; set; } = "";
        
        public string КодНБУ { get; set; } = "";
        
        public string КодСтатусу { get; set; } = "";
        
        public string ДатаЗапису { get; set; } = "";
        
    }
        
    public partial class Row_28_2 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіПриміщення"
        
    public partial class Row_29_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Склад { get; set; } = "";
        
        public string НалаштуванняАдресногоЗберігання { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіКомірки"
        
    public partial class Row_30_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Приміщення { get; set; } = "";
        
        public string Лінія { get; set; } = "";
        
        public string Позиція { get; set; } = "";
        
        public string Стелаж { get; set; } = "";
        
        public string Ярус { get; set; } = "";
        
        public string ТипСкладськоїКомірки { get; set; } = "";
        
        public string Типорозмір { get; set; } = "";
        
        public string Папка { get; set; } = "";
        
    }
        
    public partial class Row_30_2 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Приміщення { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ОбластьЗберігання"
        
    public partial class Row_31_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Приміщення { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ТипорозміриКомірок"
        
    public partial class Row_32_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Висота { get; set; } = "";
        
        public string Глибина { get; set; } = "";
        
        public string Вантажопідйомність { get; set; } = "";
        
        public string Обєм { get; set; } = "";
        
        public string Ширина { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіКомірки_Папки"
        
    public partial class Row_33_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Код { get; set; } = "";
        
        public string Власник { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "Блокнот"
        
    public partial class Row_34_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string ДатаЗапису { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "ЗбереженіЗвіти"
        
    public partial class Row_35_1 : Row
    {
        
        public string Код { get; set; } = "";
        
        public string Додано { get; set; } = "";
        
        public string Назва { get; set; } = "";
        
        public string Користувач { get; set; } = "";
        
    }
        
    #endregion
    
    #region DIRECTORY "КасиККМ"
        
    public partial class Row_36_1 : Row
    {
        
        public string Назва { get; set; } = "";
        
        public string Валюта { get; set; } = "";
        
        public string Тип { get; set; } = "";
        
        public string Склад { get; set; } = "";
        
    }
        
    #endregion
    
}

namespace GeneratedCode.Довідники.ТабличніСписки
{
    
    #region DIRECTORY "Організації"
        
    public partial class Організації_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_1_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_1_1? row = (GeneratedCode.Rows.Row_1_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_1_1? row = (GeneratedCode.Rows.Row_1_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_1_1? row = (GeneratedCode.Rows.Row_1_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Організації_Select Організації_Select = new();
            Організації_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Організації_Const.Код,
                /*Назва*/ Довідники.Організації_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Організації_Select.QuerySelect.Where = (List<Where>)where;

            Організації_Select.QuerySelect.Order.Add(
               Довідники.Організації_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Організації_Select.Select();
            store.RemoveAll();
            while (Організації_Select.MoveNext())
            {
                Довідники.Організації_Pointer? curr = Організації_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_1_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Організації_Const.Код].ToString() ?? "",
                            Назва = fields[Організації_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Номенклатура"
        
    public partial class Номенклатура_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_2_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ОдиницяВиміру);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Пакування", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ТипНоменклатури);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Тип", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Залишок);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Залишок", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВРезерві);
                };

                ColumnViewColumn column = ColumnViewColumn.New("В резерві", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВРезервіПідЗамовлення);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Під замовлення", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_1? row = (GeneratedCode.Rows.Row_2_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ЗалишокВКомірках);
                };

                ColumnViewColumn column = ColumnViewColumn.New("В комірках", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Номенклатура_Select Номенклатура_Select = new();
            Номенклатура_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Номенклатура_Const.Код,
                /*Назва*/ Довідники.Номенклатура_Const.Назва,
                /*ТипНоменклатури*/ Довідники.Номенклатура_Const.ТипНоменклатури,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Номенклатура_Select.QuerySelect.Where = (List<Where>)where;

            Номенклатура_Select.QuerySelect.Order.Add(
               Довідники.Номенклатура_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.ПакуванняОдиниціВиміру_Pointer.GetJoin(Номенклатура_Select.QuerySelect, Довідники.Номенклатура_Const.ОдиницяВиміру,
                Номенклатура_Select.QuerySelect.Table, "join_tab_1", "ОдиницяВиміру");
            
                /* Додаткове поле: Залишок */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ВНаявності} ) AS ВНаявності FROM {РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.TABLE} AS ТовариНаСкладах WHERE ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВНаявності, 1) FROM Залишки ) END)", "Залишок"));
            
                /* Додаткове поле: ВРезерві */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіЗіСкладу} ) AS ВРезервіЗіСкладу FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіЗіСкладу, 1) FROM Залишки ) END)", "ВРезерві"));
            
                /* Додаткове поле: ВРезервіПідЗамовлення */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіПідЗамовлення} ) AS ВРезервіПідЗамовлення FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіПідЗамовлення, 1) FROM Залишки ) END)", "ВРезервіПідЗамовлення"));
            
                /* Додаткове поле: ЗалишокВКомірках */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ТовариВКомірках.{РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ТовариВКомірках.{РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.ВНаявності} ) AS ВНаявності FROM {РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.TABLE} AS ТовариВКомірках WHERE ТовариВКомірках.{РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВНаявності, 1) FROM Залишки ) END)", "ЗалишокВКомірках"));
            
            await Номенклатура_Select.Select();
            store.RemoveAll();
            while (Номенклатура_Select.MoveNext())
            {
                Довідники.Номенклатура_Pointer? curr = Номенклатура_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_2_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Номенклатура_Const.Код].ToString() ?? "",
                            Назва = fields[Номенклатура_Const.Назва].ToString() ?? "",
                            ОдиницяВиміру = fields["ОдиницяВиміру"].ToString() ?? "",
                            ТипНоменклатури = Перелічення.ПсевдонімиПерелічення.ТипиНоменклатури_Alias((
                              (Перелічення.ТипиНоменклатури)(fields[Номенклатура_Const.ТипНоменклатури] != DBNull.Value ? fields[Номенклатура_Const.ТипНоменклатури] : 0)) ),
                            Залишок = fields["Залишок"].ToString() ?? "",
                        ВРезерві = fields["ВРезерві"].ToString() ?? "",
                        ВРезервіПідЗамовлення = fields["ВРезервіПідЗамовлення"].ToString() ?? "",
                        ЗалишокВКомірках = fields["ЗалишокВКомірках"].ToString() ?? "",
                        
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Номенклатура_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_2_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_2_2? row = (GeneratedCode.Rows.Row_2_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_2? row = (GeneratedCode.Rows.Row_2_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_2? row = (GeneratedCode.Rows.Row_2_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Номенклатура", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_2? row = (GeneratedCode.Rows.Row_2_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ОдиницяВиміру);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Пакування", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_2? row = (GeneratedCode.Rows.Row_2_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Залишок);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Залишок", factory);
                column.Resizable = true;
                
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_2? row = (GeneratedCode.Rows.Row_2_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВРезерві);
                };

                ColumnViewColumn column = ColumnViewColumn.New("В резерві", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_2_2? row = (GeneratedCode.Rows.Row_2_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВРезервіПідЗамовлення);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Під замовлення", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Номенклатура_Select Номенклатура_Select = new();
            Номенклатура_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Номенклатура_Const.Код,
                /*Назва*/ Довідники.Номенклатура_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Номенклатура_Select.QuerySelect.Where = (List<Where>)where;

            Номенклатура_Select.QuerySelect.Order.Add(
               Довідники.Номенклатура_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.ПакуванняОдиниціВиміру_Pointer.GetJoin(Номенклатура_Select.QuerySelect, Довідники.Номенклатура_Const.ОдиницяВиміру,
                Номенклатура_Select.QuerySelect.Table, "join_tab_1", "ОдиницяВиміру");
            
                /* Додаткове поле: Залишок */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ВНаявності} ) AS ВНаявності FROM {РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.TABLE} AS ТовариНаСкладах WHERE ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВНаявності, 1) FROM Залишки ) END)", "Залишок"));
            
                /* Додаткове поле: ВРезерві */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіЗіСкладу} ) AS ВРезервіЗіСкладу FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіЗіСкладу, 1) FROM Залишки ) END)", "ВРезерві"));
            
                /* Додаткове поле: ВРезервіПідЗамовлення */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіПідЗамовлення} ) AS ВРезервіПідЗамовлення FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіПідЗамовлення, 1) FROM Залишки ) END)", "ВРезервіПідЗамовлення"));
            
            await Номенклатура_Select.Select();
            store.RemoveAll();
            while (Номенклатура_Select.MoveNext())
            {
                Довідники.Номенклатура_Pointer? curr = Номенклатура_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_2_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Номенклатура_Const.Код].ToString() ?? "",
                            Назва = fields[Номенклатура_Const.Назва].ToString() ?? "",
                            ОдиницяВиміру = fields["ОдиницяВиміру"].ToString() ?? "",
                            Залишок = fields["Залишок"].ToString() ?? "",
                        ВРезерві = fields["ВРезерві"].ToString() ?? "",
                        ВРезервіПідЗамовлення = fields["ВРезервіПідЗамовлення"].ToString() ?? "",
                        
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Виробники"
        
    public partial class Виробники_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_3_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_3_1? row = (GeneratedCode.Rows.Row_3_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_3_1? row = (GeneratedCode.Rows.Row_3_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_3_1? row = (GeneratedCode.Rows.Row_3_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Виробники_Select Виробники_Select = new();
            Виробники_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Виробники_Const.Код,
                /*Назва*/ Довідники.Виробники_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Виробники_Select.QuerySelect.Where = (List<Where>)where;

            Виробники_Select.QuerySelect.Order.Add(
               Довідники.Виробники_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Виробники_Select.Select();
            store.RemoveAll();
            while (Виробники_Select.MoveNext())
            {
                Довідники.Виробники_Pointer? curr = Виробники_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_3_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Виробники_Const.Код].ToString() ?? "",
                            Назва = fields[Виробники_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиНоменклатури"
        
    public partial class ВидиНоменклатури_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_4_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_4_1? row = (GeneratedCode.Rows.Row_4_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_4_1? row = (GeneratedCode.Rows.Row_4_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_4_1? row = (GeneratedCode.Rows.Row_4_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ВидиНоменклатури_Select ВидиНоменклатури_Select = new();
            ВидиНоменклатури_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиНоменклатури_Const.Код,
                /*Назва*/ Довідники.ВидиНоменклатури_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ВидиНоменклатури_Select.QuerySelect.Where = (List<Where>)where;

            ВидиНоменклатури_Select.QuerySelect.Order.Add(
               Довідники.ВидиНоменклатури_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ВидиНоменклатури_Select.Select();
            store.RemoveAll();
            while (ВидиНоменклатури_Select.MoveNext())
            {
                Довідники.ВидиНоменклатури_Pointer? curr = ВидиНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_4_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиНоменклатури_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиНоменклатури_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ПакуванняОдиниціВиміру"
        
    public partial class ПакуванняОдиниціВиміру_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_5_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_5_1? row = (GeneratedCode.Rows.Row_5_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_5_1? row = (GeneratedCode.Rows.Row_5_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_5_1? row = (GeneratedCode.Rows.Row_5_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_5_1? row = (GeneratedCode.Rows.Row_5_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КількістьУпаковок);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Коєфіціент", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_5_1? row = (GeneratedCode.Rows.Row_5_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.НазваПовна);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Опис", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ПакуванняОдиниціВиміру_Select ПакуванняОдиниціВиміру_Select = new();
            ПакуванняОдиниціВиміру_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ПакуванняОдиниціВиміру_Const.Код,
                /*Назва*/ Довідники.ПакуванняОдиниціВиміру_Const.Назва,
                /*КількістьУпаковок*/ Довідники.ПакуванняОдиниціВиміру_Const.КількістьУпаковок,
                /*НазваПовна*/ Довідники.ПакуванняОдиниціВиміру_Const.НазваПовна,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ПакуванняОдиниціВиміру_Select.QuerySelect.Where = (List<Where>)where;

            ПакуванняОдиниціВиміру_Select.QuerySelect.Order.Add(
               Довідники.ПакуванняОдиниціВиміру_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ПакуванняОдиниціВиміру_Select.Select();
            store.RemoveAll();
            while (ПакуванняОдиниціВиміру_Select.MoveNext())
            {
                Довідники.ПакуванняОдиниціВиміру_Pointer? curr = ПакуванняОдиниціВиміру_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_5_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ПакуванняОдиниціВиміру_Const.Код].ToString() ?? "",
                            Назва = fields[ПакуванняОдиниціВиміру_Const.Назва].ToString() ?? "",
                            КількістьУпаковок = fields[ПакуванняОдиниціВиміру_Const.КількістьУпаковок].ToString() ?? "",
                            НазваПовна = fields[ПакуванняОдиниціВиміру_Const.НазваПовна].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Валюти"
        
    public partial class Валюти_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_6_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_6_1? row = (GeneratedCode.Rows.Row_6_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_1? row = (GeneratedCode.Rows.Row_6_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_1? row = (GeneratedCode.Rows.Row_6_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_1? row = (GeneratedCode.Rows.Row_6_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КороткаНазва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Коротка  назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_1? row = (GeneratedCode.Rows.Row_6_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код_R030);
                };

                ColumnViewColumn column = ColumnViewColumn.New("R030", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_1? row = (GeneratedCode.Rows.Row_6_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВиводитиКурсНаСтартову);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Показувати на стартовій", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Валюти_Select Валюти_Select = new();
            Валюти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Валюти_Const.Код,
                /*Назва*/ Довідники.Валюти_Const.Назва,
                /*КороткаНазва*/ Довідники.Валюти_Const.КороткаНазва,
                /*Код_R030*/ Довідники.Валюти_Const.Код_R030,
                /*ВиводитиКурсНаСтартову*/ Довідники.Валюти_Const.ВиводитиКурсНаСтартову,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Валюти_Select.QuerySelect.Where = (List<Where>)where;

            Валюти_Select.QuerySelect.Order.Add(
               Довідники.Валюти_Const.Код, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Валюти_Select.Select();
            store.RemoveAll();
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_6_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Валюти_Const.Код].ToString() ?? "",
                            Назва = fields[Валюти_Const.Назва].ToString() ?? "",
                            КороткаНазва = fields[Валюти_Const.КороткаНазва].ToString() ?? "",
                            Код_R030 = fields[Валюти_Const.Код_R030].ToString() ?? "",
                            ВиводитиКурсНаСтартову = (fields[Валюти_Const.ВиводитиКурсНаСтартову] != DBNull.Value ? (bool)fields[Валюти_Const.ВиводитиКурсНаСтартову] : false) ? "Так" : "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Валюти_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_6_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_6_2? row = (GeneratedCode.Rows.Row_6_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_2? row = (GeneratedCode.Rows.Row_6_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_2? row = (GeneratedCode.Rows.Row_6_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_6_2? row = (GeneratedCode.Rows.Row_6_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КороткаНазва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Коротка назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Валюти_Select Валюти_Select = new();
            Валюти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Валюти_Const.Код,
                /*Назва*/ Довідники.Валюти_Const.Назва,
                /*КороткаНазва*/ Довідники.Валюти_Const.КороткаНазва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Валюти_Select.QuerySelect.Where = (List<Where>)where;

            Валюти_Select.QuerySelect.Order.Add(
               Довідники.Валюти_Const.Код, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Валюти_Select.Select();
            store.RemoveAll();
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_6_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Валюти_Const.Код].ToString() ?? "",
                            Назва = fields[Валюти_Const.Назва].ToString() ?? "",
                            КороткаНазва = fields[Валюти_Const.КороткаНазва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Контрагенти"
        
    public partial class Контрагенти_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_7_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_7_1? row = (GeneratedCode.Rows.Row_7_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_7_1? row = (GeneratedCode.Rows.Row_7_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_7_1? row = (GeneratedCode.Rows.Row_7_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_7_1? row = (GeneratedCode.Rows.Row_7_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Папка);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Папка", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_7_1? row = (GeneratedCode.Rows.Row_7_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Постачальник);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Постачальник", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_7_1? row = (GeneratedCode.Rows.Row_7_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Покупець);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Покупець", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Контрагенти_Select Контрагенти_Select = new();
            Контрагенти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Контрагенти_Const.Код,
                /*Назва*/ Довідники.Контрагенти_Const.Назва,
                /*Постачальник*/ Довідники.Контрагенти_Const.Постачальник,
                /*Покупець*/ Довідники.Контрагенти_Const.Покупець,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Контрагенти_Select.QuerySelect.Where = (List<Where>)where;

            Контрагенти_Select.QuerySelect.Order.Add(
               Довідники.Контрагенти_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Контрагенти_Папки_Pointer.GetJoin(Контрагенти_Select.QuerySelect, Довідники.Контрагенти_Const.Папка,
                Контрагенти_Select.QuerySelect.Table, "join_tab_1", "Папка");
            
            await Контрагенти_Select.Select();
            store.RemoveAll();
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_7_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Контрагенти_Const.Код].ToString() ?? "",
                            Назва = fields[Контрагенти_Const.Назва].ToString() ?? "",
                            Папка = fields["Папка"].ToString() ?? "",
                            Постачальник = (fields[Контрагенти_Const.Постачальник] != DBNull.Value ? (bool)fields[Контрагенти_Const.Постачальник] : false) ? "Так" : "",
                            Покупець = (fields[Контрагенти_Const.Покупець] != DBNull.Value ? (bool)fields[Контрагенти_Const.Покупець] : false) ? "Так" : "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Контрагенти_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_7_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_7_2? row = (GeneratedCode.Rows.Row_7_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_7_2? row = (GeneratedCode.Rows.Row_7_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_7_2? row = (GeneratedCode.Rows.Row_7_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Контрагенти_Select Контрагенти_Select = new();
            Контрагенти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Контрагенти_Const.Код,
                /*Назва*/ Довідники.Контрагенти_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Контрагенти_Select.QuerySelect.Where = (List<Where>)where;

            Контрагенти_Select.QuerySelect.Order.Add(
               Довідники.Контрагенти_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Контрагенти_Select.Select();
            store.RemoveAll();
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_7_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Контрагенти_Const.Код].ToString() ?? "",
                            Назва = fields[Контрагенти_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Склади"
        
    public partial class Склади_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_8_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_8_1? row = (GeneratedCode.Rows.Row_8_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_8_1? row = (GeneratedCode.Rows.Row_8_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_8_1? row = (GeneratedCode.Rows.Row_8_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_8_1? row = (GeneratedCode.Rows.Row_8_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ТипСкладу);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Тип cкладу", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_8_1? row = (GeneratedCode.Rows.Row_8_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.НалаштуванняАдресногоЗберігання);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Адресне зберігання", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Склади_Select Склади_Select = new();
            Склади_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Склади_Const.Код,
                /*Назва*/ Довідники.Склади_Const.Назва,
                /*ТипСкладу*/ Довідники.Склади_Const.ТипСкладу,
                /*НалаштуванняАдресногоЗберігання*/ Довідники.Склади_Const.НалаштуванняАдресногоЗберігання,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Склади_Select.QuerySelect.Where = (List<Where>)where;

            Склади_Select.QuerySelect.Order.Add(
               Довідники.Склади_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Склади_Select.Select();
            store.RemoveAll();
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_8_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Склади_Const.Код].ToString() ?? "",
                            Назва = fields[Склади_Const.Назва].ToString() ?? "",
                            ТипСкладу = Перелічення.ПсевдонімиПерелічення.ТипиСкладів_Alias((
                              (Перелічення.ТипиСкладів)(fields[Склади_Const.ТипСкладу] != DBNull.Value ? fields[Склади_Const.ТипСкладу] : 0)) ),
                            НалаштуванняАдресногоЗберігання = Перелічення.ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Alias((
                              (Перелічення.НалаштуванняАдресногоЗберігання)(fields[Склади_Const.НалаштуванняАдресногоЗберігання] != DBNull.Value ? fields[Склади_Const.НалаштуванняАдресногоЗберігання] : 0)) ),
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Склади_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_8_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_8_2? row = (GeneratedCode.Rows.Row_8_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_8_2? row = (GeneratedCode.Rows.Row_8_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_8_2? row = (GeneratedCode.Rows.Row_8_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Склади_Select Склади_Select = new();
            Склади_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Склади_Const.Код,
                /*Назва*/ Довідники.Склади_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Склади_Select.QuerySelect.Where = (List<Where>)where;

            Склади_Select.QuerySelect.Order.Add(
               Довідники.Склади_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Склади_Select.Select();
            store.RemoveAll();
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_8_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Склади_Const.Код].ToString() ?? "",
                            Назва = fields[Склади_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЦін"
        
    public partial class ВидиЦін_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_9_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_9_1? row = (GeneratedCode.Rows.Row_9_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_9_1? row = (GeneratedCode.Rows.Row_9_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_9_1? row = (GeneratedCode.Rows.Row_9_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_9_1? row = (GeneratedCode.Rows.Row_9_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Валюта);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ВидиЦін_Select ВидиЦін_Select = new();
            ВидиЦін_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиЦін_Const.Код,
                /*Назва*/ Довідники.ВидиЦін_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ВидиЦін_Select.QuerySelect.Where = (List<Where>)where;

            ВидиЦін_Select.QuerySelect.Order.Add(
               Довідники.ВидиЦін_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Валюти_Pointer.GetJoin(ВидиЦін_Select.QuerySelect, Довідники.ВидиЦін_Const.Валюта,
                ВидиЦін_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await ВидиЦін_Select.Select();
            store.RemoveAll();
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_9_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиЦін_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиЦін_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class ВидиЦін_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_9_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_9_2? row = (GeneratedCode.Rows.Row_9_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_9_2? row = (GeneratedCode.Rows.Row_9_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ВидиЦін_Select ВидиЦін_Select = new();
            ВидиЦін_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ВидиЦін_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ВидиЦін_Select.QuerySelect.Where = (List<Where>)where;

            ВидиЦін_Select.QuerySelect.Order.Add(
               Довідники.ВидиЦін_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ВидиЦін_Select.Select();
            store.RemoveAll();
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_9_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ВидиЦін_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЦінПостачальників"
        
    public partial class ВидиЦінПостачальників_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_10_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_10_1? row = (GeneratedCode.Rows.Row_10_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_10_1? row = (GeneratedCode.Rows.Row_10_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_10_1? row = (GeneratedCode.Rows.Row_10_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ВидиЦінПостачальників_Select ВидиЦінПостачальників_Select = new();
            ВидиЦінПостачальників_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиЦінПостачальників_Const.Код,
                /*Назва*/ Довідники.ВидиЦінПостачальників_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ВидиЦінПостачальників_Select.QuerySelect.Where = (List<Where>)where;

            ВидиЦінПостачальників_Select.QuerySelect.Order.Add(
               Довідники.ВидиЦінПостачальників_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ВидиЦінПостачальників_Select.Select();
            store.RemoveAll();
            while (ВидиЦінПостачальників_Select.MoveNext())
            {
                Довідники.ВидиЦінПостачальників_Pointer? curr = ВидиЦінПостачальників_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_10_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиЦінПостачальників_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиЦінПостачальників_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Користувачі"
        
    public partial class Користувачі_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_11_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_11_1? row = (GeneratedCode.Rows.Row_11_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_11_1? row = (GeneratedCode.Rows.Row_11_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_11_1? row = (GeneratedCode.Rows.Row_11_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Користувачі_Select Користувачі_Select = new();
            Користувачі_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Користувачі_Const.Код,
                /*Назва*/ Довідники.Користувачі_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Користувачі_Select.QuerySelect.Where = (List<Where>)where;

            Користувачі_Select.QuerySelect.Order.Add(
               Довідники.Користувачі_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Користувачі_Select.Select();
            store.RemoveAll();
            while (Користувачі_Select.MoveNext())
            {
                Довідники.Користувачі_Pointer? curr = Користувачі_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_11_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Користувачі_Const.Код].ToString() ?? "",
                            Назва = fields[Користувачі_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ФізичніОсоби"
        
    public partial class ФізичніОсоби_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_12_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_12_1? row = (GeneratedCode.Rows.Row_12_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_12_1? row = (GeneratedCode.Rows.Row_12_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_12_1? row = (GeneratedCode.Rows.Row_12_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ФізичніОсоби_Select ФізичніОсоби_Select = new();
            ФізичніОсоби_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ФізичніОсоби_Const.Код,
                /*Назва*/ Довідники.ФізичніОсоби_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ФізичніОсоби_Select.QuerySelect.Where = (List<Where>)where;

            ФізичніОсоби_Select.QuerySelect.Order.Add(
               Довідники.ФізичніОсоби_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ФізичніОсоби_Select.Select();
            store.RemoveAll();
            while (ФізичніОсоби_Select.MoveNext())
            {
                Довідники.ФізичніОсоби_Pointer? curr = ФізичніОсоби_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_12_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ФізичніОсоби_Const.Код].ToString() ?? "",
                            Назва = fields[ФізичніОсоби_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СтруктураПідприємства"
        
    public partial class СтруктураПідприємства_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_13_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_13_1? row = (GeneratedCode.Rows.Row_13_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_13_1? row = (GeneratedCode.Rows.Row_13_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_13_1? row = (GeneratedCode.Rows.Row_13_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.СтруктураПідприємства_Select СтруктураПідприємства_Select = new();
            СтруктураПідприємства_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.СтруктураПідприємства_Const.Код,
                /*Назва*/ Довідники.СтруктураПідприємства_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) СтруктураПідприємства_Select.QuerySelect.Where = (List<Where>)where;

            СтруктураПідприємства_Select.QuerySelect.Order.Add(
               Довідники.СтруктураПідприємства_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await СтруктураПідприємства_Select.Select();
            store.RemoveAll();
            while (СтруктураПідприємства_Select.MoveNext())
            {
                Довідники.СтруктураПідприємства_Pointer? curr = СтруктураПідприємства_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_13_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[СтруктураПідприємства_Const.Код].ToString() ?? "",
                            Назва = fields[СтруктураПідприємства_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "КраїниСвіту"
        
    public partial class КраїниСвіту_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_14_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_14_1? row = (GeneratedCode.Rows.Row_14_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_14_1? row = (GeneratedCode.Rows.Row_14_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_14_1? row = (GeneratedCode.Rows.Row_14_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.КраїниСвіту_Select КраїниСвіту_Select = new();
            КраїниСвіту_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.КраїниСвіту_Const.Код,
                /*Назва*/ Довідники.КраїниСвіту_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) КраїниСвіту_Select.QuerySelect.Where = (List<Where>)where;

            КраїниСвіту_Select.QuerySelect.Order.Add(
               Довідники.КраїниСвіту_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await КраїниСвіту_Select.Select();
            store.RemoveAll();
            while (КраїниСвіту_Select.MoveNext())
            {
                Довідники.КраїниСвіту_Pointer? curr = КраїниСвіту_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_14_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[КраїниСвіту_Const.Код].ToString() ?? "",
                            Назва = fields[КраїниСвіту_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Файли"
        
    public partial class Файли_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_15_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_15_1? row = (GeneratedCode.Rows.Row_15_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_15_1? row = (GeneratedCode.Rows.Row_15_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_15_1? row = (GeneratedCode.Rows.Row_15_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_15_1? row = (GeneratedCode.Rows.Row_15_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.НазваФайлу);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва файлу", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_15_1? row = (GeneratedCode.Rows.Row_15_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Розмір);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Розмір", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_15_1? row = (GeneratedCode.Rows.Row_15_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ДатаСтворення);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Дата створення", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Файли_Select Файли_Select = new();
            Файли_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Файли_Const.Код,
                /*Назва*/ Довідники.Файли_Const.Назва,
                /*НазваФайлу*/ Довідники.Файли_Const.НазваФайлу,
                /*Розмір*/ Довідники.Файли_Const.Розмір,
                /*ДатаСтворення*/ Довідники.Файли_Const.ДатаСтворення,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Файли_Select.QuerySelect.Where = (List<Where>)where;

            Файли_Select.QuerySelect.Order.Add(
               Довідники.Файли_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Файли_Select.Select();
            store.RemoveAll();
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_15_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Файли_Const.Код].ToString() ?? "",
                            Назва = fields[Файли_Const.Назва].ToString() ?? "",
                            НазваФайлу = fields[Файли_Const.НазваФайлу].ToString() ?? "",
                            Розмір = fields[Файли_Const.Розмір].ToString() ?? "",
                            ДатаСтворення = fields[Файли_Const.ДатаСтворення].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Файли_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_15_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_15_2? row = (GeneratedCode.Rows.Row_15_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_15_2? row = (GeneratedCode.Rows.Row_15_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Файли_Select Файли_Select = new();
            Файли_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Файли_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Файли_Select.QuerySelect.Where = (List<Where>)where;

            Файли_Select.QuerySelect.Order.Add(
               Довідники.Файли_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Файли_Select.Select();
            store.RemoveAll();
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_15_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Файли_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ХарактеристикиНоменклатури"
        
    public partial class ХарактеристикиНоменклатури_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_16_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_16_1? row = (GeneratedCode.Rows.Row_16_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_16_1? row = (GeneratedCode.Rows.Row_16_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_16_1? row = (GeneratedCode.Rows.Row_16_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Номенклатура);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Номенклатура", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_16_1? row = (GeneratedCode.Rows.Row_16_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_16_1? row = (GeneratedCode.Rows.Row_16_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Залишки);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Залишки", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_16_1? row = (GeneratedCode.Rows.Row_16_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВРезерві);
                };

                ColumnViewColumn column = ColumnViewColumn.New("В резерві", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_16_1? row = (GeneratedCode.Rows.Row_16_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВРезервіПідЗамовлення);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Під замовлення", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ХарактеристикиНоменклатури_Select ХарактеристикиНоменклатури_Select = new();
            ХарактеристикиНоменклатури_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ХарактеристикиНоменклатури_Const.Код,
                /*Назва*/ Довідники.ХарактеристикиНоменклатури_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ХарактеристикиНоменклатури_Select.QuerySelect.Where = (List<Where>)where;

            ХарактеристикиНоменклатури_Select.QuerySelect.Order.Add(
               Довідники.ХарактеристикиНоменклатури_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Номенклатура_Pointer.GetJoin(ХарактеристикиНоменклатури_Select.QuerySelect, Довідники.ХарактеристикиНоменклатури_Const.Номенклатура,
                ХарактеристикиНоменклатури_Select.QuerySelect.Table, "join_tab_1", "Номенклатура");
            
                /* Додаткове поле: Залишки */
                ХарактеристикиНоменклатури_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ХарактеристикаНоменклатури} AS Характеристика, SUM(ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ВНаявності}) AS ВНаявності FROM {РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.TABLE} AS ТовариНаСкладах WHERE ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.{Довідники.ХарактеристикиНоменклатури_Const.Номенклатура} AND ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ХарактеристикаНоменклатури} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.uid GROUP BY Характеристика ) SELECT ROUND(ВНаявності, 1) FROM Залишки)", "Залишки"));
            
                /* Додаткове поле: ВРезерві */
                ХарактеристикиНоменклатури_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} AS Характеристика, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіЗіСкладу}) AS ВРезервіЗіСкладу FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.{Довідники.ХарактеристикиНоменклатури_Const.Номенклатура} AND ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.uid GROUP BY Характеристика ) SELECT ROUND(ВРезервіЗіСкладу, 1) FROM Залишки)", "ВРезерві"));
            
                /* Додаткове поле: ВРезервіПідЗамовлення */
                ХарактеристикиНоменклатури_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} AS Характеристика, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіПідЗамовлення}) AS ВРезервіПідЗамовлення FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.{Довідники.ХарактеристикиНоменклатури_Const.Номенклатура} AND ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.uid GROUP BY Характеристика ) SELECT ROUND(ВРезервіПідЗамовлення, 1) FROM Залишки)", "ВРезервіПідЗамовлення"));
            
            await ХарактеристикиНоменклатури_Select.Select();
            store.RemoveAll();
            while (ХарактеристикиНоменклатури_Select.MoveNext())
            {
                Довідники.ХарактеристикиНоменклатури_Pointer? curr = ХарактеристикиНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_16_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ХарактеристикиНоменклатури_Const.Код].ToString() ?? "",
                            Номенклатура = fields["Номенклатура"].ToString() ?? "",
                            Назва = fields[ХарактеристикиНоменклатури_Const.Назва].ToString() ?? "",
                            Залишки = fields["Залишки"].ToString() ?? "",
                        ВРезерві = fields["ВРезерві"].ToString() ?? "",
                        ВРезервіПідЗамовлення = fields["ВРезервіПідЗамовлення"].ToString() ?? "",
                        
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Номенклатура_Папки"
        
    public partial class Номенклатура_Папки_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_17_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_17_1? row = (GeneratedCode.Rows.Row_17_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_17_1? row = (GeneratedCode.Rows.Row_17_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_17_1? row = (GeneratedCode.Rows.Row_17_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Номенклатура_Папки_SelectHierarchical Номенклатура_Папки_Select = new();
            Номенклатура_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Номенклатура_Папки_Const.Назва,
                /*Код*/ Довідники.Номенклатура_Папки_Const.Код,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Номенклатура_Папки_Select.QuerySelect.Where = (List<Where>)where;

            Номенклатура_Папки_Select.QuerySelect.Order.Add(
               Довідники.Номенклатура_Папки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Номенклатура_Папки_Select.Select();
            store.RemoveAll();
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_17_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Номенклатура_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Номенклатура_Папки_Const.Код].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Номенклатура_Папки_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_17_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_17_2? row = (GeneratedCode.Rows.Row_17_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_17_2? row = (GeneratedCode.Rows.Row_17_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_17_2? row = (GeneratedCode.Rows.Row_17_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Номенклатура_Папки_SelectHierarchical Номенклатура_Папки_Select = new();
            Номенклатура_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Номенклатура_Папки_Const.Назва,
                /*Код*/ Довідники.Номенклатура_Папки_Const.Код,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Номенклатура_Папки_Select.QuerySelect.Where = (List<Where>)where;

            Номенклатура_Папки_Select.QuerySelect.Order.Add(
               Довідники.Номенклатура_Папки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Номенклатура_Папки_Select.Select();
            store.RemoveAll();
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_17_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Номенклатура_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Номенклатура_Папки_Const.Код].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Контрагенти_Папки"
        
    public partial class Контрагенти_Папки_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_18_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_18_1? row = (GeneratedCode.Rows.Row_18_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_18_1? row = (GeneratedCode.Rows.Row_18_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_18_1? row = (GeneratedCode.Rows.Row_18_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Контрагенти_Папки_SelectHierarchical Контрагенти_Папки_Select = new();
            Контрагенти_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Контрагенти_Папки_Const.Назва,
                /*Код*/ Довідники.Контрагенти_Папки_Const.Код,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Контрагенти_Папки_Select.QuerySelect.Where = (List<Where>)where;

            Контрагенти_Папки_Select.QuerySelect.Order.Add(
               Довідники.Контрагенти_Папки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Контрагенти_Папки_Select.Select();
            store.RemoveAll();
            while (Контрагенти_Папки_Select.MoveNext())
            {
                Довідники.Контрагенти_Папки_Pointer? curr = Контрагенти_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_18_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Контрагенти_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Контрагенти_Папки_Const.Код].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Склади_Папки"
        
    public partial class Склади_Папки_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_19_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_19_1? row = (GeneratedCode.Rows.Row_19_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_19_1? row = (GeneratedCode.Rows.Row_19_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_19_1? row = (GeneratedCode.Rows.Row_19_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Склади_Папки_SelectHierarchical Склади_Папки_Select = new();
            Склади_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Склади_Папки_Const.Назва,
                /*Код*/ Довідники.Склади_Папки_Const.Код,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Склади_Папки_Select.QuerySelect.Where = (List<Where>)where;

            Склади_Папки_Select.QuerySelect.Order.Add(
               Довідники.Склади_Папки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Склади_Папки_Select.Select();
            store.RemoveAll();
            while (Склади_Папки_Select.MoveNext())
            {
                Довідники.Склади_Папки_Pointer? curr = Склади_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_19_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Склади_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Склади_Папки_Const.Код].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Каси"
        
    public partial class Каси_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_20_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_20_1? row = (GeneratedCode.Rows.Row_20_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_20_1? row = (GeneratedCode.Rows.Row_20_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_20_1? row = (GeneratedCode.Rows.Row_20_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_20_1? row = (GeneratedCode.Rows.Row_20_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Валюта);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_20_1? row = (GeneratedCode.Rows.Row_20_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Залишок);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Залишок", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Каси_Select Каси_Select = new();
            Каси_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Каси_Const.Код,
                /*Назва*/ Довідники.Каси_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Каси_Select.QuerySelect.Where = (List<Where>)where;

            Каси_Select.QuerySelect.Order.Add(
               Довідники.Каси_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Валюти_Pointer.GetJoin(Каси_Select.QuerySelect, Довідники.Каси_Const.Валюта,
                Каси_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
                /* Додаткове поле: Залишок */
                Каси_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(SELECT ROUND(РухКоштів.{РегістриНакопичення.РухКоштів_Підсумки_TablePart.Сума}, 2) AS Сума FROM {РегістриНакопичення.РухКоштів_Підсумки_TablePart.TABLE} AS РухКоштів WHERE РухКоштів.{РегістриНакопичення.РухКоштів_Підсумки_TablePart.Каса} = {Довідники.Каси_Const.TABLE}.uid)", "Залишок"));
            
            await Каси_Select.Select();
            store.RemoveAll();
            while (Каси_Select.MoveNext())
            {
                Довідники.Каси_Pointer? curr = Каси_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_20_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Каси_Const.Код].ToString() ?? "",
                            Назва = fields[Каси_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            Залишок = fields["Залишок"].ToString() ?? "",
                        
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Каси_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_20_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_20_2? row = (GeneratedCode.Rows.Row_20_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_20_2? row = (GeneratedCode.Rows.Row_20_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_20_2? row = (GeneratedCode.Rows.Row_20_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_20_2? row = (GeneratedCode.Rows.Row_20_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Валюта);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Каси_Select Каси_Select = new();
            Каси_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Каси_Const.Код,
                /*Назва*/ Довідники.Каси_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Каси_Select.QuerySelect.Where = (List<Where>)where;

            Каси_Select.QuerySelect.Order.Add(
               Довідники.Каси_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Валюти_Pointer.GetJoin(Каси_Select.QuerySelect, Довідники.Каси_Const.Валюта,
                Каси_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await Каси_Select.Select();
            store.RemoveAll();
            while (Каси_Select.MoveNext())
            {
                Довідники.Каси_Pointer? curr = Каси_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_20_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Каси_Const.Код].ToString() ?? "",
                            Назва = fields[Каси_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "БанківськіРахункиОрганізацій"
        
    public partial class БанківськіРахункиОрганізацій_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_21_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_21_1? row = (GeneratedCode.Rows.Row_21_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_21_1? row = (GeneratedCode.Rows.Row_21_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_21_1? row = (GeneratedCode.Rows.Row_21_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_21_1? row = (GeneratedCode.Rows.Row_21_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Валюта);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.БанківськіРахункиОрганізацій_Select БанківськіРахункиОрганізацій_Select = new();
            БанківськіРахункиОрганізацій_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.БанківськіРахункиОрганізацій_Const.Код,
                /*Назва*/ Довідники.БанківськіРахункиОрганізацій_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) БанківськіРахункиОрганізацій_Select.QuerySelect.Where = (List<Where>)where;

            БанківськіРахункиОрганізацій_Select.QuerySelect.Order.Add(
               Довідники.БанківськіРахункиОрганізацій_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиОрганізацій_Select.QuerySelect, Довідники.БанківськіРахункиОрганізацій_Const.Валюта,
                БанківськіРахункиОрганізацій_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await БанківськіРахункиОрганізацій_Select.Select();
            store.RemoveAll();
            while (БанківськіРахункиОрганізацій_Select.MoveNext())
            {
                Довідники.БанківськіРахункиОрганізацій_Pointer? curr = БанківськіРахункиОрганізацій_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_21_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[БанківськіРахункиОрганізацій_Const.Код].ToString() ?? "",
                            Назва = fields[БанківськіРахункиОрганізацій_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ДоговориКонтрагентів"
        
    public partial class ДоговориКонтрагентів_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_22_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_22_1? row = (GeneratedCode.Rows.Row_22_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_22_1? row = (GeneratedCode.Rows.Row_22_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_22_1? row = (GeneratedCode.Rows.Row_22_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_22_1? row = (GeneratedCode.Rows.Row_22_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Контрагент);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Контрагент", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_22_1? row = (GeneratedCode.Rows.Row_22_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ТипДоговору);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Тип", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ДоговориКонтрагентів_Select ДоговориКонтрагентів_Select = new();
            ДоговориКонтрагентів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ДоговориКонтрагентів_Const.Код,
                /*Назва*/ Довідники.ДоговориКонтрагентів_Const.Назва,
                /*ТипДоговору*/ Довідники.ДоговориКонтрагентів_Const.ТипДоговору,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ДоговориКонтрагентів_Select.QuerySelect.Where = (List<Where>)where;

            ДоговориКонтрагентів_Select.QuerySelect.Order.Add(
               Довідники.ДоговориКонтрагентів_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
                ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");
            
            await ДоговориКонтрагентів_Select.Select();
            store.RemoveAll();
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_22_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ДоговориКонтрагентів_Const.Код].ToString() ?? "",
                            Назва = fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "",
                            Контрагент = fields["Контрагент"].ToString() ?? "",
                            ТипДоговору = Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((
                              (Перелічення.ТипДоговорів)(fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0)) ),
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class ДоговориКонтрагентів_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_22_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_22_2? row = (GeneratedCode.Rows.Row_22_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_22_2? row = (GeneratedCode.Rows.Row_22_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_22_2? row = (GeneratedCode.Rows.Row_22_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Контрагент);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Контрагент", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_22_2? row = (GeneratedCode.Rows.Row_22_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ТипДоговору);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Тип", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ДоговориКонтрагентів_Select ДоговориКонтрагентів_Select = new();
            ДоговориКонтрагентів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ДоговориКонтрагентів_Const.Назва,
                /*ТипДоговору*/ Довідники.ДоговориКонтрагентів_Const.ТипДоговору,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ДоговориКонтрагентів_Select.QuerySelect.Where = (List<Where>)where;

            ДоговориКонтрагентів_Select.QuerySelect.Order.Add(
               Довідники.ДоговориКонтрагентів_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
                ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");
            
            await ДоговориКонтрагентів_Select.Select();
            store.RemoveAll();
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_22_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "",
                            Контрагент = fields["Контрагент"].ToString() ?? "",
                            ТипДоговору = Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((
                              (Перелічення.ТипДоговорів)(fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0)) ),
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "БанківськіРахункиКонтрагентів"
        
    public partial class БанківськіРахункиКонтрагентів_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_23_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_23_1? row = (GeneratedCode.Rows.Row_23_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_23_1? row = (GeneratedCode.Rows.Row_23_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_23_1? row = (GeneratedCode.Rows.Row_23_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_23_1? row = (GeneratedCode.Rows.Row_23_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Валюта);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.БанківськіРахункиКонтрагентів_Select БанківськіРахункиКонтрагентів_Select = new();
            БанківськіРахункиКонтрагентів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.БанківськіРахункиКонтрагентів_Const.Код,
                /*Назва*/ Довідники.БанківськіРахункиКонтрагентів_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) БанківськіРахункиКонтрагентів_Select.QuerySelect.Where = (List<Where>)where;

            БанківськіРахункиКонтрагентів_Select.QuerySelect.Order.Add(
               Довідники.БанківськіРахункиКонтрагентів_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиКонтрагентів_Select.QuerySelect, Довідники.БанківськіРахункиКонтрагентів_Const.Валюта,
                БанківськіРахункиКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await БанківськіРахункиКонтрагентів_Select.Select();
            store.RemoveAll();
            while (БанківськіРахункиКонтрагентів_Select.MoveNext())
            {
                Довідники.БанківськіРахункиКонтрагентів_Pointer? curr = БанківськіРахункиКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_23_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[БанківськіРахункиКонтрагентів_Const.Код].ToString() ?? "",
                            Назва = fields[БанківськіРахункиКонтрагентів_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СтаттяРухуКоштів"
        
    public partial class СтаттяРухуКоштів_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_24_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_24_1? row = (GeneratedCode.Rows.Row_24_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_24_1? row = (GeneratedCode.Rows.Row_24_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_24_1? row = (GeneratedCode.Rows.Row_24_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_24_1? row = (GeneratedCode.Rows.Row_24_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КореспондуючийРахунок);
                };

                ColumnViewColumn column = ColumnViewColumn.New("КореспондуючийРахунок", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_24_1? row = (GeneratedCode.Rows.Row_24_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВидРухуКоштів);
                };

                ColumnViewColumn column = ColumnViewColumn.New("ВидРухуКоштів", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.СтаттяРухуКоштів_Select СтаттяРухуКоштів_Select = new();
            СтаттяРухуКоштів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СтаттяРухуКоштів_Const.Назва,
                /*Код*/ Довідники.СтаттяРухуКоштів_Const.Код,
                /*КореспондуючийРахунок*/ Довідники.СтаттяРухуКоштів_Const.КореспондуючийРахунок,
                /*ВидРухуКоштів*/ Довідники.СтаттяРухуКоштів_Const.ВидРухуКоштів,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) СтаттяРухуКоштів_Select.QuerySelect.Where = (List<Where>)where;

            СтаттяРухуКоштів_Select.QuerySelect.Order.Add(
               Довідники.СтаттяРухуКоштів_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await СтаттяРухуКоштів_Select.Select();
            store.RemoveAll();
            while (СтаттяРухуКоштів_Select.MoveNext())
            {
                Довідники.СтаттяРухуКоштів_Pointer? curr = СтаттяРухуКоштів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_24_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СтаттяРухуКоштів_Const.Назва].ToString() ?? "",
                            Код = fields[СтаттяРухуКоштів_Const.Код].ToString() ?? "",
                            КореспондуючийРахунок = fields[СтаттяРухуКоштів_Const.КореспондуючийРахунок].ToString() ?? "",
                            ВидРухуКоштів = Перелічення.ПсевдонімиПерелічення.ВидиРухуКоштів_Alias((
                              (Перелічення.ВидиРухуКоштів)(fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] != DBNull.Value ? fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] : 0)) ),
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СеріїНоменклатури"
        
    public partial class СеріїНоменклатури_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_25_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_25_1? row = (GeneratedCode.Rows.Row_25_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_25_1? row = (GeneratedCode.Rows.Row_25_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Номер);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Номер", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.СеріїНоменклатури_Select СеріїНоменклатури_Select = new();
            СеріїНоменклатури_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Номер*/ Довідники.СеріїНоменклатури_Const.Номер,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) СеріїНоменклатури_Select.QuerySelect.Where = (List<Where>)where;

            СеріїНоменклатури_Select.QuerySelect.Order.Add(
               Довідники.СеріїНоменклатури_Const.Номер, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await СеріїНоменклатури_Select.Select();
            store.RemoveAll();
            while (СеріїНоменклатури_Select.MoveNext())
            {
                Довідники.СеріїНоменклатури_Pointer? curr = СеріїНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_25_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Номер = fields[СеріїНоменклатури_Const.Номер].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ПартіяТоварівКомпозит"
        
    public partial class ПартіяТоварівКомпозит_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_26_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_26_1? row = (GeneratedCode.Rows.Row_26_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_1? row = (GeneratedCode.Rows.Row_26_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_1? row = (GeneratedCode.Rows.Row_26_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Дата);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Дата", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_1? row = (GeneratedCode.Rows.Row_26_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ТипДокументу);
                };

                ColumnViewColumn column = ColumnViewColumn.New("ТипДокументу", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_1? row = (GeneratedCode.Rows.Row_26_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ПоступленняТоварівТаПослуг);
                };

                ColumnViewColumn column = ColumnViewColumn.New("ПоступленняТоварівТаПослуг", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_1? row = (GeneratedCode.Rows.Row_26_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ВведенняЗалишків);
                };

                ColumnViewColumn column = ColumnViewColumn.New("ВведенняЗалишків", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_1? row = (GeneratedCode.Rows.Row_26_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Залишки);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Залишки", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ПартіяТоварівКомпозит_Select ПартіяТоварівКомпозит_Select = new();
            ПартіяТоварівКомпозит_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ПартіяТоварівКомпозит_Const.Назва,
                /*Дата*/ Довідники.ПартіяТоварівКомпозит_Const.Дата,
                /*ТипДокументу*/ Довідники.ПартіяТоварівКомпозит_Const.ТипДокументу,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ПартіяТоварівКомпозит_Select.QuerySelect.Where = (List<Where>)where;

            ПартіяТоварівКомпозит_Select.QuerySelect.Order.Add(
               Довідники.ПартіяТоварівКомпозит_Const.Дата, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Документи.ПоступленняТоварівТаПослуг_Pointer.GetJoin(ПартіяТоварівКомпозит_Select.QuerySelect, Довідники.ПартіяТоварівКомпозит_Const.ПоступленняТоварівТаПослуг,
                ПартіяТоварівКомпозит_Select.QuerySelect.Table, "join_tab_1", "ПоступленняТоварівТаПослуг");
            Документи.ВведенняЗалишків_Pointer.GetJoin(ПартіяТоварівКомпозит_Select.QuerySelect, Довідники.ПартіяТоварівКомпозит_Const.ВведенняЗалишків,
                ПартіяТоварівКомпозит_Select.QuerySelect.Table, "join_tab_2", "ВведенняЗалишків");
            
                /* Додаткове поле: Залишки */
                ПартіяТоварівКомпозит_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ПартіїТоварів.{РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.ПартіяТоварівКомпозит} AS ПартіяТоварівКомпозит, SUM(ПартіїТоварів.{РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.Кількість} ) AS Кількість FROM {РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.TABLE} AS ПартіїТоварів WHERE ПартіїТоварів.{РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.ПартіяТоварівКомпозит} = {Довідники.ПартіяТоварівКомпозит_Const.TABLE}.uid GROUP BY ПартіяТоварівКомпозит ) SELECT ROUND(Кількість, 1) FROM Залишки)", "Залишки"));
            
            await ПартіяТоварівКомпозит_Select.Select();
            store.RemoveAll();
            while (ПартіяТоварівКомпозит_Select.MoveNext())
            {
                Довідники.ПартіяТоварівКомпозит_Pointer? curr = ПартіяТоварівКомпозит_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_26_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ПартіяТоварівКомпозит_Const.Назва].ToString() ?? "",
                            Дата = fields[ПартіяТоварівКомпозит_Const.Дата].ToString() ?? "",
                            ТипДокументу = Перелічення.ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_Alias((
                              (Перелічення.ТипДокументуПартіяТоварівКомпозит)(fields[ПартіяТоварівКомпозит_Const.ТипДокументу] != DBNull.Value ? fields[ПартіяТоварівКомпозит_Const.ТипДокументу] : 0)) ),
                            ПоступленняТоварівТаПослуг = fields["ПоступленняТоварівТаПослуг"].ToString() ?? "",
                            ВведенняЗалишків = fields["ВведенняЗалишків"].ToString() ?? "",
                            Залишки = fields["Залишки"].ToString() ?? "",
                        
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class ПартіяТоварівКомпозит_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_26_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_26_2? row = (GeneratedCode.Rows.Row_26_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_2? row = (GeneratedCode.Rows.Row_26_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_26_2? row = (GeneratedCode.Rows.Row_26_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Дата);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Дата", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ПартіяТоварівКомпозит_Select ПартіяТоварівКомпозит_Select = new();
            ПартіяТоварівКомпозит_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ПартіяТоварівКомпозит_Const.Назва,
                /*Дата*/ Довідники.ПартіяТоварівКомпозит_Const.Дата,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ПартіяТоварівКомпозит_Select.QuerySelect.Where = (List<Where>)where;

            ПартіяТоварівКомпозит_Select.QuerySelect.Order.Add(
               Довідники.ПартіяТоварівКомпозит_Const.Дата, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ПартіяТоварівКомпозит_Select.Select();
            store.RemoveAll();
            while (ПартіяТоварівКомпозит_Select.MoveNext())
            {
                Довідники.ПартіяТоварівКомпозит_Pointer? curr = ПартіяТоварівКомпозит_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_26_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ПартіяТоварівКомпозит_Const.Назва].ToString() ?? "",
                            Дата = fields[ПартіяТоварівКомпозит_Const.Дата].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЗапасів"
        
    public partial class ВидиЗапасів_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_27_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_27_1? row = (GeneratedCode.Rows.Row_27_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_27_1? row = (GeneratedCode.Rows.Row_27_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_27_1? row = (GeneratedCode.Rows.Row_27_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ВидиЗапасів_Select ВидиЗапасів_Select = new();
            ВидиЗапасів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиЗапасів_Const.Код,
                /*Назва*/ Довідники.ВидиЗапасів_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ВидиЗапасів_Select.QuerySelect.Where = (List<Where>)where;

            ВидиЗапасів_Select.QuerySelect.Order.Add(
               Довідники.ВидиЗапасів_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ВидиЗапасів_Select.Select();
            store.RemoveAll();
            while (ВидиЗапасів_Select.MoveNext())
            {
                Довідники.ВидиЗапасів_Pointer? curr = ВидиЗапасів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_27_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиЗапасів_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиЗапасів_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Банки"
        
    public partial class Банки_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_28_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ПовнаНазва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Повна назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КодМФО);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код МФО", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КодЄДРПОУ);
                };

                ColumnViewColumn column = ColumnViewColumn.New("ЄДРПОУ", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.НомерЛіцензії);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Номер ліцензії", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ДатаЛіцензії);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Дата ліцензії", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Статус);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Статус", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ТипНаселеногоПункту);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Тип населеного пункту", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.УнікальнийКодБанку);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Унікальний код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ПоштовийІндекс);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Поштовий індекс", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.НазваНаселеногоПункту);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Населений пункт", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Адреса);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Адреса", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.НомерТелефону);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Телефон", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ДатаВідкриттяУстанови);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Дата відкриття установи", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ДатаЗакриттяУстанови);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Дата закриття установи", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КодНБУ);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код НБУ", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.КодСтатусу);
                };

                ColumnViewColumn column = ColumnViewColumn.New("КодСтатусу", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_1? row = (GeneratedCode.Rows.Row_28_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ДатаЗапису);
                };

                ColumnViewColumn column = ColumnViewColumn.New("ДатаЗапису", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Банки_Select Банки_Select = new();
            Банки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Банки_Const.Код,
                /*Назва*/ Довідники.Банки_Const.Назва,
                /*ПовнаНазва*/ Довідники.Банки_Const.ПовнаНазва,
                /*КодМФО*/ Довідники.Банки_Const.КодМФО,
                /*КодЄДРПОУ*/ Довідники.Банки_Const.КодЄДРПОУ,
                /*НомерЛіцензії*/ Довідники.Банки_Const.НомерЛіцензії,
                /*ДатаЛіцензії*/ Довідники.Банки_Const.ДатаЛіцензії,
                /*Статус*/ Довідники.Банки_Const.Статус,
                /*ТипНаселеногоПункту*/ Довідники.Банки_Const.ТипНаселеногоПункту,
                /*УнікальнийКодБанку*/ Довідники.Банки_Const.УнікальнийКодБанку,
                /*ПоштовийІндекс*/ Довідники.Банки_Const.ПоштовийІндекс,
                /*НазваНаселеногоПункту*/ Довідники.Банки_Const.НазваНаселеногоПункту,
                /*Адреса*/ Довідники.Банки_Const.Адреса,
                /*НомерТелефону*/ Довідники.Банки_Const.НомерТелефону,
                /*ДатаВідкриттяУстанови*/ Довідники.Банки_Const.ДатаВідкриттяУстанови,
                /*ДатаЗакриттяУстанови*/ Довідники.Банки_Const.ДатаЗакриттяУстанови,
                /*КодНБУ*/ Довідники.Банки_Const.КодНБУ,
                /*КодСтатусу*/ Довідники.Банки_Const.КодСтатусу,
                /*ДатаЗапису*/ Довідники.Банки_Const.ДатаЗапису,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Банки_Select.QuerySelect.Where = (List<Where>)where;

            Банки_Select.QuerySelect.Order.Add(
               Довідники.Банки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Банки_Select.Select();
            store.RemoveAll();
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_28_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Банки_Const.Код].ToString() ?? "",
                            Назва = fields[Банки_Const.Назва].ToString() ?? "",
                            ПовнаНазва = fields[Банки_Const.ПовнаНазва].ToString() ?? "",
                            КодМФО = fields[Банки_Const.КодМФО].ToString() ?? "",
                            КодЄДРПОУ = fields[Банки_Const.КодЄДРПОУ].ToString() ?? "",
                            НомерЛіцензії = fields[Банки_Const.НомерЛіцензії].ToString() ?? "",
                            ДатаЛіцензії = fields[Банки_Const.ДатаЛіцензії].ToString() ?? "",
                            Статус = fields[Банки_Const.Статус].ToString() ?? "",
                            ТипНаселеногоПункту = fields[Банки_Const.ТипНаселеногоПункту].ToString() ?? "",
                            УнікальнийКодБанку = fields[Банки_Const.УнікальнийКодБанку].ToString() ?? "",
                            ПоштовийІндекс = fields[Банки_Const.ПоштовийІндекс].ToString() ?? "",
                            НазваНаселеногоПункту = fields[Банки_Const.НазваНаселеногоПункту].ToString() ?? "",
                            Адреса = fields[Банки_Const.Адреса].ToString() ?? "",
                            НомерТелефону = fields[Банки_Const.НомерТелефону].ToString() ?? "",
                            ДатаВідкриттяУстанови = fields[Банки_Const.ДатаВідкриттяУстанови].ToString() ?? "",
                            ДатаЗакриттяУстанови = fields[Банки_Const.ДатаЗакриттяУстанови].ToString() ?? "",
                            КодНБУ = fields[Банки_Const.КодНБУ].ToString() ?? "",
                            КодСтатусу = fields[Банки_Const.КодСтатусу].ToString() ?? "",
                            ДатаЗапису = fields[Банки_Const.ДатаЗапису].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Банки_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_28_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_28_2? row = (GeneratedCode.Rows.Row_28_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_2? row = (GeneratedCode.Rows.Row_28_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_28_2? row = (GeneratedCode.Rows.Row_28_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Банки_Select Банки_Select = new();
            Банки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Банки_Const.Код,
                /*Назва*/ Довідники.Банки_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Банки_Select.QuerySelect.Where = (List<Where>)where;

            Банки_Select.QuerySelect.Order.Add(
               Довідники.Банки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Банки_Select.Select();
            store.RemoveAll();
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_28_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Банки_Const.Код].ToString() ?? "",
                            Назва = fields[Банки_Const.Назва].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіПриміщення"
        
    public partial class СкладськіПриміщення_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_29_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_29_1? row = (GeneratedCode.Rows.Row_29_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_29_1? row = (GeneratedCode.Rows.Row_29_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_29_1? row = (GeneratedCode.Rows.Row_29_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Склад);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Склад", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_29_1? row = (GeneratedCode.Rows.Row_29_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.НалаштуванняАдресногоЗберігання);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Налаштування", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.СкладськіПриміщення_Select СкладськіПриміщення_Select = new();
            СкладськіПриміщення_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СкладськіПриміщення_Const.Назва,
                /*НалаштуванняАдресногоЗберігання*/ Довідники.СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) СкладськіПриміщення_Select.QuerySelect.Where = (List<Where>)where;

            СкладськіПриміщення_Select.QuerySelect.Order.Add(
               Довідники.СкладськіПриміщення_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Склади_Pointer.GetJoin(СкладськіПриміщення_Select.QuerySelect, Довідники.СкладськіПриміщення_Const.Склад,
                СкладськіПриміщення_Select.QuerySelect.Table, "join_tab_1", "Склад");
            
            await СкладськіПриміщення_Select.Select();
            store.RemoveAll();
            while (СкладськіПриміщення_Select.MoveNext())
            {
                Довідники.СкладськіПриміщення_Pointer? curr = СкладськіПриміщення_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_29_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СкладськіПриміщення_Const.Назва].ToString() ?? "",
                            Склад = fields["Склад"].ToString() ?? "",
                            НалаштуванняАдресногоЗберігання = Перелічення.ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Alias((
                              (Перелічення.НалаштуванняАдресногоЗберігання)(fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] != DBNull.Value ? fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] : 0)) ),
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіКомірки"
        
    public partial class СкладськіКомірки_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_30_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Приміщення);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Приміщення", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Лінія);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Лінія", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Позиція);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Позиція", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Стелаж);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Стелаж", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Ярус);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Ярус", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ТипСкладськоїКомірки);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Тип комірки", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Типорозмір);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Типорозмір", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_1? row = (GeneratedCode.Rows.Row_30_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Папка);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Папка", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.СкладськіКомірки_Select СкладськіКомірки_Select = new();
            СкладськіКомірки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СкладськіКомірки_Const.Назва,
                /*Лінія*/ Довідники.СкладськіКомірки_Const.Лінія,
                /*Позиція*/ Довідники.СкладськіКомірки_Const.Позиція,
                /*Стелаж*/ Довідники.СкладськіКомірки_Const.Стелаж,
                /*Ярус*/ Довідники.СкладськіКомірки_Const.Ярус,
                /*ТипСкладськоїКомірки*/ Довідники.СкладськіКомірки_Const.ТипСкладськоїКомірки,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) СкладськіКомірки_Select.QuerySelect.Where = (List<Where>)where;

            СкладськіКомірки_Select.QuerySelect.Order.Add(
               Довідники.СкладськіКомірки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Приміщення,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            Довідники.ТипорозміриКомірок_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Типорозмір,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_2", "Типорозмір");
            Довідники.СкладськіКомірки_Папки_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Папка,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_3", "Папка");
            
            await СкладськіКомірки_Select.Select();
            store.RemoveAll();
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_30_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СкладськіКомірки_Const.Назва].ToString() ?? "",
                            Приміщення = fields["Приміщення"].ToString() ?? "",
                            Лінія = fields[СкладськіКомірки_Const.Лінія].ToString() ?? "",
                            Позиція = fields[СкладськіКомірки_Const.Позиція].ToString() ?? "",
                            Стелаж = fields[СкладськіКомірки_Const.Стелаж].ToString() ?? "",
                            Ярус = fields[СкладськіКомірки_Const.Ярус].ToString() ?? "",
                            ТипСкладськоїКомірки = Перелічення.ПсевдонімиПерелічення.ТипиСкладськихКомірок_Alias((
                              (Перелічення.ТипиСкладськихКомірок)(fields[СкладськіКомірки_Const.ТипСкладськоїКомірки] != DBNull.Value ? fields[СкладськіКомірки_Const.ТипСкладськоїКомірки] : 0)) ),
                            Типорозмір = fields["Типорозмір"].ToString() ?? "",
                            Папка = fields["Папка"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class СкладськіКомірки_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_30_2.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_30_2? row = (GeneratedCode.Rows.Row_30_2?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_2? row = (GeneratedCode.Rows.Row_30_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_30_2? row = (GeneratedCode.Rows.Row_30_2?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Приміщення);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Приміщення", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.СкладськіКомірки_Select СкладськіКомірки_Select = new();
            СкладськіКомірки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СкладськіКомірки_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) СкладськіКомірки_Select.QuerySelect.Where = (List<Where>)where;

            СкладськіКомірки_Select.QuerySelect.Order.Add(
               Довідники.СкладськіКомірки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Приміщення,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            
            await СкладськіКомірки_Select.Select();
            store.RemoveAll();
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_30_2 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СкладськіКомірки_Const.Назва].ToString() ?? "",
                            Приміщення = fields["Приміщення"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ОбластьЗберігання"
        
    public partial class ОбластьЗберігання_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_31_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_31_1? row = (GeneratedCode.Rows.Row_31_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_31_1? row = (GeneratedCode.Rows.Row_31_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_31_1? row = (GeneratedCode.Rows.Row_31_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Приміщення);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Приміщення", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ОбластьЗберігання_Select ОбластьЗберігання_Select = new();
            ОбластьЗберігання_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ОбластьЗберігання_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ОбластьЗберігання_Select.QuerySelect.Where = (List<Where>)where;

            ОбластьЗберігання_Select.QuerySelect.Order.Add(
               Довідники.ОбластьЗберігання_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.СкладськіПриміщення_Pointer.GetJoin(ОбластьЗберігання_Select.QuerySelect, Довідники.ОбластьЗберігання_Const.Приміщення,
                ОбластьЗберігання_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            
            await ОбластьЗберігання_Select.Select();
            store.RemoveAll();
            while (ОбластьЗберігання_Select.MoveNext())
            {
                Довідники.ОбластьЗберігання_Pointer? curr = ОбластьЗберігання_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_31_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ОбластьЗберігання_Const.Назва].ToString() ?? "",
                            Приміщення = fields["Приміщення"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ТипорозміриКомірок"
        
    public partial class ТипорозміриКомірок_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_32_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_32_1? row = (GeneratedCode.Rows.Row_32_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_32_1? row = (GeneratedCode.Rows.Row_32_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_32_1? row = (GeneratedCode.Rows.Row_32_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Висота);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Висота", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_32_1? row = (GeneratedCode.Rows.Row_32_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Глибина);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Глибина", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_32_1? row = (GeneratedCode.Rows.Row_32_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Вантажопідйомність);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Вантажопідйомність", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_32_1? row = (GeneratedCode.Rows.Row_32_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Обєм);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Обєм", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_32_1? row = (GeneratedCode.Rows.Row_32_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Ширина);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Ширина", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ТипорозміриКомірок_Select ТипорозміриКомірок_Select = new();
            ТипорозміриКомірок_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ТипорозміриКомірок_Const.Назва,
                /*Висота*/ Довідники.ТипорозміриКомірок_Const.Висота,
                /*Глибина*/ Довідники.ТипорозміриКомірок_Const.Глибина,
                /*Вантажопідйомність*/ Довідники.ТипорозміриКомірок_Const.Вантажопідйомність,
                /*Обєм*/ Довідники.ТипорозміриКомірок_Const.Обєм,
                /*Ширина*/ Довідники.ТипорозміриКомірок_Const.Ширина,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ТипорозміриКомірок_Select.QuerySelect.Where = (List<Where>)where;

            ТипорозміриКомірок_Select.QuerySelect.Order.Add(
               Довідники.ТипорозміриКомірок_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await ТипорозміриКомірок_Select.Select();
            store.RemoveAll();
            while (ТипорозміриКомірок_Select.MoveNext())
            {
                Довідники.ТипорозміриКомірок_Pointer? curr = ТипорозміриКомірок_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_32_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ТипорозміриКомірок_Const.Назва].ToString() ?? "",
                            Висота = fields[ТипорозміриКомірок_Const.Висота].ToString() ?? "",
                            Глибина = fields[ТипорозміриКомірок_Const.Глибина].ToString() ?? "",
                            Вантажопідйомність = fields[ТипорозміриКомірок_Const.Вантажопідйомність].ToString() ?? "",
                            Обєм = fields[ТипорозміриКомірок_Const.Обєм].ToString() ?? "",
                            Ширина = fields[ТипорозміриКомірок_Const.Ширина].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіКомірки_Папки"
        
    public partial class СкладськіКомірки_Папки_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_33_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_33_1? row = (GeneratedCode.Rows.Row_33_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_33_1? row = (GeneratedCode.Rows.Row_33_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_33_1? row = (GeneratedCode.Rows.Row_33_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_33_1? row = (GeneratedCode.Rows.Row_33_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Власник);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Власник", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.СкладськіКомірки_Папки_SelectHierarchical СкладськіКомірки_Папки_Select = new();
            СкладськіКомірки_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СкладськіКомірки_Папки_Const.Назва,
                /*Код*/ Довідники.СкладськіКомірки_Папки_Const.Код,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) СкладськіКомірки_Папки_Select.QuerySelect.Where = (List<Where>)where;

            СкладськіКомірки_Папки_Select.QuerySelect.Order.Add(
               Довідники.СкладськіКомірки_Папки_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Папки_Select.QuerySelect, Довідники.СкладськіКомірки_Папки_Const.Власник,
                СкладськіКомірки_Папки_Select.QuerySelect.Table, "join_tab_1", "Власник");
            
            await СкладськіКомірки_Папки_Select.Select();
            store.RemoveAll();
            while (СкладськіКомірки_Папки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Папки_Pointer? curr = СкладськіКомірки_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_33_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СкладськіКомірки_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[СкладськіКомірки_Папки_Const.Код].ToString() ?? "",
                            Власник = fields["Власник"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Блокнот"
        
    public partial class Блокнот_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_34_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_34_1? row = (GeneratedCode.Rows.Row_34_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_34_1? row = (GeneratedCode.Rows.Row_34_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_34_1? row = (GeneratedCode.Rows.Row_34_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_34_1? row = (GeneratedCode.Rows.Row_34_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.ДатаЗапису);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Дата", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.Блокнот_Select Блокнот_Select = new();
            Блокнот_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Блокнот_Const.Код,
                /*Назва*/ Довідники.Блокнот_Const.Назва,
                /*ДатаЗапису*/ Довідники.Блокнот_Const.ДатаЗапису,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) Блокнот_Select.QuerySelect.Where = (List<Where>)where;

            Блокнот_Select.QuerySelect.Order.Add(
               Довідники.Блокнот_Const.ДатаЗапису, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            
            await Блокнот_Select.Select();
            store.RemoveAll();
            while (Блокнот_Select.MoveNext())
            {
                Довідники.Блокнот_Pointer? curr = Блокнот_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_34_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Блокнот_Const.Код].ToString() ?? "",
                            Назва = fields[Блокнот_Const.Назва].ToString() ?? "",
                            ДатаЗапису = fields[Блокнот_Const.ДатаЗапису].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ЗбереженіЗвіти"
        
    public partial class ЗбереженіЗвіти_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_35_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_35_1? row = (GeneratedCode.Rows.Row_35_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_35_1? row = (GeneratedCode.Rows.Row_35_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Код);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Код", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_35_1? row = (GeneratedCode.Rows.Row_35_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Додано);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Додано", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_35_1? row = (GeneratedCode.Rows.Row_35_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_35_1? row = (GeneratedCode.Rows.Row_35_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Користувач);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Користувач", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.ЗбереженіЗвіти_Select ЗбереженіЗвіти_Select = new();
            ЗбереженіЗвіти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ЗбереженіЗвіти_Const.Код,
                /*Додано*/ Довідники.ЗбереженіЗвіти_Const.Додано,
                /*Назва*/ Довідники.ЗбереженіЗвіти_Const.Назва,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) ЗбереженіЗвіти_Select.QuerySelect.Where = (List<Where>)where;

            ЗбереженіЗвіти_Select.QuerySelect.Order.Add(
               Довідники.ЗбереженіЗвіти_Const.Код, SelectOrder.DESC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Користувачі_Pointer.GetJoin(ЗбереженіЗвіти_Select.QuerySelect, Довідники.ЗбереженіЗвіти_Const.Користувач,
                ЗбереженіЗвіти_Select.QuerySelect.Table, "join_tab_1", "Користувач");
            
            await ЗбереженіЗвіти_Select.Select();
            store.RemoveAll();
            while (ЗбереженіЗвіти_Select.MoveNext())
            {
                Довідники.ЗбереженіЗвіти_Pointer? curr = ЗбереженіЗвіти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_35_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ЗбереженіЗвіти_Const.Код].ToString() ?? "",
                            Додано = fields[ЗбереженіЗвіти_Const.Додано].ToString() ?? "",
                            Назва = fields[ЗбереженіЗвіти_Const.Назва].ToString() ?? "",
                            Користувач = fields["Користувач"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "КасиККМ"
        
    public partial class КасиККМ_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(GeneratedCode.Rows.Row_36_1.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    GeneratedCode.Rows.Row_36_1? row = (GeneratedCode.Rows.Row_36_1?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Іконки.ДляТабличногоСписку.Delete : InterfaceGtk4.Іконки.ДляТабличногоСписку.Normal));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }

            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_36_1? row = (GeneratedCode.Rows.Row_36_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Назва);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Назва", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_36_1? row = (GeneratedCode.Rows.Row_36_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Валюта);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Валюта", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_36_1? row = (GeneratedCode.Rows.Row_36_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Тип);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Тип", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label label = Label.New(null);
                    label.Halign = Align.Start;
                    listItem.Child = label;
                };
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    Label? label = (Label?)listItem.Child;
                    GeneratedCode.Rows.Row_36_1? row = (GeneratedCode.Rows.Row_36_1?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Склад);
                };

                ColumnViewColumn column = ColumnViewColumn.New("Склад", factory);
                column.Resizable = true;
                columnView.AppendColumn(column);
            }
            

            return store;
        }

        public static async ValueTask LoadRecords(Gio.ListStore store)
        {
            
            Довідники.КасиККМ_Select КасиККМ_Select = new();
            КасиККМ_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.КасиККМ_Const.Назва,
                /*Тип*/ Довідники.КасиККМ_Const.Тип,
                
            ]);

            
            //var where = treeView.Data["Where"];
            //if (where != null) КасиККМ_Select.QuerySelect.Where = (List<Where>)where;

            КасиККМ_Select.QuerySelect.Order.Add(
               Довідники.КасиККМ_Const.Назва, SelectOrder.ASC);
            

            /* Приєднання таблиць, JOIN */
            Довідники.Валюти_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Валюта,
                КасиККМ_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            Довідники.Склади_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Склад,
                КасиККМ_Select.QuerySelect.Table, "join_tab_2", "Склад");
            
            await КасиККМ_Select.Select();
            store.RemoveAll();
            while (КасиККМ_Select.MoveNext())
            {
                Довідники.КасиККМ_Pointer? curr = КасиККМ_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    GeneratedCode.Rows.Row_36_1 row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[КасиККМ_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            Тип = Перелічення.ПсевдонімиПерелічення.ТипККМ_Alias((
                              (Перелічення.ТипККМ)(fields[КасиККМ_Const.Тип] != DBNull.Value ? fields[КасиККМ_Const.Тип] : 0)) ),
                            Склад = fields["Склад"].ToString() ?? "",
                            
                    };
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
}

  