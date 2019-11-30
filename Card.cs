using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHandV3
{
    public class Card
    {
        public string[] SuitValues = { "Clubs", "Diamonds", "Hearts", "Spades" };
        public string[] CardValues = { "Ace", "Jack", "Queen", "King" };

        public int CardValue;
        public int CardSuit;

        public Card()
        {
            Random newCard = new Random();
            Random newSuit = new Random();
            this.CardValue = newCard.Next(2, 15);
            this.CardSuit = newSuit.Next(0, 4);
        }

        public Card(int CardValue, int CardSuit)
        {
            this.CardValue = CardValue;
            this.CardSuit = CardSuit;
        }
    }
}
