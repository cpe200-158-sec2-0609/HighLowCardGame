using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Deck
    {
        private List<Card> _deck;
        private int _numCard;
        private Random rand;

        public  List<Card> deck
        {
            get
            {
                return _deck;
            }
            set
            {
                _deck = new List<Card>(value);
            }
        }
        public int NumCard
        {
            get
            {
                return _numCard;
            }
            set
            {
                _numCard = value;
            }
        }
        public Deck()
        {
            deck = new List<Card>();
            //_numCard = 0;
            rand = new Random();
            for(int i=0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck.Add(new Card(j+1,i + 1));
                }
            }
        }
        
        public int CountCard()
        {
            NumCard = 0;
            for(int i=0; i < deck.Count(); i++)
            {
                NumCard += 1;
            }
            return NumCard;
        }
        public void Shuffled()
        {
            Random rand = new Random();
            for(int i=0; i < deck.Count() ; i++)
            {
                var n = rand.Next(i, deck.Count);
                var temp = deck[i];
                deck[i] = deck[n];
                deck[n] = temp;
            }
            Console.WriteLine("Card is Shuffled.");
        }
        
    }
}
