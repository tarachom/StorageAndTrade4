
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