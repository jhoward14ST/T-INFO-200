///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-27 - Airline - Allows an airline employee to book available seats in
// a flight
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-27 - Jared Howard - File created
// 2022-03-08 - Jared Howard - Prompts and basic methods started
// 2022-03-11 - Jared Howard - Methods throughouly tested. No clear way to crash program.
// 2022-03-12 - Jared Howard - Methods changed to private. Testing finished, output file created.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program airline = new Program();
            airline.Run();
        }

        // Runs the program
        internal void Run()
        {
            // Creates array of values for seat assignment
            bool[] seating = new bool[10];
            BeginningPrompt();
            while (!IsPlaneFull(IsFirstFull(seating), IsEconomyFull(seating)))
            {
                seating = BookingApp(seating);
            }
            FullFlight();
        }

        // Prints seating availability
        private void SeatingPrinter(bool[] seating)
        {
            Console.WriteLine("\n****************** SEATING AVAILABILITY ******************");
            Console.Write("First Class: ");
            int firstCount = 0;
            for(int i = 0; i < 5; i++)
                if(seating[i] == true)
                {
                    Console.Write("X  ");
                    firstCount++;
                }
                else
                {
                    Console.Write("O  ");
                }
            Console.WriteLine($"{firstCount}/5 seats filled");

            Console.Write("    Economy: ");
            int econCount = 0;
            for(int i = 5; i < 10; i++)
            {
                if(seating[i] == true)
                {
                    Console.Write("X  ");
                    econCount++;
                }
                else
                {
                    Console.Write("O  ");
                }
            }
            Console.WriteLine($"{econCount}/5 seats filled");
            Console.WriteLine("**********************************************************");
        }

        // Prompts user to enter in seats until they opt out or plane fills up
        private bool[] BookingApp(bool[] seating)
        {
            // Prompts user to select tickets
            TicketPrompt();

            // Starts off the first prompt to get started
            char selection = PromptWithValidation();

            switch(selection)
            {
                case '1':
                    // Assign first class
                    SeatingAvailability('2', seating);
                    // TESTING
                    SeatingPrinter(seating);
                    break;
                case '2':
                    // Assign economy
                    SeatingAvailability('1', seating);
                    // TESTING
                    SeatingPrinter(seating);
                    break;
                case '4':
                    // Display message and end
                    Console.WriteLine("\n----------------------------------------------");
                    Console.WriteLine("                 EXITED APPLICATION");
                    Console.WriteLine("----------------------------------------------");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            return seating;

        }

        // Runs logic behind seating assignments. If economy is full, then asks about
        // first class and vice versa. Returns new array with newly assigned seat.
        private bool[] SeatingAvailability(char input, bool[] seating)
        {
            if (input == '1')
            {
                if (IsEconomyFull(seating))
                {
                    // Is first class ok?
                    EconomyFullPrompt();
                    char alternative = char.Parse(Console.ReadLine());
                    alternative = ReturnValid(alternative);

                    // If yes
                    if (alternative == '1')
                    {
                        // Then assign first class seat
                        AssignFirst(seating);
                    }
                    // If no
                    if (alternative == '2')
                    {
                        NextFlight();
                    }
                }
                else
                {
                    AssignEconomy(seating);
                }
            }
            if (input == '2')
            {
                if (IsFirstFull(seating))
                {
                    // Is economy ok?
                    FirstClassFullPrompt();
                    char alternative = char.Parse(Console.ReadLine());
                    alternative = ReturnValid(alternative);

                    // If yes
                    if (alternative == '1')
                    {
                        // Then assign economy seat
                        AssignEconomy(seating);
                    }
                    // If no
                    if (alternative == '2')
                    {
                        NextFlight();
                    }
                }
                else
                {
                    AssignFirst(seating);
                }
            }
            return seating;
        }

        /************ PROMPT printing methods ************/

        // Prints out the beginning prompt with explanation
        private void BeginningPrompt()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("  Welcome to the Airline app. This app allows you to book seats \n" +
                              "  on a flight for customers. There are 5 seats available for economy \n" +
                              "  and 5 available for first class. The app will continually prompt \n" +
                              "  you until one of three cases is true:  \n" +
                              "                         ********  \n" +
                              "  CASE 1: All seats are full. \n" +
                              "  CASE 2: All economy seats are full and there are no customers \n" +
                              "  willing to switch to first class \n" +
                              "  CASE 3: All first class seats are full and there are no customers \n" +
                              "  willing to switch to economy \n" +
                              "                         ********  \n" +
                              "  When one of these cases is true, the app will display the next \n" +
                              "  available flight to the destination.");
            Console.WriteLine("--------------------------------------------------------------------- \n");
        }

        // Prints out the prompt for first class or economy
        private void TicketPrompt()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("   Please enter [1] for First Class or [2] for Economy.\n" +
                              "   Enter [4] to finish seating and exit the application.");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("   Selection: ");
        }

        // Prints out prompt if First Class is full
        private void FirstClassFullPrompt()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine(" The First Class section is full. Is Economy acceptable?\n" +
                              "              Enter [1] for YES or [2] for NO");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("   Selection: ");
        }

        // Prints our prompt if Economy is full
        private void EconomyFullPrompt()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine(" The Economy section is full. Is First Class acceptable?\n" +
                              "              Enter [1] for YES or [2] for NO");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("   Selection: ");
        }

        // Prints out message for next flight
        private void NextFlight()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("         The next flight leaves in 3 hours.");
            Console.WriteLine("----------------------------------------------------------");
        }

        // Prints out message for a full flight
        private void FullFlight()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("         All seats on this flight have been taken.      \n" +
                              "           The next flight leaves in 3 hours.");
            Console.WriteLine("----------------------------------------------------------");
        }

        /************ END of PROMPT printing methods ************/

        /************ Input VALIDATION methods ************/

        // Returns key entered as char
        private char UserInput()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            return input.KeyChar;
        }

        // Combines seat prompt and validation
        private char PromptWithValidation()
        {
            char input = UserInput();
            input = ReturnValidExit(input);
            return input;
        }

        // Ensures a valid input from user
        private char ReturnValid(char input)
        {
            bool valid = IsValid(input);
            while (!valid)
            {
                Console.Write("\nThat was not a valid input. Please try again: ");
                char newInput = UserInput();
                if (IsValid(newInput))
                {
                    return newInput;
                }
                else
                {
                    valid = false;
                }
            }
            return input;
        }

        // Helper method for ReturnValid
        private bool IsValid(char input)
        {
            if (input != '1' && input != '2')
            {
                return false;
            }
            return true;
        }

        // Ensures a valid input from user (includes 4 to exit)
        private char ReturnValidExit(char input)
        {
            bool valid = IsValidExit(input);
            while (!valid)
            {
                Console.Write("\nThat was not a valid input. Please try again: ");
                char newInput = UserInput();
                if (IsValidExit(newInput))
                {
                    return newInput;
                }
                else
                {
                    valid = false;
                }
            }
            return input;
        }

        // IsValid which includes 4 to exit application
        private bool IsValidExit(char input)
        {
            if (input != '1' && input != '2' && input != '4')
            {
                return false;
            }
            return true;
        }

        /************ END of input VALIDATION methods ************/

        /************ Seating ASSIGNMENT methods ************/

        // Checks if First class is full
        private bool IsEconomyFull(bool[] seating)
        {
            int count = 0;
            for (int i = 5; i < seating.Length; i++)
            {
                if (seating[i] == true)
                {
                    count++;
                }
            }
            if (count == 5)
            {
                return true;
            }
            else return false;
        }

        // Checks if Economy is full
        private bool IsFirstFull(bool[] seating)
        {
            int count = 0;
            for (int i = 0; i < seating.Length / 2; i++)
            {
                if (seating[i] == true)
                {
                    count++;
                }
            }
            if (count == 5)
            {
                return true;
            }
            else return false;
        }

        // Checks if plane is full
        private bool IsPlaneFull(bool first, bool economy)
        {
            if(first && economy)
            {
                return true;
            }
            return false;
        }

        // Assigns the first available economy seat
        private bool[] AssignEconomy(bool[] seating)
        {
            for (int i = 5; i < seating.Length; i++)
            {
                if (seating[i] == false)
                {
                    seating[i] = true;
                    break;
                }
            }
            return seating;
        }

        // Assigns the first available first class seat
        private bool[] AssignFirst(bool[] seating)
        {
            for (int i = 0; i < seating.Length / 2; i++)
            {
                if (seating[i] == false)
                {
                    seating[i] = true;
                    break;
                }
            }
            return seating;
        }

        /************ END of seating ASSIGNMENT methods ************/

    }
}
