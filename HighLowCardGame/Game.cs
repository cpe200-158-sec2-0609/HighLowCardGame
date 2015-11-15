using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Game
    {
        private Player _player1;
        private Player _player2;
        private Deck _dec;
        public Deck Dec
        {
            get
            {
                return _dec;
            }
            set
            {
                _dec = value;
            }
        }
        public Player Player1
        {
            get
            {
                return _player1;
            }
            set
            {
                _player1 = value;
            }
        }
        public Player Player2
        {
            get
            {
                return _player2;
            }
            set
            {
                _player2 = value;
            }
        }
        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            Dec = new Deck();
        }
        public void Deal()
        {
            for(int i=0; i<26; i++)
            {
                    Player1.Mycard.deck.Add(Dec.deck[i]);
                    Player2.Mycard.deck.Add(Dec.deck[i+26]);
            }
            Console.WriteLine("Card is already dealed.");
        }
        public void Start()
        {
            Console.WriteLine("====================== | STAR! | ====================");
            Console.WriteLine("Enter player1 's name");
            Player1.Name = Console.ReadLine();
            Console.WriteLine("Enter player2 's name");
            Player2.Name = Console.ReadLine();
            Dec.Shuffled();
            Deal();
        } 
        public int TopCard(Player p)
        {
            int r = p.Mycard.deck[0].Rank;
            Console.WriteLine(p.Name + "'s card is " + p.Mycard.deck[0].ToString());
            p.Mycard.deck.RemoveAt(0);
            return r;
        }
        public void Playing()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            int card_p1 = TopCard(Player1);
            int card_p2 = TopCard(Player2);
            if(card_p1 > card_p2)
            {
                Player2.Score += 2;
                Console.WriteLine(Player2.Name + " win in this turn.");
                Console.WriteLine(Player1.Name + "'s score = " + Player1.Score);
                Console.WriteLine(Player2.Name + "'s score = " + Player2.Score);
            }
            else if(card_p1 < card_p2)
            {
                Player1.Score += 2;
                Console.WriteLine(Player1.Name + " win in this turn.");
                Console.WriteLine(Player1.Name + "'s score = " + Player1.Score);
                Console.WriteLine(Player2.Name + "'s score = " + Player2.Score);
            }
            else if(card_p1 == card_p2)
            {
                Console.WriteLine("Card's rank of both players is equal.");
                Console.WriteLine("Both players have to open cards eaual to the rank.");
                if(Player1.Mycard.CountCard()==0 || Player2.Mycard.CountCard() == 0)
                {
                    Console.WriteLine("Cards run out !!");
                }
                else if(card_p1>Player1.Mycard.CountCard() || card_p2 > Player2.Mycard.CountCard())
                {
                    Console.WriteLine("Each player has cards in their deck less than the card's rank.");
                    Player1.Mycard.deck.Add(Player1.Mycard.deck[0]);
                    Console.WriteLine(Player1.Name + " have to shuffle cards.");
                    Player1.Mycard.Shuffled();
                    Player2.Mycard.deck.Add(Player2.Mycard.deck[0]);
                    Console.WriteLine(Player2.Name + " have to shuffle cards.");
                    Player2.Mycard.Shuffled();
                }
                else if(Player1.Mycard.deck[card_p1-1] == Player2.Mycard.deck[card_p2])
                {
                    Console.WriteLine("Card's rank of both players is equal again.");
                    Player1.Mycard.deck.Add(Player1.Mycard.deck[0]);
                    Console.WriteLine(Player1.Name + " have to shuffle cards.");
                    Player1.Mycard.Shuffled();
                    Player2.Mycard.deck.Add(Player2.Mycard.deck[0]);
                    Console.WriteLine(Player2.Name + " have to shuffle cards.");
                    Player2.Mycard.Shuffled();
                }
                else if(Player1.Mycard.deck[card_p1 - 1] != Player2.Mycard.deck[card_p2-1])
                {
                    int card_rank = card_p1;
                    int nscore = 2;
                    for(int i=0; i<card_rank; i++)
                    {
                        card_p1 = TopCard(Player1);
                        card_p2 = TopCard(Player2);
                        nscore += 2;
                    }
                    if(card_p1 < card_p2)
                    {
                        Player1.Score += nscore;
                        Console.WriteLine(Player1.Name + " win in this turn.");
                        Console.WriteLine(Player1.Name + "'s score = " + Player1.Score);
                        Console.WriteLine(Player2.Name + "'s score = " + Player2.Score);
                    }
                    else if(card_p1 > card_p2){
                        Player2.Score += nscore;
                        Console.WriteLine(Player2.Name + " win in this turn.");
                        Console.WriteLine(Player1.Name + "'s score = " + Player1.Score);
                        Console.WriteLine(Player2.Name + "'s score = " + Player2.Score);
                    }
                }
            }
        } 
        public bool IsEnd()
        {
            if(Player1.Mycard.CountCard()==0 || Player2.Mycard.CountCard() == 0)
            {
                Console.WriteLine("====================== | END GAME! | ====================");
                if(Player1.Score == Player2.Score)
                {
                    Console.WriteLine("Draw !!");
                }
                else if(Player1.Score > Player2.Score)
                {
                    Console.WriteLine("The winner is >>>>> " + Player1.Name + " !");
                }
                else if(Player2.Score > Player1.Score)
                {
                    Console.WriteLine("The winner is >>>>> " + Player2.Name + " !");
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
