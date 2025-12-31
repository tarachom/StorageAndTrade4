
using Gtk;
using InterfaceGtk4;
using GeneratedCode;
using GeneratedCode.Константи;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

class FormStorageAndTrade : FormGeneral
{
    public FormStorageAndTrade() : base(Program.App, Config.Kernel) { }

    #region Override

    protected override void ButtonMessageClicked()
    {

    }

    protected override void ButtonFindClicked(string text)
    {

    }

    protected override void OpenDocumentByType(string name)
    {
        new FunctionForDynamicOpen().OpenDocumentByType(name, null);
    }

    protected override void OpenDirectoryByType(string name)
    {
        new FunctionForDynamicOpen().OpenDirectoryByType(name, null);
    }

    protected override void OpenJournalByType(string name)
    {
        new FunctionForDynamicOpen().OpenJournalByType(name, null);
    }

    protected override void OpenRegisterInformationByType(string name)
    {
        new FunctionForDynamicOpen().OpenRegisterInformationByType(name, null);
    }

    protected override void OpenRegisterAccumulationByType(string name)
    {
        new FunctionForDynamicOpen().OpenRegisterAccumulationByType(name, null);
    }

    protected override void Settings(LinkButton linkButton)
    {

    }

    protected override async void Service(LinkButton linkButton)
    {
        PageService page = new();
        Notebook.CreatePage("Сервіс", page);
        await page.SetValue();
    }

    protected override void Processing(LinkButton linkButton)
    {
        Notebook.CreatePage("Обробки", new PageProcessing());
    }

    protected override void MenuDocuments(Box vBox)
    {

    }

    protected override void MenuDirectory(Box vBox)
    {

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
        PageHome page = new PageHome();
        Notebook.CreatePage("Стартова", () => page, false, null, null, true);
        await page.SetValue();

        PageHome2 page2 = new();
        Notebook.CreatePage("Home New", () => page2);
        await page2.SetValue();

        PageHome3 page3 = new();
        Notebook.CreatePage("Home New", () => page3);
        await page3.SetValue();
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