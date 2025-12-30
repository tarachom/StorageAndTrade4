
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

    protected override void Налаштування(LinkButton linkButton)
    {

    }

    protected override async void Сервіс(LinkButton linkButton)
    {
        PageService page = new();
        NotebookFunction.CreateNotebookPage("Сервіс", page);
        await page.SetValue();
    }

    protected override void Обробки(LinkButton linkButton)
    {
        NotebookFunction.CreateNotebookPage("Обробки", new PageProcessing());
    }

    protected override void ВідкритиДокументВідповідноДоВиду(string name)
    {

    }

    protected override void ВідкритиДовідникВідповідноДоВиду(string name)
    {

    }

    protected override void ВідкритиЖурналВідповідноДоВиду(string name)
    {

    }

    protected override void ВідкритиРегістрВідомостейВідповідноДоВиду(string name)
    {

    }

    protected override void ВідкритиРегістрНакопиченняВідповідноДоВиду(string name)
    {

    }

    protected override void МенюДокументи(Box vBox)
    {

    }

    protected override void МенюДовідники(Box vBox)
    {

    }

    protected override void МенюЖурнали(Box vBox)
    {

    }

    protected override void МенюЗвіти(Box vBox)
    {

    }

    protected override void МенюРегістри(Box vBox)
    {

    }

    #endregion

    public async ValueTask OpenFirstPages()
    {
        PageHome page = new PageHome();
        NotebookFunction.CreateNotebookPage("Стартова", () => page, false, null, null, true);
        await page.SetValue();

        PageHome2 page2 = new();
        NotebookFunction.CreateNotebookPage("Home New", () => page2);
        await page2.SetValue();

        PageHome3 page3 = new();
        NotebookFunction.CreateNotebookPage("Home New", () => page3);
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