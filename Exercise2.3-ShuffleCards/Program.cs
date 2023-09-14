namespace Exercise2._3_ShuffleCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDeck cardDeck = new();

            cardDeck.Shuffle();

            Console.WriteLine("Regular shuffle:");
            foreach (Card card in cardDeck.Cards)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
            }


            cardDeck = new();

            cardDeck.FisherYatesShuffle();

            Console.WriteLine("Fisher-Yates shuffle:");
            foreach (Card card in cardDeck.Cards)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
            }
        }
    }
}