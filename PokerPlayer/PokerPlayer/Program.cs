using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 10000;

            Deck myDeck = new Deck();
            myDeck.Shuffle();
            myDeck.Shuffle();
            myDeck.Shuffle();
            myDeck.Shuffle();
            myDeck.Shuffle();
            myDeck.Shuffle();

            PokerPlayer cian = new PokerPlayer();

            for (int i = 0; i < 20; i++)
            {
                myDeck.Shuffle();
                cian.DrawHand(myDeck.Deal(5));
                cian.ShowHand();
                Console.WriteLine();
            }
            


            //keep console open
            Console.ReadKey();
        }
    }
}
