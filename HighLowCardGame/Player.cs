using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Player 
    {
        private string _name;
        private int _score;
        private Deck _mycard;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
        public Deck Mycard
        {
            get
            {
                return _mycard;
            }
            set
            {
                _mycard = value;
            }
        }
        public Player()
        {
            Name = "Untitle";
            Score = 0;
            Mycard = new Deck();
            Mycard.deck.Clear();
        }
        
    }
}
