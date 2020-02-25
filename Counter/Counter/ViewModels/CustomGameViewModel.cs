using Counter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Counter.ViewModels
{
    public class CustomGameViewModel : INotifyPropertyChanged
    {
        public Game _game { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CustomGameViewModel(Game game)
        {
            _game = game;
        }
        public CustomGameViewModel()
        {

        }
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
