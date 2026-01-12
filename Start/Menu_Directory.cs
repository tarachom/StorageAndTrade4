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

        /*CreateLink(vLeft, Склади_Const.FULLNAME, async () =>
        {
            Склади page = new Склади();
            NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, Склади_Const.FULLNAME, () => page);
            await page.SetValue();
        });

        CreateLink(vLeft, Валюти_Const.FULLNAME, async () =>
        {
            Валюти page = new Валюти();
            NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, Валюти_Const.FULLNAME, () => page);
            await page.SetValue();
        });

        CreateLink(vLeft, Каси_Const.FULLNAME, async () =>
        {
            Каси page = new Каси();
            NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, Каси_Const.FULLNAME, () => page);
            await page.SetValue();
        });

        CreateLink(vLeft, Організації_Const.FULLNAME, async () =>
        {
            Організації page = new Організації();
            NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, Організації_Const.FULLNAME, () => page);
            await page.SetValue();
        });

        CreateLink(vLeft, Блокнот_Const.FULLNAME, async () =>
        {
            Блокнот page = new Блокнот();
            NotebookFunction.CreateNotebookPage(Program.GeneralNotebook, Блокнот_Const.FULLNAME, () => page);
            await page.SetValue();
        });*/
    }
}