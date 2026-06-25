
using Gtk;
using InterfaceGtk4;
using GeneratedCode;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<FormGeneral>]
partial class FormStorageAndTrade : FormGeneral
{
    public static new FormStorageAndTrade New()
    {
        FormStorageAndTrade window = NewWithProperties([]);
        window.Application = Program.BasicApp;
        window.Init(Config.Kernel);

        return window;
    }

    #region Override

    protected override void ButtonMessageClicked()
    {
        ФункціїДляПовідомлень.ВідкритиПовідомлення();
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
        PageService page = PageService.New();
        NotebookFunc.CreatePage("Сервіс", page);
        await page.SetValue();
    }

    protected override void Processing(LinkButton linkButton)
    {
        NotebookFunc.CreatePage("Обробки", PageProcessing.New());
    }

    protected override void MenuDocuments(Box vBox, Popover? popover = null)
    {
        vBox.Append(Menu_Document.New(popover));
    }

    protected override void MenuDirectory(Box vBox, Popover? popover = null)
    {
        vBox.Append(Menu_Directory.New(popover));
    }

    protected override void MenuJournals(Box vBox, Popover? popover = null)
    {

    }

    protected override void MenuReports(Box vBox, Popover? popover = null)
    {

    }

    protected override void MenuRegisters(Box vBox, Popover? popover = null)
    {

    }

    #endregion

    public async Task OpenFirstPages()
    {
        {
            PageHome page = PageHome.New();
            NotebookFunc?.CreatePage("Стартова", () => page, false, null, null, true);
            await page.SetValue();
        }

        {
            PageAI page = PageAI.New();
            NotebookFunc?.CreatePage("AI", () => page);
            await page.SetValue();
        }
    }

    public async Task SetCurrentUser()
    {
        Користувачі_Pointer ЗнайденийКористувач = await new Користувачі_Select().FindByField(Користувачі_Const.КодВСпеціальнійТаблиці, Config.Kernel.User);
        if (ЗнайденийКористувач.IsEmpty())
        {
            Користувачі_Object НовийКористувач = new()
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