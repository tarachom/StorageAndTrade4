
using Gtk;
using InterfaceGtk4;
using GeneratedCode;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

class FormStorageAndTrade : FormGeneral
{
    public FormStorageAndTrade() : base(Program.BasicApp, Config.Kernel) { }

    #region Override

    protected override void ButtonMessageClicked()
    {

    }

    protected override void ButtonFindClicked(string text)
    {

    }

    protected override bool OpenDocumentByType(string name)
    {
        return new FunctionForDynamicOpen().OpenDocumentByType(name, null);
    }

    protected override bool OpenDirectoryByType(string name)
    {
        return new FunctionForDynamicOpen().OpenDirectoryByType(name, null);
    }

    protected override bool OpenJournalByType(string name)
    {
        return new FunctionForDynamicOpen().OpenJournalByType(name, null);
    }

    protected override bool OpenRegisterInformationByType(string name)
    {
        return new FunctionForDynamicOpen().OpenRegisterInformationByType(name, null);
    }

    protected override bool OpenRegisterAccumulationByType(string name)
    {
        return new FunctionForDynamicOpen().OpenRegisterAccumulationByType(name, null);
    }

    protected override void Settings(LinkButton linkButton)
    {

    }

    protected override async void Service(LinkButton linkButton)
    {
        PageService page = new();
        NotebookFunc.CreatePage("Сервіс", page);
        await page.SetValue();
    }

    protected override void Processing(LinkButton linkButton)
    {
        NotebookFunc.CreatePage("Обробки", new PageProcessing());
    }

    protected override void MenuDocuments(Box vBox)
    {
        vBox.Append(new Menu_Document());
    }

    protected override void MenuDirectory(Box vBox)
    {
        vBox.Append(new Menu_Directory());
    }

    protected override void MenuJournals(Box vBox)
    {

    }

    protected override void MenuReports(Box vBox)
    {

    }

    protected override void MenuRegisters(Box vBox)
    {

    }

    #endregion

    public async ValueTask OpenFirstPages()
    {
        PageHome page = new();
        NotebookFunc?.CreatePage("Стартова", () => page, false, null, null, true);
        await page.SetValue();

        /*ПоступленняТоварівТаПослуг page2 = new();
        NotebookFunc?.CreatePage("Home New", () => page2);
        await page2.SetValue();

        ПоступленняТоварівТаПослуг_ШвидкийВибір page2_1 = new();
        NotebookFunc?.CreatePage("ПоступленняТоварівТаПослуг ШвидкийВибір", () => page2_1);
        await page2_1.SetValue();

        Номенклатура page3 = new();
        NotebookFunc?.CreatePage("Home New", () => page3);
        await page3.SetValue();

        Номенклатура_ШвидкийВибір page3_1 = new();
        NotebookFunc?.CreatePage("Home New1", () => page3_1);
        await page3_1.SetValue();*/
    }

    public async ValueTask SetCurrentUser()
    {
        Користувачі_Pointer ЗнайденийКористувач = await new Користувачі_Select().FindByField(Користувачі_Const.КодВСпеціальнійТаблиці, Config.Kernel.User);
        if (ЗнайденийКористувач.IsEmpty())
        {
            Користувачі_Objest НовийКористувач = new()
            {
                КодВСпеціальнійТаблиці = Config.Kernel.User,
                Назва = await Config.Kernel.DataBase.SpetialTableUsersGetFullName(Config.Kernel.User)
            };

            await НовийКористувач.New();
            await НовийКористувач.Save();

            Program.Користувач = НовийКористувач.GetDirectoryPointer();
        }
        else
            Program.Користувач = ЗнайденийКористувач;
    }
}