using System.ComponentModel;

namespace VRSM_simple
{
    public class Phases : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public string Phase_1 { get; set; } = "Before takeoff";
        public string Phase_2 { get; set; } = "Taxi & Takeoff";
        public string Phase_3 { get; set; } = "In-flight";
        public string Phase_4 { get; set; } = "Descent & Before landing";
        public string Phase_5 { get; set; } = "After anding";
    }
}
