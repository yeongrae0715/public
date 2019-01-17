using System.Windows;

namespace VRSM_simple
{
    /// <summary>
    /// Result.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Result : Window
    {
        public Result()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Result_Close_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main_window = new MainWindow();
            this.Close();
            main_window.Show();
        }
    }
}
