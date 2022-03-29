///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-27 - Elimination - App that prints out only unique values entered by user
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-27 - Jared Howard - File created and basic methods started
// 2022-03-02 - Jared Howard - More methods developed and testing for edge cases started
// 2022-03-07 - Jared Howard - Commas ajusted to only print between the values that are printed
// 2022-03-08 - Jared Howard - Testing completed, output file not yet created.
// 2022-03-12 - Jared Howard - Fixed to prevent crashing from non-int input. Methods changed to private.
// Testing finished, output file created.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elimination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program elimination = new Program();
            elimination.Run();
        }

        // Runs the application
        internal void Run()
        {
            BeginningPrompt();
            InputPrompt();
        }

        // Simple method to check if user input is an int and is in range
        private bool IsValid(String input)
        {
            int correct;
            if (!int.TryParse(input, out correct))
            {
                return false;
            }
            if (correct < 10 || correct > 100)
            {
                return false;
            }
            return true;
        }

        // Repeatedly prompts user to enter valid value and returns when correct
        private int ReturnValid(String input)
        {
            bool valid = IsValid(input);
            while(!valid)
                {
                    Console.Write("Invalid input. Please try again: ");
                    String newInput = Console.ReadLine();
                    if(IsValid(newInput))
                    {
                        return int.Parse(newInput);
                    }
                    else
                    {
                        valid = false;
                    }
                }
            return int.Parse(input);
        }

        // Prints unique values as user inputs 
        private void UniquePrinter(int[] arr, int index)
        {
            // Beginning string for printing values
            string str = "UNIQUE values: ";

            // Counter for checking whether all values are the same
            int count = 0;

            // Checks for all values being the same
            for(int g = 0; g < arr.Length - 1; g++)
            {
                for(int h = g + 1; h < arr.Length; h++)
                {
                    if (arr[g] == arr[h])
                    {
                        // If arr[g] and arr[h] are equal and aren't 0 then increment counter
                        if(IsValid(arr[h].ToString()) && IsValid(arr[g].ToString()))
                        {
                            count++;
                            break;
                        } 
                    }
                }
            }
            // Variable used for testing
            //Console.WriteLine($"Duplicate Counter: {count}");

            // If every value in the array isn't a duplicate
            if (count < 4)
            {
                // Iterates through the array and compares every number to another
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            break;
                        }
                        else
                        {
                            // Adds the integer to string without comma if its the only unique value
                            if (str.Length < 18)
                            {
                                str += ($"{arr[i]} ");
                                break;
                            }
                            // Adds the integer to string with comma if more than one unique value
                            else if (str.Length >= 18)
                            {
                                str += ($", {arr[i]} ");
                                break;
                            }

                        }
                    }
                }

                // Case to print out the last number in the array if it is unique. Otherwise the loops won't get to it.
                // If the last two values AREN'T the same and aren't 0, then add the last value to string
                if ((arr[arr.Length - 2] != arr[arr.Length - 1]) && (arr[arr.Length - 1] != 0))
                {
                    str += ($", {arr[arr.Length - 1]}");
                }

                // If the last two values ARE the same and aren't 0, then only add the last value to string
                else if ((arr[arr.Length - 2] == arr[arr.Length - 1]) && (arr[arr.Length - 1] != 0))
                {
                    str += ($", {arr[arr.Length - 1]}");
                }
            }

            // If every value is the same, then only add the first value to output string
            else str += arr[1];
            Console.WriteLine(str);

            // Piece of code for testing
            //Console.WriteLine(str.Length);
        }

        // Prints array out for testing
        private void ArrayPrinter(int[] arr)
        {
            Console.Write("CURRENT ARRAY: ");
            foreach(int i in arr)
            {
                Console.Write(i + " , ");
            }
            Console.WriteLine("");
        }

        // Prints out the beginning prompt with explanation
        private void BeginningPrompt()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("   Welcome to the Elimination app. This app accepts five integer \n " +
                              "  inputs between 10 and 100 inclusive and prints out only those \n " +
                              "  inputs which are not duplicates.\n " +
                              "  For example, entering 15 20 25 30 35 will result in an output of: \n " +
                              "        UNIQUE VALUES: 15 , 20 , 25 , 30 , 35 \n" + 
                              "   Entering 20 30 30 30 30 will result in an output of: \n" + 
                              "         UNIQUE VALUES: 20 , 30");
            Console.WriteLine("--------------------------------------------------------------------- \n");
        }

        // Prompts the user for numbers and adds to array if valid
        private void InputPrompt()
        {
            int[] elimArray = new int[5];

            Console.Write("Enter the first number: ");
            String stringInput = Console.ReadLine();
            int numInput;

            // Checks for valid input
            numInput = ReturnValid(stringInput);

            // Input is added to the array
            elimArray[0] = numInput;

            // Prints array during testing to ensure values are being added correctly
            //ArrayPrinter(elimArray);

            // Prints comma separated list of unique values
            UniquePrinter(elimArray, numInput);

            Console.Write("Enter the second number: ");
            stringInput = Console.ReadLine();

            // Checks for valid input
            numInput = ReturnValid(stringInput);

            // Input is added to the array
            elimArray[1] = numInput;

            // Prints array during testing to ensure values are being added correctly
            //ArrayPrinter(elimArray);

            // Prints comma separated list of unique values
            UniquePrinter(elimArray, numInput);

            Console.Write("Enter the third number: ");
            stringInput = Console.ReadLine();

            // Checks for valid input
            numInput = ReturnValid(stringInput);

            // Input is added to the array
            elimArray[2] = numInput;

            // Prints array during testing to ensure values are being added correctly
            //ArrayPrinter(elimArray);

            // Prints comma separated list of unique values
            UniquePrinter(elimArray, numInput);

            Console.Write("Enter the fourth number: ");
            stringInput = Console.ReadLine();

            // Checks for valid input
            numInput = ReturnValid(stringInput);

            // Input is added to the array
            elimArray[3] = numInput;

            // Prints array during testing to ensure values are being added correctly
            //ArrayPrinter(elimArray);

            // Prints comma separated list of unique values
            UniquePrinter(elimArray, numInput);

            Console.Write("Enter the fifth number: ");
            stringInput = Console.ReadLine();

            // Checks for valid input
            numInput = ReturnValid(stringInput);

            // Input is added to the array
            elimArray[4] = numInput;

            // Prints array during testing to ensure values are being added correctly
            //ArrayPrinter(elimArray);

            // Prints comma separated list of unique values
            UniquePrinter(elimArray, numInput);
        }
    }
}
