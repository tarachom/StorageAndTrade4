
/*
 *
 * Конфігурації ""Зберігання та Торгівля" для України"
 * Автор Тарахомин Юрій Іванович, accounting.org.ua
 * Дата конфігурації: 15.12.2025 13:19:30
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
        [Subclass<GObject.Object>]
        partial  class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(out ColumnView columnView)
        {
            Console.WriteLine(Row.GetGType());
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView = ColumnView.New(model);

            //Image
            /*{
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }*/
        }

        public static async ValueTask LoadRecords()
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
            
            await Організації_Select.Select();
            while (Організації_Select.MoveNext())
            {
                Довідники.Організації_Pointer? curr = Організації_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Організації_Const.Код].ToString() ?? "",
                            Назва = fields[Організації_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Номенклатура"
        
    public partial class Номенклатура_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string ОдиницяВиміру { get; set; } = "";
            
            public string ТипНоменклатури { get; set; } = "";
            
            public string Залишок { get; set; } = "";
            public string ВРезерві { get; set; } = "";
            public string ВРезервіПідЗамовлення { get; set; } = "";
            public string ЗалишокВКомірках { get; set; } = "";
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.ПакуванняОдиниціВиміру_Pointer.GetJoin(Номенклатура_Select.QuerySelect, Довідники.Номенклатура_Const.ОдиницяВиміру,
                Номенклатура_Select.QuerySelect.Table, "join_tab_1", "ОдиницяВиміру");
            
                /* Additional Field */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ВНаявності} ) AS ВНаявності FROM {РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.TABLE} AS ТовариНаСкладах WHERE ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВНаявності, 1) FROM Залишки ) END)", "Залишок"));
            
                /* Additional Field */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіЗіСкладу} ) AS ВРезервіЗіСкладу FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіЗіСкладу, 1) FROM Залишки ) END)", "ВРезерві"));
            
                /* Additional Field */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіПідЗамовлення} ) AS ВРезервіПідЗамовлення FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіПідЗамовлення, 1) FROM Залишки ) END)", "ВРезервіПідЗамовлення"));
            
                /* Additional Field */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ТовариВКомірках.{РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ТовариВКомірках.{РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.ВНаявності} ) AS ВНаявності FROM {РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.TABLE} AS ТовариВКомірках WHERE ТовариВКомірках.{РегістриНакопичення.ТовариВКомірках_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВНаявності, 1) FROM Залишки ) END)", "ЗалишокВКомірках"));
            
            await Номенклатура_Select.Select();
            while (Номенклатура_Select.MoveNext())
            {
                Довідники.Номенклатура_Pointer? curr = Номенклатура_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    public partial class Номенклатура_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string ОдиницяВиміру { get; set; } = "";
            
            public string Залишок { get; set; } = "";
            public string ВРезерві { get; set; } = "";
            public string ВРезервіПідЗамовлення { get; set; } = "";
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.ПакуванняОдиниціВиміру_Pointer.GetJoin(Номенклатура_Select.QuerySelect, Довідники.Номенклатура_Const.ОдиницяВиміру,
                Номенклатура_Select.QuerySelect.Table, "join_tab_1", "ОдиницяВиміру");
            
                /* Additional Field */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ВНаявності} ) AS ВНаявності FROM {РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.TABLE} AS ТовариНаСкладах WHERE ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВНаявності, 1) FROM Залишки ) END)", "Залишок"));
            
                /* Additional Field */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіЗіСкладу} ) AS ВРезервіЗіСкладу FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіЗіСкладу, 1) FROM Залишки ) END)", "ВРезерві"));
            
                /* Additional Field */
                Номенклатура_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(CASE WHEN {Довідники.Номенклатура_Const.TABLE}.{Довідники.Номенклатура_Const.ТипНоменклатури} = {(int)Перелічення.ТипиНоменклатури.Товар} THEN ( WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} AS Номенклатура, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіПідЗамовлення} ) AS ВРезервіПідЗамовлення FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.Номенклатура_Const.TABLE}.uid GROUP BY Номенклатура ) SELECT ROUND(ВРезервіПідЗамовлення, 1) FROM Залишки ) END)", "ВРезервіПідЗамовлення"));
            
            await Номенклатура_Select.Select();
            while (Номенклатура_Select.MoveNext())
            {
                Довідники.Номенклатура_Pointer? curr = Номенклатура_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Виробники"
        
    public partial class Виробники_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Виробники_Select.Select();
            while (Виробники_Select.MoveNext())
            {
                Довідники.Виробники_Pointer? curr = Виробники_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Виробники_Const.Код].ToString() ?? "",
                            Назва = fields[Виробники_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиНоменклатури"
        
    public partial class ВидиНоменклатури_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ВидиНоменклатури_Select.Select();
            while (ВидиНоменклатури_Select.MoveNext())
            {
                Довідники.ВидиНоменклатури_Pointer? curr = ВидиНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиНоменклатури_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиНоменклатури_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ПакуванняОдиниціВиміру"
        
    public partial class ПакуванняОдиниціВиміру_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string КількістьУпаковок { get; set; } = "";
            
            public string НазваПовна { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ПакуванняОдиниціВиміру_Select.Select();
            while (ПакуванняОдиниціВиміру_Select.MoveNext())
            {
                Довідники.ПакуванняОдиниціВиміру_Pointer? curr = ПакуванняОдиниціВиміру_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ПакуванняОдиниціВиміру_Const.Код].ToString() ?? "",
                            Назва = fields[ПакуванняОдиниціВиміру_Const.Назва].ToString() ?? "",
                            КількістьУпаковок = fields[ПакуванняОдиниціВиміру_Const.КількістьУпаковок].ToString() ?? "",
                            НазваПовна = fields[ПакуванняОдиниціВиміру_Const.НазваПовна].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Валюти"
        
    public partial class Валюти_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string КороткаНазва { get; set; } = "";
            
            public string Код_R030 { get; set; } = "";
            
            public string ВиводитиКурсНаСтартову { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Валюти_Select.Select();
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Валюти_Const.Код].ToString() ?? "",
                            Назва = fields[Валюти_Const.Назва].ToString() ?? "",
                            КороткаНазва = fields[Валюти_Const.КороткаНазва].ToString() ?? "",
                            Код_R030 = fields[Валюти_Const.Код_R030].ToString() ?? "",
                            ВиводитиКурсНаСтартову = (fields[Валюти_Const.ВиводитиКурсНаСтартову] != DBNull.Value ? (bool)fields[Валюти_Const.ВиводитиКурсНаСтартову] : false) ? "Так" : "",
                            
                    };
                }
            }
        }
    }
        
    public partial class Валюти_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string КороткаНазва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Валюти_Select.Select();
            while (Валюти_Select.MoveNext())
            {
                Довідники.Валюти_Pointer? curr = Валюти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Валюти_Const.Код].ToString() ?? "",
                            Назва = fields[Валюти_Const.Назва].ToString() ?? "",
                            КороткаНазва = fields[Валюти_Const.КороткаНазва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Контрагенти"
        
    public partial class Контрагенти_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Папка { get; set; } = "";
            
            public string Постачальник { get; set; } = "";
            
            public string Покупець { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Контрагенти_Папки_Pointer.GetJoin(Контрагенти_Select.QuerySelect, Довідники.Контрагенти_Const.Папка,
                Контрагенти_Select.QuerySelect.Table, "join_tab_1", "Папка");
            
            await Контрагенти_Select.Select();
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Контрагенти_Const.Код].ToString() ?? "",
                            Назва = fields[Контрагенти_Const.Назва].ToString() ?? "",
                            Папка = fields["Папка"].ToString() ?? "",
                            Постачальник = (fields[Контрагенти_Const.Постачальник] != DBNull.Value ? (bool)fields[Контрагенти_Const.Постачальник] : false) ? "Так" : "",
                            Покупець = (fields[Контрагенти_Const.Покупець] != DBNull.Value ? (bool)fields[Контрагенти_Const.Покупець] : false) ? "Так" : "",
                            
                    };
                }
            }
        }
    }
        
    public partial class Контрагенти_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Контрагенти_Select.Select();
            while (Контрагенти_Select.MoveNext())
            {
                Довідники.Контрагенти_Pointer? curr = Контрагенти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Контрагенти_Const.Код].ToString() ?? "",
                            Назва = fields[Контрагенти_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Склади"
        
    public partial class Склади_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string ТипСкладу { get; set; } = "";
            
            public string НалаштуванняАдресногоЗберігання { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Склади_Select.Select();
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    public partial class Склади_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Склади_Select.Select();
            while (Склади_Select.MoveNext())
            {
                Довідники.Склади_Pointer? curr = Склади_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Склади_Const.Код].ToString() ?? "",
                            Назва = fields[Склади_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЦін"
        
    public partial class ВидиЦін_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Валюта { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Валюти_Pointer.GetJoin(ВидиЦін_Select.QuerySelect, Довідники.ВидиЦін_Const.Валюта,
                ВидиЦін_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await ВидиЦін_Select.Select();
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиЦін_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиЦін_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    public partial class ВидиЦін_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ВидиЦін_Select.Select();
            while (ВидиЦін_Select.MoveNext())
            {
                Довідники.ВидиЦін_Pointer? curr = ВидиЦін_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ВидиЦін_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЦінПостачальників"
        
    public partial class ВидиЦінПостачальників_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ВидиЦінПостачальників_Select.Select();
            while (ВидиЦінПостачальників_Select.MoveNext())
            {
                Довідники.ВидиЦінПостачальників_Pointer? curr = ВидиЦінПостачальників_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиЦінПостачальників_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиЦінПостачальників_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Користувачі"
        
    public partial class Користувачі_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Користувачі_Select.Select();
            while (Користувачі_Select.MoveNext())
            {
                Довідники.Користувачі_Pointer? curr = Користувачі_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Користувачі_Const.Код].ToString() ?? "",
                            Назва = fields[Користувачі_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ФізичніОсоби"
        
    public partial class ФізичніОсоби_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ФізичніОсоби_Select.Select();
            while (ФізичніОсоби_Select.MoveNext())
            {
                Довідники.ФізичніОсоби_Pointer? curr = ФізичніОсоби_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ФізичніОсоби_Const.Код].ToString() ?? "",
                            Назва = fields[ФізичніОсоби_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СтруктураПідприємства"
        
    public partial class СтруктураПідприємства_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await СтруктураПідприємства_Select.Select();
            while (СтруктураПідприємства_Select.MoveNext())
            {
                Довідники.СтруктураПідприємства_Pointer? curr = СтруктураПідприємства_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[СтруктураПідприємства_Const.Код].ToString() ?? "",
                            Назва = fields[СтруктураПідприємства_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "КраїниСвіту"
        
    public partial class КраїниСвіту_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await КраїниСвіту_Select.Select();
            while (КраїниСвіту_Select.MoveNext())
            {
                Довідники.КраїниСвіту_Pointer? curr = КраїниСвіту_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[КраїниСвіту_Const.Код].ToString() ?? "",
                            Назва = fields[КраїниСвіту_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Файли"
        
    public partial class Файли_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string НазваФайлу { get; set; } = "";
            
            public string Розмір { get; set; } = "";
            
            public string ДатаСтворення { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Файли_Select.Select();
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Файли_Const.Код].ToString() ?? "",
                            Назва = fields[Файли_Const.Назва].ToString() ?? "",
                            НазваФайлу = fields[Файли_Const.НазваФайлу].ToString() ?? "",
                            Розмір = fields[Файли_Const.Розмір].ToString() ?? "",
                            ДатаСтворення = fields[Файли_Const.ДатаСтворення].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    public partial class Файли_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Файли_Select.Select();
            while (Файли_Select.MoveNext())
            {
                Довідники.Файли_Pointer? curr = Файли_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Файли_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ХарактеристикиНоменклатури"
        
    public partial class ХарактеристикиНоменклатури_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Номенклатура { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Залишки { get; set; } = "";
            public string ВРезерві { get; set; } = "";
            public string ВРезервіПідЗамовлення { get; set; } = "";
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Номенклатура_Pointer.GetJoin(ХарактеристикиНоменклатури_Select.QuerySelect, Довідники.ХарактеристикиНоменклатури_Const.Номенклатура,
                ХарактеристикиНоменклатури_Select.QuerySelect.Table, "join_tab_1", "Номенклатура");
            
                /* Additional Field */
                ХарактеристикиНоменклатури_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ХарактеристикаНоменклатури} AS Характеристика, SUM(ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ВНаявності}) AS ВНаявності FROM {РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.TABLE} AS ТовариНаСкладах WHERE ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.Номенклатура} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.{Довідники.ХарактеристикиНоменклатури_Const.Номенклатура} AND ТовариНаСкладах.{РегістриНакопичення.ТовариНаСкладах_Підсумки_TablePart.ХарактеристикаНоменклатури} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.uid GROUP BY Характеристика ) SELECT ROUND(ВНаявності, 1) FROM Залишки)", "Залишки"));
            
                /* Additional Field */
                ХарактеристикиНоменклатури_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} AS Характеристика, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіЗіСкладу}) AS ВРезервіЗіСкладу FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.{Довідники.ХарактеристикиНоменклатури_Const.Номенклатура} AND ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.uid GROUP BY Характеристика ) SELECT ROUND(ВРезервіЗіСкладу, 1) FROM Залишки)", "ВРезерві"));
            
                /* Additional Field */
                ХарактеристикиНоменклатури_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} AS Характеристика, SUM(ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ВРезервіПідЗамовлення}) AS ВРезервіПідЗамовлення FROM {РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.TABLE} AS ВільніЗалишки WHERE ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.Номенклатура} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.{Довідники.ХарактеристикиНоменклатури_Const.Номенклатура} AND ВільніЗалишки.{РегістриНакопичення.ВільніЗалишки_Підсумки_TablePart.ХарактеристикаНоменклатури} = {Довідники.ХарактеристикиНоменклатури_Const.TABLE}.uid GROUP BY Характеристика ) SELECT ROUND(ВРезервіПідЗамовлення, 1) FROM Залишки)", "ВРезервіПідЗамовлення"));
            
            await ХарактеристикиНоменклатури_Select.Select();
            while (ХарактеристикиНоменклатури_Select.MoveNext())
            {
                Довідники.ХарактеристикиНоменклатури_Pointer? curr = ХарактеристикиНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Номенклатура_Папки"
        
    public partial class Номенклатура_Папки_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Код { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Номенклатура_Папки_Select.Select();
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Номенклатура_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Номенклатура_Папки_Const.Код].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    public partial class Номенклатура_Папки_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Код { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Номенклатура_Папки_Select.Select();
            while (Номенклатура_Папки_Select.MoveNext())
            {
                Довідники.Номенклатура_Папки_Pointer? curr = Номенклатура_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Номенклатура_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Номенклатура_Папки_Const.Код].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Контрагенти_Папки"
        
    public partial class Контрагенти_Папки_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Код { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Контрагенти_Папки_Select.Select();
            while (Контрагенти_Папки_Select.MoveNext())
            {
                Довідники.Контрагенти_Папки_Pointer? curr = Контрагенти_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Контрагенти_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Контрагенти_Папки_Const.Код].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Склади_Папки"
        
    public partial class Склади_Папки_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Код { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Склади_Папки_Select.Select();
            while (Склади_Папки_Select.MoveNext())
            {
                Довідники.Склади_Папки_Pointer? curr = Склади_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[Склади_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[Склади_Папки_Const.Код].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Каси"
        
    public partial class Каси_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Валюта { get; set; } = "";
            
            public string Залишок { get; set; } = "";
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Валюти_Pointer.GetJoin(Каси_Select.QuerySelect, Довідники.Каси_Const.Валюта,
                Каси_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
                /* Additional Field */
                Каси_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(SELECT ROUND(РухКоштів.{РегістриНакопичення.РухКоштів_Підсумки_TablePart.Сума}, 2) AS Сума FROM {РегістриНакопичення.РухКоштів_Підсумки_TablePart.TABLE} AS РухКоштів WHERE РухКоштів.{РегістриНакопичення.РухКоштів_Підсумки_TablePart.Каса} = {Довідники.Каси_Const.TABLE}.uid)", "Залишок"));
            
            await Каси_Select.Select();
            while (Каси_Select.MoveNext())
            {
                Довідники.Каси_Pointer? curr = Каси_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Каси_Const.Код].ToString() ?? "",
                            Назва = fields[Каси_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            Залишок = fields["Залишок"].ToString() ?? "",
                        
                    };
                }
            }
        }
    }
        
    public partial class Каси_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Валюта { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Валюти_Pointer.GetJoin(Каси_Select.QuerySelect, Довідники.Каси_Const.Валюта,
                Каси_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await Каси_Select.Select();
            while (Каси_Select.MoveNext())
            {
                Довідники.Каси_Pointer? curr = Каси_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Каси_Const.Код].ToString() ?? "",
                            Назва = fields[Каси_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "БанківськіРахункиОрганізацій"
        
    public partial class БанківськіРахункиОрганізацій_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Валюта { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиОрганізацій_Select.QuerySelect, Довідники.БанківськіРахункиОрганізацій_Const.Валюта,
                БанківськіРахункиОрганізацій_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await БанківськіРахункиОрганізацій_Select.Select();
            while (БанківськіРахункиОрганізацій_Select.MoveNext())
            {
                Довідники.БанківськіРахункиОрганізацій_Pointer? curr = БанківськіРахункиОрганізацій_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[БанківськіРахункиОрганізацій_Const.Код].ToString() ?? "",
                            Назва = fields[БанківськіРахункиОрганізацій_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ДоговориКонтрагентів"
        
    public partial class ДоговориКонтрагентів_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Контрагент { get; set; } = "";
            
            public string ТипДоговору { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
                ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");
            
            await ДоговориКонтрагентів_Select.Select();
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ДоговориКонтрагентів_Const.Код].ToString() ?? "",
                            Назва = fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "",
                            Контрагент = fields["Контрагент"].ToString() ?? "",
                            ТипДоговору = Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((
                              (Перелічення.ТипДоговорів)(fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0)) ),
                            
                    };
                }
            }
        }
    }
        
    public partial class ДоговориКонтрагентів_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Контрагент { get; set; } = "";
            
            public string ТипДоговору { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Контрагенти_Pointer.GetJoin(ДоговориКонтрагентів_Select.QuerySelect, Довідники.ДоговориКонтрагентів_Const.Контрагент,
                ДоговориКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Контрагент");
            
            await ДоговориКонтрагентів_Select.Select();
            while (ДоговориКонтрагентів_Select.MoveNext())
            {
                Довідники.ДоговориКонтрагентів_Pointer? curr = ДоговориКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ДоговориКонтрагентів_Const.Назва].ToString() ?? "",
                            Контрагент = fields["Контрагент"].ToString() ?? "",
                            ТипДоговору = Перелічення.ПсевдонімиПерелічення.ТипДоговорів_Alias((
                              (Перелічення.ТипДоговорів)(fields[ДоговориКонтрагентів_Const.ТипДоговору] != DBNull.Value ? fields[ДоговориКонтрагентів_Const.ТипДоговору] : 0)) ),
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "БанківськіРахункиКонтрагентів"
        
    public partial class БанківськіРахункиКонтрагентів_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Валюта { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Валюти_Pointer.GetJoin(БанківськіРахункиКонтрагентів_Select.QuerySelect, Довідники.БанківськіРахункиКонтрагентів_Const.Валюта,
                БанківськіРахункиКонтрагентів_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            
            await БанківськіРахункиКонтрагентів_Select.Select();
            while (БанківськіРахункиКонтрагентів_Select.MoveNext())
            {
                Довідники.БанківськіРахункиКонтрагентів_Pointer? curr = БанківськіРахункиКонтрагентів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[БанківськіРахункиКонтрагентів_Const.Код].ToString() ?? "",
                            Назва = fields[БанківськіРахункиКонтрагентів_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СтаттяРухуКоштів"
        
    public partial class СтаттяРухуКоштів_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Код { get; set; } = "";
            
            public string КореспондуючийРахунок { get; set; } = "";
            
            public string ВидРухуКоштів { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await СтаттяРухуКоштів_Select.Select();
            while (СтаттяРухуКоштів_Select.MoveNext())
            {
                Довідники.СтаттяРухуКоштів_Pointer? curr = СтаттяРухуКоштів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СтаттяРухуКоштів_Const.Назва].ToString() ?? "",
                            Код = fields[СтаттяРухуКоштів_Const.Код].ToString() ?? "",
                            КореспондуючийРахунок = fields[СтаттяРухуКоштів_Const.КореспондуючийРахунок].ToString() ?? "",
                            ВидРухуКоштів = Перелічення.ПсевдонімиПерелічення.ВидиРухуКоштів_Alias((
                              (Перелічення.ВидиРухуКоштів)(fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] != DBNull.Value ? fields[СтаттяРухуКоштів_Const.ВидРухуКоштів] : 0)) ),
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СеріїНоменклатури"
        
    public partial class СеріїНоменклатури_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Номер { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await СеріїНоменклатури_Select.Select();
            while (СеріїНоменклатури_Select.MoveNext())
            {
                Довідники.СеріїНоменклатури_Pointer? curr = СеріїНоменклатури_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Номер = fields[СеріїНоменклатури_Const.Номер].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ПартіяТоварівКомпозит"
        
    public partial class ПартіяТоварівКомпозит_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Дата { get; set; } = "";
            
            public string ТипДокументу { get; set; } = "";
            
            public string ПоступленняТоварівТаПослуг { get; set; } = "";
            
            public string ВведенняЗалишків { get; set; } = "";
            
            public string Залишки { get; set; } = "";
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Документи.ПоступленняТоварівТаПослуг_Pointer.GetJoin(ПартіяТоварівКомпозит_Select.QuerySelect, Довідники.ПартіяТоварівКомпозит_Const.ПоступленняТоварівТаПослуг,
                ПартіяТоварівКомпозит_Select.QuerySelect.Table, "join_tab_1", "ПоступленняТоварівТаПослуг");
            Документи.ВведенняЗалишків_Pointer.GetJoin(ПартіяТоварівКомпозит_Select.QuerySelect, Довідники.ПартіяТоварівКомпозит_Const.ВведенняЗалишків,
                ПартіяТоварівКомпозит_Select.QuerySelect.Table, "join_tab_2", "ВведенняЗалишків");
            
                /* Additional Field */
                ПартіяТоварівКомпозит_Select.QuerySelect.FieldAndAlias.Add(
                    new ValueName<string>(@$"(WITH Залишки AS ( SELECT ПартіїТоварів.{РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.ПартіяТоварівКомпозит} AS ПартіяТоварівКомпозит, SUM(ПартіїТоварів.{РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.Кількість} ) AS Кількість FROM {РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.TABLE} AS ПартіїТоварів WHERE ПартіїТоварів.{РегістриНакопичення.ПартіїТоварів_Підсумки_TablePart.ПартіяТоварівКомпозит} = {Довідники.ПартіяТоварівКомпозит_Const.TABLE}.uid GROUP BY ПартіяТоварівКомпозит ) SELECT ROUND(Кількість, 1) FROM Залишки)", "Залишки"));
            
            await ПартіяТоварівКомпозит_Select.Select();
            while (ПартіяТоварівКомпозит_Select.MoveNext())
            {
                Довідники.ПартіяТоварівКомпозит_Pointer? curr = ПартіяТоварівКомпозит_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    public partial class ПартіяТоварівКомпозит_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Дата { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ПартіяТоварівКомпозит_Select.Select();
            while (ПартіяТоварівКомпозит_Select.MoveNext())
            {
                Довідники.ПартіяТоварівКомпозит_Pointer? curr = ПартіяТоварівКомпозит_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ПартіяТоварівКомпозит_Const.Назва].ToString() ?? "",
                            Дата = fields[ПартіяТоварівКомпозит_Const.Дата].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ВидиЗапасів"
        
    public partial class ВидиЗапасів_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ВидиЗапасів_Select.Select();
            while (ВидиЗапасів_Select.MoveNext())
            {
                Довідники.ВидиЗапасів_Pointer? curr = ВидиЗапасів_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ВидиЗапасів_Const.Код].ToString() ?? "",
                            Назва = fields[ВидиЗапасів_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Банки"
        
    public partial class Банки_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
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

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Банки_Select.Select();
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    public partial class Банки_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Банки_Select.Select();
            while (Банки_Select.MoveNext())
            {
                Довідники.Банки_Pointer? curr = Банки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Банки_Const.Код].ToString() ?? "",
                            Назва = fields[Банки_Const.Назва].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіПриміщення"
        
    public partial class СкладськіПриміщення_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Склад { get; set; } = "";
            
            public string НалаштуванняАдресногоЗберігання { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Склади_Pointer.GetJoin(СкладськіПриміщення_Select.QuerySelect, Довідники.СкладськіПриміщення_Const.Склад,
                СкладськіПриміщення_Select.QuerySelect.Table, "join_tab_1", "Склад");
            
            await СкладськіПриміщення_Select.Select();
            while (СкладськіПриміщення_Select.MoveNext())
            {
                Довідники.СкладськіПриміщення_Pointer? curr = СкладськіПриміщення_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СкладськіПриміщення_Const.Назва].ToString() ?? "",
                            Склад = fields["Склад"].ToString() ?? "",
                            НалаштуванняАдресногоЗберігання = Перелічення.ПсевдонімиПерелічення.НалаштуванняАдресногоЗберігання_Alias((
                              (Перелічення.НалаштуванняАдресногоЗберігання)(fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] != DBNull.Value ? fields[СкладськіПриміщення_Const.НалаштуванняАдресногоЗберігання] : 0)) ),
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіКомірки"
        
    public partial class СкладськіКомірки_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
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

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Приміщення,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            Довідники.ТипорозміриКомірок_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Типорозмір,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_2", "Типорозмір");
            Довідники.СкладськіКомірки_Папки_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Папка,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_3", "Папка");
            
            await СкладськіКомірки_Select.Select();
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    public partial class СкладськіКомірки_ЗаписиШвидкийВибір
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Приміщення { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Select.QuerySelect, Довідники.СкладськіКомірки_Const.Приміщення,
                СкладськіКомірки_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            
            await СкладськіКомірки_Select.Select();
            while (СкладськіКомірки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Pointer? curr = СкладськіКомірки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СкладськіКомірки_Const.Назва].ToString() ?? "",
                            Приміщення = fields["Приміщення"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ОбластьЗберігання"
        
    public partial class ОбластьЗберігання_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Приміщення { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.СкладськіПриміщення_Pointer.GetJoin(ОбластьЗберігання_Select.QuerySelect, Довідники.ОбластьЗберігання_Const.Приміщення,
                ОбластьЗберігання_Select.QuerySelect.Table, "join_tab_1", "Приміщення");
            
            await ОбластьЗберігання_Select.Select();
            while (ОбластьЗберігання_Select.MoveNext())
            {
                Довідники.ОбластьЗберігання_Pointer? curr = ОбластьЗберігання_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[ОбластьЗберігання_Const.Назва].ToString() ?? "",
                            Приміщення = fields["Приміщення"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ТипорозміриКомірок"
        
    public partial class ТипорозміриКомірок_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Висота { get; set; } = "";
            
            public string Глибина { get; set; } = "";
            
            public string Вантажопідйомність { get; set; } = "";
            
            public string Обєм { get; set; } = "";
            
            public string Ширина { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await ТипорозміриКомірок_Select.Select();
            while (ТипорозміриКомірок_Select.MoveNext())
            {
                Довідники.ТипорозміриКомірок_Pointer? curr = ТипорозміриКомірок_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
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
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "СкладськіКомірки_Папки"
        
    public partial class СкладськіКомірки_Папки_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Код { get; set; } = "";
            
            public string Власник { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.СкладськіПриміщення_Pointer.GetJoin(СкладськіКомірки_Папки_Select.QuerySelect, Довідники.СкладськіКомірки_Папки_Const.Власник,
                СкладськіКомірки_Папки_Select.QuerySelect.Table, "join_tab_1", "Власник");
            
            await СкладськіКомірки_Папки_Select.Select();
            while (СкладськіКомірки_Папки_Select.MoveNext())
            {
                Довідники.СкладськіКомірки_Папки_Pointer? curr = СкладськіКомірки_Папки_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[СкладськіКомірки_Папки_Const.Назва].ToString() ?? "",
                            Код = fields[СкладськіКомірки_Папки_Const.Код].ToString() ?? "",
                            Власник = fields["Власник"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "Блокнот"
        
    public partial class Блокнот_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string ДатаЗапису { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            
            await Блокнот_Select.Select();
            while (Блокнот_Select.MoveNext())
            {
                Довідники.Блокнот_Pointer? curr = Блокнот_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[Блокнот_Const.Код].ToString() ?? "",
                            Назва = fields[Блокнот_Const.Назва].ToString() ?? "",
                            ДатаЗапису = fields[Блокнот_Const.ДатаЗапису].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "ЗбереженіЗвіти"
        
    public partial class ЗбереженіЗвіти_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Код { get; set; } = "";
            
            public string Додано { get; set; } = "";
            
            public string Назва { get; set; } = "";
            
            public string Користувач { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Користувачі_Pointer.GetJoin(ЗбереженіЗвіти_Select.QuerySelect, Довідники.ЗбереженіЗвіти_Const.Користувач,
                ЗбереженіЗвіти_Select.QuerySelect.Table, "join_tab_1", "Користувач");
            
            await ЗбереженіЗвіти_Select.Select();
            while (ЗбереженіЗвіти_Select.MoveNext())
            {
                Довідники.ЗбереженіЗвіти_Pointer? curr = ЗбереженіЗвіти_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Код = fields[ЗбереженіЗвіти_Const.Код].ToString() ?? "",
                            Додано = fields[ЗбереженіЗвіти_Const.Додано].ToString() ?? "",
                            Назва = fields[ЗбереженіЗвіти_Const.Назва].ToString() ?? "",
                            Користувач = fields["Користувач"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
    #region DIRECTORY "КасиККМ"
        
    public partial class КасиККМ_Записи
    {
        [Subclass<GObject.Object>]
        partial class Row
        {
            public UnigueID UID { get; set; } = new();
            public bool DeletionLabel { get; set; } = false;
            
            public string Назва { get; set; } = "";
            
            public string Валюта { get; set; } = "";
            
            public string Тип { get; set; } = "";
            
            public string Склад { get; set; } = "";
            
        }

        public static void AddColumns(ColumnView columnView)
        {
            var store = Gio.ListStore.New(Row.GetGType());

            SingleSelection model = SingleSelection.New(store);
            model.Autoselect = true;

            columnView.Model = model;

            //Image
            {
                SignalListItemFactory factory = SignalListItemFactory.New();
                factory.OnBind += (factory, e) =>
                {
                    ListItem listitem = (ListItem)e.Object;
                    listitem.SetChild(Image.NewFromIconName("window-close-symbolic"));
                };

                ColumnViewColumn column = ColumnViewColumn.New("", factory);
                columnView.AppendColumn(column);
            }
        }

        public static async ValueTask LoadRecords()
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
            Довідники.Валюти_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Валюта,
                КасиККМ_Select.QuerySelect.Table, "join_tab_1", "Валюта");
            Довідники.Склади_Pointer.GetJoin(КасиККМ_Select.QuerySelect, Довідники.КасиККМ_Const.Склад,
                КасиККМ_Select.QuerySelect.Table, "join_tab_2", "Склад");
            
            await КасиККМ_Select.Select();
            while (КасиККМ_Select.MoveNext())
            {
                Довідники.КасиККМ_Pointer? curr = КасиККМ_Select.Current;
                if (curr != null)
                {
                    Dictionary<string, object> fields = curr.Fields;
                    Row row = new()
                    {
                        UID = curr.UnigueID,
                        DeletionLabel = (bool)fields["deletion_label"],
                        Назва = fields[КасиККМ_Const.Назва].ToString() ?? "",
                            Валюта = fields["Валюта"].ToString() ?? "",
                            Тип = Перелічення.ПсевдонімиПерелічення.ТипККМ_Alias((
                              (Перелічення.ТипККМ)(fields[КасиККМ_Const.Тип] != DBNull.Value ? fields[КасиККМ_Const.Тип] : 0)) ),
                            Склад = fields["Склад"].ToString() ?? "",
                            
                    };
                }
            }
        }
    }
        
    #endregion
    
}

  