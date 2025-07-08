
using Gtk;
using InterfaceGtk4;

class FirstWindow : FormGeneral
{
    public FirstWindow(Application app) : base(app)
    {
        NotebookFunction.CreateNotebookPage("Home", () => Label.New("Text"), false, null, null, true);
        NotebookFunction.CreateNotebookPage("Home Home Home Home Home Home Home Home Home Home Home Home", () => Label.New("Text"));
        NotebookFunction.CreateNotebookPage("Home Home Home Home Home Home Home", () => Label.New("Text"), false, () => Console.WriteLine(1), () => Console.WriteLine(2));
        NotebookFunction.CreateNotebookPage("Home Home Home 2", () => Label.New("Text"), false, () => Console.WriteLine(1), () => Console.WriteLine(2));
        string? code = NotebookFunction.CreateNotebookPage("Home Home Home 3", () => Label.New("Text"), false, () => Console.WriteLine(1), () => Console.WriteLine(2));

        if (code != null)
        {
            NotebookFunction.SpinnerNotebookPageToCode(true, code);
            //NotebookFunction.SensitiveNotebookPageToCode(false, code);
            //NotebookFunction.RenameNotebookPageToCode("sdfsdfsdfs", code);

            Task.Run(async () =>
            {
                await Task.Delay(5000);
                NotebookFunction.SpinnerNotebookPageToCode(false, code);
            });

            //NotebookFunction.RenameNotebookPageToCode("dfgdfgdf", code);
        }

        

        SetStatusBar();
    }

    protected override void ButtonMessageClicked()
    {

    }

    protected override void ButtonFindClicked(string text)
    {

    }

    protected override void Налаштування(Button button)
    {

    }

    protected override void Сервіс(Button button)
    {

    }

    protected override void Обробки(Button button)
    {

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