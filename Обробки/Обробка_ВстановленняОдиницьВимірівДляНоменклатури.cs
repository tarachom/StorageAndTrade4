
using Gtk;
using InterfaceGtk4;

using AccountingSoftware;
using GeneratedCode;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

[GObject.Subclass<Processing>("Processing_kGrQ49S5xLAhQw9wMEfxS")]
partial class Обробка_ВстановленняОдиницьВимірівДляНоменклатури : Processing
{
    Button bRun = Button.NewWithLabel("Опрацювати");
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
        //bStop.Sensitive = false;
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

    public static Обробка_ВстановленняОдиницьВимірівДляНоменклатури New()
    {
        Обробка_ВстановленняОдиницьВимірівДляНоменклатури page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
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

    async void OnRun(object? sender, EventArgs e)
    {
        ButtonSensitive(false);

        Номенклатура_Select Номенклатура = new();
        await Номенклатура.Select();

        //Прогрес
        progress.PulseStep = 1.0 / Номенклатура.Count();
        progress.Fraction = 0;

        while (Номенклатура.MoveNext())
        {
            if (cancellationToken != null && cancellationToken.IsCancellationRequested)
                break;

            if (Номенклатура.Current != null)
            {
                Номенклатура_Object? Обєкт = await Номенклатура.Current.GetDirectoryObject();
                if (Обєкт != null)
                {
                    //Пошук і встановлення одиниці зберігання
                    Обєкт.ОдиницяВиміру = await ФункціїДляДовідників.СтворитиОсновнуОдиницюВиміру(Обєкт);
                    Обєкт.ОдиницяДляЗвітів = Обєкт.ОдиницяВиміру;
                    await Обєкт.Save();
                    Log.AppendLine($"Записано: {Обєкт.Назва}");
                }
            }

            progress.Fraction += progress.PulseStep;
            progress.Text = Math.Round(progress.Fraction * 100).ToString() + " %";
        }

        ButtonSensitive(true);
    }

    void ButtonSensitive(bool sensitive)
    {
        bRun.Sensitive = sensitive;
        bStop.Sensitive = !sensitive;
    }
}
