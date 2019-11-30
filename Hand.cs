using System;
using System.Collections.Generic;
using System.Linq;

namespace BestHandV3
{
    public class Hand : Deck
    {
        private List<Card> _Hand = new List<Card>();

        public Hand(int card)
        {
            List<Card> playerOne = new List<Card>();
        }
        public int HandTotal(List<Card> hand)
        {
            int total = hand.Sum(face => face.CardValue);

            return total;
        }

    }
}

