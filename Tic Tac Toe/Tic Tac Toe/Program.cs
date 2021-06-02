using System;

namespace Tic_Tac_Toe
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Variables for game board slots and current player
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

            //Create a container array to hold the strings
            string[] slots = new string[9];
            slots[0] = slot1;
            slots[1] = slot2;
            slots[2] = slot3;
            slots[3] = slot4;
            slots[4] = slot5;
            slots[5] = slot6;
            slots[6] = slot7;
            slots[7] = slot8;
            slots[8] = slot9;

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
            //Unfortunately this currently never gets displayed.
            Console.WriteLine("Welcome to Tic Tac Toe!\n");

            //Main game loop
            //Check to see if the game is over
            while (timeToExit == false)
            {

                //Display the board to the user
                DisplayBoard();

                //Ask the user to choose a number
                Console.Write($"Player {currentPlayer}, please type a number to make your move (1-9): ");

                //Declare the variables
                int userInputInt = 0;
                string userInputString = "";

                //Receive the input from the user
                userInputString = Console.ReadLine();

                //Need to protect this for string inputs
                userInputInt = int.Parse(userInputString);

                //Need to build logic to protect the slot and clarify user input
                //If user input is less than one or more than 9, it's invalid
                //If the slot already contains X or O then need to ask for input again
                //If the slot is not already taken by X or O, then proceed to the switch statement to actually make the move

                if (userInputInt < 1 || userInputInt > 9)
                {
                    Console.WriteLine($"Invalid input. Please type a number that represents a game board slot (1-9)");
                    Console.WriteLine($"Input error was found. Press enter to try again.");
                    //Console.Read(); //Using Console.Read as a means to pause the input so the user can read the error messages
                    //Was causing my application to not work. Removing Console.Read helps!!
                    continue; //Break out of the while loop directly, start a new loop
                }



                bool errorFound = false;


                //This switch statement will actually place the X or O in to the game board slot by stamping the current player
                switch (userInputInt)
                {
                    case 1:
                        if (slot1 == "X" || slot1 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot1 = currentPlayer;
                            break;
                        }

                    case 2:
                        if (slot2 == "X" || slot2 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot2 = currentPlayer;
                            break;
                        }
                    case 3:
                        if (slot3 == "X" || slot3 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot3 = currentPlayer;
                            break;
                        }
                    case 4:
                        if (slot4 == "X" || slot4 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot4 = currentPlayer;
                            break;
                        }
                    case 5:
                        if (slot5 == "X" || slot5 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot5 = currentPlayer;
                            break;
                        }
                    case 6:
                        if (slot6 == "X" || slot6 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot6 = currentPlayer;
                            break;
                        }
                    case 7:
                        if (slot7 == "X" || slot7 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot7 = currentPlayer;
                            break;
                        }
                    case 8:
                        if (slot8 == "X" || slot8 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot8 = currentPlayer;
                            break;
                        }
                    case 9:
                        if (slot9 == "X" || slot9 == "O") //If the slot already has X or O in it, that's an error
                        {
                            Console.WriteLine($"Someone has already played in that space.");
                            errorFound = true;
                            break;
                        }
                        else
                        {
                            slot9 = currentPlayer;
                            break;
                        }

                    default:
                        break;
                }

                if (errorFound == true) // If the previous check for errors returned any errors, need to start a new iteration of the while loop.
                {
                    Console.WriteLine($"Slot already played error was found. Press enter to try again.");
                    //Console.Read(); //THIS WAS CAUSING ISSUES
                    continue;
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

                    //Ask if the user wants to play again
                    Console.WriteLine($"Would you like to play again? (Y / N):");
                    string strUserInput = Console.ReadLine();

                    if (strUserInput.ToLower() == "y")//If the user wants to play again
                    {
                        //Re-set variables for game board slots and current player
                        slot1 = "1";
                        slot2 = "2";
                        slot3 = "3";
                        slot4 = "4";
                        slot5 = "5";
                        slot6 = "6";
                        slot7 = "7";
                        slot8 = "8";
                        slot9 = "9";
                        timeToExit = false;
                        currentPlayer = "X";
                    }
                    else { timeToExit = true; }

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
