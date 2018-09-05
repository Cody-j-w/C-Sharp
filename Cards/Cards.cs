namespace Cards
{
    class Card{
       public string stringVal;
       public string suit;
       public int val;

        public Card(int cardVal, string cardSuit, string cardStringVal)
        {
            val = cardVal;
            suit = cardSuit;
            stringVal = cardStringVal;
        }
    }
}