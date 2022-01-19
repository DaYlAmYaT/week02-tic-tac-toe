using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameover = false;
            int attempt = 0;
            string player;
            int choice;
            List<string> status = new List<string>();

            MakeBoard(status);
            do
            {   
                DisplayBoard(status);
                player = GetTurn(attempt);
                choice = GetUserChoice(player);
                MakeMove(status, player, choice);
                attempt++;
                gameover = IsGameOver(status, attempt);


            } while (gameover != true);

            DisplayBoard(status);
            Console.WriteLine("\nGood game! Thx for playing!");
            
        }
        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"\n{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");            
        }
        
        static int GetUserChoice(string player)
        {
            Console.WriteLine($"\n{player}'s turn.");
            Console.WriteLine("Where do you want to play?");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            return choice;
        }
        static void MakeMove(List<string> board, string player, int choice)
        {
            board[choice - 1] = player;
        }
        static void MakeBoard(List<string> board)
        {
            for (int i = 1; i <= 10; i++)
            {
                board.Add(i.ToString());
            }
        }
        static string GetTurn(int attempt)
        {
            string turn;
            if (attempt % 2 == 0)
            {
                turn = "x";
            }
            else
            {
                turn = "o";
            }
            return turn;
        }

        static bool IsGameOver(List<string> board, int attempt)
        {
            if (board[0] == board[1] && board[0] == board[2])
                {
                    return true;
                }
                else if (board[3] == board[4] && board[3] == board[5])
                {
                    return true;
                }
                else if (board[6] == board[7] && board[6] == board[8])
                {
                    return true;
                }
                else if (board[0] == board[3] && board[3] == board[6])
                {
                    return true;
                }                                
                else if (board[1] == board[4] && board[1] == board[7])
                {
                    return true;
                }
                else if (board[2] == board[5] && board[2] == board[8])
                {
                    return true;
                }
                else if (board[0] == board[4] && board[0] == board[8])
                {
                    return true;
                }
                else if (board[2] == board[4] && board[2] == board[6])
                {
                    return true;
                }
                else if (attempt >= 9)
                {
                    return true;
                }
            return false;

        }
        
    }
}
