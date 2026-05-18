
using Gtk;
using InterfaceGtk4;

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<Processing>("Processing__9dAhQS5xLkGxSrQ4MEw9w")]
partial class Обробка_Завантаження_ПлануРахунків : Processing
{
    Button bRun = Button.NewWithLabel("Завантажити");
    Button bStop = Button.NewWithLabel("Зупинити");
    Button bClear = Button.NewWithLabel("Очистити");
    ProgressBar progress = ProgressBar.New();
    CancellationTokenSource? cancellationToken = null;

    partial void Initialize()
    {
        bRun.MarginEnd = 10;
        bRun.OnClicked += OnRun;
        HBoxTop.Append(bRun);

        bStop.MarginEnd = 10;
        bStop.Sensitive = false;
        bStop.OnClicked += OnStop;
        HBoxTop.Append(bStop);

        progress.MarginEnd = 10;
        progress.WidthRequest = 500;
        progress.ShowText = true;
        HBoxTop.Append(progress);

        bClear.MarginEnd = 10;
        bClear.OnClicked += OnClear;
        HBoxTop.Append(bClear);
    }

    public static Обробка_Завантаження_ПлануРахунків New()
    {
        Обробка_Завантаження_ПлануРахунків page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }

    async void OnRun(object? sender, EventArgs e)
    {
        ButtonSensitive(false);

        var hBox = Log.CreateMessage($"Вибір файлу Excel", LogMessage.TypeMessage.Info);

        var native = Gtk.FileChooserNative.New(
            "Виберіть файл",                  // Заголовок
            Program.BasicForm,                    // Батьківське вікно (можна null)
            Gtk.FileChooserAction.Open,      // Дія (відкриття)
            "Відкрити",                      // Текст кнопки підтвердження
            "Скасувати"                      // Текст кнопки скасування
        );

        FileFilter filter = FileFilter.New();
        filter.Name = "Файли Excel (*.xls, *.xlsx)";
        filter.AddPattern("*.xls");
        filter.AddPattern("*.xlsx");
        native.AddFilter(filter);

        FileFilter allFilesFilter = FileFilter.New();
        allFilesFilter.Name = "Усі файли";
        allFilesFilter.AddPattern("*");
        native.AddFilter(allFilesFilter);

        native.OnResponse += (sender, e) =>
        {
            if (e.ResponseId == (int)Gtk.ResponseType.Accept)
            {
                var file = native.GetFile(); // Отримуємо вибраний файл (Gio.File)
                if (file != null)
                {
                    string path = file.GetPath() ?? "";
                    Console.WriteLine($"Вибрано шлях: {path}");
                    // Ваша логіка завантаження плану рахунків
                }
            }
            native.Dispose(); // Звільняємо ресурси
        };

        native.Show();

        /*
                FileDialog dialog = FileDialog.New();
                dialog.Title = "Оберіть файл Excel";

                FileFilter filter = FileFilter.New();
                filter.Name = "Файли Excel (*.xls, *.xlsx)";
                filter.AddPattern("*.xls");
                filter.AddPattern("*.xlsx");

                Gio.ListStore filters = Gio.ListStore.New(FileFilter.GetGType());
                filters.Append(filter);

                dialog.Filters = filters;

                try
                {
                    var file = await dialog.OpenAsync(NotebookFunc?.BasicForm);
                    if (file != null)
                    {
                        string? path = file.GetPath();
                        if (!string.IsNullOrEmpty(path))
                        {
                            Log.AppendMessage(hBox, path, LogMessage.TypeMessage.None);

                            cancellationToken = new();
                            await Upload(path);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.CreateMessage($"Помилка вибору файлу: {ex.Message}", LogMessage.TypeMessage.Error);
                }
                */

        ButtonSensitive(true);
    }

    void OnStop(object? sender, EventArgs e)
    {
        cancellationToken?.Cancel();
        ButtonSensitive(true);
    }

    void OnClear(object? sender, EventArgs e)
    {
        Log.ClearMessage();

        progress.Fraction = 0;
        progress.Text = "";
    }

    void ButtonSensitive(bool sensitive)
    {
        bRun.Sensitive = sensitive;
        bStop.Sensitive = !sensitive;
    }

    enum Columns
    {
        Клас = 0,
        Родич,
        Код,
        Назва,
        ЦеГрупа,
        Сумовий,
        Кількісний,
        Валютний,
        Забалансовий,
        Субконто1,
        Субконто2,
        Субконто3
    }

    /// <summary>
    /// Завантаження файлу
    /// </summary>
    /// <param name="currentFile">Файл Ексель</param>
    async ValueTask Upload(string currentFile)
    {
        IWorkbook workbook = new XSSFWorkbook();

        try
        {
            using FileStream fileStream = new(currentFile, FileMode.Open, FileAccess.Read);
            workbook = new XSSFWorkbook(fileStream);
        }
        catch (Exception ex)
        {
            Log.CreateMessage($"Помилка відкриття файлу {currentFile}, {ex.Message}", LogMessage.TypeMessage.Error);
            return;
        }

        ISheet sheet = workbook.GetSheetAt(0);
        if (sheet == null)
        {
            Log.CreateMessage($"Незнайдений лист", LogMessage.TypeMessage.Error);
            return;
        }

        const int startDataRow = 3;
        int maxRow = ФункціїДляЕксель.ОбчислитиКількістьРядків(sheet, startDataRow, (int)Columns.Клас);
        Log.CreateMessage($"Максимальна кількість рядків {maxRow}", LogMessage.TypeMessage.None);

        //Обробка даних
        {
            bool cancelation = false;

            //Прогрес
            progress.PulseStep = 1.0 / (maxRow - startDataRow);
            progress.Fraction = 0;

            //Заповнення колекції
            for (int i = startDataRow; i < maxRow; i++)
            {
                if (cancellationToken != null && cancellationToken.IsCancellationRequested)
                {
                    cancelation = true;
                    break;
                }

                IRow row = sheet.GetRow(i);

                ПланРахунків_Objest Обєкт = new();
                await Обєкт.New();

                //Клас
                {
                    ICell cell = row.GetCell((int)Columns.Клас);
                    string text = cell?.ToString()?.Trim() ?? "";

                    Обєкт.Клас = int.Parse(text);
                }

                //Родич
                {
                    ICell cell = row.GetCell((int)Columns.Родич);
                    string text = cell?.ToString()?.Trim() ?? "";

                    if (!string.IsNullOrEmpty(text))
                        Обєкт.Родич = await new ПланРахунків_Select().FindByField(ПланРахунків_Const.Код, text);
                }

                //Код
                {
                    ICell cell = row.GetCell((int)Columns.Код);
                    string text = cell?.ToString()?.Trim() ?? "";

                    Обєкт.Код = text;
                }

                //Назва
                {
                    ICell cell = row.GetCell((int)Columns.Назва);
                    string text = cell?.ToString()?.Trim() ?? "";

                    Обєкт.Назва = text;
                }

                //ЦеГрупа
                {
                    ICell cell = row.GetCell((int)Columns.ЦеГрупа);
                    string text = cell?.ToString()?.Trim() ?? "";

                    if (text == "True") Обєкт.ЦеГрупа = true;
                }

                //Сумовий
                {
                    ICell cell = row.GetCell((int)Columns.Сумовий);
                    string text = cell?.ToString()?.Trim() ?? "";

                    if (text == "True") Обєкт.Сумовий = true;
                }

                //Кількісний
                {
                    ICell cell = row.GetCell((int)Columns.Кількісний);
                    string text = cell?.ToString()?.Trim() ?? "";

                    if (text == "True") Обєкт.Кількісний = true;
                }

                //Валютний
                {
                    ICell cell = row.GetCell((int)Columns.Валютний);
                    string text = cell?.ToString()?.Trim() ?? "";

                    if (text == "True") Обєкт.Валютний = true;
                }

                //Забалансовий
                {
                    ICell cell = row.GetCell((int)Columns.Забалансовий);
                    string text = cell?.ToString()?.Trim() ?? "";

                    if (text == "True") Обєкт.Забалансовий = true;
                }

                //Субконто1
                {
                    ICell cell = row.GetCell((int)Columns.Субконто1);
                    string text = cell?.ToString()?.Trim() ?? "";

                    Обєкт.Субконто1 = ОтриматиНазвуДовідника(text);
                }

                //Субконто2
                {
                    ICell cell = row.GetCell((int)Columns.Субконто2);
                    string text = cell?.ToString()?.Trim() ?? "";

                    Обєкт.Субконто2 = ОтриматиНазвуДовідника(text);
                }

                //Субконто3
                {
                    ICell cell = row.GetCell((int)Columns.Субконто3);
                    string text = cell?.ToString()?.Trim() ?? "";

                    Обєкт.Субконто3 = ОтриматиНазвуДовідника(text);
                }

                await Обєкт.Save();

                progress.Fraction += progress.PulseStep;
                progress.Text = Math.Round(progress.Fraction * 100).ToString() + " %";
            }

            if (cancelation)
                Log.CreateMessage("Перервано", LogMessage.TypeMessage.Error);
        }

        workbook.Close();
        Log.CreateMessage("Завершено", LogMessage.TypeMessage.Ok);
    }

    string ОтриматиНазвуДовідника(string Субконто)
    {
        string СубконтоДляПошуку = Субконто.Trim().ToLower();
        if (string.IsNullOrEmpty(Субконто)) return "";

        string? НазваДовідника = СубконтоДляПошуку switch
        {
            "основні засоби" => "ОсновніЗасоби",
            "номенклатура" => "Номенклатура",
            "малоцінні та швидкозношувані предмети" => "МалоцінніПредмети",
            "підрозділи" => "СтруктураПідприємства",
            "склад" => "Склади",
            "статті" => "Статті",
            "статті доходів і витрат" => "Статті",
            "грошові рахунки власні" => "ГрошовіРахункиВласні",
            "номенклатура внутрішня" => "НоменклатураВнутрішня",
            "контрагенти" => "Контрагенти",
            "договори" => "Договори",
            "податки" => "ВидиПодатків",
            "співробітники" => "Співробітники",
            "Бланки" => "Бланки",
            _ => null
        };

        return string.IsNullOrEmpty(НазваДовідника) ? "" : $"Довідники.{НазваДовідника}";
    }
}
