
/*
 *
 * Конфігурації ""Зберігання та Торгівля" для України"
 * Автор Тарахомин Юрій Іванович, accounting.org.ua
 * Дата конфігурації: 15.12.2025 23:27:49
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

namespace GeneratedCode.Довідники.ТабличніСписки
{
    
    #region DIRECTORY "Організації"
        
    public partial class Організації_Записи
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                Організації_Select.QuerySelect.Order.Add(
                 Довідники.Організації_Const.Назва, SelectOrder.ASC);
            
            await Організації_Select.Select();
            store.RemoveAll();
            while (Організації_Select.MoveNext())
            {
                Довідники.Організації_Pointer? curr = Організації_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Організації_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Організації_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ОдиницяВиміру"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ТипНоменклатури"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Залишок"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВРезерві"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВРезервіПідЗамовлення"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ЗалишокВКомірках"]);
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

            
                /* Sort */
                Номенклатура_Select.QuerySelect.Order.Add(
                 Довідники.Номенклатура_Const.Назва, SelectOrder.ASC);
            
                /* Join */
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
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Номенклатура_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Номенклатура_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ОдиницяВиміру", Fields["ОдиницяВиміру"].ToString() ?? "");
                    row.Fields.Add("ТипНоменклатури", Перелічення.ПсевдонімиПерелічення.ТипиНоменклатури_Alias((Перелічення.ТипиНоменклатури)(Fields[Номенклатура_Const.ТипНоменклатури] != DBNull.Value ? Fields[Номенклатура_Const.ТипНоменклатури] : 0) ));
                    row.Fields.Add("Залишок", Fields["Залишок"].ToString() ?? "");
                    row.Fields.Add("ВРезерві", Fields["ВРезерві"].ToString() ?? "");
                    row.Fields.Add("ВРезервіПідЗамовлення", Fields["ВРезервіПідЗамовлення"].ToString() ?? "");
                    row.Fields.Add("ЗалишокВКомірках", Fields["ЗалишокВКомірках"].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Номенклатура_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ОдиницяВиміру"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Залишок"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВРезерві"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВРезервіПідЗамовлення"]);
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

            
                /* Sort */
                Номенклатура_Select.QuerySelect.Order.Add(
                 Довідники.Номенклатура_Const.Назва, SelectOrder.ASC);
            
                /* Join */
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
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Номенклатура_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Номенклатура_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ОдиницяВиміру", Fields["ОдиницяВиміру"].ToString() ?? "");
                    row.Fields.Add("Залишок", Fields["Залишок"].ToString() ?? "");
                    row.Fields.Add("ВРезерві", Fields["ВРезерві"].ToString() ?? "");
                    row.Fields.Add("ВРезервіПідЗамовлення", Fields["ВРезервіПідЗамовлення"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                Виробники_Select.QuerySelect.Order.Add(
                 Довідники.Виробники_Const.Назва, SelectOrder.ASC);
            
            await Виробники_Select.Select();
            store.RemoveAll();
            while (Виробники_Select.MoveNext())
            {
                Довідники.Виробники_Pointer? curr = Виробники_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Виробники_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Виробники_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                ВидиНоменклатури_Select.QuerySelect.Order.Add(
                 Довідники.ВидиНоменклатури_Const.Назва, SelectOrder.ASC);
            
            await ВидиНоменклатури_Select.Select();
            store.RemoveAll();
            while (ВидиНоменклатури_Select.MoveNext())
            {
                Довідники.ВидиНоменклатури_Pointer? curr = ВидиНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиНоменклатури_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиНоменклатури_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КількістьУпаковок"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["НазваПовна"]);
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

            
                /* Sort */
                ПакуванняОдиниціВиміру_Select.QuerySelect.Order.Add(
                 Довідники.ПакуванняОдиниціВиміру_Const.Назва, SelectOrder.ASC);
            
            await ПакуванняОдиниціВиміру_Select.Select();
            store.RemoveAll();
            while (ПакуванняОдиниціВиміру_Select.MoveNext())
            {
                Довідники.ПакуванняОдиниціВиміру_Pointer? curr = ПакуванняОдиниціВиміру_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ПакуванняОдиниціВиміру_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ПакуванняОдиниціВиміру_Const.Назва].ToString() ?? "");
                    row.Fields.Add("КількістьУпаковок", Fields[ПакуванняОдиниціВиміру_Const.КількістьУпаковок].ToString() ?? "");
                    row.Fields.Add("НазваПовна", Fields[ПакуванняОдиниціВиміру_Const.НазваПовна].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КороткаНазва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код_R030"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВиводитиКурсНаСтартову"]);
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

            
                /* Sort */
                Валюти_Select.QuerySelect.Order.Add(
                 Довідники.Валюти_Const.Код, SelectOrder.ASC);
            
            await Валюти_Select.Select();
            store.RemoveAll();
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Валюти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Валюти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("КороткаНазва", Fields[Валюти_Const.КороткаНазва].ToString() ?? "");
                    row.Fields.Add("Код_R030", Fields[Валюти_Const.Код_R030].ToString() ?? "");
                    row.Fields.Add("ВиводитиКурсНаСтартову", (Fields[Валюти_Const.ВиводитиКурсНаСтартову] != DBNull.Value && (bool)Fields[Валюти_Const.ВиводитиКурсНаСтартову]) ? "Так" : "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Валюти_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КороткаНазва"]);
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

            
                /* Sort */
                Валюти_Select.QuerySelect.Order.Add(
                 Довідники.Валюти_Const.Код, SelectOrder.ASC);
            
            await Валюти_Select.Select();
            store.RemoveAll();
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Валюти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Валюти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("КороткаНазва", Fields[Валюти_Const.КороткаНазва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Папка"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Постачальник"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Покупець"]);
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

            
                /* Sort */
                Контрагенти_Select.QuerySelect.Order.Add(
                 Довідники.Контрагенти_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Контрагенти_Папки_Pointer.GetJoin(Контрагенти_Select.QuerySelect, Довідники.Контрагенти_Const.Папка,
                Контрагенти_Select.QuerySelect.Table, "join_tab_1", "Папка");
            
            await Контрагенти_Select.Select();
            store.RemoveAll();
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Контрагенти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Контрагенти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Папка", Fields["Папка"].ToString() ?? "");
                    row.Fields.Add("Постачальник", (Fields[Контрагенти_Const.Постачальник] != DBNull.Value && (bool)Fields[Контрагенти_Const.Постачальник]) ? "Так" : "");
                    row.Fields.Add("Покупець", (Fields[Контрагенти_Const.Покупець] != DBNull.Value && (bool)Fields[Контрагенти_Const.Покупець]) ? "Так" : "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Контрагенти_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                Контрагенти_Select.QuerySelect.Order.Add(
                 Довідники.Контрагенти_Const.Назва, SelectOrder.ASC);
            
            await Контрагенти_Select.Select();
            store.RemoveAll();
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Контрагенти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Контрагенти_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ТипСкладу"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["НалаштуванняАдресногоЗберігання"]);
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

            
                /* Sort */
                Склади_Select.QuerySelect.Order.Add(
                 Довідники.Склади_Const.Назва, SelectOrder.ASC);
            
            await Склади_Select.Select();
            store.RemoveAll();
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Склади_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Склади_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ТипСкладу", Перелічення.ПсевдонімиПерелічення.ТипиСкладів_Alias((Перелічення.ТипиСкладів)(Fields[Склади_Const.ТипСкладу] != DBNull.Value ? Fields[Склади_Const.ТипСкладу] : 0) ));
                    row.Fields.Add("НалаштуванняАдресногоЗберігання", Перелічення.ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Alias((Перелічення.НалаштуванняАдресногоЗберігання)(Fields[Склади_Const.НалаштуванняАдресногоЗберігання] != DBNull.Value ? Fields[Склади_Const.НалаштуванняАдресногоЗберігання] : 0) ));
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Склади_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                Склади_Select.QuerySelect.Order.Add(
                 Довідники.Склади_Const.Назва, SelectOrder.ASC);
            
            await Склади_Select.Select();
            store.RemoveAll();
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Склади_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Склади_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Валюта"]);
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

            
                /* Sort */
                ВидиЦін_Select.QuerySelect.Order.Add(
                 Довідники.ВидиЦін_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Валюти_Pointer.GetJoin(ВидиЦін_Select.QuerySelect, Довідники.ВидиЦін_Const.Валюта,
                ВидиЦін_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await ВидиЦін_Select.Select();
            store.RemoveAll();
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиЦін_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиЦін_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class ВидиЦін_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                ВидиЦін_Select.QuerySelect.Order.Add(
                 Довідники.ВидиЦін_Const.Назва, SelectOrder.ASC);
            
            await ВидиЦін_Select.Select();
            store.RemoveAll();
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ВидиЦін_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                ВидиЦінПостачальників_Select.QuerySelect.Order.Add(
                 Довідники.ВидиЦінПостачальників_Const.Назва, SelectOrder.ASC);
            
            await ВидиЦінПостачальників_Select.Select();
            store.RemoveAll();
            while (ВидиЦінПостачальників_Select.MoveNext())
            {
                Довідники.ВидиЦінПостачальників_Pointer? curr = ВидиЦінПостачальників_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиЦінПостачальників_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиЦінПостачальників_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                Користувачі_Select.QuerySelect.Order.Add(
                 Довідники.Користувачі_Const.Назва, SelectOrder.ASC);
            
            await Користувачі_Select.Select();
            store.RemoveAll();
            while (Користувачі_Select.MoveNext())
            {
                Довідники.Користувачі_Pointer? curr = Користувачі_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Користувачі_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Користувачі_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                ФізичніОсоби_Select.QuerySelect.Order.Add(
                 Довідники.ФізичніОсоби_Const.Назва, SelectOrder.ASC);
            
            await ФізичніОсоби_Select.Select();
            store.RemoveAll();
            while (ФізичніОсоби_Select.MoveNext())
            {
                Довідники.ФізичніОсоби_Pointer? curr = ФізичніОсоби_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ФізичніОсоби_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ФізичніОсоби_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                СтруктураПідприємства_Select.QuerySelect.Order.Add(
                 Довідники.СтруктураПідприємства_Const.Назва, SelectOrder.ASC);
            
            await СтруктураПідприємства_Select.Select();
            store.RemoveAll();
            while (СтруктураПідприємства_Select.MoveNext())
            {
                Довідники.СтруктураПідприємства_Pointer? curr = СтруктураПідприємства_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[СтруктураПідприємства_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[СтруктураПідприємства_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                КраїниСвіту_Select.QuerySelect.Order.Add(
                 Довідники.КраїниСвіту_Const.Назва, SelectOrder.ASC);
            
            await КраїниСвіту_Select.Select();
            store.RemoveAll();
            while (КраїниСвіту_Select.MoveNext())
            {
                Довідники.КраїниСвіту_Pointer? curr = КраїниСвіту_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[КраїниСвіту_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[КраїниСвіту_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["НазваФайлу"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Розмір"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ДатаСтворення"]);
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

            
                /* Sort */
                Файли_Select.QuerySelect.Order.Add(
                 Довідники.Файли_Const.Назва, SelectOrder.ASC);
            
            await Файли_Select.Select();
            store.RemoveAll();
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Файли_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Файли_Const.Назва].ToString() ?? "");
                    row.Fields.Add("НазваФайлу", Fields[Файли_Const.НазваФайлу].ToString() ?? "");
                    row.Fields.Add("Розмір", Fields[Файли_Const.Розмір].ToString() ?? "");
                    row.Fields.Add("ДатаСтворення", Fields[Файли_Const.ДатаСтворення].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Файли_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                Файли_Select.QuerySelect.Order.Add(
                 Довідники.Файли_Const.Назва, SelectOrder.ASC);
            
            await Файли_Select.Select();
            store.RemoveAll();
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Файли_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Номенклатура"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Залишки"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВРезерві"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВРезервіПідЗамовлення"]);
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

            
                /* Sort */
                ХарактеристикиНоменклатури_Select.QuerySelect.Order.Add(
                 Довідники.ХарактеристикиНоменклатури_Const.Назва, SelectOrder.ASC);
            
                /* Join */
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
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ХарактеристикиНоменклатури_Const.Код].ToString() ?? "");
                    row.Fields.Add("Номенклатура", Fields["Номенклатура"].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ХарактеристикиНоменклатури_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Залишки", Fields["Залишки"].ToString() ?? "");
                    row.Fields.Add("ВРезерві", Fields["ВРезерві"].ToString() ?? "");
                    row.Fields.Add("ВРезервіПідЗамовлення", Fields["ВРезервіПідЗамовлення"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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

            
                /* Sort */
                Номенклатура_Папки_Select.QuerySelect.Order.Add(
                 Довідники.Номенклатура_Папки_Const.Назва, SelectOrder.ASC);
            
            await Номенклатура_Папки_Select.Select();
            store.RemoveAll();
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Номенклатура_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Номенклатура_Папки_Const.Код].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Номенклатура_Папки_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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

            
                /* Sort */
                Номенклатура_Папки_Select.QuerySelect.Order.Add(
                 Довідники.Номенклатура_Папки_Const.Назва, SelectOrder.ASC);
            
            await Номенклатура_Папки_Select.Select();
            store.RemoveAll();
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Номенклатура_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Номенклатура_Папки_Const.Код].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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

            
                /* Sort */
                Контрагенти_Папки_Select.QuerySelect.Order.Add(
                 Довідники.Контрагенти_Папки_Const.Назва, SelectOrder.ASC);
            
            await Контрагенти_Папки_Select.Select();
            store.RemoveAll();
            while (Контрагенти_Папки_Select.MoveNext())
            {
                Довідники.Контрагенти_Папки_Pointer? curr = Контрагенти_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Контрагенти_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Контрагенти_Папки_Const.Код].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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

            
                /* Sort */
                Склади_Папки_Select.QuerySelect.Order.Add(
                 Довідники.Склади_Папки_Const.Назва, SelectOrder.ASC);
            
            await Склади_Папки_Select.Select();
            store.RemoveAll();
            while (Склади_Папки_Select.MoveNext())
            {
                Довідники.Склади_Папки_Pointer? curr = Склади_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Склади_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Склади_Папки_Const.Код].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Валюта"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Залишок"]);
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

            
                /* Sort */
                Каси_Select.QuerySelect.Order.Add(
                 Довідники.Каси_Const.Назва, SelectOrder.ASC);
            
                /* Join */
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
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Каси_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Каси_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    row.Fields.Add("Залишок", Fields["Залишок"].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Каси_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Валюта"]);
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

            
                /* Sort */
                Каси_Select.QuerySelect.Order.Add(
                 Довідники.Каси_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Валюти_Pointer.GetJoin(Каси_Select.QuerySelect, Довідники.Каси_Const.Валюта,
                Каси_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await Каси_Select.Select();
            store.RemoveAll();
            while (Каси_Select.MoveNext())
            {
                Довідники.Каси_Pointer? curr = Каси_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Каси_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Каси_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Валюта"]);
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

            
                /* Sort */
                БанківськіРахункиОрганізацій_Select.QuerySelect.Order.Add(
                 Довідники.БанківськіРахункиОрганізацій_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиОрганізацій_Select.QuerySelect, Довідники.БанківськіРахункиОрганізацій_Const.Валюта,
                БанківськіРахункиОрганізацій_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await БанківськіРахункиОрганізацій_Select.Select();
            store.RemoveAll();
            while (БанківськіРахункиОрганізацій_Select.MoveNext())
            {
                Довідники.БанківськіРахункиОрганізацій_Pointer? curr = БанківськіРахункиОрганізацій_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[БанківськіРахункиОрганізацій_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[БанківськіРахункиОрганізацій_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Контрагент"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ТипДоговору"]);
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

            
                /* Sort */
                ДоговориКонтрагентів_Select.QuerySelect.Order.Add(
                 Довідники.ДоговориКонтрагентів_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
                ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");
            
            await ДоговориКонтрагентів_Select.Select();
            store.RemoveAll();
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ДоговориКонтрагентів_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Контрагент", Fields["Контрагент"].ToString() ?? "");
                    row.Fields.Add("ТипДоговору", Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((Перелічення.ТипДоговорів)(Fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? Fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0) ));
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class ДоговориКонтрагентів_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Контрагент"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ТипДоговору"]);
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

            
                /* Sort */
                ДоговориКонтрагентів_Select.QuerySelect.Order.Add(
                 Довідники.ДоговориКонтрагентів_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
                ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");
            
            await ДоговориКонтрагентів_Select.Select();
            store.RemoveAll();
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Контрагент", Fields["Контрагент"].ToString() ?? "");
                    row.Fields.Add("ТипДоговору", Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((Перелічення.ТипДоговорів)(Fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? Fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0) ));
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Валюта"]);
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

            
                /* Sort */
                БанківськіРахункиКонтрагентів_Select.QuerySelect.Order.Add(
                 Довідники.БанківськіРахункиКонтрагентів_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиКонтрагентів_Select.QuerySelect, Довідники.БанківськіРахункиКонтрагентів_Const.Валюта,
                БанківськіРахункиКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await БанківськіРахункиКонтрагентів_Select.Select();
            store.RemoveAll();
            while (БанківськіРахункиКонтрагентів_Select.MoveNext())
            {
                Довідники.БанківськіРахункиКонтрагентів_Pointer? curr = БанківськіРахункиКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[БанківськіРахункиКонтрагентів_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[БанківськіРахункиКонтрагентів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КореспондуючийРахунок"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВидРухуКоштів"]);
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

            
                /* Sort */
                СтаттяРухуКоштів_Select.QuerySelect.Order.Add(
                 Довідники.СтаттяРухуКоштів_Const.Назва, SelectOrder.ASC);
            
            await СтаттяРухуКоштів_Select.Select();
            store.RemoveAll();
            while (СтаттяРухуКоштів_Select.MoveNext())
            {
                Довідники.СтаттяРухуКоштів_Pointer? curr = СтаттяРухуКоштів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СтаттяРухуКоштів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[СтаттяРухуКоштів_Const.Код].ToString() ?? "");
                    row.Fields.Add("КореспондуючийРахунок", Fields[СтаттяРухуКоштів_Const.КореспондуючийРахунок].ToString() ?? "");
                    row.Fields.Add("ВидРухуКоштів", Перелічення.ПсевдонімиПерелічення.ВидиРухуКоштів_Alias((Перелічення.ВидиРухуКоштів)(Fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] != DBNull.Value ? Fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] : 0) ));
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Номер"]);
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

            
                /* Sort */
                СеріїНоменклатури_Select.QuerySelect.Order.Add(
                 Довідники.СеріїНоменклатури_Const.Номер, SelectOrder.ASC);
            
            await СеріїНоменклатури_Select.Select();
            store.RemoveAll();
            while (СеріїНоменклатури_Select.MoveNext())
            {
                Довідники.СеріїНоменклатури_Pointer? curr = СеріїНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Номер", Fields[СеріїНоменклатури_Const.Номер].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Дата"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ТипДокументу"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ПоступленняТоварівТаПослуг"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ВведенняЗалишків"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Залишки"]);
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

            
                /* Sort */
                ПартіяТоварівКомпозит_Select.QuerySelect.Order.Add(
                 Довідники.ПартіяТоварівКомпозит_Const.Дата, SelectOrder.ASC);
            
                /* Join */
                Документи.ПоступленняТоварівТаПослуг_Pointer.GetJoin(ПартіяТоварівКомпозит_Select.QuerySelect, Довідники.ПартіяТоварівКомпозит_Const.ПоступленняТоварівТаПослуг,
                ПартіяТоварівКомпозит_Select.QuerySelect.Table, "join_tab_1", "ПоступленняТоварівТаПослуг");
            
                /* Join */
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
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ПартіяТоварівКомпозит_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Дата", Fields[ПартіяТоварівКомпозит_Const.Дата].ToString() ?? "");
                    row.Fields.Add("ТипДокументу", Перелічення.ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_Alias((Перелічення.ТипДокументуПартіяТоварівКомпозит)(Fields[ПартіяТоварівКомпозит_Const.ТипДокументу] != DBNull.Value ? Fields[ПартіяТоварівКомпозит_Const.ТипДокументу] : 0) ));
                    row.Fields.Add("ПоступленняТоварівТаПослуг", Fields["ПоступленняТоварівТаПослуг"].ToString() ?? "");
                    row.Fields.Add("ВведенняЗалишків", Fields["ВведенняЗалишків"].ToString() ?? "");
                    row.Fields.Add("Залишки", Fields["Залишки"].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class ПартіяТоварівКомпозит_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Дата"]);
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

            
                /* Sort */
                ПартіяТоварівКомпозит_Select.QuerySelect.Order.Add(
                 Довідники.ПартіяТоварівКомпозит_Const.Дата, SelectOrder.ASC);
            
            await ПартіяТоварівКомпозит_Select.Select();
            store.RemoveAll();
            while (ПартіяТоварівКомпозит_Select.MoveNext())
            {
                Довідники.ПартіяТоварівКомпозит_Pointer? curr = ПартіяТоварівКомпозит_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ПартіяТоварівКомпозит_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Дата", Fields[ПартіяТоварівКомпозит_Const.Дата].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                ВидиЗапасів_Select.QuerySelect.Order.Add(
                 Довідники.ВидиЗапасів_Const.Назва, SelectOrder.ASC);
            
            await ВидиЗапасів_Select.Select();
            store.RemoveAll();
            while (ВидиЗапасів_Select.MoveNext())
            {
                Довідники.ВидиЗапасів_Pointer? curr = ВидиЗапасів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиЗапасів_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиЗапасів_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ПовнаНазва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КодМФО"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КодЄДРПОУ"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["НомерЛіцензії"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ДатаЛіцензії"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Статус"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ТипНаселеногоПункту"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["УнікальнийКодБанку"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ПоштовийІндекс"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["НазваНаселеногоПункту"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Адреса"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["НомерТелефону"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ДатаВідкриттяУстанови"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ДатаЗакриттяУстанови"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КодНБУ"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["КодСтатусу"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ДатаЗапису"]);
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

            
                /* Sort */
                Банки_Select.QuerySelect.Order.Add(
                 Довідники.Банки_Const.Назва, SelectOrder.ASC);
            
            await Банки_Select.Select();
            store.RemoveAll();
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Банки_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Банки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ПовнаНазва", Fields[Банки_Const.ПовнаНазва].ToString() ?? "");
                    row.Fields.Add("КодМФО", Fields[Банки_Const.КодМФО].ToString() ?? "");
                    row.Fields.Add("КодЄДРПОУ", Fields[Банки_Const.КодЄДРПОУ].ToString() ?? "");
                    row.Fields.Add("НомерЛіцензії", Fields[Банки_Const.НомерЛіцензії].ToString() ?? "");
                    row.Fields.Add("ДатаЛіцензії", Fields[Банки_Const.ДатаЛіцензії].ToString() ?? "");
                    row.Fields.Add("Статус", Fields[Банки_Const.Статус].ToString() ?? "");
                    row.Fields.Add("ТипНаселеногоПункту", Fields[Банки_Const.ТипНаселеногоПункту].ToString() ?? "");
                    row.Fields.Add("УнікальнийКодБанку", Fields[Банки_Const.УнікальнийКодБанку].ToString() ?? "");
                    row.Fields.Add("ПоштовийІндекс", Fields[Банки_Const.ПоштовийІндекс].ToString() ?? "");
                    row.Fields.Add("НазваНаселеногоПункту", Fields[Банки_Const.НазваНаселеногоПункту].ToString() ?? "");
                    row.Fields.Add("Адреса", Fields[Банки_Const.Адреса].ToString() ?? "");
                    row.Fields.Add("НомерТелефону", Fields[Банки_Const.НомерТелефону].ToString() ?? "");
                    row.Fields.Add("ДатаВідкриттяУстанови", Fields[Банки_Const.ДатаВідкриттяУстанови].ToString() ?? "");
                    row.Fields.Add("ДатаЗакриттяУстанови", Fields[Банки_Const.ДатаЗакриттяУстанови].ToString() ?? "");
                    row.Fields.Add("КодНБУ", Fields[Банки_Const.КодНБУ].ToString() ?? "");
                    row.Fields.Add("КодСтатусу", Fields[Банки_Const.КодСтатусу].ToString() ?? "");
                    row.Fields.Add("ДатаЗапису", Fields[Банки_Const.ДатаЗапису].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class Банки_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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

            
                /* Sort */
                Банки_Select.QuerySelect.Order.Add(
                 Довідники.Банки_Const.Назва, SelectOrder.ASC);
            
            await Банки_Select.Select();
            store.RemoveAll();
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Банки_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Банки_Const.Назва].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Склад"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["НалаштуванняАдресногоЗберігання"]);
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

            
                /* Sort */
                СкладськіПриміщення_Select.QuerySelect.Order.Add(
                 Довідники.СкладськіПриміщення_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Склади_Pointer.GetJoin(СкладськіПриміщення_Select.QuerySelect, Довідники.СкладськіПриміщення_Const.Склад,
                СкладськіПриміщення_Select.QuerySelect.Table, "join_tab_1", "Склад");
            
            await СкладськіПриміщення_Select.Select();
            store.RemoveAll();
            while (СкладськіПриміщення_Select.MoveNext())
            {
                Довідники.СкладськіПриміщення_Pointer? curr = СкладськіПриміщення_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіПриміщення_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Склад", Fields["Склад"].ToString() ?? "");
                    row.Fields.Add("НалаштуванняАдресногоЗберігання", Перелічення.ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Alias((Перелічення.НалаштуванняАдресногоЗберігання)(Fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] != DBNull.Value ? Fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] : 0) ));
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Приміщення"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Лінія"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Позиція"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Стелаж"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Ярус"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ТипСкладськоїКомірки"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Типорозмір"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Папка"]);
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

            
                /* Sort */
                СкладськіКомірки_Select.QuerySelect.Order.Add(
                 Довідники.СкладськіКомірки_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Приміщення,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            
                /* Join */
                Довідники.ТипорозміриКомірок_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Типорозмір,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_2", "Типорозмір");
            
                /* Join */
                Довідники.СкладськіКомірки_Папки_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Папка,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_3", "Папка");
            
            await СкладськіКомірки_Select.Select();
            store.RemoveAll();
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіКомірки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Приміщення", Fields["Приміщення"].ToString() ?? "");
                    row.Fields.Add("Лінія", Fields[СкладськіКомірки_Const.Лінія].ToString() ?? "");
                    row.Fields.Add("Позиція", Fields[СкладськіКомірки_Const.Позиція].ToString() ?? "");
                    row.Fields.Add("Стелаж", Fields[СкладськіКомірки_Const.Стелаж].ToString() ?? "");
                    row.Fields.Add("Ярус", Fields[СкладськіКомірки_Const.Ярус].ToString() ?? "");
                    row.Fields.Add("ТипСкладськоїКомірки", Перелічення.ПсевдонімиПерелічення.ТипиСкладськихКомірок_Alias((Перелічення.ТипиСкладськихКомірок)(Fields[СкладськіКомірки_Const.ТипСкладськоїКомірки] != DBNull.Value ? Fields[СкладськіКомірки_Const.ТипСкладськоїКомірки] : 0) ));
                    row.Fields.Add("Типорозмір", Fields["Типорозмір"].ToString() ?? "");
                    row.Fields.Add("Папка", Fields["Папка"].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    public partial class СкладськіКомірки_ЗаписиШвидкийВибір
    {
        public static Gio.ListStore Create(ColumnView columnView)
        {
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Приміщення"]);
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

            
                /* Sort */
                СкладськіКомірки_Select.QuerySelect.Order.Add(
                 Довідники.СкладськіКомірки_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Приміщення,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            
            await СкладськіКомірки_Select.Select();
            store.RemoveAll();
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіКомірки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Приміщення", Fields["Приміщення"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Приміщення"]);
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

            
                /* Sort */
                ОбластьЗберігання_Select.QuerySelect.Order.Add(
                 Довідники.ОбластьЗберігання_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.СкладськіПриміщення_Pointer.GetJoin(ОбластьЗберігання_Select.QuerySelect, Довідники.ОбластьЗберігання_Const.Приміщення,
                ОбластьЗберігання_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            
            await ОбластьЗберігання_Select.Select();
            store.RemoveAll();
            while (ОбластьЗберігання_Select.MoveNext())
            {
                Довідники.ОбластьЗберігання_Pointer? curr = ОбластьЗберігання_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ОбластьЗберігання_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Приміщення", Fields["Приміщення"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Висота"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Глибина"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Вантажопідйомність"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Обєм"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Ширина"]);
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

            
                /* Sort */
                ТипорозміриКомірок_Select.QuerySelect.Order.Add(
                 Довідники.ТипорозміриКомірок_Const.Назва, SelectOrder.ASC);
            
            await ТипорозміриКомірок_Select.Select();
            store.RemoveAll();
            while (ТипорозміриКомірок_Select.MoveNext())
            {
                Довідники.ТипорозміриКомірок_Pointer? curr = ТипорозміриКомірок_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ТипорозміриКомірок_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Висота", Fields[ТипорозміриКомірок_Const.Висота].ToString() ?? "");
                    row.Fields.Add("Глибина", Fields[ТипорозміриКомірок_Const.Глибина].ToString() ?? "");
                    row.Fields.Add("Вантажопідйомність", Fields[ТипорозміриКомірок_Const.Вантажопідйомність].ToString() ?? "");
                    row.Fields.Add("Обєм", Fields[ТипорозміриКомірок_Const.Обєм].ToString() ?? "");
                    row.Fields.Add("Ширина", Fields[ТипорозміриКомірок_Const.Ширина].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Власник"]);
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

            
                /* Sort */
                СкладськіКомірки_Папки_Select.QuerySelect.Order.Add(
                 Довідники.СкладськіКомірки_Папки_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Папки_Select.QuerySelect, Довідники.СкладськіКомірки_Папки_Const.Власник,
                СкладськіКомірки_Папки_Select.QuerySelect.Table, "join_tab_1", "Власник");
            
            await СкладськіКомірки_Папки_Select.Select();
            store.RemoveAll();
            while (СкладськіКомірки_Папки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Папки_Pointer? curr = СкладськіКомірки_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіКомірки_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[СкладськіКомірки_Папки_Const.Код].ToString() ?? "");
                    row.Fields.Add("Власник", Fields["Власник"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["ДатаЗапису"]);
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

            
                /* Sort */
                Блокнот_Select.QuerySelect.Order.Add(
                 Довідники.Блокнот_Const.ДатаЗапису, SelectOrder.ASC);
            
            await Блокнот_Select.Select();
            store.RemoveAll();
            while (Блокнот_Select.MoveNext())
            {
                Довідники.Блокнот_Pointer? curr = Блокнот_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Блокнот_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Блокнот_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ДатаЗапису", Fields[Блокнот_Const.ДатаЗапису].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Код"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Додано"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Користувач"]);
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

            
                /* Sort */
                ЗбереженіЗвіти_Select.QuerySelect.Order.Add(
                 Довідники.ЗбереженіЗвіти_Const.Код, SelectOrder.DESC);
            
                /* Join */
                Довідники.Користувачі_Pointer.GetJoin(ЗбереженіЗвіти_Select.QuerySelect, Довідники.ЗбереженіЗвіти_Const.Користувач,
                ЗбереженіЗвіти_Select.QuerySelect.Table, "join_tab_1", "Користувач");
            
            await ЗбереженіЗвіти_Select.Select();
            store.RemoveAll();
            while (ЗбереженіЗвіти_Select.MoveNext())
            {
                Довідники.ЗбереженіЗвіти_Pointer? curr = ЗбереженіЗвіти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ЗбереженіЗвіти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Додано", Fields[ЗбереженіЗвіти_Const.Додано].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ЗбереженіЗвіти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Користувач", Fields["Користувач"].ToString() ?? "");
                    
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
            Gio.ListStore store = Gio.ListStore.New(DirectoryRow.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (_, args) =>
                {
                    ListItem listItem = (ListItem)args.Object;
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    listItem.SetChild(Picture.NewForPixbuf((row?.DeletionLabel ?? false) ? InterfaceGtk4.Icon.ForTabularLists.Delete : InterfaceGtk4.Icon.ForTabularLists.Normal));
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Назва"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Валюта"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Тип"]);
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
                    DirectoryRow? row = (DirectoryRow?)listItem.Item;
                    if (label != null && row != null)
                        label.SetText(row.Fields["Склад"]);
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

            
                /* Sort */
                КасиККМ_Select.QuerySelect.Order.Add(
                 Довідники.КасиККМ_Const.Назва, SelectOrder.ASC);
            
                /* Join */
                Довідники.Валюти_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Валюта,
                КасиККМ_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
                /* Join */
                Довідники.Склади_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Склад,
                КасиККМ_Select.QuerySelect.Table, "join_tab_2", "Склад");
            
            await КасиККМ_Select.Select();
            store.RemoveAll();
            while (КасиККМ_Select.MoveNext())
            {
                Довідники.КасиККМ_Pointer? curr = КасиККМ_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[КасиККМ_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    row.Fields.Add("Тип", Перелічення.ПсевдонімиПерелічення.ТипККМ_Alias((Перелічення.ТипККМ)(Fields[КасиККМ_Const.Тип] != DBNull.Value ? Fields[КасиККМ_Const.Тип] : 0) ));
                    row.Fields.Add("Склад", Fields["Склад"].ToString() ?? "");
                    
                    store.Append(row);
                }
            }
        }
    }
        
    #endregion
    
}

  