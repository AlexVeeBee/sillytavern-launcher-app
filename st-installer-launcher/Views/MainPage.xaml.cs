using Microsoft.UI.Xaml.Controls;

using st_installer_launcher.ViewModels;
using Windows.Storage;

namespace st_installer_launcher.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();

        CheckApps();
    }

    private async void CheckApps(bool forced = false)
    {
        var localSettings = ApplicationData.Current.LocalSettings;

        var alreadyVeryfied = localSettings.Values["apps_alreadyVeryfied"];
        
        if (alreadyVeryfied == null)
        {
            localSettings.Values["apps_alreadyVeryfied"] = true;
        }
        var lastcheckdate_get = localSettings.Values["lastcheckdate"];
        var lastcheckdate_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
        if (lastcheckdate_get != null)
        {
            lastcheckdate_date = DateTime.Parse(lastcheckdate_get.ToString());
        }
        
        try
        {
            throw new Exception("Error");
        } catch ( Exception er) {
        }
    }

    private void ButtonCheckApps(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void AppLuncherSizechange(object sender, Microsoft.UI.Xaml.SizeChangedEventArgs e)
    {
        if (e.NewSize.Width < 600)
        {
            AppLuncher.Orientation = Orientation.Vertical;
        }
        else
        {
            AppLuncher.Orientation = Orientation.Horizontal;
        }
    }

    private void Home_AppSettings_SizeChanged(object sender, Microsoft.UI.Xaml.SizeChangedEventArgs e)
    {
        if (e.NewSize.Width < 600)
        {
            Home_AppSettings.Orientation = Orientation.Vertical;
        }
        else
        {
            Home_AppSettings.Orientation = Orientation.Horizontal;
        }
    }
}
