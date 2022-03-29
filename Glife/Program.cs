///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-01-26 - L5life - This is the driver class
// L5life: A program that simulates the computational phenomenon invented by British mathematician
// John Conway to show possibilities of population simulations in a mathematically controlled environment.
//
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-01-26 - Jared Howard - Coding started during class on Linux
// 2022-02-02 - Jared Howard - Adjustments made to GetNeighborCount, GamePrompt created
// 2022-02-05 - Jared Howard - Game tested and builds created. COMPLETED
//
// From Charles Costarella, T INFO 200 Section B, Lectures: t200B-Wi22-01-24-class-meeting and t200B-Wi22-01-26-class-meeting
// CREDITS: This program was created under the instruction of Charles Costarella, and all credit goes to him.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.GamePrompt();
            string userInput = Console.ReadLine();
            if (userInput == "C" || userInput == "c")
            {
                // want to be able to create a game obj and call the ctor
                // to kick off the simulation
                Game game = new Game();
                game.PlayTheGame();
            }
            else
            {
                Console.WriteLine("The simulation has ended.");
            }
        }
    }
}
