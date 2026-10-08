using HomeVault.Data;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace HomeVault_App;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : Application
{
    private Window? _window;

    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Invoked when the application is launched.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        EnsureDatabaseReady();

        _window = new MainWindow();
        _window.Activate();
    }

    private static void EnsureDatabaseReady()
    {
        var appDataDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "HomeVault");

        Directory.CreateDirectory(appDataDirectory);

        var dbPath = Path.Combine(appDataDirectory, "homevault.db");

        var options = new DbContextOptionsBuilder<HomeVaultDbContext>()
            .UseSqlite($"Data Source={dbPath}")
            .Options;

        using var dbContext = new HomeVaultDbContext(options);
        dbContext.Database.Migrate();
    }
}
