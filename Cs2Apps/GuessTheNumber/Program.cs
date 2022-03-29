///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-08 - Cs2 - Program 3 (GuessTheNumber): This program generates a random number between 
// 0 and 1000, and prompts the user to guess what the number is. The user will know whether
// their guess is too high or too low if they guess incorrectly and when they have guessed the
// correct number. Once they correctly guess the number, a user can opt to play again.
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-08 - Jared Howard - File started in linux. Prompts and structure developed. Untested.
// 2022-02-10 - Jared Howard - File recreated. Program tested in console window and everything
// checks out. No ouput file yet.
// 2022-02-10 - Jared Howard - Project tested, ouput recorded, final comments added, built and completed.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeginPrompt();
            string start = Console.ReadLine();
            if (start == "c" || start == "C")
            {
                PlayGame();
            }
        }
        // Displays beginning prompt for the user
        static void BeginPrompt()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(" Welcome to the Guess the Number app. This program will generate \n" +
                              " a random number between 0 and 1000.Your goal is to try and guess \n" +
                              " what that number is !When you make an incorrect guess, the program \n" +
                              " will display either 'Too high. Try again.' or 'Too low. Try again.' \n" +
                              " and will prompt you to guess again. When you guess the number \n" +
                              "             correctly you can opt to play again!");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("------------------------ ENTER C TO BEGIN ---------------------------");
        }
        // Runs the repetitive mechanics of the game
        static void PlayGame()
        {
            // Random number generated
            Random random = new Random();
            int answer = random.Next(1000);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("         A number has been generated. Make a guess!");
            Console.WriteLine("---------------------------------------------------------------------");
            //Console.WriteLine($"Will remove after testing: {answer}");
            bool playing = true;
            int userGuess = int.Parse(Console.ReadLine());
            // Calls playing method, repeats until 'playing' is switched to false with correct answer
            while (Playing(answer, userGuess))
            {
                userGuess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Congratulations. You guessed the number!");
            Console.WriteLine();
            PlayAgainPrompt();
            // Option to play again
            string continueOrExit = Console.ReadLine();
            if (continueOrExit == "p" || continueOrExit == "P")
            {
                PlayGame();
            }
            if (continueOrExit == "x" || continueOrExit == "X")
            {

            }
        }
        // Displays whether too high or too low. Contains switch for while loop located on line 61
        static bool Playing(int answer, int guess)
        {
            if (answer == guess)
            {
                return false;
            }
            else if (answer < guess)
            {
                Console.WriteLine("Too high. Try again.");
                Console.WriteLine("Guess again: ");
                return true;
            }
            else
            {
                Console.WriteLine("Too low. Try again.");
                Console.WriteLine("Guess again: ");
                return true;
            }
        }
        // Asks the user whether they want to play again
        static void PlayAgainPrompt()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("----------     ENTER P TO PLAY AGAIN OR X TO EXIT          ----------");
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
