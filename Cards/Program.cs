using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards.Deck freshDeck = new Deck();

            foreach(Card card in freshDeck.cards)
            {
                Console.WriteLine($"{card.stringVal} of {card.suit} - card value:{card.val}");
                
            }

            freshDeck.shuffle();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Cards.Player newPlayer = new Player("Don");

            newPlayer.draw(freshDeck);
            newPlayer.draw(freshDeck);
            newPlayer.draw(freshDeck);
            newPlayer.draw(freshDeck);
            newPlayer.draw(freshDeck);

            Console.WriteLine($"{newPlayer.name}'s hand:");
            foreach(Card card in newPlayer.hand)
            {
                
                Console.WriteLine($"{card.stringVal} of {card.suit} - card value:{card.val}");
                
            }


        }
    }
}
