using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;

namespace Guest_Memorandum_APP.Views
{
    /// <summary>
    /// AboutView.xaml 的交互逻辑
    /// </summary>
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void GitHubButton_OnClick(object sender, RoutedEventArgs e)
            => OpenInBrowser("https://github.com/GZG-ke");

        private void TwitterButton_OnClick(object sender, RoutedEventArgs e)
            => OpenInBrowser("https://x.com");

        private void ChatButton_OnClick(object sender, RoutedEventArgs e)
            => OpenInBrowser("https://gitter.im");

        private void EmailButton_OnClick(object sender, RoutedEventArgs e)
            => OpenInBrowser("mailto://shengzhou12138@gmail.com");


        public static void OpenInBrowser(string? url)
        {
            if (url is not null && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
    }
}