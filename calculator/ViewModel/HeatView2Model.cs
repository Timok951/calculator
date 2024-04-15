using calculator.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.ViewModel
{
    internal class HeatView2Model : BindingHelper
    {

        private string specificheatofcombustion;

        public string Specificheatofcombustion
        {
            get { return specificheatofcombustion; }

            set {  specificheatofcombustion = value;
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


        public HeatView2Model()
        {
            specificheatofcombustion = "specific heat of combustion";
            mass = "mass";


            answer = "Answer";

            AddCommand = new BindableCommand(_ => Calculate());

        }

        public void Calculate()
        {
            int answerstint =  Convert.ToInt32(mass) * Convert.ToInt32(specificheatofcombustion);
            Answer = Convert.ToString(answerstint);

        }
    }
}
