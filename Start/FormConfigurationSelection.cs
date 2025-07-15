
/*
        FormConfigurationSelection.cs
*/

using Gtk;
using AccountingSoftware;
using InterfaceGtkLib;

using GeneratedCode;
using GeneratedCode.Константи;

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
            //Config.StartBackgroundTask();

            //Значення констант за замовчуванням
            //if (string.IsNullOrEmpty(ЖурналиДокументів.ОсновнийТипПеріоду_Const))
            //ЖурналиДокументів.ОсновнийТипПеріоду_Const = ПеріодДляЖурналу.ТипПеріоду.ВесьПеріод.ToString();

            FormStorageAndTrade form = new() { OpenConfigurationParam = openConfigurationParam };
            form.SetStatusBar();
            form.Show();

            //Присвоєння користувача
            //Program.GeneralForm.SetCurrentUser();

            //Відкрити перші сторінки
            //Program.GeneralForm.OpenFirstPages();

            Program.GeneralForm = form;
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