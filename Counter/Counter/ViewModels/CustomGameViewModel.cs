using Counter.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Counter.ViewModels
{
    public class CustomGameViewModel : BaseViewModel
    {
        public Game Game { get; set; }
        public bool GameOver {get;set;}

        //public int PlayerCount { get; set; }
        public List<int> PlayerCount;
        public List<Player> Players { get; set; }


        public void CheckHealth(Player player)
        {
            if (player.CommanderHealth == 0 || player.PlayerHealth == 0)
            {
                GameOver = true;
                MessagingCenter.Send(this, "GameOver");
            }
        }

        #region commands
        #region life commands
        public ICommand AddLifeCommand { get; }         //player total
        public ICommand SubLifeCommand { get; }
       
        #endregion add life commands

        #region Com Commands
        public ICommand AddCommanderLifeCommand { get; }     //commander total
        public ICommand SubCommanderLifeCommand { get; }


        #endregion Com Commands
        #endregion commands

        #region Command methods
        public void AddLife(Player player)
        {
            player.PlayerHealth++;
           
            
        }
        public void SubLife(Player player)
        {
            player.PlayerHealth--;

            CheckHealth(player);

        }

        public void SubComLife(Player player)
        {
           
            player.PlayerHealth--;
            player.CommanderHealth--;
            CheckHealth(player);
        }
        public void AddComLife(Player player)
        {

            player.PlayerHealth++;
            player.CommanderHealth++;

        }
        #endregion command methods

       
        public CustomGameViewModel(Game game, int playerCount)
        {
           
            Game = game;
            GameOver = false;
           
            PlayerCount = new List<int>(playerCount);
            Players = new List<Player>(playerCount);

            for (int i = 0; i < playerCount; i++)
            {
                Player TempPlayer = new Player
                {
                    PlayerHealth = Game.LifeTotal,
                    CommanderHealth = Game.CommanderCount
                };
                Players.Add(TempPlayer);
                
            }
            

            AddLifeCommand = new Command<Player>(AddLife);
            SubLifeCommand = new Command<Player>(SubLife);

            AddCommanderLifeCommand = new Command<Player>(AddComLife);
            SubCommanderLifeCommand = new Command<Player>(SubComLife);
            
            
        }

        
        
        
    }
}
