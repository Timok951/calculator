using calculator.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace calculator.ViewModel
{
    internal class HeatViewModel : BindingHelper
    {
        private string heatCapacity;

        public string HeatCapacity
        {
            get { return heatCapacity; }
            set
            {
                heatCapacity = value;
                OnPropertyChanged();
            }
        }

        private string mass;
        public string Mass
        {
            get { return mass; }

            set
            {
                mass = value;
                OnPropertyChanged();
            }
        }

        private string endtemperature;
        public string EndTemperature
        {
            get { return endtemperature; }
            set
            {
                endtemperature = value;
                OnPropertyChanged();
            }
        }

        private string starttemperature;

        public string StartTemperature
        {
            get { return starttemperature; }
            set
            {
                starttemperature = value;
                OnPropertyChanged();
            }
        }

        public string answer;
        public string Answer
        {
            get {return answer; }
        set {answer = value; 
                OnPropertyChanged(); }
        }

        public BindableCommand AddCommand { get; set; }


        public HeatViewModel()
        {
            heatCapacity = "heat capacity";
            mass = "mass";

            endtemperature = "endtemperatrue";
            starttemperature = "start temperature";
            answer = "Answer";

            AddCommand = new BindableCommand(_ => Calculate());

        }

        public void Calculate()
        {
            int answerstint = (Convert.ToInt32(heatCapacity) * Convert.ToInt32(mass)) * (Convert.ToInt32(endtemperature) - Convert.ToInt32(starttemperature));
            Answer = Convert.ToString(answerstint);
            
        }
    }
}
