using calculator.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.ViewModel
{
    internal class CurrentStrengthViewModel : BindingHelper
    {

        private string voltage;

        public string Voltage
        {
            get { return voltage; }

            set
            {
                voltage = value;
                OnPropertyChanged();

            }
        }

        private string resistance;
        public string Resistance
        {
            get { return resistance; }

            set
            {
                resistance = value;
                OnPropertyChanged();
            }
        }


        public string answer;
        public string Answer
        {
            get { return answer; }
            set
            {
                answer = value;
                OnPropertyChanged();
            }
        }

        public BindableCommand AddCommand { get; set; }


        public CurrentStrengthViewModel()
        {
            voltage = "specific heat of combustion";
            resistance = "resistance";


            answer = "Answer";

            AddCommand = new BindableCommand(_ => Calculate());

        }

        public void Calculate()
        {
            int answerstint = Convert.ToInt32(voltage)/ Convert.ToInt32(resistance);
            Answer = Convert.ToString(answerstint);

        }
    }
}
