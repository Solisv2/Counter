using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Counter.Models
{
    public class Ticker: INotifyPropertyChanged
    {
        private int _id;
        private string _player;
        private int _count;
        private int _commanderCount;


        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }
        public string Player 
        {
            get => _player;
            set
            {
                _player = value;
                RaisePropertyChanged(nameof(Player));
            }
        }
        public int Count 
        {
            get => _count;
            set
            {
                _count = value;
                RaisePropertyChanged(nameof(Count));
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
