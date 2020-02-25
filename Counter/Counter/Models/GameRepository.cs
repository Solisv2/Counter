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
                        GameType = "Free for All",
                         NumPlayers = new ObservableCollection<int>
                        {
                            1,
                            2,
                            3,
                            4
                        },

                        LifeTotal = 20,
                        CommanderCount = 20,
                        IsCommander = true
                    }
                //    new Game
                //    {
                //        Player = new ObservableCollection<string>
                //        {
                //            "player 1",
                //            "player 2"
                //        },
                //        GameType = "Commander",
                //         NumPlayers = new ObservableCollection<int>
                //        {
                //            1,
                //            2,
                //            3,
                //            4
                //        },
                //        LifeTotal = 40,
                //        CommanderCount = 20
                //    }
                };
            }
        }
    }
}
