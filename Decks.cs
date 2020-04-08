using System;
using System.Collections.Generic;

namespace Decks{
    class Card{
        public string StringVal;
        public string Suit;
        public int Val;

        public Card(string suit, int val){
            Suit=suit;
            Val=val;
            StringVal = suit + " " + val;
        }
    }

    class Deck{
        public List<Card> Cards{get; set;}

        public Deck(){
            Cards=setDeck();
            Console.WriteLine("New deck has been built!");
        }

        public List<Card> setDeck(){
            List<string> suites = new List<string>{"Red", "Blue", "Green", "Yellow"};
            List<Card> deck = new List<Card>();
            foreach (string suite in suites)
            {
                for(int i = 0; i <= 9; i++){
                    deck.Add(new Card(suite, i));
                    if(i != 0){
                        deck.Add(new Card(suite, i));
                    }
                }
            }
            return deck;
        }

        public Card Deal(){
            Card target = Cards[0];
            Cards.Remove(Cards[0]);
            Console.WriteLine("Dealing card...");
            return target;
        }

        public void Reset(){
            Console.WriteLine("reseting the deck...");
            Cards=setDeck();
        }

        public void Shuffle(){
            List<Card> shuffled = new List<Card>();
            Random rand = new Random();
            Console.WriteLine("Shuffling.......");
            while(Cards.Count != 0){
                int selected = rand.Next(Cards.Count);
                shuffled.Add(Cards[selected]);
                Cards.RemoveAt(selected);
            }
            Cards=shuffled;
        }
    }
    class Player{
        public string Name;
        public List<Card> hand;
        public Player(string name){
            Name = name;
            hand = new List<Card>();
            Console.WriteLine($"{Name} has been initialized!");
        }

        public Card Draw(Deck deck){
            Console.WriteLine("Player drawing card...");
            Card drew = deck.Deal();
            hand.Add(drew);
            return drew;
        }

        public Card Discard(int indx){
            Console.WriteLine($"Player discarded a card...");
            if(indx>hand.Count || indx<0){
                return null;
            }
            Card target = hand[indx];
            hand.Remove(target);
            return target;
        }
    }
}