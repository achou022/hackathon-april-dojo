using System;
using Decks;

namespace hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck uno = new Deck();
            Player p1 = new Player("Player One");
            uno.Shuffle();
            printDeck(uno);
            p1.Draw(uno);
            p1.Draw(uno);
            p1.Draw(uno);
            p1.Draw(uno);
            p1.Draw(uno);
            p1.ShowHand();
            string test = Console.ReadLine();
            Console.WriteLine("Did you just type " + test + "?");
        }
        public static void printDeck(Deck deck){
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.StringVal);
            }
        }
    }
}
