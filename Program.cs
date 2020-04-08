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
            uno.Shuffle();
            printDeck(uno);
        }
        public static void printDeck(Deck deck){
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.StringVal);
            }
        }
    }
}
