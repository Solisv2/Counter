using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Counter.Models
{
    public class GameRepository
    {
        public ObservableCollection<Game> Games { get; set; }

        public GameRepository()
        {
            LoadData();
        }

        private void LoadData()
        {
            if (Games == null)
            {
                Games = new ObservableCollection<Game>
                {
                    new Game
                    {
                        Player = new ObservableCollection<string>
                        {
                            "player 1",
                            "player 2"
                        },
                        GameType = "1v1",
                        NumPlayers = 2,
                        
                        LifeTotal = 20,
                        CommanderCount = 20
                    },
                    new Game
                    {
                        Player = new ObservableCollection<string>
                        {
                            "player 1",
                            "player 2"
                        },
                        GameType = "Commander",
                        
                        LifeTotal = 40,
                        CommanderCount = 20
                    }
                };
            }
        }
    }
}
