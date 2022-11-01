//TIC - TAC - TOE GAME//
//AUTHOR:: Angeline Nyepen//

using System;
using System.Collections.Generic;

namespace Unit01
{


    class Program
    {
        //// <summary>
        /// Welcome to Tic Tac Toe program. 
        /// </summary>
        static void Main(string[] args)
        {
            DisplayGreeting();

            string currentPlayer = "x";

            List<string> board = GetNewBoard();

            while (!GameOver(board))
            {
                DisplayBoard(board);

                int squareChoice = GetUserChoice(currentPlayer);
                MakeMove(board, squareChoice, currentPlayer);

                currentPlayer = GetNextPlayer(currentPlayer);
            }

            DisplayBoard(board);
            Console.WriteLine("Good game. Thanks for playing!");
        }


        /// <summary>
        /// Gets a new instance of the board with the numbers 1-9 in place.
        /// </summary>
        /// <returns>A list of 9 strings representing each square.</returns>
        static List<string> GetNewBoard()
        {
            List<string> board = new List<String>();

            board.Add("1");
            board.Add("2");
            board.Add("3");
            board.Add("4");
            board.Add("5");
            board.Add("6");
            board.Add("7");
            board.Add("8");
            board.Add("9");

            return board;

        }


        /// <summary>
        /// Display board with the numbers 1-9 in place.
        /// </summary>
        /// <returns>A list of 9 strings representing each square.</returns>
        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]} ");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]} ");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]} ");
        }


        static bool GameOver(List<string> board)
        {
            bool Over = false;

            if (Winner(board, "x") || Winner(board, "o"))
            {
                Over = true;
            }

            return Over;
        }

        static bool Winner(List<string> board, string player)
        {
            // There are more elegant ways to check for a win, especially if
            // something besides a 3x3 board were anticipated. This brute force
            // approach is sufficient to check for the possibilities.

            bool won = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                won = true;
            }

            return won;
        }
        /// <summary>
        /// Gets a next player of the board at x and 0.
        /// </summary>
        /// <returns>A list of 9 strings representing each square.</returns>
        static string GetNextPlayer(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }

            return nextPlayer;
        }


        /// <summary>
        /// Gets a choice from the user.
        /// </summary>
        /// <returns>A list of 9 strings representing each square.</returns>
        static int GetUserChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();

            int squareChoice = int.Parse(move_string);
            return squareChoice;
        }

        /// <summary>
        /// Places the current players mark on the board at the desired spot.
        /// This method does NOT check to ensure the spot is available.
        /// </summary>
        /// <param name="board">The current board</param>
        /// <param name="squareChoice">The 1-based spot number (not a 0-based index).</param>
        /// <param name="currentPlayer">The current player's sign (x or o)</param>
        static void MakeMove(List<string> board, int squareChoice, string currentPlayer)
        {
            int boardIndex = squareChoice - 1;
            board[boardIndex] = currentPlayer;
        }





        /// <summary>
        /// Display a greeting meeting for the user playin the game..

        static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Game");
        }

    }
}