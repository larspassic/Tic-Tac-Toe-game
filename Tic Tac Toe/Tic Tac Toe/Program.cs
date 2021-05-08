using System;

namespace Tic_Tac_Toe
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Variables for game board slots
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

            
            //Method to display the current game board out to the console
            void DisplayBoard()
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine($" {slot1} | {slot2} | {slot3}");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {slot4} | {slot5} | {slot6}");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {slot7} | {slot8} | {slot9}");
                Console.WriteLine("");
            }

            //Welcome the players
            Console.WriteLine("Welcome to Tic Tac Toe!\n");

            //Main game loop
            //Check to see if the game is over
            while (timeToExit == false)
            {
                //Display the board to the user
                DisplayBoard();

                //Ask the user to choose a number
                Console.Write($"Player {currentPlayer}, please type a number to make your move (1-9): ");

                //Receive the input from the user
                int userInputInt = 0;
                string userInputString = Console.ReadLine();
                userInputInt = int.Parse(userInputString);

                //Need to build logic to protect the slot and clarify user input
                //If the slot is X or O then need to ask for input again
                //If the slot is not X or O, then proceed to the switch statement to actually make the move
                

                //This switch statement will actually place the X or O in to the game board slot by stamping the current player
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

                //If the three in a row patterns make "OOO" or "XXX" then that player has won
                //Announce the winner, set timetoexit to true, and end the game
                
                //If CheckForWinner returns true - that means a winner was found
                //Display the board and announce the winner
                if (CheckForWinner(slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9))
                {
                    //Break out of the game loop
                    timeToExit = true;

                    //Clear the console
                    Console.Clear();

                    //Show the board one last time
                    DisplayBoard();

                    //Announce the winner
                    Console.WriteLine($"Player {currentPlayer} has won!");
                    
                    //Wait for user interaction
                    Console.ReadLine();

                    //Break out of the game loop
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

            //End the game by closing the console window
            Environment.Exit(0);

        }

        //Method to check for a winner
        private static bool CheckForWinner(string slot1, string slot2, string slot3, string slot4, string slot5, string slot6, string slot7, string slot8, string slot9)
        {
            //Refresh the different victory patterns - these need to be refreshed prior to checking for a winner
            string topHorizontal = slot1 + slot2 + slot3;
            string middleHorizontal = slot4 + slot5 + slot6;
            string bottomHorizontal = slot7 + slot8 + slot9;
            string leftVertical = slot1 + slot4 + slot7;
            string middleVertical = slot2 + slot5 + slot8;
            string rightVertical = slot3 + slot6 + slot9;
            string diagonalDown = slot1 + slot5 + slot9;
            string diagonalUp = slot7 + slot5 + slot3;

            //Check for player O winning
            if (topHorizontal == "OOO" || middleHorizontal == "OOO" || bottomHorizontal == "OOO" || leftVertical == "OOO" || middleVertical == "OOO" || rightVertical == "OOO" || diagonalDown == "OOO" || diagonalUp == "OOO")
            {
                return true;
            }

            //Check for player X winning
            if (topHorizontal == "XXX" || middleHorizontal == "XXX" || bottomHorizontal == "XXX" || leftVertical == "XXX" || middleVertical == "XXX" || rightVertical == "XXX" || diagonalDown == "XXX" || diagonalUp == "XXX")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
