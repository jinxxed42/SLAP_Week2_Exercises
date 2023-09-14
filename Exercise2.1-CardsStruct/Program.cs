namespace Exercise2._1_CardsStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    Card card = new(value, suit);
                    cards.Add(card);
                }
            }

            foreach (Card card in cards)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
        }
    }
}