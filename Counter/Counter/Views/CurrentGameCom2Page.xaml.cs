using Counter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Counter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentGameCom2Page : ContentPage
    {
     
        public CurrentGameCom2Page()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<CustomGameViewModel>(this, "GameOver",(sender) =>
            DisplayAlert("Game Over", "Someone Lost....", "Exit"));

        }   
    }
}