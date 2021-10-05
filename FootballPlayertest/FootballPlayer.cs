using System;
using System.Runtime.CompilerServices;

namespace FootballPlayerTest
{
    public class FootballPlayer
    {
        private string _name;
        private int _id;
        private int _price;
        private int _shirtNumber;

        public FootballPlayer()
        {

        }
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length <= 4) throw new ArgumentException();
                {
                    _name = value;
                }
            }
        }
        public int ID
        {
            get => _id;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _id = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }
        public int shirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException();
                _shirtNumber= value;
            }
        }
    }
}
