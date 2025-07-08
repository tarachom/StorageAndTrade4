
using Gtk;
using Gdk;

class Program
{
    static void Main()
    {
        var app = Application.New("ua.org.accounting.window", Gio.ApplicationFlags.FlagsNone);

        app.OnActivate += (sender, args) =>
        {
            FirstWindow firstWindow = new(app);
            firstWindow.Show();
        };

        //Css Style
        {
            string styleDefaultFile = Path.Combine(AppContext.BaseDirectory, "StyleCss/Default.css");
            var displayDefault = Display.GetDefault();

            //Settings.GetDefault().GtkThemeName = "Adwaita";

            if (File.Exists(styleDefaultFile) && displayDefault != null)
            {
                CssProvider provider = CssProvider.New();
                provider.LoadFromPath(styleDefaultFile);
                StyleContext.AddProviderForDisplay(displayDefault, provider, 800);
            }
        }

        app.Run(0, null);
    }
}
