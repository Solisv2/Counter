using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Counter.Models
{
    public class Player:ObservableObject
    {
        private int playerHealth;
        private int commanderHealth;

        public int PlayerHealth
        {
            get => playerHealth;
            set
            {
                SetProperty(ref playerHealth, value);
            }
        }
        public int CommanderHealth
        {
            get => commanderHealth;
            set
            {
                SetProperty(ref commanderHealth, value);
            }
        }
    }
}
