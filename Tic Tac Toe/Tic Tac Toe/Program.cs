using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        //Variables
        string slot1 = "";
        string slot2 = "";
        string slot3 = "";
        string slot4 = "";
        string slot5 = "";
        string slot6 = "";
        string slot7 = "";
        string slot8 = "";
        string slot9 = "";

        static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Welcome to Tic Tac Toe!");




            //Display the board to the user
            DisplayBoard();

            //Ask the user to choose a number
            Console.WriteLine($"Please type a number to make your move: (1-9)");

            //Receive the input from the user
            int userInput = 0;
            userInput = Console.Read();



        }

        private static void DisplayBoard()
        {
            Console.WriteLine($"{slot1} | {slot2} | {slot3}");
            Console.WriteLine($"{slot4} | {slot5} | {slot6}");
            Console.WriteLine($"{slot7} | {slot8} | {slot9}");
        }
    }
}
