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
    public partial class CurrentGame2Page : ContentPage
    {

        public Game OldGame { get; set; }
        
        async void Alert()
        {
            var Result = await DisplayAlert("Game Over", "Someone Lost....", "Replay", "Back to Main Screen");

            if (Result)
            {

                //this.BindingContext = OldContext;

                //CurrentGame2Page currentGamePage = new CurrentGame2Page();                      //resetting page and context
                CustomGameViewModel customGameViewModel = new CustomGameViewModel(OldGame, 2);
                this.BindingContext = customGameViewModel;
                //currentGamePage.BindingContext = customGameViewModel;
                //currentGamePage.OldGame = OldGame;                                              //allows replay to work past first instance



                //await Navigation.PopModalAsync();
                //await Navigation.PushModalAsync(currentGamePage);
                //Navigation.InsertPageBefore(currentGamePage,this);
                //await Navigation.PopAsync();

            }
            else if (Result == false)
            { 
                await Navigation.PopModalAsync();              
            }
        }

        public CurrentGame2Page()
        {

            InitializeComponent();
            MessagingCenter.Subscribe<CustomGameViewModel>(this, "GameOver", (sender) =>
            Alert());


        }
    }
}