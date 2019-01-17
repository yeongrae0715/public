using System;
using System.Windows;

namespace VRSM_simple
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            FlightPhases flight_phases = new FlightPhases();
            MainLayout.Children.Add(flight_phases);
        }
        
    }
}
