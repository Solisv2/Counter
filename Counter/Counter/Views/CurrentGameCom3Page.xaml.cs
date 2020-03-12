using Counter.Models;
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
    public partial class CurrentGameCom3Page : ContentPage
    {

        public Game OldGame { get; set; }

        async void Alert()
        {
            var Result = await DisplayAlert("Game Over", "Someone Lost....", "Replay", "Back to Main Screen");

            if (Result)
            {
               
                CustomGameViewModel customGameViewModel = new CustomGameViewModel(OldGame, 3);
                this.BindingContext = customGameViewModel;
            }
            else if (Result == false)
            {
                await Navigation.PopModalAsync();

            }
        }

        public CurrentGameCom3Page()
        {

            InitializeComponent();
            MessagingCenter.Subscribe<CustomGameViewModel>(this, "GameOver", (sender) =>
            Alert());


        }
    }
}