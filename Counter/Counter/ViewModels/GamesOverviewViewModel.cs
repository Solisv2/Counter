using Counter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Counter.ViewModels 
{
    public class GamesOverviewViewModel : BaseViewModel
    {
        private readonly GameRepository gameRepository;

        public ObservableCollection<Game> Games { get; set; }
        public Game CustomGame { get; set; }

        public ICommand ChangeCommand { get;  }

        public void CheckCommander()
        {
            if(Games[0].IsCommander==true)
            {
                Games[0].IsCommander = false;
            }
            else
            {
                Games[0].IsCommander = true;
            }
        }
         
        public GamesOverviewViewModel()
        {
            gameRepository = new GameRepository();
            Games = gameRepository.Games;
            CustomGame = gameRepository.Games[0];
            ChangeCommand = new Command(CheckCommander);
        } 
    }
}
