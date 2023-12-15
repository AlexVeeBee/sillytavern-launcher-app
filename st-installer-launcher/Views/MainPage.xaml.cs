using Microsoft.UI.Xaml.Controls;

using st_installer_launcher.ViewModels;

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
