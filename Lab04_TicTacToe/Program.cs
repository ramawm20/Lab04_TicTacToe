using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the TicTacToe Game!");

            while (true) 
            {
                StartGame();
                Console.WriteLine("Play again?? (Y/N)");
                string answer=Console.ReadLine();
                if (answer == "N")
                {
                    Environment.Exit(0);
                }

            }
            

        }

        static void StartGame()
        {

            Console.WriteLine("Enter the First player Name please:");
            Player pl1 = new Player();
            pl1.Name = Console.ReadLine();
            pl1.Marker = "X";
            pl1.IsTurn = true;

            Console.WriteLine("Enter the Second player Name please:");
            Player pl2 = new Player();
            pl2.Name = Console.ReadLine();
            pl2.Marker = "O";
            pl2.IsTurn = false ;

            Game game = new Game(pl1, pl2);
            game.Play();
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }


    }
}
