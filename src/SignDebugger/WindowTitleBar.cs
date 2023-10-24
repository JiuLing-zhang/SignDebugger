using SignDebugger.Page;
using System.Windows;

namespace SignDebugger;
internal class WindowTitleBar : IWindowTitleBar
{
    public bool IsMaximized => Application.Current.MainWindow.WindowState == WindowState.Maximized;

    public void Minimize()
    {
        if (Application.Current.MainWindow == null)
        {
            return;
        }
        Application.Current.MainWindow.WindowState = WindowState.Minimized;
    }

    public void Maximize()
    {
        if (Application.Current.MainWindow == null)
        {
            return;
        }

        if (IsMaximized)
        {
            Application.Current.MainWindow.WindowState = WindowState.Normal;
        }
        else
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }
    }

    public void Close()
    {
        if (Application.Current.MainWindow == null)
        {
            return;
        }
        Application.Current.MainWindow.Close();
    }
}