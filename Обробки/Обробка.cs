
using Gtk;
using AccountingSoftware;
using GeneratedCode;

namespace StorageAndTrade
{
    class Обробка : InterfaceGtk4.Processing
    {
        Button bRun = Button.NewWithLabel("Заповнити");
        Button bStop = Button.NewWithLabel("Зупинити");
        Button bClear = Button.NewWithLabel("Очистити");
        ProgressBar progress = ProgressBar.New();
        CancellationTokenSource? cancellationToken = null;

        public Обробка()
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
    }
}