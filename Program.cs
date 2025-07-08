
using Gtk;
using Gdk;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

class Program
{
    /// <summary>
    /// Авторизований користувач
    /// </summary>
    public static Користувачі_Pointer Користувач { get; set; } = new Користувачі_Pointer();

    static void Main()
    {
        var app = Application.New("ua.org.accounting.window", Gio.ApplicationFlags.FlagsNone);

        app.OnActivate += (sender, args) =>
        {
            FirstWindow firstWindow = new(app);
            firstWindow.Show();
        };

        //Settings.GetDefault().GtkThemeName = "Adwaita";

        Display? display = Display.GetDefault();
        if (display != null)
        {
            //Icon
            IconTheme iconTheme = IconTheme.GetForDisplay(display);
            iconTheme.AddSearchPath(Path.Combine(AppContext.BaseDirectory, "images"));

            //Css
            string styleDefaultFile = Path.Combine(AppContext.BaseDirectory, "StyleCss/Default.css");
            if (File.Exists(styleDefaultFile))
            {
                CssProvider provider = CssProvider.New();
                provider.LoadFromPath(styleDefaultFile);
                StyleContext.AddProviderForDisplay(display, provider, 800);
            }
        }

        app.RunWithSynchronizationContext(null);
    }
}
