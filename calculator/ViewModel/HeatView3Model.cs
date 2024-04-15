using calculator.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.ViewModel
{
    internal class HeatView3Model : BindingHelper
    {

        private string specificheatoffusion;

        public string Specificheatoffusion
        {
            get { return specificheatoffusion; }

            set
            {
                specificheatoffusion = value;
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


        public HeatView3Model()
        {
            specificheatoffusion = "specific heat of fusion";
            mass = "mass";


            answer = "Answer";

            AddCommand = new BindableCommand(_ => Calculate());

        }

        public void Calculate()
        {
            int answerstint = Convert.ToInt32(mass) * Convert.ToInt32(specificheatoffusion);
            Answer = Convert.ToString(answerstint);

        }
    }
}
