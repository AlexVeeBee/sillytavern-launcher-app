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
}
