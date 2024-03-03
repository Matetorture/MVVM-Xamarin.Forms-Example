using App3.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public PeopleViewModel PeopleViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();

            PeopleViewModel = new PeopleViewModel();

            peopleList.ItemsSource = PeopleViewModel.People;
        }
    }
}
