using System.Windows;
using Tools;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunButton_OnClick(object sender, RoutedEventArgs e)
        {
            var filePaths = MusicQualityTool.GetFilesUnderQuality(@"C:\Tries\mic check", 320);
        }
    }
}
