using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Counter.Models
{
    public class Game: ObservableObject
    {

        private int _id;
        private string _gameType;
        private ObservableCollection<int>_numPlayers;
        private int _selectedNumPlayers;
        private ObservableCollection<string> _player;
        private int _lifeTotal;
        private int _commanderCount;
        private bool _isCommander;


        public int Id
        {
            get => _id;
            set
            {
                SetProperty(ref _id, value);          
            }
        }
        public string GameType
        {
            get => _gameType;
            set
            {
                SetProperty(ref _gameType, value);
            }
        }

        public ObservableCollection<int> NumPlayers
        {
            get => _numPlayers;
            set
            {

                SetProperty(ref _numPlayers, value);     
            }
        }

        public int SelectedNumPlayers
        {
            get => _selectedNumPlayers;
            set
            {
                SetProperty(ref _selectedNumPlayers, value);
            }
        }
        public ObservableCollection<string> Player
        {
            get => _player;
            set
            {
                SetProperty(ref _player, value);
            }
        }
        public int LifeTotal
        {
            get => _lifeTotal;
            set
            {
                SetProperty(ref _lifeTotal, value);
            }
        }
        public int CommanderCount
        {
            get => _commanderCount;
            set
            {
                SetProperty(ref _commanderCount, value);            
            }
        }

        public bool IsCommander
        {
            get => _isCommander;
            set
            {
                SetProperty(ref _isCommander, value);               
            }
        }

      
    }
}

