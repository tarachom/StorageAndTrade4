
/*
 *
 * Конфігурації ""Зберігання та Торгівля" для України"
 * Автор Тарахомин Юрій Іванович, accounting.org.ua
 * Дата конфігурації: 26.12.2025 17:43:07
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

    public static class Організації_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Організації_Select Організації_Select = new();
            Організації_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Організації_Const.Код,
                /*Назва*/ Довідники.Організації_Const.Назва,

            ]);


            if (form.WhereList != null) Організації_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Організації_Select.QuerySelect.Order.Add(
             Довідники.Організації_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Організації_Select.SplitSelectToPages, Організації_Select.QuerySelect, unigueIDSelect);


            await Організації_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Організації_Select.MoveNext())
            {
                Довідники.Організації_Pointer? curr = Організації_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Організації_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Організації_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Номенклатура"

    public static class Номенклатура_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ОдиницяВиміру, "Пакування"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ТипНоменклатури, "Тип"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Залишок, "Залишок"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВРезерві, "В резерві"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВРезервіПідЗамовлення, "Під замовлення"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ЗалишокВКомірках, "В комірках"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* ТипНоменклатури, enum */
                Switch sw = Switch.New();

                ComboBoxText ТипНоменклатури = new();
                foreach (var item in ПсевдонімиПерелічення.ТипиНоменклатури_List())
                    ТипНоменклатури.Append(item.Value.ToString(), item.Name);
                ТипНоменклатури.Active = 0;
                object get() => Enum.TryParse(ТипНоменклатури.ActiveId, out ТипиНоменклатури value) ? (int)value : 0;

                filterList.Add(new(Номенклатура_Const.ТипНоменклатури, get, sw));
                form.Filter.Append("Тип:", ТипНоменклатури, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Номенклатура_Select Номенклатура_Select = new();
            Номенклатура_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Номенклатура_Const.Код,
                /*Назва*/ Довідники.Номенклатура_Const.Назва,
                /*ТипНоменклатури*/ Довідники.Номенклатура_Const.ТипНоменклатури,

            ]);


            if (form.WhereList != null) Номенклатура_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Номенклатура_Select.QuerySelect.Order.Add(
             Довідники.Номенклатура_Const.Код, SelectOrder.ASC);

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


            /* Pages */
            await form.SplitPages(Номенклатура_Select.SplitSelectToPages, Номенклатура_Select.QuerySelect, unigueIDSelect);


            await Номенклатура_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Номенклатура_Select.MoveNext())
            {
                Довідники.Номенклатура_Pointer? curr = Номенклатура_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Номенклатура_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Номенклатура_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ОдиницяВиміру", Fields["ОдиницяВиміру"].ToString() ?? "");
                    row.Fields.Add("ТипНоменклатури", Перелічення.ПсевдонімиПерелічення.ТипиНоменклатури_Alias((Перелічення.ТипиНоменклатури)(Fields[Номенклатура_Const.ТипНоменклатури] != DBNull.Value ? Fields[Номенклатура_Const.ТипНоменклатури] : 0)));
                    row.Fields.Add("Залишок", Fields["Залишок"].ToString() ?? "");
                    row.Fields.Add("ВРезерві", Fields["ВРезерві"].ToString() ?? "");
                    row.Fields.Add("ВРезервіПідЗамовлення", Fields["ВРезервіПідЗамовлення"].ToString() ?? "");
                    row.Fields.Add("ЗалишокВКомірках", Fields["ЗалишокВКомірках"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Номенклатура_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Номенклатура"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ОдиницяВиміру, "Пакування"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Залишок, "Залишок"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВРезерві, "В резерві"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВРезервіПідЗамовлення, "Під замовлення"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Номенклатура_Select Номенклатура_Select = new();
            Номенклатура_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Номенклатура_Const.Код,
                /*Назва*/ Довідники.Номенклатура_Const.Назва,

            ]);


            if (form.WhereList != null) Номенклатура_Select.QuerySelect.Where = (List<Where>)form.WhereList;


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


            /* Pages */
            await form.SplitPages(Номенклатура_Select.SplitSelectToPages, Номенклатура_Select.QuerySelect, unigueIDSelect);


            await Номенклатура_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Номенклатура_Select.MoveNext())
            {
                Довідники.Номенклатура_Pointer? curr = Номенклатура_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Номенклатура_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Номенклатура_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ОдиницяВиміру", Fields["ОдиницяВиміру"].ToString() ?? "");
                    row.Fields.Add("Залишок", Fields["Залишок"].ToString() ?? "");
                    row.Fields.Add("ВРезерві", Fields["ВРезерві"].ToString() ?? "");
                    row.Fields.Add("ВРезервіПідЗамовлення", Fields["ВРезервіПідЗамовлення"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Виробники"

    public static class Виробники_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Виробники_Select Виробники_Select = new();
            Виробники_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Виробники_Const.Код,
                /*Назва*/ Довідники.Виробники_Const.Назва,

            ]);


            if (form.WhereList != null) Виробники_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Виробники_Select.QuerySelect.Order.Add(
             Довідники.Виробники_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Виробники_Select.SplitSelectToPages, Виробники_Select.QuerySelect, unigueIDSelect);


            await Виробники_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Виробники_Select.MoveNext())
            {
                Довідники.Виробники_Pointer? curr = Виробники_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Виробники_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Виробники_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ВидиНоменклатури"

    public static class ВидиНоменклатури_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ВидиНоменклатури_Select ВидиНоменклатури_Select = new();
            ВидиНоменклатури_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиНоменклатури_Const.Код,
                /*Назва*/ Довідники.ВидиНоменклатури_Const.Назва,

            ]);


            if (form.WhereList != null) ВидиНоменклатури_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ВидиНоменклатури_Select.QuerySelect.Order.Add(
             Довідники.ВидиНоменклатури_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ВидиНоменклатури_Select.SplitSelectToPages, ВидиНоменклатури_Select.QuerySelect, unigueIDSelect);


            await ВидиНоменклатури_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ВидиНоменклатури_Select.MoveNext())
            {
                Довідники.ВидиНоменклатури_Pointer? curr = ВидиНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиНоменклатури_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиНоменклатури_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ПакуванняОдиниціВиміру"

    public static class ПакуванняОдиниціВиміру_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КількістьУпаковок, "Коєфіціент"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: НазваПовна, "Опис"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ПакуванняОдиниціВиміру_Select ПакуванняОдиниціВиміру_Select = new();
            ПакуванняОдиниціВиміру_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ПакуванняОдиниціВиміру_Const.Код,
                /*Назва*/ Довідники.ПакуванняОдиниціВиміру_Const.Назва,
                /*КількістьУпаковок*/ Довідники.ПакуванняОдиниціВиміру_Const.КількістьУпаковок,
                /*НазваПовна*/ Довідники.ПакуванняОдиниціВиміру_Const.НазваПовна,

            ]);


            if (form.WhereList != null) ПакуванняОдиниціВиміру_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ПакуванняОдиниціВиміру_Select.QuerySelect.Order.Add(
             Довідники.ПакуванняОдиниціВиміру_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ПакуванняОдиниціВиміру_Select.SplitSelectToPages, ПакуванняОдиниціВиміру_Select.QuerySelect, unigueIDSelect);


            await ПакуванняОдиниціВиміру_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ПакуванняОдиниціВиміру_Select.MoveNext())
            {
                Довідники.ПакуванняОдиниціВиміру_Pointer? curr = ПакуванняОдиниціВиміру_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ПакуванняОдиниціВиміру_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ПакуванняОдиниціВиміру_Const.Назва].ToString() ?? "");
                    row.Fields.Add("КількістьУпаковок", Fields[ПакуванняОдиниціВиміру_Const.КількістьУпаковок].ToString() ?? "");
                    row.Fields.Add("НазваПовна", Fields[ПакуванняОдиниціВиміру_Const.НазваПовна].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Валюти"

    public static class Валюти_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КороткаНазва, "Коротка  назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Код_R030, "R030"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВиводитиКурсНаСтартову, "Показувати на стартовій"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* Код_R030, string */
                Switch sw = Switch.New();

                Entry Код_R030 = Entry.New();
                Код_R030.WidthRequest = 300;
                object get() => Код_R030.GetText();

                filterList.Add(new(Валюти_Const.Код_R030, get, sw));
                form.Filter.Append("R030:", Код_R030, sw);
            }

            { /* ВиводитиКурсНаСтартову, boolean */
                Switch sw = Switch.New();

                CheckButton ВиводитиКурсНаСтартову = CheckButton.New();
                ВиводитиКурсНаСтартову.OnActivate += (_, _) => sw.Active = ВиводитиКурсНаСтартову.Active;
                object get() => ВиводитиКурсНаСтартову.Active;

                filterList.Add(new(Валюти_Const.ВиводитиКурсНаСтартову, get, sw));
                form.Filter.Append("Показувати на стартовій:", ВиводитиКурсНаСтартову, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


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


            if (form.WhereList != null) Валюти_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Валюти_Select.QuerySelect.Order.Add(
             Довідники.Валюти_Const.Код, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Валюти_Select.SplitSelectToPages, Валюти_Select.QuerySelect, unigueIDSelect);


            await Валюти_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Валюти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Валюти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("КороткаНазва", Fields[Валюти_Const.КороткаНазва].ToString() ?? "");
                    row.Fields.Add("Код_R030", Fields[Валюти_Const.Код_R030].ToString() ?? "");
                    row.Fields.Add("ВиводитиКурсНаСтартову", (Fields[Валюти_Const.ВиводитиКурсНаСтартову] != DBNull.Value && (bool)Fields[Валюти_Const.ВиводитиКурсНаСтартову]) ? "Так" : "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Валюти_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КороткаНазва, "Коротка назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Валюти_Select Валюти_Select = new();
            Валюти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Валюти_Const.Код,
                /*Назва*/ Довідники.Валюти_Const.Назва,
                /*КороткаНазва*/ Довідники.Валюти_Const.КороткаНазва,

            ]);


            if (form.WhereList != null) Валюти_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Валюти_Select.QuerySelect.Order.Add(
             Довідники.Валюти_Const.Код, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Валюти_Select.SplitSelectToPages, Валюти_Select.QuerySelect, unigueIDSelect);


            await Валюти_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Валюти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Валюти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("КороткаНазва", Fields[Валюти_Const.КороткаНазва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Контрагенти"

    public static class Контрагенти_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Папка, "Папка"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Постачальник, "Постачальник"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Покупець, "Покупець"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* Постачальник, boolean */
                Switch sw = Switch.New();

                CheckButton Постачальник = CheckButton.New();
                Постачальник.OnActivate += (_, _) => sw.Active = Постачальник.Active;
                object get() => Постачальник.Active;

                filterList.Add(new(Контрагенти_Const.Постачальник, get, sw));
                form.Filter.Append("Постачальник:", Постачальник, sw);
            }

            { /* Покупець, boolean */
                Switch sw = Switch.New();

                CheckButton Покупець = CheckButton.New();
                Покупець.OnActivate += (_, _) => sw.Active = Покупець.Active;
                object get() => Покупець.Active;

                filterList.Add(new(Контрагенти_Const.Покупець, get, sw));
                form.Filter.Append("Покупець:", Покупець, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Контрагенти_Select Контрагенти_Select = new();
            Контрагенти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Контрагенти_Const.Код,
                /*Назва*/ Довідники.Контрагенти_Const.Назва,
                /*Постачальник*/ Довідники.Контрагенти_Const.Постачальник,
                /*Покупець*/ Довідники.Контрагенти_Const.Покупець,

            ]);


            if (form.WhereList != null) Контрагенти_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Контрагенти_Select.QuerySelect.Order.Add(
             Довідники.Контрагенти_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Контрагенти_Папки_Pointer.GetJoin(Контрагенти_Select.QuerySelect, Довідники.Контрагенти_Const.Папка,
            Контрагенти_Select.QuerySelect.Table, "join_tab_1", "Папка");


            /* Pages */
            await form.SplitPages(Контрагенти_Select.SplitSelectToPages, Контрагенти_Select.QuerySelect, unigueIDSelect);


            await Контрагенти_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Контрагенти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Контрагенти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Папка", Fields["Папка"].ToString() ?? "");
                    row.Fields.Add("Постачальник", (Fields[Контрагенти_Const.Постачальник] != DBNull.Value && (bool)Fields[Контрагенти_Const.Постачальник]) ? "Так" : "");
                    row.Fields.Add("Покупець", (Fields[Контрагенти_Const.Покупець] != DBNull.Value && (bool)Fields[Контрагенти_Const.Покупець]) ? "Так" : "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Контрагенти_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Контрагенти_Select Контрагенти_Select = new();
            Контрагенти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Контрагенти_Const.Код,
                /*Назва*/ Довідники.Контрагенти_Const.Назва,

            ]);


            if (form.WhereList != null) Контрагенти_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Контрагенти_Select.QuerySelect.Order.Add(
             Довідники.Контрагенти_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Контрагенти_Select.SplitSelectToPages, Контрагенти_Select.QuerySelect, unigueIDSelect);


            await Контрагенти_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Контрагенти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Контрагенти_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Склади"

    public static class Склади_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ТипСкладу, "Тип cкладу"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: НалаштуванняАдресногоЗберігання, "Адресне зберігання"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* ТипСкладу, enum */
                Switch sw = Switch.New();

                ComboBoxText ТипСкладу = new();
                foreach (var item in ПсевдонімиПерелічення.ТипиСкладів_List())
                    ТипСкладу.Append(item.Value.ToString(), item.Name);
                ТипСкладу.Active = 0;
                object get() => Enum.TryParse(ТипСкладу.ActiveId, out ТипиСкладів value) ? (int)value : 0;

                filterList.Add(new(Склади_Const.ТипСкладу, get, sw));
                form.Filter.Append("Тип cкладу:", ТипСкладу, sw);
            }

            { /* НалаштуванняАдресногоЗберігання, enum */
                Switch sw = Switch.New();

                ComboBoxText НалаштуванняАдресногоЗберігання = new();
                foreach (var item in ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_List())
                    НалаштуванняАдресногоЗберігання.Append(item.Value.ToString(), item.Name);
                НалаштуванняАдресногоЗберігання.Active = 0;
                object get() => Enum.TryParse(НалаштуванняАдресногоЗберігання.ActiveId, out НалаштуванняАдресногоЗберігання value) ? (int)value : 0;

                filterList.Add(new(Склади_Const.НалаштуванняАдресногоЗберігання, get, sw));
                form.Filter.Append("Адресне зберігання:", НалаштуванняАдресногоЗберігання, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Склади_Select Склади_Select = new();
            Склади_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Склади_Const.Код,
                /*Назва*/ Довідники.Склади_Const.Назва,
                /*ТипСкладу*/ Довідники.Склади_Const.ТипСкладу,
                /*НалаштуванняАдресногоЗберігання*/ Довідники.Склади_Const.НалаштуванняАдресногоЗберігання,

            ]);


            if (form.WhereList != null) Склади_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Склади_Select.QuerySelect.Order.Add(
             Довідники.Склади_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Склади_Select.SplitSelectToPages, Склади_Select.QuerySelect, unigueIDSelect);


            await Склади_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Склади_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Склади_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ТипСкладу", Перелічення.ПсевдонімиПерелічення.ТипиСкладів_Alias((Перелічення.ТипиСкладів)(Fields[Склади_Const.ТипСкладу] != DBNull.Value ? Fields[Склади_Const.ТипСкладу] : 0)));
                    row.Fields.Add("НалаштуванняАдресногоЗберігання", Перелічення.ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Alias((Перелічення.НалаштуванняАдресногоЗберігання)(Fields[Склади_Const.НалаштуванняАдресногоЗберігання] != DBNull.Value ? Fields[Склади_Const.НалаштуванняАдресногоЗберігання] : 0)));

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Склади_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Склади_Select Склади_Select = new();
            Склади_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Склади_Const.Код,
                /*Назва*/ Довідники.Склади_Const.Назва,

            ]);


            if (form.WhereList != null) Склади_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Склади_Select.QuerySelect.Order.Add(
             Довідники.Склади_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Склади_Select.SplitSelectToPages, Склади_Select.QuerySelect, unigueIDSelect);


            await Склади_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Склади_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Склади_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ВидиЦін"

    public static class ВидиЦін_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Валюта, "Валюта"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ВидиЦін_Select ВидиЦін_Select = new();
            ВидиЦін_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиЦін_Const.Код,
                /*Назва*/ Довідники.ВидиЦін_Const.Назва,

            ]);


            if (form.WhereList != null) ВидиЦін_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ВидиЦін_Select.QuerySelect.Order.Add(
             Довідники.ВидиЦін_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Валюти_Pointer.GetJoin(ВидиЦін_Select.QuerySelect, Довідники.ВидиЦін_Const.Валюта,
            ВидиЦін_Select.QuerySelect.Table, "join_tab_1", "Валюта");


            /* Pages */
            await form.SplitPages(ВидиЦін_Select.SplitSelectToPages, ВидиЦін_Select.QuerySelect, unigueIDSelect);


            await ВидиЦін_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиЦін_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиЦін_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class ВидиЦін_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ВидиЦін_Select ВидиЦін_Select = new();
            ВидиЦін_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ВидиЦін_Const.Назва,

            ]);


            if (form.WhereList != null) ВидиЦін_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ВидиЦін_Select.QuerySelect.Order.Add(
             Довідники.ВидиЦін_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ВидиЦін_Select.SplitSelectToPages, ВидиЦін_Select.QuerySelect, unigueIDSelect);


            await ВидиЦін_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ВидиЦін_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ВидиЦінПостачальників"

    public static class ВидиЦінПостачальників_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ВидиЦінПостачальників_Select ВидиЦінПостачальників_Select = new();
            ВидиЦінПостачальників_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиЦінПостачальників_Const.Код,
                /*Назва*/ Довідники.ВидиЦінПостачальників_Const.Назва,

            ]);


            if (form.WhereList != null) ВидиЦінПостачальників_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ВидиЦінПостачальників_Select.QuerySelect.Order.Add(
             Довідники.ВидиЦінПостачальників_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ВидиЦінПостачальників_Select.SplitSelectToPages, ВидиЦінПостачальників_Select.QuerySelect, unigueIDSelect);


            await ВидиЦінПостачальників_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ВидиЦінПостачальників_Select.MoveNext())
            {
                Довідники.ВидиЦінПостачальників_Pointer? curr = ВидиЦінПостачальників_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиЦінПостачальників_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиЦінПостачальників_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Користувачі"

    public static class Користувачі_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Користувачі_Select Користувачі_Select = new();
            Користувачі_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Користувачі_Const.Код,
                /*Назва*/ Довідники.Користувачі_Const.Назва,

            ]);


            if (form.WhereList != null) Користувачі_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Користувачі_Select.QuerySelect.Order.Add(
             Довідники.Користувачі_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Користувачі_Select.SplitSelectToPages, Користувачі_Select.QuerySelect, unigueIDSelect);


            await Користувачі_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Користувачі_Select.MoveNext())
            {
                Довідники.Користувачі_Pointer? curr = Користувачі_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Користувачі_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Користувачі_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ФізичніОсоби"

    public static class ФізичніОсоби_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ФізичніОсоби_Select ФізичніОсоби_Select = new();
            ФізичніОсоби_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ФізичніОсоби_Const.Код,
                /*Назва*/ Довідники.ФізичніОсоби_Const.Назва,

            ]);


            if (form.WhereList != null) ФізичніОсоби_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ФізичніОсоби_Select.QuerySelect.Order.Add(
             Довідники.ФізичніОсоби_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ФізичніОсоби_Select.SplitSelectToPages, ФізичніОсоби_Select.QuerySelect, unigueIDSelect);


            await ФізичніОсоби_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ФізичніОсоби_Select.MoveNext())
            {
                Довідники.ФізичніОсоби_Pointer? curr = ФізичніОсоби_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ФізичніОсоби_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ФізичніОсоби_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "СтруктураПідприємства"

    public static class СтруктураПідприємства_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.СтруктураПідприємства_Select СтруктураПідприємства_Select = new();
            СтруктураПідприємства_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.СтруктураПідприємства_Const.Код,
                /*Назва*/ Довідники.СтруктураПідприємства_Const.Назва,

            ]);


            if (form.WhereList != null) СтруктураПідприємства_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            СтруктураПідприємства_Select.QuerySelect.Order.Add(
             Довідники.СтруктураПідприємства_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(СтруктураПідприємства_Select.SplitSelectToPages, СтруктураПідприємства_Select.QuerySelect, unigueIDSelect);


            await СтруктураПідприємства_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (СтруктураПідприємства_Select.MoveNext())
            {
                Довідники.СтруктураПідприємства_Pointer? curr = СтруктураПідприємства_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[СтруктураПідприємства_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[СтруктураПідприємства_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "КраїниСвіту"

    public static class КраїниСвіту_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.КраїниСвіту_Select КраїниСвіту_Select = new();
            КраїниСвіту_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.КраїниСвіту_Const.Код,
                /*Назва*/ Довідники.КраїниСвіту_Const.Назва,

            ]);


            if (form.WhereList != null) КраїниСвіту_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            КраїниСвіту_Select.QuerySelect.Order.Add(
             Довідники.КраїниСвіту_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(КраїниСвіту_Select.SplitSelectToPages, КраїниСвіту_Select.QuerySelect, unigueIDSelect);


            await КраїниСвіту_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (КраїниСвіту_Select.MoveNext())
            {
                Довідники.КраїниСвіту_Pointer? curr = КраїниСвіту_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[КраїниСвіту_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[КраїниСвіту_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Файли"

    public static class Файли_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: НазваФайлу, "Назва файлу"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Розмір, "Розмір"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ДатаСтворення, "Дата створення"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


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


            if (form.WhereList != null) Файли_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Файли_Select.QuerySelect.Order.Add(
             Довідники.Файли_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Файли_Select.SplitSelectToPages, Файли_Select.QuerySelect, unigueIDSelect);


            await Файли_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Файли_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Файли_Const.Назва].ToString() ?? "");
                    row.Fields.Add("НазваФайлу", Fields[Файли_Const.НазваФайлу].ToString() ?? "");
                    row.Fields.Add("Розмір", Fields[Файли_Const.Розмір].ToString() ?? "");
                    row.Fields.Add("ДатаСтворення", Fields[Файли_Const.ДатаСтворення].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Файли_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Файли_Select Файли_Select = new();
            Файли_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Файли_Const.Назва,

            ]);


            if (form.WhereList != null) Файли_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Файли_Select.QuerySelect.Order.Add(
             Довідники.Файли_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Файли_Select.SplitSelectToPages, Файли_Select.QuerySelect, unigueIDSelect);


            await Файли_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Файли_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ХарактеристикиНоменклатури"

    public static class ХарактеристикиНоменклатури_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Номенклатура, "Номенклатура"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Залишки, "Залишки"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВРезерві, "В резерві"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВРезервіПідЗамовлення, "Під замовлення"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ХарактеристикиНоменклатури_Select ХарактеристикиНоменклатури_Select = new();
            ХарактеристикиНоменклатури_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ХарактеристикиНоменклатури_Const.Код,
                /*Назва*/ Довідники.ХарактеристикиНоменклатури_Const.Назва,

            ]);


            if (form.WhereList != null) ХарактеристикиНоменклатури_Select.QuerySelect.Where = (List<Where>)form.WhereList;


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


            /* Pages */
            await form.SplitPages(ХарактеристикиНоменклатури_Select.SplitSelectToPages, ХарактеристикиНоменклатури_Select.QuerySelect, unigueIDSelect);


            await ХарактеристикиНоменклатури_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ХарактеристикиНоменклатури_Select.MoveNext())
            {
                Довідники.ХарактеристикиНоменклатури_Pointer? curr = ХарактеристикиНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ХарактеристикиНоменклатури_Const.Код].ToString() ?? "");
                    row.Fields.Add("Номенклатура", Fields["Номенклатура"].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ХарактеристикиНоменклатури_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Залишки", Fields["Залишки"].ToString() ?? "");
                    row.Fields.Add("ВРезерві", Fields["ВРезерві"].ToString() ?? "");
                    row.Fields.Add("ВРезервіПідЗамовлення", Fields["ВРезервіПідЗамовлення"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Номенклатура_Папки"

    public static class Номенклатура_Папки_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Номенклатура_Папки_SelectHierarchical Номенклатура_Папки_Select = new();
            Номенклатура_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Номенклатура_Папки_Const.Назва,
                /*Код*/ Довідники.Номенклатура_Папки_Const.Код,

            ]);


            if (form.WhereList != null) Номенклатура_Папки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Номенклатура_Папки_Select.QuerySelect.Order.Add(
             Довідники.Номенклатура_Папки_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Номенклатура_Папки_Select.SplitSelectToPages, Номенклатура_Папки_Select.QuerySelect, unigueIDSelect);


            await Номенклатура_Папки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Номенклатура_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Номенклатура_Папки_Const.Код].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Номенклатура_Папки_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Номенклатура_Папки_SelectHierarchical Номенклатура_Папки_Select = new();
            Номенклатура_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Номенклатура_Папки_Const.Назва,
                /*Код*/ Довідники.Номенклатура_Папки_Const.Код,

            ]);


            if (form.WhereList != null) Номенклатура_Папки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Номенклатура_Папки_Select.QuerySelect.Order.Add(
             Довідники.Номенклатура_Папки_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Номенклатура_Папки_Select.SplitSelectToPages, Номенклатура_Папки_Select.QuerySelect, unigueIDSelect);


            await Номенклатура_Папки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Номенклатура_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Номенклатура_Папки_Const.Код].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Контрагенти_Папки"

    public static class Контрагенти_Папки_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Контрагенти_Папки_SelectHierarchical Контрагенти_Папки_Select = new();
            Контрагенти_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Контрагенти_Папки_Const.Назва,
                /*Код*/ Довідники.Контрагенти_Папки_Const.Код,

            ]);


            if (form.WhereList != null) Контрагенти_Папки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Контрагенти_Папки_Select.QuerySelect.Order.Add(
             Довідники.Контрагенти_Папки_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Контрагенти_Папки_Select.SplitSelectToPages, Контрагенти_Папки_Select.QuerySelect, unigueIDSelect);


            await Контрагенти_Папки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Контрагенти_Папки_Select.MoveNext())
            {
                Довідники.Контрагенти_Папки_Pointer? curr = Контрагенти_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Контрагенти_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Контрагенти_Папки_Const.Код].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Склади_Папки"

    public static class Склади_Папки_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Склади_Папки_SelectHierarchical Склади_Папки_Select = new();
            Склади_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.Склади_Папки_Const.Назва,
                /*Код*/ Довідники.Склади_Папки_Const.Код,

            ]);


            if (form.WhereList != null) Склади_Папки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Склади_Папки_Select.QuerySelect.Order.Add(
             Довідники.Склади_Папки_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Склади_Папки_Select.SplitSelectToPages, Склади_Папки_Select.QuerySelect, unigueIDSelect);


            await Склади_Папки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Склади_Папки_Select.MoveNext())
            {
                Довідники.Склади_Папки_Pointer? curr = Склади_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[Склади_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[Склади_Папки_Const.Код].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Каси"

    public static class Каси_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Валюта, "Валюта"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Залишок, "Залишок"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Каси_Select Каси_Select = new();
            Каси_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Каси_Const.Код,
                /*Назва*/ Довідники.Каси_Const.Назва,

            ]);


            if (form.WhereList != null) Каси_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Каси_Select.QuerySelect.Order.Add(
             Довідники.Каси_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Валюти_Pointer.GetJoin(Каси_Select.QuerySelect, Довідники.Каси_Const.Валюта,
            Каси_Select.QuerySelect.Table, "join_tab_1", "Валюта");

            /* Додаткове поле: Залишок */
            Каси_Select.QuerySelect.FieldAndAlias.Add(
                new ValueName<string>(@$"(SELECT ROUND(РухКоштів.{РегістриНакопичення.РухКоштів_Підсумки_TablePart.Сума}, 2) AS Сума FROM {РегістриНакопичення.РухКоштів_Підсумки_TablePart.TABLE} AS РухКоштів WHERE РухКоштів.{РегістриНакопичення.РухКоштів_Підсумки_TablePart.Каса} = {Довідники.Каси_Const.TABLE}.uid)", "Залишок"));


            /* Pages */
            await form.SplitPages(Каси_Select.SplitSelectToPages, Каси_Select.QuerySelect, unigueIDSelect);


            await Каси_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Каси_Select.MoveNext())
            {
                Довідники.Каси_Pointer? curr = Каси_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Каси_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Каси_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    row.Fields.Add("Залишок", Fields["Залишок"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Каси_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Валюта, "Валюта"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Каси_Select Каси_Select = new();
            Каси_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Каси_Const.Код,
                /*Назва*/ Довідники.Каси_Const.Назва,

            ]);


            if (form.WhereList != null) Каси_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Каси_Select.QuerySelect.Order.Add(
             Довідники.Каси_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Валюти_Pointer.GetJoin(Каси_Select.QuerySelect, Довідники.Каси_Const.Валюта,
            Каси_Select.QuerySelect.Table, "join_tab_1", "Валюта");


            /* Pages */
            await form.SplitPages(Каси_Select.SplitSelectToPages, Каси_Select.QuerySelect, unigueIDSelect);


            await Каси_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Каси_Select.MoveNext())
            {
                Довідники.Каси_Pointer? curr = Каси_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Каси_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Каси_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "БанківськіРахункиОрганізацій"

    public static class БанківськіРахункиОрганізацій_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Валюта, "Валюта"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.БанківськіРахункиОрганізацій_Select БанківськіРахункиОрганізацій_Select = new();
            БанківськіРахункиОрганізацій_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.БанківськіРахункиОрганізацій_Const.Код,
                /*Назва*/ Довідники.БанківськіРахункиОрганізацій_Const.Назва,

            ]);


            if (form.WhereList != null) БанківськіРахункиОрганізацій_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            БанківськіРахункиОрганізацій_Select.QuerySelect.Order.Add(
             Довідники.БанківськіРахункиОрганізацій_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиОрганізацій_Select.QuerySelect, Довідники.БанківськіРахункиОрганізацій_Const.Валюта,
            БанківськіРахункиОрганізацій_Select.QuerySelect.Table, "join_tab_1", "Валюта");


            /* Pages */
            await form.SplitPages(БанківськіРахункиОрганізацій_Select.SplitSelectToPages, БанківськіРахункиОрганізацій_Select.QuerySelect, unigueIDSelect);


            await БанківськіРахункиОрганізацій_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (БанківськіРахункиОрганізацій_Select.MoveNext())
            {
                Довідники.БанківськіРахункиОрганізацій_Pointer? curr = БанківськіРахункиОрганізацій_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[БанківськіРахункиОрганізацій_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[БанківськіРахункиОрганізацій_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ДоговориКонтрагентів"

    public static class ДоговориКонтрагентів_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Контрагент, "Контрагент"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ТипДоговору, "Тип"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* ТипДоговору, enum */
                Switch sw = Switch.New();

                ComboBoxText ТипДоговору = new();
                foreach (var item in ПсевдонімиПерелічення.ТипДоговорів_List())
                    ТипДоговору.Append(item.Value.ToString(), item.Name);
                ТипДоговору.Active = 0;
                object get() => Enum.TryParse(ТипДоговору.ActiveId, out ТипДоговорів value) ? (int)value : 0;

                filterList.Add(new(ДоговориКонтрагентів_Const.ТипДоговору, get, sw));
                form.Filter.Append("Тип:", ТипДоговору, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ДоговориКонтрагентів_Select ДоговориКонтрагентів_Select = new();
            ДоговориКонтрагентів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ДоговориКонтрагентів_Const.Код,
                /*Назва*/ Довідники.ДоговориКонтрагентів_Const.Назва,
                /*ТипДоговору*/ Довідники.ДоговориКонтрагентів_Const.ТипДоговору,

            ]);


            if (form.WhereList != null) ДоговориКонтрагентів_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ДоговориКонтрагентів_Select.QuerySelect.Order.Add(
             Довідники.ДоговориКонтрагентів_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
            ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");


            /* Pages */
            await form.SplitPages(ДоговориКонтрагентів_Select.SplitSelectToPages, ДоговориКонтрагентів_Select.QuerySelect, unigueIDSelect);


            await ДоговориКонтрагентів_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ДоговориКонтрагентів_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Контрагент", Fields["Контрагент"].ToString() ?? "");
                    row.Fields.Add("ТипДоговору", Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((Перелічення.ТипДоговорів)(Fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? Fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0)));

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class ДоговориКонтрагентів_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Контрагент, "Контрагент"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ТипДоговору, "Тип"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ДоговориКонтрагентів_Select ДоговориКонтрагентів_Select = new();
            ДоговориКонтрагентів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ДоговориКонтрагентів_Const.Назва,
                /*ТипДоговору*/ Довідники.ДоговориКонтрагентів_Const.ТипДоговору,

            ]);


            if (form.WhereList != null) ДоговориКонтрагентів_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ДоговориКонтрагентів_Select.QuerySelect.Order.Add(
             Довідники.ДоговориКонтрагентів_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
            ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");


            /* Pages */
            await form.SplitPages(ДоговориКонтрагентів_Select.SplitSelectToPages, ДоговориКонтрагентів_Select.QuerySelect, unigueIDSelect);


            await ДоговориКонтрагентів_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Контрагент", Fields["Контрагент"].ToString() ?? "");
                    row.Fields.Add("ТипДоговору", Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((Перелічення.ТипДоговорів)(Fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? Fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0)));

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "БанківськіРахункиКонтрагентів"

    public static class БанківськіРахункиКонтрагентів_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Валюта, "Валюта"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.БанківськіРахункиКонтрагентів_Select БанківськіРахункиКонтрагентів_Select = new();
            БанківськіРахункиКонтрагентів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.БанківськіРахункиКонтрагентів_Const.Код,
                /*Назва*/ Довідники.БанківськіРахункиКонтрагентів_Const.Назва,

            ]);


            if (form.WhereList != null) БанківськіРахункиКонтрагентів_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            БанківськіРахункиКонтрагентів_Select.QuerySelect.Order.Add(
             Довідники.БанківськіРахункиКонтрагентів_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиКонтрагентів_Select.QuerySelect, Довідники.БанківськіРахункиКонтрагентів_Const.Валюта,
            БанківськіРахункиКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Валюта");


            /* Pages */
            await form.SplitPages(БанківськіРахункиКонтрагентів_Select.SplitSelectToPages, БанківськіРахункиКонтрагентів_Select.QuerySelect, unigueIDSelect);


            await БанківськіРахункиКонтрагентів_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (БанківськіРахункиКонтрагентів_Select.MoveNext())
            {
                Довідники.БанківськіРахункиКонтрагентів_Pointer? curr = БанківськіРахункиКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[БанківськіРахункиКонтрагентів_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[БанківськіРахункиКонтрагентів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "СтаттяРухуКоштів"

    public static class СтаттяРухуКоштів_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КореспондуючийРахунок, "КореспондуючийРахунок"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВидРухуКоштів, "ВидРухуКоштів"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* ВидРухуКоштів, enum */
                Switch sw = Switch.New();

                ComboBoxText ВидРухуКоштів = new();
                foreach (var item in ПсевдонімиПерелічення.ВидиРухуКоштів_List())
                    ВидРухуКоштів.Append(item.Value.ToString(), item.Name);
                ВидРухуКоштів.Active = 0;
                object get() => Enum.TryParse(ВидРухуКоштів.ActiveId, out ВидиРухуКоштів value) ? (int)value : 0;

                filterList.Add(new(СтаттяРухуКоштів_Const.ВидРухуКоштів, get, sw));
                form.Filter.Append("ВидРухуКоштів:", ВидРухуКоштів, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.СтаттяРухуКоштів_Select СтаттяРухуКоштів_Select = new();
            СтаттяРухуКоштів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СтаттяРухуКоштів_Const.Назва,
                /*Код*/ Довідники.СтаттяРухуКоштів_Const.Код,
                /*КореспондуючийРахунок*/ Довідники.СтаттяРухуКоштів_Const.КореспондуючийРахунок,
                /*ВидРухуКоштів*/ Довідники.СтаттяРухуКоштів_Const.ВидРухуКоштів,

            ]);


            if (form.WhereList != null) СтаттяРухуКоштів_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            СтаттяРухуКоштів_Select.QuerySelect.Order.Add(
             Довідники.СтаттяРухуКоштів_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(СтаттяРухуКоштів_Select.SplitSelectToPages, СтаттяРухуКоштів_Select.QuerySelect, unigueIDSelect);


            await СтаттяРухуКоштів_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (СтаттяРухуКоштів_Select.MoveNext())
            {
                Довідники.СтаттяРухуКоштів_Pointer? curr = СтаттяРухуКоштів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СтаттяРухуКоштів_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[СтаттяРухуКоштів_Const.Код].ToString() ?? "");
                    row.Fields.Add("КореспондуючийРахунок", Fields[СтаттяРухуКоштів_Const.КореспондуючийРахунок].ToString() ?? "");
                    row.Fields.Add("ВидРухуКоштів", Перелічення.ПсевдонімиПерелічення.ВидиРухуКоштів_Alias((Перелічення.ВидиРухуКоштів)(Fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] != DBNull.Value ? Fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] : 0)));

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "СеріїНоменклатури"

    public static class СеріїНоменклатури_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Номер, "Номер"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.СеріїНоменклатури_Select СеріїНоменклатури_Select = new();
            СеріїНоменклатури_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Номер*/ Довідники.СеріїНоменклатури_Const.Номер,

            ]);


            if (form.WhereList != null) СеріїНоменклатури_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            СеріїНоменклатури_Select.QuerySelect.Order.Add(
             Довідники.СеріїНоменклатури_Const.Номер, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(СеріїНоменклатури_Select.SplitSelectToPages, СеріїНоменклатури_Select.QuerySelect, unigueIDSelect);


            await СеріїНоменклатури_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (СеріїНоменклатури_Select.MoveNext())
            {
                Довідники.СеріїНоменклатури_Pointer? curr = СеріїНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Номер", Fields[СеріїНоменклатури_Const.Номер].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ПартіяТоварівКомпозит"

    public static class ПартіяТоварівКомпозит_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Дата, "Дата"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ТипДокументу, "ТипДокументу"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ПоступленняТоварівТаПослуг, "ПоступленняТоварівТаПослуг"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ВведенняЗалишків, "ВведенняЗалишків"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Залишки, "Залишки"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* ТипДокументу, enum */
                Switch sw = Switch.New();

                ComboBoxText ТипДокументу = new();
                foreach (var item in ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_List())
                    ТипДокументу.Append(item.Value.ToString(), item.Name);
                ТипДокументу.Active = 0;
                object get() => Enum.TryParse(ТипДокументу.ActiveId, out ТипДокументуПартіяТоварівКомпозит value) ? (int)value : 0;

                filterList.Add(new(ПартіяТоварівКомпозит_Const.ТипДокументу, get, sw));
                form.Filter.Append("ТипДокументу:", ТипДокументу, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ПартіяТоварівКомпозит_Select ПартіяТоварівКомпозит_Select = new();
            ПартіяТоварівКомпозит_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ПартіяТоварівКомпозит_Const.Назва,
                /*Дата*/ Довідники.ПартіяТоварівКомпозит_Const.Дата,
                /*ТипДокументу*/ Довідники.ПартіяТоварівКомпозит_Const.ТипДокументу,

            ]);


            if (form.WhereList != null) ПартіяТоварівКомпозит_Select.QuerySelect.Where = (List<Where>)form.WhereList;


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


            /* Pages */
            await form.SplitPages(ПартіяТоварівКомпозит_Select.SplitSelectToPages, ПартіяТоварівКомпозит_Select.QuerySelect, unigueIDSelect);


            await ПартіяТоварівКомпозит_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ПартіяТоварівКомпозит_Select.MoveNext())
            {
                Довідники.ПартіяТоварівКомпозит_Pointer? curr = ПартіяТоварівКомпозит_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ПартіяТоварівКомпозит_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Дата", Fields[ПартіяТоварівКомпозит_Const.Дата].ToString() ?? "");
                    row.Fields.Add("ТипДокументу", Перелічення.ПсевдонімиПерелічення.ТипДокументуПартіяТоварівКомпозит_Alias((Перелічення.ТипДокументуПартіяТоварівКомпозит)(Fields[ПартіяТоварівКомпозит_Const.ТипДокументу] != DBNull.Value ? Fields[ПартіяТоварівКомпозит_Const.ТипДокументу] : 0)));
                    row.Fields.Add("ПоступленняТоварівТаПослуг", Fields["ПоступленняТоварівТаПослуг"].ToString() ?? "");
                    row.Fields.Add("ВведенняЗалишків", Fields["ВведенняЗалишків"].ToString() ?? "");
                    row.Fields.Add("Залишки", Fields["Залишки"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class ПартіяТоварівКомпозит_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Дата, "Дата"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ПартіяТоварівКомпозит_Select ПартіяТоварівКомпозит_Select = new();
            ПартіяТоварівКомпозит_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ПартіяТоварівКомпозит_Const.Назва,
                /*Дата*/ Довідники.ПартіяТоварівКомпозит_Const.Дата,

            ]);


            if (form.WhereList != null) ПартіяТоварівКомпозит_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ПартіяТоварівКомпозит_Select.QuerySelect.Order.Add(
             Довідники.ПартіяТоварівКомпозит_Const.Дата, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ПартіяТоварівКомпозит_Select.SplitSelectToPages, ПартіяТоварівКомпозит_Select.QuerySelect, unigueIDSelect);


            await ПартіяТоварівКомпозит_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ПартіяТоварівКомпозит_Select.MoveNext())
            {
                Довідники.ПартіяТоварівКомпозит_Pointer? curr = ПартіяТоварівКомпозит_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ПартіяТоварівКомпозит_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Дата", Fields[ПартіяТоварівКомпозит_Const.Дата].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ВидиЗапасів"

    public static class ВидиЗапасів_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ВидиЗапасів_Select ВидиЗапасів_Select = new();
            ВидиЗапасів_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ВидиЗапасів_Const.Код,
                /*Назва*/ Довідники.ВидиЗапасів_Const.Назва,

            ]);


            if (form.WhereList != null) ВидиЗапасів_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ВидиЗапасів_Select.QuerySelect.Order.Add(
             Довідники.ВидиЗапасів_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ВидиЗапасів_Select.SplitSelectToPages, ВидиЗапасів_Select.QuerySelect, unigueIDSelect);


            await ВидиЗапасів_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ВидиЗапасів_Select.MoveNext())
            {
                Довідники.ВидиЗапасів_Pointer? curr = ВидиЗапасів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ВидиЗапасів_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ВидиЗапасів_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Банки"

    public static class Банки_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ПовнаНазва, "Повна назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КодМФО, "Код МФО"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КодЄДРПОУ, "ЄДРПОУ"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: НомерЛіцензії, "Номер ліцензії"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ДатаЛіцензії, "Дата ліцензії"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Статус, "Статус"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ТипНаселеногоПункту, "Тип населеного пункту"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: УнікальнийКодБанку, "Унікальний код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ПоштовийІндекс, "Поштовий індекс"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: НазваНаселеногоПункту, "Населений пункт"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Адреса, "Адреса"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: НомерТелефону, "Телефон"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ДатаВідкриттяУстанови, "Дата відкриття установи"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ДатаЗакриттяУстанови, "Дата закриття установи"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КодНБУ, "Код НБУ"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: КодСтатусу, "КодСтатусу"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ДатаЗапису, "ДатаЗапису"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


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


            if (form.WhereList != null) Банки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Банки_Select.QuerySelect.Order.Add(
             Довідники.Банки_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Банки_Select.SplitSelectToPages, Банки_Select.QuerySelect, unigueIDSelect);


            await Банки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
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

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class Банки_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Банки_Select Банки_Select = new();
            Банки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Банки_Const.Код,
                /*Назва*/ Довідники.Банки_Const.Назва,

            ]);


            if (form.WhereList != null) Банки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Банки_Select.QuerySelect.Order.Add(
             Довідники.Банки_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Банки_Select.SplitSelectToPages, Банки_Select.QuerySelect, unigueIDSelect);


            await Банки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Банки_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Банки_Const.Назва].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "СкладськіПриміщення"

    public static class СкладськіПриміщення_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Склад, "Склад"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: НалаштуванняАдресногоЗберігання, "Налаштування"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

            List<FilterControl.FilterListItem> filterList = [];

            { /* НалаштуванняАдресногоЗберігання, enum */
                Switch sw = Switch.New();

                ComboBoxText НалаштуванняАдресногоЗберігання = new();
                foreach (var item in ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_List())
                    НалаштуванняАдресногоЗберігання.Append(item.Value.ToString(), item.Name);
                НалаштуванняАдресногоЗберігання.Active = 0;
                object get() => Enum.TryParse(НалаштуванняАдресногоЗберігання.ActiveId, out НалаштуванняАдресногоЗберігання value) ? (int)value : 0;

                filterList.Add(new(СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання, get, sw));
                form.Filter.Append("Налаштування:", НалаштуванняАдресногоЗберігання, sw);
            }

            form.Filter.GetWhere = () =>
            {
                List<Where> where = [];
                foreach (var filter in filterList)
                    if (filter.IsOn.Active)
                        where.Add(new Where(filter.Field, Comparison.EQ, filter.GetValueFunc.Invoke()));

                form.WhereList = where;
                return where.Count != 0;
            };

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.СкладськіПриміщення_Select СкладськіПриміщення_Select = new();
            СкладськіПриміщення_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СкладськіПриміщення_Const.Назва,
                /*НалаштуванняАдресногоЗберігання*/ Довідники.СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання,

            ]);


            if (form.WhereList != null) СкладськіПриміщення_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            СкладськіПриміщення_Select.QuerySelect.Order.Add(
             Довідники.СкладськіПриміщення_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Склади_Pointer.GetJoin(СкладськіПриміщення_Select.QuerySelect, Довідники.СкладськіПриміщення_Const.Склад,
            СкладськіПриміщення_Select.QuerySelect.Table, "join_tab_1", "Склад");


            /* Pages */
            await form.SplitPages(СкладськіПриміщення_Select.SplitSelectToPages, СкладськіПриміщення_Select.QuerySelect, unigueIDSelect);


            await СкладськіПриміщення_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (СкладськіПриміщення_Select.MoveNext())
            {
                Довідники.СкладськіПриміщення_Pointer? curr = СкладськіПриміщення_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіПриміщення_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Склад", Fields["Склад"].ToString() ?? "");
                    row.Fields.Add("НалаштуванняАдресногоЗберігання", Перелічення.ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Alias((Перелічення.НалаштуванняАдресногоЗберігання)(Fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] != DBNull.Value ? Fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] : 0)));

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "СкладськіКомірки"

    public static class СкладськіКомірки_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Приміщення, "Приміщення"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Лінія, "Лінія"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Позиція, "Позиція"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Стелаж, "Стелаж"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Ярус, "Ярус"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ТипСкладськоїКомірки, "Тип комірки"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Типорозмір, "Типорозмір"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Папка, "Папка"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


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


            if (form.WhereList != null) СкладськіКомірки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


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


            /* Pages */
            await form.SplitPages(СкладськіКомірки_Select.SplitSelectToPages, СкладськіКомірки_Select.QuerySelect, unigueIDSelect);


            await СкладськіКомірки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіКомірки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Приміщення", Fields["Приміщення"].ToString() ?? "");
                    row.Fields.Add("Лінія", Fields[СкладськіКомірки_Const.Лінія].ToString() ?? "");
                    row.Fields.Add("Позиція", Fields[СкладськіКомірки_Const.Позиція].ToString() ?? "");
                    row.Fields.Add("Стелаж", Fields[СкладськіКомірки_Const.Стелаж].ToString() ?? "");
                    row.Fields.Add("Ярус", Fields[СкладськіКомірки_Const.Ярус].ToString() ?? "");
                    row.Fields.Add("ТипСкладськоїКомірки", Перелічення.ПсевдонімиПерелічення.ТипиСкладськихКомірок_Alias((Перелічення.ТипиСкладськихКомірок)(Fields[СкладськіКомірки_Const.ТипСкладськоїКомірки] != DBNull.Value ? Fields[СкладськіКомірки_Const.ТипСкладськоїКомірки] : 0)));
                    row.Fields.Add("Типорозмір", Fields["Типорозмір"].ToString() ?? "");
                    row.Fields.Add("Папка", Fields["Папка"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    public static class СкладськіКомірки_ЗаписиШвидкийВибір
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Приміщення, "Приміщення"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.СкладськіКомірки_Select СкладськіКомірки_Select = new();
            СкладськіКомірки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СкладськіКомірки_Const.Назва,

            ]);


            if (form.WhereList != null) СкладськіКомірки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            СкладськіКомірки_Select.QuerySelect.Order.Add(
             Довідники.СкладськіКомірки_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Приміщення,
            СкладськіКомірки_Select.QuerySelect.Table, "join_tab_1", "Приміщення");


            /* Pages */
            await form.SplitPages(СкладськіКомірки_Select.SplitSelectToPages, СкладськіКомірки_Select.QuerySelect, unigueIDSelect);


            await СкладськіКомірки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіКомірки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Приміщення", Fields["Приміщення"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ОбластьЗберігання"

    public static class ОбластьЗберігання_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Приміщення, "Приміщення"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ОбластьЗберігання_Select ОбластьЗберігання_Select = new();
            ОбластьЗберігання_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.ОбластьЗберігання_Const.Назва,

            ]);


            if (form.WhereList != null) ОбластьЗберігання_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ОбластьЗберігання_Select.QuerySelect.Order.Add(
             Довідники.ОбластьЗберігання_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.СкладськіПриміщення_Pointer.GetJoin(ОбластьЗберігання_Select.QuerySelect, Довідники.ОбластьЗберігання_Const.Приміщення,
            ОбластьЗберігання_Select.QuerySelect.Table, "join_tab_1", "Приміщення");


            /* Pages */
            await form.SplitPages(ОбластьЗберігання_Select.SplitSelectToPages, ОбластьЗберігання_Select.QuerySelect, unigueIDSelect);


            await ОбластьЗберігання_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ОбластьЗберігання_Select.MoveNext())
            {
                Довідники.ОбластьЗберігання_Pointer? curr = ОбластьЗберігання_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ОбластьЗберігання_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Приміщення", Fields["Приміщення"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ТипорозміриКомірок"

    public static class ТипорозміриКомірок_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Висота, "Висота"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Глибина, "Глибина"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Вантажопідйомність, "Вантажопідйомність"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Обєм, "Обєм"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Ширина, "Ширина"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


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


            if (form.WhereList != null) ТипорозміриКомірок_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ТипорозміриКомірок_Select.QuerySelect.Order.Add(
             Довідники.ТипорозміриКомірок_Const.Назва, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(ТипорозміриКомірок_Select.SplitSelectToPages, ТипорозміриКомірок_Select.QuerySelect, unigueIDSelect);


            await ТипорозміриКомірок_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ТипорозміриКомірок_Select.MoveNext())
            {
                Довідники.ТипорозміриКомірок_Pointer? curr = ТипорозміриКомірок_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[ТипорозміриКомірок_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Висота", Fields[ТипорозміриКомірок_Const.Висота].ToString() ?? "");
                    row.Fields.Add("Глибина", Fields[ТипорозміриКомірок_Const.Глибина].ToString() ?? "");
                    row.Fields.Add("Вантажопідйомність", Fields[ТипорозміриКомірок_Const.Вантажопідйомність].ToString() ?? "");
                    row.Fields.Add("Обєм", Fields[ТипорозміриКомірок_Const.Обєм].ToString() ?? "");
                    row.Fields.Add("Ширина", Fields[ТипорозміриКомірок_Const.Ширина].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "СкладськіКомірки_Папки"

    public static class СкладськіКомірки_Папки_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Власник, "Власник"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.СкладськіКомірки_Папки_SelectHierarchical СкладськіКомірки_Папки_Select = new();
            СкладськіКомірки_Папки_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.СкладськіКомірки_Папки_Const.Назва,
                /*Код*/ Довідники.СкладськіКомірки_Папки_Const.Код,

            ]);


            if (form.WhereList != null) СкладськіКомірки_Папки_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            СкладськіКомірки_Папки_Select.QuerySelect.Order.Add(
             Довідники.СкладськіКомірки_Папки_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Папки_Select.QuerySelect, Довідники.СкладськіКомірки_Папки_Const.Власник,
            СкладськіКомірки_Папки_Select.QuerySelect.Table, "join_tab_1", "Власник");


            /* Pages */
            await form.SplitPages(СкладськіКомірки_Папки_Select.SplitSelectToPages, СкладськіКомірки_Папки_Select.QuerySelect, unigueIDSelect);


            await СкладськіКомірки_Папки_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (СкладськіКомірки_Папки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Папки_Pointer? curr = СкладськіКомірки_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[СкладськіКомірки_Папки_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Код", Fields[СкладськіКомірки_Папки_Const.Код].ToString() ?? "");
                    row.Fields.Add("Власник", Fields["Власник"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "Блокнот"

    public static class Блокнот_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: ДатаЗапису, "Дата"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.Блокнот_Select Блокнот_Select = new();
            Блокнот_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.Блокнот_Const.Код,
                /*Назва*/ Довідники.Блокнот_Const.Назва,
                /*ДатаЗапису*/ Довідники.Блокнот_Const.ДатаЗапису,

            ]);


            if (form.WhereList != null) Блокнот_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            Блокнот_Select.QuerySelect.Order.Add(
             Довідники.Блокнот_Const.ДатаЗапису, SelectOrder.ASC);


            /* Pages */
            await form.SplitPages(Блокнот_Select.SplitSelectToPages, Блокнот_Select.QuerySelect, unigueIDSelect);


            await Блокнот_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (Блокнот_Select.MoveNext())
            {
                Довідники.Блокнот_Pointer? curr = Блокнот_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[Блокнот_Const.Код].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[Блокнот_Const.Назва].ToString() ?? "");
                    row.Fields.Add("ДатаЗапису", Fields[Блокнот_Const.ДатаЗапису].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "ЗбереженіЗвіти"

    public static class ЗбереженіЗвіти_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Код, "Код"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Додано, "Додано"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Користувач, "Користувач"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.ЗбереженіЗвіти_Select ЗбереженіЗвіти_Select = new();
            ЗбереженіЗвіти_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Код*/ Довідники.ЗбереженіЗвіти_Const.Код,
                /*Додано*/ Довідники.ЗбереженіЗвіти_Const.Додано,
                /*Назва*/ Довідники.ЗбереженіЗвіти_Const.Назва,

            ]);


            if (form.WhereList != null) ЗбереженіЗвіти_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            ЗбереженіЗвіти_Select.QuerySelect.Order.Add(
             Довідники.ЗбереженіЗвіти_Const.Код, SelectOrder.DESC);

            /* Join */
            Довідники.Користувачі_Pointer.GetJoin(ЗбереженіЗвіти_Select.QuerySelect, Довідники.ЗбереженіЗвіти_Const.Користувач,
            ЗбереженіЗвіти_Select.QuerySelect.Table, "join_tab_1", "Користувач");


            /* Pages */
            await form.SplitPages(ЗбереженіЗвіти_Select.SplitSelectToPages, ЗбереженіЗвіти_Select.QuerySelect, unigueIDSelect);


            await ЗбереженіЗвіти_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (ЗбереженіЗвіти_Select.MoveNext())
            {
                Довідники.ЗбереженіЗвіти_Pointer? curr = ЗбереженіЗвіти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Код", Fields[ЗбереженіЗвіти_Const.Код].ToString() ?? "");
                    row.Fields.Add("Додано", Fields[ЗбереженіЗвіти_Const.Додано].ToString() ?? "");
                    row.Fields.Add("Назва", Fields[ЗбереженіЗвіти_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Користувач", Fields["Користувач"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

    #region DIRECTORY "КасиККМ"

    public static class КасиККМ_Записи
    {
        public static void AddColumn(DocumentJournal form)
        {
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
                form.Grid.AppendColumn(column);
            }


            //Назва: Назва, "Назва"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Валюта, "Валюта"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Тип, "Тип"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }

            //Назва: Склад, "Склад"
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnSetup += (_, args) =>
                {
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
                form.Grid.AppendColumn(column);
            }


            { /* Пуста колонка для заповнення вільного простору */
                ColumnViewColumn column = ColumnViewColumn.New(null, null);
                column.Resizable = true;
                column.Expand = true;
                form.Grid.AppendColumn(column);
            }
        }

        public static void CreateFilter(DocumentJournal form)
        {

        }

        public static async ValueTask LoadRecords(DocumentJournal form)
        {
            form.BeforeLoadRecords();

            UnigueID? unigueIDSelect = form.SelectPointerItem ?? form.DocumentPointerItem;


            Довідники.КасиККМ_Select КасиККМ_Select = new();
            КасиККМ_Select.QuerySelect.Field.AddRange(
            [
                "deletion_label",
                /*Назва*/ Довідники.КасиККМ_Const.Назва,
                /*Тип*/ Довідники.КасиККМ_Const.Тип,

            ]);


            if (form.WhereList != null) КасиККМ_Select.QuerySelect.Where = (List<Where>)form.WhereList;


            /* Sort */
            КасиККМ_Select.QuerySelect.Order.Add(
             Довідники.КасиККМ_Const.Назва, SelectOrder.ASC);

            /* Join */
            Довідники.Валюти_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Валюта,
            КасиККМ_Select.QuerySelect.Table, "join_tab_1", "Валюта");

            /* Join */
            Довідники.Склади_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Склад,
            КасиККМ_Select.QuerySelect.Table, "join_tab_2", "Склад");


            /* Pages */
            await form.SplitPages(КасиККМ_Select.SplitSelectToPages, КасиККМ_Select.QuerySelect, unigueIDSelect);


            await КасиККМ_Select.Select();
            form.Store.RemoveAll();
            uint selectPosition = 0;
            while (КасиККМ_Select.MoveNext())
            {
                Довідники.КасиККМ_Pointer? curr = КасиККМ_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> Fields = curr.Fields;
                    DirectoryRow row = new() { UnigueID = curr.UnigueID, DeletionLabel = (bool)Fields["deletion_label"] };
                    row.Fields.Add("Назва", Fields[КасиККМ_Const.Назва].ToString() ?? "");
                    row.Fields.Add("Валюта", Fields["Валюта"].ToString() ?? "");
                    row.Fields.Add("Тип", Перелічення.ПсевдонімиПерелічення.ТипККМ_Alias((Перелічення.ТипККМ)(Fields[КасиККМ_Const.Тип] != DBNull.Value ? Fields[КасиККМ_Const.Тип] : 0)));
                    row.Fields.Add("Склад", Fields["Склад"].ToString() ?? "");

                    form.Store.Append(row);
                    if (row.UnigueID.Equals(unigueIDSelect)) selectPosition = form.Store.GetNItems();
                }
            }
            form.AfterLoadRecords(selectPosition);
        }
    }

    #endregion

}

