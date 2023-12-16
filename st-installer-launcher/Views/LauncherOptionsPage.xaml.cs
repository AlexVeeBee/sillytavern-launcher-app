using Microsoft.UI.Xaml.Controls;

using st_installer_launcher.ViewModels;

namespace st_installer_launcher.Views;

public sealed partial class LauncherOptionsPage : Page
{
    public LauncherOptionsViewModel ViewModel
    {
        get;
    }

    public LauncherOptionsPage()
    {
        ViewModel = App.GetService<LauncherOptionsViewModel>();
        InitializeComponent();
    }
}
