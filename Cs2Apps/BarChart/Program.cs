///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-02 - Cs2 - Program 2 (Bar Chart): This program accepts three integer
// values and displays a corresponding number of asterisks for each number input.
// For example: A user enters 1 2 3 and the following would be output:
// NUMBER (1): *
// NUMBER (2): **
// NUMBER (3): ***
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-08 - Jared Howard - File started in linux. Prompts and some iteration methods implemented.
// 2022-02-10 - Jared Howard - File recreated.
// 2022-02-10 - Jared Howard - Project tested, ouput recorded, final comments added, built and completed.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shows beginning prompt
            BeginPrompt();
            // User opts to begin
            string appStart = Console.ReadLine();
            if (NumberPrompt(appStart))
            {
                // ArrBuilder is called to populate array with user inputs   
                int[] inputArray = ArrBuilder();
                // Final display of numbers with asterisks
                InputPrinter(inputArray);
            }
            else Console.WriteLine("The application was not initialized!");
        }
        // Displays beginning prompt for user
        static void BeginPrompt()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("   Welcome to the Bar Chart app. This accepts three integer \n " +
                              "  inputs between 0 and 30 and prints out a corresponding number \n " +
                              "  of adjacent asterisks for each number input.For example, \n" +
                              "          entering 15 20 25 will result in an output of: \n " +
                              "            NUMBER 1(15): *************** \n" +
                              "             NUMBER 2(20): ******************** \n" +
                              "             NUMBER 3(25): ************************* ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("--------------------- ENTER C TO BEGIN -------------------------");
        }
        // Checks if user opted to continue and displays beginning prompt
        static bool NumberPrompt(string start)
        {
            if (start == "C" || start == "c")
            {
                Console.WriteLine("Please enter three whole numbers between 0 and 30.");
                return true;
            }
            else
            {
                return false;
            }
        }
        // Prints each number and the corresponding number of asterisks
        static void InputPrinter(int[] arr)
        {
            Console.WriteLine("Your numbers: ");
            foreach (int number in arr)
            {
                Console.WriteLine($"NUMBER ({number}): {BarPrinter(number)}");
                ;
            }
        }
        // Builds an array of values with the user inputs. Includes prompts and call InputChecker method
        static int[] ArrBuilder()
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            num1 = InputChecker(num1);
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            num2 = InputChecker(num2);
            Console.WriteLine("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());
            num3 = InputChecker(num3);
            int[] outputArr = new int[3] { num1, num2, num3 };
            return outputArr;
        }
        // Makes sure the user is entering correct inputs and repeats until proper input received
        static int InputChecker(int input)
        {
            while (input < 0 || input > 30)
            {
                Console.WriteLine("The value you entered is not between 0 and 30. Please try again.");
                input = int.Parse(Console.ReadLine());
                InputChecker(input);
            }
            return input;
        }
        // Prints a number of asterisks equal to the input
        static string BarPrinter(int num)
        {
            string ast = null;
            while (num > 0)
            {
                ast += "*";
                num--;
            }
            return ast;
        }
    }
}
