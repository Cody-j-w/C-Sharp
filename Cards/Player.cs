using System.Collections.Generic;
using System;

namespace Cards
{

    class Player
    {

        public string name;
        public List<Card> hand = new List<Card>();

        public Card draw(Deck deck)
        {
            Card DrawnCard;
            hand.Add(deck.cards[0]);
            DrawnCard = deck.cards[0];
            deck.cards.RemoveAt(0);
            Console.WriteLine($"{this.name} drew a {DrawnCard.stringVal} of {DrawnCard.suit}");
            return DrawnCard;
            
        }

        public Card discard(int idx)
        {
            Card DiscardedCard = hand[idx];
            hand.RemoveAt(idx);
            return DiscardedCard;
        }

        public Player(string name)
        {
            this.name = name;
        }
    }
}