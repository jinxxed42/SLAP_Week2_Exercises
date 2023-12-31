﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._3_ShuffleCards
{
    internal class Card
    {
        public CardValue Value { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }
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

    internal enum CardSuit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
