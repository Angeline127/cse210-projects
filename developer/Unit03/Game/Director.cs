using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {

        private bool isPlaying = true;
        private string chosenWord;

        private TerminalService terminalService = new TerminalService();
        public HiddenWord hiddenWord = new HiddenWord();
        private Jumper jumper = new Jumper();
        public int tries = 0;
        public int numberOfGuesses = 0;

        private bool checkWord;

        List<char> guessedLetters = new List<char>();

        public string currentGuess = "test";


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            StartUp();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }


        private void StartUp()
        {
            Console.WriteLine("\nHint: The Qurom of the Twelve Apostles");
            chosenWord = hiddenWord.pullWord();
            hiddenWord.listWord(chosenWord);
            hiddenWord.createHiddenWord();
            hiddenWord.printGuessWord();
        }
        private void GetInputs()
        {
            Console.WriteLine("\n");
            jumper.printJumper(tries);
            checkWord = true;
            while (checkWord){
                currentGuess = terminalService.ReadGuess("\nGuess a letter [a-z]: ");
                checkWord = jumper.checkInput(guessedLetters, currentGuess);
            }
            guessedLetters.Add(currentGuess[0]);
            

        }


        private void DoUpdates()
        {
            numberOfGuesses = guessedLetters.Count;
            int usedTries = hiddenWord.compare(guessedLetters, numberOfGuesses);
            tries = tries + usedTries;
            isPlaying = jumper.checkJumper(hiddenWord.guess, tries);
        }


        private void DoOutputs()
        {
            Console.WriteLine("\n");
            if (isPlaying){
                hiddenWord.printGuessWord();
            }
            else {
                jumper.printJumper(tries);
                hiddenWord.printAnswerWord();
                Console.WriteLine("\n");
            }
  
        }

        static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to Jumper Game");
        }
    }
}