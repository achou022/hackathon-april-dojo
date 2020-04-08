using System;
using System.IO;
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
            // setting up game
            Console.WriteLine("What's your name player...?");
            string name = Console.ReadLine();
            Player player = new Player(name);
            Player computer = new Player("Computer");
            for(int i = 0; i < 6; i++){
                player.Draw(uno);
                computer.Draw(uno);
            }
            // game loop
            bool playing = true;
            while(playing){
                // game logic
                playing = false;
            }
            Console.WriteLine("game over...");
        }
        public static void printDeck(Deck deck){
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.StringVal);
            }
        }
    }
}
