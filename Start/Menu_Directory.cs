/*

Довідники

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<Form>]
partial class Menu_Directory : Form
{
    public Popover? Popover { get; set; } = null;

    partial void Initialize()
    {
        //Список
        Box hBoxList = New(Orientation.Horizontal, 0);
        Append(hBoxList);

        Box vLeft = New(Orientation.Vertical, 0);
        hBoxList.Append(vLeft);

        CreateCaptionLink(vLeft, "Торгівля", null);
        {
            CreateLink(vLeft, Контрагенти_Const.FULLNAME, async () =>
            {
                Контрагенти_Список page = Контрагенти_Список.New();
                NotebookFunc?.CreatePage(Контрагенти_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, Номенклатура_Const.FULLNAME, async () =>
            {
                Номенклатура_Список page = Номенклатура_Список.New();
                NotebookFunc?.CreatePage(Номенклатура_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, Склади_Const.FULLNAME, async () =>
            {
                Склади_Список page = Склади_Список.New();
                NotebookFunc?.CreatePage(Склади_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, Валюти_Const.FULLNAME, async () =>
            {
                Валюти_Список page = Валюти_Список.New();
                NotebookFunc?.CreatePage(Валюти_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, Каси_Const.FULLNAME, async () =>
            {
                Каси_Список page = Каси_Список.New();
                NotebookFunc?.CreatePage(Каси_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, Організації_Const.FULLNAME, async () =>
            {
                Організації_Список page = Організації_Список.New();
                NotebookFunc?.CreatePage(Організації_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, Блокнот_Const.FULLNAME, async () =>
            {
                Блокнот_Список page = Блокнот_Список.New();
                NotebookFunc?.CreatePage(Блокнот_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, ХарактеристикиНоменклатури_Const.FULLNAME, async () =>
            {
                ХарактеристикиНоменклатури_Список page = ХарактеристикиНоменклатури_Список.New();
                NotebookFunc?.CreatePage(ХарактеристикиНоменклатури_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vLeft, СкладськіКомірки_Const.FULLNAME, async () =>
            {
                СкладськіКомірки_Список page = СкладськіКомірки_Список.New();
                NotebookFunc?.CreatePage(СкладськіКомірки_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });
        }

        CreateSeparator(hBoxList);

        Box vRight = New(Orientation.Vertical, 0);
        hBoxList.Append(vRight);

        CreateCaptionLink(vRight, "Бухгалтерія", null);
        {
            CreateLink(vRight, ПланРахунків_Const.FULLNAME, async () =>
            {
                ПланРахунків_Список page = ПланРахунків_Список.New();
                NotebookFunc?.CreatePage(ПланРахунків_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vRight, Категорії_Const.FULLNAME, async () =>
            {
                Категорії_Список page = Категорії_Список.New();
                NotebookFunc?.CreatePage(Категорії_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });

            CreateLink(vRight, Статті_Const.FULLNAME, async () =>
            {
                Статті_Список page = Статті_Список.New();
                NotebookFunc?.CreatePage(Статті_Const.FULLNAME, page);
                await page.SetValue();

                Popover?.Hide();
            });
        }
    }

    public static Menu_Directory New(Popover? popover = null)
    {
        Menu_Directory page = NewWithProperties([]);
        page.Popover = popover;
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }
}