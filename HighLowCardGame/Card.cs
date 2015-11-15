using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Card
    {
        private int _rank;
        private int _suits;
        private string[] rk = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        private string[] sui = { "Hearts", "Clubs", "Diamonds", "Spades" };

        public int Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                if(value <= 0 && value > 13)
                {
                    _rank = 0;
                }
                else
                {
                    _rank = value;
                }
            }
        }
        public int Suits
        {
            get
            {
                return _suits;
            }
            set
            {
                if(value<=0 && value > 4)
                {
                    _suits = 0;
                }
                else
                {
                    _suits = value;
                }
               
            }
        }
        public Card(int r, int s)
        {
            _suits = s;
            _rank = r;
        }
        public override string ToString()
        {
            return rk[Rank - 1] + " of " + sui[Suits - 1];
        }
    }
}
