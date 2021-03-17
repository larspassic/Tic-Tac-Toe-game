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

        public void Main()
        {
            //Welcome
            Console.WriteLine("Welcome to Tic Tac Toe!\n");

            string currentPlayer = "X";

            //Main game loop
            while (true)
            {
                


                //Display the board to the user
                DisplayBoard();

                //Ask the user to choose a number
                Console.WriteLine($"Player {currentPlayer}, please type a number to make your move: (1-9)");

                //Receive the input from the user
                int userInputInt = 0;
                string userInputString = Console.ReadLine();
                userInputInt = int.Parse(userInputString);

                //Add the character of the player to the slot
                
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
