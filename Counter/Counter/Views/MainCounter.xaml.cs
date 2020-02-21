using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Counter.ViewModels;
using Counter.Models;
using System.ComponentModel;

namespace Counter.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    //[DesignTimeVisible(true)]
    public partial class MainCounter : ContentPage
    {

        public Ticker MainTicker { get; set; }     //MainCounterViewModel viewModel;
        public MainCounter()
        {
            InitializeComponent();
            //binding
            var ticker = new Ticker
            {
                Id = 1,
                Player = "Player1",
                Count = 40,
                CommanderCount = 10
            };
            
            //BindingContext = this.viewModel = viewModel;

            MainTicker = new Ticker
            {
                Id = 1,
                Player = "Player 1",
                Count = 40,
                CommanderCount = 10
            };
            this.BindingContext = MainTicker;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MainTicker.Count++;
        }

        //public MainCounter()
        //{
        //    InitializeComponent();
        //    var ticker = new Ticker
        //    {
        //        Player = "Player1",
        //        Count = 20
        //    };


        //    viewModel = new MainCounterViewModel(ticker);
        //    BindingContext = viewModel;
        //}
        //int PlayerCount = 20;


    }
}