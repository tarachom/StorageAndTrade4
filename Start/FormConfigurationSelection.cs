
/*
    FormConfigurationSelection.cs
*/

using AccountingSoftware;
using InterfaceGtkLib;

using GeneratedCode;
using GeneratedCode.Константи;
using InterfaceGtk4;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

/// <summary>
/// Переоприділення форми вибору бази
/// </summary>
[GObject.Subclass<InterfaceGtk4.FormConfigurationSelection>]
partial class FormConfigurationSelection : InterfaceGtk4.FormConfigurationSelection
{
    public override TypeForm TypeOpenForm { get; set; } = TypeForm.WorkingProgram;

    public static new FormConfigurationSelection New()
    {
        FormConfigurationSelection window = NewWithProperties([]);
        window.Application = Program.BasicApp;
        window.ProgramKernel = Config.Kernel;
        window.ConfiguratorKernel = Config.Kernel;
        return window;
    }

    public override async Task<bool> OpenProgram(ConfigurationParam? openConfigurationParam)
    {
        //Запуск фонових задач
        Config.StartBackgroundTask();

        //Значення констант стандартно
        {
            if (string.IsNullOrEmpty(await ЖурналиДокументів.ОсновнийТипПеріоду()))
                await ЖурналиДокументів.ОсновнийТипПеріоду(PeriodForJournal.TypePeriod.AllPeriod.ToString());

            //Одиниця виміру штуки в довіднику КласифікаторОдиницьВиміру
            {
                const string КодОдШтуки = "1";

                КласифікаторОдиницьВиміру_Pointer Вказівник = await new КласифікаторОдиницьВиміру_Select().FindByField("Назва", "шт.");
                if (Вказівник.IsEmpty())
                {
                    КласифікаторОдиницьВиміру_Object Обєкт = new();
                    await Обєкт.New();
                    Обєкт.Назва = "шт.";
                    Обєкт.ПовнаНазва = "Штуки";
                    Обєкт.Код = КодОдШтуки;
                    await Обєкт.Save();

                    Вказівник = Обєкт.GetDirectoryPointer();
                }

                if ((await ЗначенняТипові.ОсновнаОдиницяВиміруЗаКласифікатором()).IsEmpty())
                    await ЗначенняТипові.ОсновнаОдиницяВиміруЗаКласифікатором(Вказівник);
            }
        }

        FormStorageAndTrade form = FormStorageAndTrade.NewWithParam(openConfigurationParam);
        form.Show();

        Program.BasicForm = form;

        //Присвоєння користувача
        await form.SetCurrentUser();

        //Відкрити перші сторінки
        await form.OpenFirstPages();

        return true;
    }

    public override async Task<bool> OpenConfigurator(ConfigurationParam? openConfigurationParam)
    {
        Configurator.FormConfigurator form = Configurator.FormConfigurator.NewProgramStart(Program.BasicApp, Config.Kernel, openConfigurationParam);
        form.Show();

        //Відкрити перші сторінки
        await form.OpenFirstPages();

        return true;
    }
}