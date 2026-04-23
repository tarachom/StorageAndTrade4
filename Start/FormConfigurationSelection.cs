
/*
    FormConfigurationSelection.cs
*/

using AccountingSoftware;
using InterfaceGtkLib;

using GeneratedCode;
using GeneratedCode.Константи;
using InterfaceGtk4;

namespace StorageAndTrade;

/// <summary>
/// Переоприділення форми вибору бази
/// </summary>
[GObject.Subclass<InterfaceGtk4.FormConfigurationSelection>]
partial class FormConfigurationSelection : InterfaceGtk4.FormConfigurationSelection
{
    public static new FormConfigurationSelection New()
    {
        FormConfigurationSelection window = NewWithProperties([]);
        window.Application = Program.BasicApp;
        window.Init(Config.Kernel, Config.Kernel, TypeForm.WorkingProgram);

        return window;
    }

    public override async ValueTask<bool> OpenProgram(ConfigurationParam? openConfigurationParam)
    {
        //Запуск фонових задач
        Config.StartBackgroundTask();

        //Значення констант за замовчуванням
        if (string.IsNullOrEmpty(ЖурналиДокументів.ОсновнийТипПеріоду_Const))
            ЖурналиДокументів.ОсновнийТипПеріоду_Const = PeriodForJournal.TypePeriod.AllPeriod.ToString();

        FormStorageAndTrade form = FormStorageAndTrade.New();
        form.OpenConfigurationParam = openConfigurationParam;
        form.SetStatusBar();
        form.Show();

        Program.BasicForm = form;

        //Присвоєння користувача
        await form.SetCurrentUser();

        //Відкрити перші сторінки
        await form.OpenFirstPages();

        return true;
    }

    public override async ValueTask<bool> OpenConfigurator(ConfigurationParam? openConfigurationParam)
    {
        Configurator.FormConfigurator form = Configurator.FormConfigurator.NewProgramStart(Program.BasicApp, Config.Kernel);
        form.OpenConfigurationParam = openConfigurationParam;
        form.SetStatusBar();
        form.Show();

        //Відкрити перші сторінки
        await form.OpenFirstPages();

        return true;
    }
}
