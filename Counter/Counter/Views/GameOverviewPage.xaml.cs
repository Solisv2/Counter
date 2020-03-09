using Counter.Models;
using Counter.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        GamesOverviewViewModel viewModel;
        Game game= new Game();
        Picker picker;
        int PickerValue;
        bool IsCommander = true;

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
            
            LoadGame(game);
            if(game.IsCommander == true)
            {
                if (PickerValue == 2)
                {
                    CurrentGameCom2Page currentGamePage = new CurrentGameCom2Page();
                    CustomGameViewModel customGameViewModel = new CustomGameViewModel(game, PickerValue);
                    currentGamePage.BindingContext = customGameViewModel;
                    await Navigation.PushModalAsync(currentGamePage);
                }
                else if (PickerValue == 3)
                {
                    CurrentGameCom3Page currentGamePage = new CurrentGameCom3Page();
                    CustomGameViewModel customGameViewModel = new CustomGameViewModel(game, PickerValue);
                    currentGamePage.BindingContext = customGameViewModel;
                    await Navigation.PushModalAsync(currentGamePage);
                }
                else if (PickerValue == 4)
                {

                    CurrentGameCom4Page currentGamePage = new CurrentGameCom4Page();
                    CustomGameViewModel customGameViewModel = new CustomGameViewModel(game, PickerValue);
                    currentGamePage.BindingContext = customGameViewModel;
                    await Navigation.PushModalAsync(currentGamePage);
                }
            }
            else
            {
                if (PickerValue == 2)
                {
                    CurrentGame2Page currentGamePage = new CurrentGame2Page();
                    CustomGameViewModel customGameViewModel = new CustomGameViewModel(game, PickerValue);
                    currentGamePage.BindingContext = customGameViewModel;
                    await Navigation.PushModalAsync(currentGamePage);
                }
                else if (PickerValue == 3)
                {
                    CurrentGame3Page currentGamePage = new CurrentGame3Page();
                    CustomGameViewModel customGameViewModel = new CustomGameViewModel(game, PickerValue);
                    currentGamePage.BindingContext = customGameViewModel;
                    await Navigation.PushModalAsync(currentGamePage);
                }
                else if (PickerValue == 4)
                {

                    CurrentGame4Page currentGamePage = new CurrentGame4Page();
                    CustomGameViewModel customGameViewModel = new CustomGameViewModel(game, PickerValue);
                    currentGamePage.BindingContext = customGameViewModel;
                    await Navigation.PushModalAsync(currentGamePage);
                }
            }
           
            

            //await Navigation.PushModalAsync(new CurrentGamePage(new CustomGameViewModel()));
            //await Navigation.PushModalAsync(new CurrentGamePage(new CustomGameViewModel(test)));
        }

        private void LoadGame(Game _game)
        {
            
            _game.GameType = GameType.Text;
            _game.LifeTotal = int.Parse(Lifetotal.Text);
            _game.IsCommander = IsCommander;
            _game.SelectedNumPlayers = picker.SelectedIndex;
            _game.CommanderCount = int.Parse(CommanderCountEditor.Text);
            PickerValue = picker.SelectedIndex + 2;
            
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            picker = sender as Picker;
            var selectedItem = picker.SelectedItem;

        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            //CommanderCheck.IsVisible = false;
            if(e.Value == false)
            {
                IsCommander = false;
                CommanderCountLabel.IsVisible = false;
                CommanderCountEditor.IsVisible = false;
                //StartGameButton.TranslationY = -25;
                //StartGameButton.AnchorY = -25;
                StartGameButton1.IsVisible = true;
                StartGameButton2.IsVisible = false;
            }

            else
            {
                IsCommander = true;
                CommanderCountLabel.IsVisible = true;
                CommanderCountEditor.IsVisible = true;
                StartGameButton1.IsVisible = false;
                StartGameButton2.IsVisible = true;
                //StartGameButton.TranslationY = 25;
                //StartGameButton.AnchorY = 25;

            }
            
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