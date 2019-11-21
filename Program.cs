using System;

namespace BestHandV3
{
    class Card
    {
        public enum SuitValues { Clubs = 0, Diamonds = 1, Hearts = 2, Spades = 4 };
        public enum CardValues { Ace = 1, Jack = 11, Queen = 12, King = 13 };
        Array suits = Enum.GetValues(typeof(SuitValues));
        SuitValues randomSuitValue = (SuitValues)(new Random()).Next(0, 3);
        CardValues randomCardValues = (CardValues)new Random().Next(1, 13);


        public CardValues CardValue;
        public string CardSuit;

        public Card()
        {
            this.CardValue = randomCardValues;
            this.CardSuit = randomSuitValue.ToString();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Card newCard = new Card();
            Console.WriteLine("{0} of {1}.", newCard.CardValue, newCard.CardSuit);
        }
    }
}
