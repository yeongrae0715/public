using System.Windows;
using System.Windows.Controls;

namespace VRSM_simple
{
    /// <summary>
    /// FlightPhases.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FlightPhases : UserControl
    {
        

        public FlightPhases()
        {
            InitializeComponent();

            this.DataContext = new Phases();
        }

        private void Phase_Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Scenarios scenarios = new Scenarios();
            scenarios.Show();
        }
    }
}
