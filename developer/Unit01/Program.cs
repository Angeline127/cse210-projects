//TIC-TAC-TOE GAME//
//AUTHOR:: Angeline Nyepen//

using System;
using System.Collections.Generic;

namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {
           
           DisplayGreeting();

           List<string> board = GetNewBoard();
           

           DisplayBoard(board);

           string currentPlayer = "x";
    
            if (currentPlayer == "-")
            {
                Console.Write("Good game. Thanks for playing!");
            }
    
           int squareChoice = GetUserChoice(currentPlayer);
           MakeMove(board, currentPlayer, squareChoice);




           DisplayBoard(board);

           currentPlayer = "o";

           squareChoice = GetUserChoice(currentPlayer);
           MakeMove(board, currentPlayer, squareChoice);

           DisplayBoard(board);



        }

        static int GetUserChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
           int squareChoice = int.Parse(Console.ReadLine());

           return squareChoice;
        }

        static void MakeMove(List<string>board, string currentPlayer, int squareChoice)
        {
           int boardIndex = squareChoice - 1;
           board [boardIndex] = currentPlayer;
        }
    



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

        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]} ");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]} ");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]} ");
        }

        static void DisplayGreeting()
        {
             Console.WriteLine("Welcome to the Tic Tac Toe Program");
        }
    }
}
