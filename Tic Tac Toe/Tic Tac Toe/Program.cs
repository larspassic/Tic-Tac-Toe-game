using System;

namespace Tic_Tac_Toe
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Variables
            string slot1 = "1";
            string slot2 = "2";
            string slot3 = "3";
            string slot4 = "4";
            string slot5 = "5";
            string slot6 = "6";
            string slot7 = "7";
            string slot8 = "8";
            string slot9 = "9";
            bool timeToExit = false;
            string currentPlayer = "X";

            void DisplayBoard()
            {
                Console.WriteLine("");
                Console.WriteLine($"{slot1} | {slot2} | {slot3}");
                Console.WriteLine($"----------");
                Console.WriteLine($"{slot4} | {slot5} | {slot6}");
                Console.WriteLine($"----------");
                Console.WriteLine($"{slot7} | {slot8} | {slot9}");
                Console.WriteLine("");
            }

            //Welcome
            Console.WriteLine("Welcome to Tic Tac Toe!\n");


            //Check to see if the game is over
            while (timeToExit == false)
            {
                //Main game loop

                //Display the board to the user
                DisplayBoard();

                //Ask the user to choose a number
                Console.WriteLine($"Player {currentPlayer}, please type a number to make your move: (1-9)");

                //Receive the input from the user
                int userInputInt = 0;
                string userInputString = Console.ReadLine();
                userInputInt = int.Parse(userInputString);

                //Need to build logic to protect the slot
                //If the slot is X or O then need to ask for input again


                //Actually place the X or O in to the game board
                switch (userInputInt)
                {
                    case 1:
                        slot1 = currentPlayer;
                        break;
                    case 2:
                        slot2 = currentPlayer;
                        break;
                    case 3:
                        slot3 = currentPlayer;
                        break;
                    case 4:
                        slot4 = currentPlayer;
                        break;
                    case 5:
                        slot5 = currentPlayer;
                        break;
                    case 6:
                        slot6 = currentPlayer;
                        break;
                    case 7:
                        slot7 = currentPlayer;
                        break;
                    case 8:
                        slot8 = currentPlayer;
                        break;
                    case 9:
                        slot9 = currentPlayer;
                        break;

                    default:
                        break;
                }


                //End of the game loop, switch turns
                if (currentPlayer == "X")
                {
                    currentPlayer = "O";
                }
                else if (currentPlayer == "O")
                {
                    currentPlayer = "X";
                }
            }

        }

    }
}
