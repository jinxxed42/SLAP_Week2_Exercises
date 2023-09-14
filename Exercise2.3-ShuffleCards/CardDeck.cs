using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._3_ShuffleCards
{
    internal class CardDeck
    {
        public List<Card> Cards { get; private set; } = new();

        public CardDeck()
        {
            foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    Card card = new Card(value, suit);
                    Cards.Add(card);
                }
            }
        }

        // Simple shuffle
        public void Shuffle()
        {
            List<Card> shuffledDeck = new();
            while (Cards.Count > 0)
            {
                int rand = Random.Shared.Next(0, Cards.Count);
                shuffledDeck.Add(Cards[rand]);
                Cards.RemoveAt(rand);
            }
            Cards = shuffledDeck;
        }

        // Shuffling with Fisher-Yates algorithm
        public void FisherYatesShuffle()
        {
            for (int i = Cards.Count - 1; i > 1; i--)
            {
                int j = Random.Shared.Next(0, i);
                Card card = Cards[j];
                Cards[j] = Cards[i];
                Cards[i] = card;
            }
        }
    }
}
