/*

Довідники

*/

using Gtk;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

class Menu_Directory : Form
{
    public Menu_Directory() : base(Program.BasicForm?.NotebookFunc)
    {
        //Список
        Box hBoxList = New(Orientation.Horizontal, 0);
        Append(hBoxList);

        Box vLeft = New(Orientation.Vertical, 0);
        hBoxList.Append(vLeft);

        CreateLink(vLeft, Контрагенти_Const.FULLNAME, async () =>
        {
            Контрагенти_Список page = new();
            NotebookFunc?.CreatePage(Контрагенти_Const.FULLNAME, page);
            await page.SetValue();
        });

        CreateLink(vLeft, Номенклатура_Const.FULLNAME, async () =>
        {
            Номенклатура_Список page = new();
            NotebookFunc?.CreatePage(Номенклатура_Const.FULLNAME, page);
            await page.SetValue();
        });

        CreateLink(vLeft, Номенклатура_Папки_Const.FULLNAME, async () =>
        {
            Номенклатура_Папки_Список page = new();
            NotebookFunc?.CreatePage(Номенклатура_Папки_Const.FULLNAME, page);
            await page.SetValue();
        });

        CreateLink(vLeft, Склади_Const.FULLNAME, async () =>
        {
            Склади_Список page = new();
            NotebookFunc?.CreatePage(Склади_Const.FULLNAME, page);
            await page.SetValue();
        });

        CreateLink(vLeft, Валюти_Const.FULLNAME, async () =>
        {
            Валюти_Список page = new();
            NotebookFunc?.CreatePage(Валюти_Const.FULLNAME, page);
            await page.SetValue();
        });

        CreateLink(vLeft, Каси_Const.FULLNAME, async () =>
        {
            Каси_Список page = new();
            NotebookFunc?.CreatePage(Каси_Const.FULLNAME, page);
            await page.SetValue();
        });

        CreateLink(vLeft, Організації_Const.FULLNAME, async () =>
        {
            Організації_Список page = new();
            NotebookFunc?.CreatePage(Організації_Const.FULLNAME, page);
            await page.SetValue();
        });

        CreateLink(vLeft, Блокнот_Const.FULLNAME, async () =>
        {
            Блокнот_Список page = new();
            NotebookFunc?.CreatePage(Блокнот_Const.FULLNAME, page);
            await page.SetValue();
        });
    }
}