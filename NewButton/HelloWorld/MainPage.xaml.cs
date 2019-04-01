using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace HelloWorld
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool IsHelloWorld = true;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageDialog dialog = new MessageDialog("Hello World");
            //await dialog.ShowAsync();
            //IsHelloWorld = !IsHelloWorld;
            //if (IsHelloWorld)
            //{
            //    MyTextBlock.Text = "Hello World";
            //}
            //else
            //{
            //    MyTextBlock.Text = "你好，世界";
            //}
            var dialog = new ContentDialog();
            dialog.PrimaryButtonText = "yo!";
            await dialog.ShowAsync();
        }
    }
}
