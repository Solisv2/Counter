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
    public partial class GameOverviewPage : ContentPage
    {
        public GameOverviewPage()
        {
            InitializeComponent();
        }

        private void GamesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewCustomGamePage()));
        }

        private async void StartGameButton_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new CurrentGamePage(new CustomGameViewModel()));
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            

            //var CheckboxHandler = (CheckBox)sender;
            ////if(e.Value)
            ////{
            //StackLayout ParentStackView = (StackLayout)CheckboxHandler.Parent;
            //Label CommanderLabel = (Label)ParentStackView.Children[2];
            //    CommanderLabel.MaxLines = 0;

           
            //}
            
            
        }
    }
}