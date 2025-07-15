
using Gtk;
using Gdk;
using GeneratedCode.Довідники;

namespace StorageAndTrade;

class Program
{
    public static readonly Application App = Application.New("ua.org.accounting.storage_and_trade", Gio.ApplicationFlags.FlagsNone);

    /// <summary>
    /// Основна форма
    /// </summary>
    public static FormStorageAndTrade? GeneralForm { get; set; }

    /// <summary>
    /// Авторизований користувач
    /// </summary>
    public static Користувачі_Pointer Користувач { get; set; } = new Користувачі_Pointer();

    static void Main()
    {
        App.OnActivate += (app, args) => new FormConfigurationSelection().Show();
        App.OnShutdown += (app, args) => { };

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

        App.RunWithSynchronizationContext(null);
    }
}
