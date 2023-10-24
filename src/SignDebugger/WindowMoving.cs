using SignDebugger.Page;
using System;
using System.Windows;
using System.Windows.Threading;
namespace SignDebugger;
internal class WindowMoving : IWindowMoving
{
    private bool _isMoving;

    private double _mouseStartX;
    private double _mouseStartY;
    private double _windowStartLeft;
    private double _windowStartTop;

    public WindowMoving()
    {
        var timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromMilliseconds(10);
        timer.Tick += (_, __) =>
        {
            if (!_isMoving)
            {
                return;
            }
            PInvoke.User32.GetCursorPos(out var point);
            Application.Current.MainWindow.Left = _windowStartLeft - _mouseStartX + point.x;
            Application.Current.MainWindow.Top = _windowStartTop - _mouseStartY + point.y;
        };
        timer.Start();
    }

    public void MouseDown()
    {
        PInvoke.User32.GetCursorPos(out var point);
        _mouseStartX = point.x;
        _mouseStartY = point.y;
        _windowStartLeft = Application.Current.MainWindow.Left;
        _windowStartTop = Application.Current.MainWindow.Top;
        _isMoving = true;
    }

    public void MouseUp()
    {
        _isMoving = false;
    }
}