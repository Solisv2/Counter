using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Counter.Models
{
    public class Game
    {

        private int _id;
        private string _gameType;
        private ObservableCollection<int>_numPlayers;
        private ObservableCollection<string> _player;
        private int _lifeTotal;
        private int _commanderCount;
        private bool _isCommander;


        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }
        public string GameType
        {
            get => _gameType;
            set
            {
                _gameType = value;
                RaisePropertyChanged(nameof(GameType));
            }
        }

        public ObservableCollection<int> NumPlayers
        {
            get => _numPlayers;
            set
            {
                _numPlayers = value;
                RaisePropertyChanged(nameof(NumPlayers));
            }
        }
        public ObservableCollection<string> Player
        {
            get => _player;
            set
            {
                _player = value;
                RaisePropertyChanged(nameof(Player));
            }
        }
        public int LifeTotal
        {
            get => _lifeTotal;
            set
            {
                _lifeTotal = value;
                RaisePropertyChanged(nameof(LifeTotal));
            }
        }
        public int CommanderCount
        {
            get => _commanderCount;
            set
            {
                _commanderCount = value;
                RaisePropertyChanged(nameof(CommanderCount));
            }
        }

        public bool IsCommander
        {
            get => _isCommander;
            set
            {
                _isCommander = value;
                RaisePropertyChanged(nameof(IsCommander));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

