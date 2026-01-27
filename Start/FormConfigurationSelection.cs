
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
class FormConfigurationSelection : InterfaceGtk4.FormConfigurationSelection
{
    public FormConfigurationSelection() : base(Program.BasicApp, Config.Kernel, Config.Kernel, TypeForm.WorkingProgram) { }

    public override async ValueTask<bool> OpenProgram(ConfigurationParam? openConfigurationParam)
    {
        //Запуск фонових задач
        Config.StartBackgroundTask();

        //Значення констант за замовчуванням
        if (string.IsNullOrEmpty(ЖурналиДокументів.ОсновнийТипПеріоду_Const))
            ЖурналиДокументів.ОсновнийТипПеріоду_Const = PeriodForJournal.TypePeriod.AllPeriod.ToString();

        FormStorageAndTrade form = new() { OpenConfigurationParam = openConfigurationParam };
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
        Configurator.FormConfigurator form = new(Program.BasicApp, Config.Kernel) { OpenConfigurationParam = openConfigurationParam };
        form.SetStatusBar();
        form.Show();

        //Відкрити перші сторінки
        await form.OpenFirstPages();

        return true;
    }
}
