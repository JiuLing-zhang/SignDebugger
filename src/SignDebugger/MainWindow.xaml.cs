using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;
using System.Windows;
using MudExtensions.Services;
using SignDebugger.Page;

namespace SignDebugger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IWindowMoving, WindowMoving>();
            serviceCollection.AddSingleton<IWindowTitleBar, WindowTitleBar>();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddBlazorWebViewDeveloperTools();
            serviceCollection.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopLeft;
                config.SnackbarConfiguration.ShowCloseIcon = false;
                config.SnackbarConfiguration.VisibleStateDuration = 1000;
                config.SnackbarConfiguration.ShowTransitionDuration = 200;
                config.SnackbarConfiguration.HideTransitionDuration = 400;
            });
            serviceCollection.AddMudExtensions();
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}
