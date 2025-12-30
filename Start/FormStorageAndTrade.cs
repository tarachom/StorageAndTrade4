
using Gtk;
using InterfaceGtk4;
using GeneratedCode;

namespace StorageAndTrade;

class FormStorageAndTrade : FormGeneral
{
    public FormStorageAndTrade() : base(Program.App, Config.Kernel)
    {
        NotebookFunction.CreateNotebookPage("Home", () => Label.New("Text"), false, null, null, true);
        NotebookFunction.CreateNotebookPage("Home2", () => Label.New("Text"));

        PageHome page = new();
        NotebookFunction.CreateNotebookPage("Home3", () => page);
        page.SetValue();
        page.SpinnerOn();

        NotebookFunction.CreateNotebookPage("Home4 erw er wer wq qwer wqer wqerqwer", null);
        NotebookFunction.CreateNotebookPage("Home5", Label.New("Text"));
        string c = NotebookFunction.CreateNotebookPage("Home6", null);

        Task.Run(async () =>
        {
            for (int i = 0; i < 100; i++)
            {
                NotebookFunction.SpinnerNotebookPage(c);
                await Task.Delay(1000);
                NotebookFunction.SpinnerNotebookPage(c, false);
                await Task.Delay(1000);
                NotebookFunction.RenameNotebookPage("Text", c);
                page.SpinnerOff();
            }
        });

        PageHome2 page2 = new();
        NotebookFunction.CreateNotebookPage("Home New", () => page2);
        page2.SetValue();

        PageHome3 page3 = new();
        NotebookFunction.CreateNotebookPage("Home New", () => page3);
        page3.SetValue();

        SetStatusBar();
    }

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
}