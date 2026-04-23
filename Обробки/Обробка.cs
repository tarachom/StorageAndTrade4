
using Gtk;
using InterfaceGtk4;

using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade;

[GObject.Subclass<Processing>("Processing_9fAhQS5xLkGxSrQ4MEw9w")]
partial class Обробка : Processing
{
    Button bRun = Button.NewWithLabel("Заповнити");
    Button bStop = Button.NewWithLabel("Зупинити");
    Button bClear = Button.NewWithLabel("Очистити");
    ProgressBar progress = ProgressBar.New();
    //CancellationTokenSource? cancellationToken = null;

    partial void Initialize()
    {
        bRun.MarginEnd = 10;
        bRun.OnClicked += (_, _) => Log.AppendLine("Text");
        HBoxTop.Append(bRun);

        bStop.MarginEnd = 10;
        //bStop.Sensitive = false;
        bStop.OnClicked += (_, _) => Log.CreateMessage("Text", InterfaceGtk4.LogMessage.TypeMessage.Info);
        HBoxTop.Append(bStop);

        progress.MarginEnd = 10;
        progress.WidthRequest = 500;
        progress.ShowText = true;
        HBoxTop.Append(progress);

        bClear.MarginEnd = 10;
        bClear.OnClicked += (_, _) => Log.ClearMessage();
        HBoxTop.Append(bClear);
    }

    public static Обробка New()
    {
        Обробка page = NewWithProperties([]);
        page.NotebookFunc = Program.BasicForm?.NotebookFunc;

        return page;
    }
}
