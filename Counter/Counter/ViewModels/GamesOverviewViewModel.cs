using Counter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Counter.ViewModels
{
    public class GamesOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly GameRepository GameRepository;

        public ObservableCollection<Game> Games { get; set; }

        public GamesOverviewViewModel()
        {
            GameRepository = new GameRepository();
            Games = GameRepository.Games;
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
