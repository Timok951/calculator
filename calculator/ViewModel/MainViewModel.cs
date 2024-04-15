using calculator.View;
using calculator.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace calculator
{

    internal class MainViewModel : BindingHelper
    {

        private string pageselected;

        public string Pageselected
        {
            get { return pageselected; }
            set
            {
                pageselected = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<String> pages;

        public ObservableCollection<String> Pages
        {
            get { return pages; }
            set
            {
                pages = value;
                OnPropertyChanged();
            }
        }

        private Page pageshowing;

        public Page Pageshowing
        {
            get { return pageshowing; }
            set { 
                pageshowing = value; OnPropertyChanged(); 
                
            }
        }

        public BindableCommand AddCommand { get; set; }



        public MainViewModel()
        {
            Pages = new ObservableCollection<String>();
            Pages.Add("Heat when body get heated");
            Pages.Add("Heat when fuel get burn");
            Pages.Add("The amount of heat released when a body melts");
            Pages.Add("Current strength");

            AddCommand = new BindableCommand(_  => Changespages());




        }

        public void Changespages()
        {

            switch (Pageselected){
                case "Heat when body get heated":
                    HeatPage heatPage = new HeatPage();
                    Pageshowing = heatPage;
                    break;
                case "Heat when fuel get burn":
                        HeatPage2 heatPage2 = new HeatPage2();
                        Pageshowing = heatPage2;
                    break;
                case "The amount of heat released when a body melts":
                    HeatPage3 heatPage3 = new HeatPage3();
                    Pageshowing = heatPage3;
                    break;
                case "Current strength":
                    CurrentStrengthPage currentstrength = new CurrentStrengthPage();
                    Pageshowing = currentstrength;
                    break;


            }



        }

    }
}
