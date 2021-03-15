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

        void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Welcome to Tic Tac Toe!\n");

            string playerTurn = "X";

            //Main game loop
            while (true)
            {



                //Display the board to the user
                DisplayBoard();

                //Ask the user to choose a number
                Console.WriteLine($"Please type a number to make your move: (1-9)");

                //Receive the input from the user
                int userInputInt = 0;
                string userInputString = Console.ReadLine();
                userInputInt = int.Parse(userInputString);

                //Add the character of the player to the slot
                
                switch (userInputInt)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    
                    default:
                        break;
                }

                //End of the game loop, switch turns
                if (playerTurn == "X")
                {
                    playerTurn = "O";
                }
                else if (playerTurn == "O")
                {
                    playerTurn = "X";
                }
            }
        }

        private void DisplayBoard()
        {
            Console.WriteLine($"{slot1} | {slot2} | {slot3}");
            Console.WriteLine($"---------------------------");
            Console.WriteLine($"{slot4} | {slot5} | {slot6}");
            Console.WriteLine($"---------------------------");
            Console.WriteLine($"{slot7} | {slot8} | {slot9}");
        }
    }
}
