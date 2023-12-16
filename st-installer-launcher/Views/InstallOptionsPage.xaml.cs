using Microsoft.UI.Xaml.Controls;

using st_installer_launcher.ViewModels;

namespace st_installer_launcher.Views;

public sealed partial class InstallOptionsPage : Page
{
    public InstallOptionsViewModel ViewModel
    {
        get;
    }

    public InstallOptionsPage()
    {
        ViewModel = App.GetService<InstallOptionsViewModel>();
        InitializeComponent();
    }
}
