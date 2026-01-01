
/*
        FormConfigurationSelection.cs
*/

using Gtk;
using AccountingSoftware;
using InterfaceGtkLib;

using GeneratedCode;
using GeneratedCode.Константи;
using InterfaceGtk4;

namespace StorageAndTrade
{
    /// <summary>
    /// Переоприділення форми вибору бази
    /// </summary>
    class FormConfigurationSelection : InterfaceGtk4.FormConfigurationSelection
    {
        public FormConfigurationSelection() : base(Program.App, Config.Kernel, null, TypeForm.WorkingProgram) { }

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

            Program.Form = form;

            //Присвоєння користувача
            await form.SetCurrentUser();

            //Відкрити перші сторінки
            await form.OpenFirstPages();

            return await ValueTask.FromResult(true);
        }

        public override async ValueTask<bool> OpenConfigurator(ConfigurationParam? openConfigurationParam)
        {
            // Configurator.FormConfigurator сonfigurator = new() { OpenConfigurationParam = openConfigurationParam };
            // сonfigurator.Show();

            // сonfigurator.SetValue();
            // сonfigurator.LoadTreeAsync();

            return await ValueTask.FromResult(true);
        }
    }
}