using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///Hilo Game let's go
    /// The  Director control the order of play.
    /// </summary>
    
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int winningbonus = 100;
        int losingloss = 75;
        int totalScore = 300;
        int currentCard;
        int nextCard;
        public Director()
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
        }

        //start the game and connect it to program.cs
        public void StartGame()
        {
            foreach (Card card in cards)
            {
                card.getNewCard();
                currentCard = card.cardValue;
            }
            while (isPlaying)
            {
                GameMain();
                CheckGame();

            }
        }

        //The main game, it pulls card, ask for user input, compares and check values.
        public void GameMain()
        {
            Console.WriteLine($"The card is {currentCard}");
            if (!isPlaying)
            {
                return;
            }
            foreach (Card card in cards)
            {
                card.getNewCard();
                nextCard = card.cardValue;
            }
            Console.Write("Higer or Lower? [h/l] ");
            string cardGuess = Console.ReadLine();
            Console.WriteLine($"The next card was: {nextCard}");
            if (cardGuess.Equals("h") && currentCard < nextCard)
            {
                totalScore += winningbonus;
            }
            else if (cardGuess.Equals("l") && currentCard > nextCard)
            {
                totalScore -= losingloss;
                if (totalScore < 0)
                {
                    totalScore = 0;
                }
            }
            else if (cardGuess.Equals("h") && currentCard > nextCard)
            {
                totalScore -= losingloss;
                if (totalScore < 0)
                {
                    totalScore = 0;
                }
            }
            else if (cardGuess.Equals("l") && currentCard > nextCard)
            {
                totalScore -= losingloss;
                if (totalScore < 0)
                {
                    totalScore = 0;
                }
            }

        }

        /// To Checks if the user can still keep playing the game,  whether by a a score of 0 or by player choice
        public void CheckGame()
        {
            Console.WriteLine($"Your score is: {totalScore}");
            if (totalScore == 0)
            {
                isPlaying = false;
            }
            if (!isPlaying)
            {
                return;
            }

            currentCard = nextCard;
            Console.Write("Play again? [y/n] ");
            string rollDice = Console.ReadLine();
            isPlaying = (rollDice == "y");
        }

         static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to HiLo Game");
        }

    }
}


