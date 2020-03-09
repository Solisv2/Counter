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
    public partial class CurrentGame4Page : ContentPage
    {
        public CurrentGame4Page()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<CustomGameViewModel>(this, "GameOver", (sender) =>
            DisplayAlert("Game Over", "Someone Lost....", "Exit"));
        }
    }
}