using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {

        static Random random = new();
        
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;

        }

        private static string RandomSuit()
        {
            //get a random number from 1 to 4, and returning the suit based on the number.
            int value = random.Next(1, 5);

            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 1) return "Clubs";
            return "Diamonds";

        }

        private static string RandomValue()
        {
            //get a random number from 2 to 14 corresponding with the card value.
            int value = random.Next(2, 14);

            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();

        }
    }
}
