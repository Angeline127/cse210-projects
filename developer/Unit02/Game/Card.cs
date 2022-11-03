using System;

namespace Unit02.Game
{
    class Card
    {
        public int cardValue;

        //create a class for a card

        public void getNewCard(){
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,14);
        }
    }
}