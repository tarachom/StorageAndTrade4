
using Gtk;
using Gdk;
using GeneratedCode.Довідники;

using System.Runtime.InteropServices;

namespace StorageAndTrade;

internal static partial class NativeMethods
{
    [LibraryImport("kernel32.dll", EntryPoint = "SetDllDirectoryW", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool SetDllDirectory(string lpPathName);
}

class Program
{
    public static readonly Application BasicApp = Application.New("ua.org.accounting.storage_and_trade", Gio.ApplicationFlags.FlagsNone);
    
    /// <summary>
    /// Основна форма
    /// </summary>
    public static FormStorageAndTrade? BasicForm { get; set; }

    /// <summary>
    /// Авторизований користувач
    /// </summary>
    public static Користувачі_Pointer Користувач { get; set; } = new Користувачі_Pointer();

    static void Main()
    {
        if (OperatingSystem.IsWindows())
        {
            string msysBinPath = @"C:\msys64\ucrt64\bin";

            if (System.IO.Directory.Exists(msysBinPath))
            {
                if (!NativeMethods.SetDllDirectory(msysBinPath))
                    Console.WriteLine("Warning: Failed to set DLL directory.");
            }
            else
                Console.WriteLine($"Warning: MSYS2 path not found at {msysBinPath}");
        }

        BasicApp.OnActivate += (app, _) =>
        {
            var window = FormConfigurationSelection.New();
            window.Show();
        };
        BasicApp.OnShutdown += (app, args) => { };

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

        BasicApp.RunWithSynchronizationContext(null);
    }
}