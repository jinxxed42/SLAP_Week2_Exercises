using System;

namespace Exercise2._1_CardsStruct
{
    internal struct Card
    {
        public CardValue Value { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }
    }

    internal enum CardSuit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    internal enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
