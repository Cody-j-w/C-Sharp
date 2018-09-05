using System.Collections.Generic;
using System;

namespace Cards
{
    class Deck
    {
        public List<Card> cards = new List<Card>();

        public Card deal()
        {
            Card DrawnCard;
            DrawnCard = cards[0];
            cards.Remove(cards[0]);
            return DrawnCard;
        }

        public void reset()
        {
            this.cards.Clear();
            
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            string[] values = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            foreach(string suit in suits)
            {
                for(int i = 0; i<=12; i++)
                {
                    cards.Add(new Card(i+1, suit, values[i]));
                }
            }

        }

        public void shuffle()
        {
            Random rando = new Random();
            Card temp;
            for(int i = 0; i<52; i++)
            {
                int shift = rando.Next(0, 52);
                temp = cards[i];
                cards[i] = cards[shift];
                cards[shift] = temp;
            }
        }

        public Deck()
        {
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            string[] values = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            foreach(string suit in suits)
            {
                for(int i = 0; i<=12; i++)
                {
                    cards.Add(new Card(i+1, suit, values[i]));
                }
            }
        }
    }
}