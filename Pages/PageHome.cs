/*

Стартова сторінка

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode;
using GeneratedCode.Довідники;
using AccountingSoftware;

namespace StorageAndTrade;

class PageHome : Form
{
    public ActiveUsersView activeUsersView = new(Config.Kernel, 800, 300);
    public LockObjectsView lockObjectsView = new(800, 300);

    public PageHome() : base(Program.BasicForm?.NotebookFunc)
    {
        {
            Box hBox = New(Orientation.Horizontal, 0);
            hBox.MarginBottom = 10;
            hBox.Append(activeUsersView);
            Append(hBox);
        }

        {
            Box hBox = New(Orientation.Horizontal, 0);
            hBox.Append(lockObjectsView);
            Append(hBox);
        }


    }

    public class Номенклатура_Папки_Записи
    {
        public bool DeletionLabel = false;
        public string ID = "";
        public string Назва = "Дерево";
        public string Код = "";
    }

    public async ValueTask SetValue()
    {
        /*Номенклатура_Папки_SelectHierarchical Номенклатура_Папки_Select = new Номенклатура_Папки_SelectHierarchical();
        Номенклатура_Папки_Select.QuerySelect.Field.AddRange(
        [
            "deletion_label",
            Номенклатура_Папки_Const.Назва,
            Номенклатура_Папки_Const.Код,
        ]);

        Dictionary<string, TreeIter> nodeDictionary = new();

        await Номенклатура_Папки_Select.Select();
        while (Номенклатура_Папки_Select.MoveNext())
        {
            Номенклатура_Папки_Pointer? current = Номенклатура_Папки_Select.Current;

            string Parent = Номенклатура_Папки_Select.Parent?.ToString() ?? Guid.Empty.ToString();
            int Level = Номенклатура_Папки_Select.Level;

            if (current != null)
            {
                Dictionary<string, object> Fields = current.Fields;
                Номенклатура_Папки_Записи Record = new Номенклатура_Папки_Записи
                {
                    ID = current.UnigueID.ToString(),
                    DeletionLabel = (bool)Fields["deletion_label"],
                    Назва = Fields[Номенклатура_Папки_Const.Назва].ToString() ?? "",
                    Код = Fields[Номенклатура_Папки_Const.Код].ToString() ?? "",
                };

                //TreeIter CurrentIter = Level == 1 ? Store.AppendValues(rootIter, Record.ToArray()) : Store.AppendValues(nodeDictionary[Parent], Record.ToArray());
                nodeDictionary.Add(Record.ID, CurrentIter);
            }
        }*/
    }

    /*
        class ItemRow : RowTablePart
        {
            public string Name { get; set; } = "";
            public UnigueID ParentID { get; set; } = new();
        }

        void Tree()
        {
            ItemRow itemRow = new();

            Gio.ListStore Store = Gio.ListStore.New(ItemRow.GetGType());

            TreeListModel list = TreeListModel.New(Store, false, false, CreateFunc);
            SingleSelection model = SingleSelection.New(list);

            // Создание фабрики 
            SignalListItemFactory factory = SignalListItemFactory.New();
            factory.OnSetup += SetupListItem;
            factory.OnBind += BindListItem;

            ListView treeView = ListView.New(model, factory);
            treeView.Valign = Align.Start;
        }

        void SetupListItem(SignalListItemFactory factory, SignalListItemFactory.SetupSignalArgs e)
        {
            ListItem listitem = (ListItem)e.Object;
            Label label = Label.New(null);

            // виджет, который будет представлять отдельный элемент в списке
            TreeExpander expander = TreeExpander.New();
            expander.SetChild(label);

            listitem.SetChild(expander);
        }

        void BindListItem(SignalListItemFactory factory, SignalListItemFactory.BindSignalArgs e)
        {
            ListItem listitem = (ListItem)e.Object;
            // получаем текущую строку
            TreeListRow? tree_row = (TreeListRow?)listitem.Item;
            // получаем данные из текущей строки
            StringObject? strobj = (StringObject?)tree_row?.Item;

            // получаем виджет для вывода элемента модели - TreeExpander
            TreeExpander? tree_expander = (TreeExpander?)listitem.GetChild();

            if (tree_expander == null || strobj == null) return;
            // Назначаем виджету текущую строку:
            tree_expander.ListRow = tree_row;

            // Получаем дочерние виджеты:
            Label? label = (Label?)tree_expander.Child;
            // устанавливаем по этим данным текст метки
            label?.Label_ = strobj.GetString();
        }

        async void Load(UnigueID unigueID)
        {
            Номенклатура_Папки_SelectHierarchical select = new();
            select.QuerySelect.Field.AddRange(
            [
                Номенклатура_Папки_Const.Назва,
                Номенклатура_Папки_Const.Родич
            ]);

            select.QuerySelect.Where.Add(new Where(Номенклатура_Папки_Const.Родич, Comparison.EQ, unigueID.UGuid));
            await select.Select();
            while (Номенклатура_Select.MoveNext())
            {

            }
        }

        // создание дочерних моделей для элементов
        Gio.ListModel? CreateFunc(GObject.Object item)
        {
            // получаем элемент из корневой модели
            ItemRow itemRow = (ItemRow)item;

            Console.WriteLine(itemRow.UnigueID);

            // получаем набор вложенных данных по ключу
            // if (companies.ContainsKey(key)) return StringList.New(companies[key]);

            Load(itemRow.UnigueID);

            return null; // если для элемента не нужна дочерняя модель и у него нет вложенных элементов
        }

    */
}
