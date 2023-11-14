using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics;
using Microsoft.UI.Windowing;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App13
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = AppWindow.GetFromWindowId(windowId);
            appWindow.Title = "계산기"; // 타이틀
            appWindow.Move(new PointInt32(100, 100)); // 창 위치
            appWindow.Resize(new SizeInt32 { Width = 320, Height = 320 });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(a.Text, out double v1 ) && double.TryParse(b.Text, out double v2))
            {
                double r = v1 * v2;
                c.Text = r.ToString();
            }
            else
            {
                c.Text = "잘못된 입력";
            }


        }
    }

        
}

