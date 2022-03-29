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
// 2022-02-08 - Jared Howard - File started in linux. Prompts and structure developed. Tested but has problems with exiting.
// 2022-02-10 - Jared Howard - File recreated. Environment.Exit(0) added to end if the user opts to quit. Works correctly in testing.
// 2022-02-10 - Jared Howard - Project tested, ouput recorded, final comments added, built and completed.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITeacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeginPrompt();
            int points = 0;
            PlayGame(points);
        }
        // Displays beginning prompt for the user
        static void BeginPrompt()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(" Welcome to the AI Teacher app. This program will ask you to solve \n" +
                              "  multiplication problems to help you learn! If you get it right, \n" +
                              " you will be asked another problem. If you get it wrong, you get to \n" +
                              " try again for the right answer.The more questions you get right \n" +
                              "                 the more points you earn. \n" +
                              "      Reaching 10 and 100 points earns you a banner!");
        }
        // Runs the game and number generation
        static void PlayGame(int points)
        {
            // Random numbers created
            Random random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            string answer = (num1 * num2).ToString();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"                How much is {num1} times {num2} ?");
            Console.WriteLine("                             PRESS X TO EXIT");
            Console.WriteLine("---------------------------------------------------------------------");
            string userInput = Console.ReadLine();
            bool playing = true;
            // If user enters x, program ends
            if (userInput == "X" || userInput == "x")
            {
                playing = false;
                Environment.Exit(0);
            }
            else
            {
                string numInput = userInput;
                while (playing)
                {
                    Playing(answer, numInput, points);
                    numInput = Console.ReadLine();
                }
            }
        }
        // Runs repetitive fuctions of the game and tracks points
        static void Playing(string answer, string input, int points)
        {
            if (input == "X" || input == "x")
            {
                Environment.Exit(0);
            }
            if (answer == input)
            {
                Console.WriteLine("Very good!");
                points++;
                Console.WriteLine($"You now have {points} points!");
                // Prints banner when the user reaches 10 and 100 points
                BigMilestones(points);
                // Calls itself to repeat when correct answer is given
                PlayGame(points);
            }
            else
            {
                Console.WriteLine("No. Please try again.");
            }
        }
        // Displays banner when the user reaches 10 and 100 points
        static void BigMilestones(int points)
        {
            if (points == 10)
            {
                Console.WriteLine("            *****          ********     ");
                Console.WriteLine("           *** ***        ***    ***    ");
                Console.WriteLine("          ***  ****      ****    ****   ");
                Console.WriteLine("         ***   ****      ****    ****   ");
                Console.WriteLine("               ****      ****    ****   ");
                Console.WriteLine("               ****      ****    ****   ");
                Console.WriteLine("               ****      ****    ****   ");
                Console.WriteLine("               ****      ****    ****   ");
                Console.WriteLine("               ****      ****    ****   ");
                Console.WriteLine("               ****      ****    ****   ");
                Console.WriteLine("               ****      ****    ****   ");
                Console.WriteLine("           ************   ***    ***    ");
                Console.WriteLine("           ************    ********     ");
            }
            if (points == 100)
            {
                Console.WriteLine("            *****          ********       ********   ");
                Console.WriteLine("           *** ***        ***    ***     ***    ***  ");
                Console.WriteLine("          ***  ****      ****    ****   ****    **** ");
                Console.WriteLine("         ***   ****      ****    ****   ****    **** ");
                Console.WriteLine("               ****      ****    ****   ****    **** ");
                Console.WriteLine("               ****      ****    ****   ****    **** ");
                Console.WriteLine("               ****      ****    ****   ****    **** ");
                Console.WriteLine("               ****      ****    ****   ****    **** ");
                Console.WriteLine("               ****      ****    ****   ****    **** ");
                Console.WriteLine("               ****      ****    ****   ****    **** ");
                Console.WriteLine("               ****      ****    ****   ****    **** ");
                Console.WriteLine("           ************   ***    ***     ***    ***  ");
                Console.WriteLine("           ************    ********       ********   ");
            }
        }
    }
}
