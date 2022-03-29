///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-01-26 - L5life - This portion of the L5life program creates the methods which are called in the driver class
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
    internal class Game
    {
        private char[,] gameBoard;
        private char[,] buffBoard;

        // char contstants for the alive, dead, and empty WS chars
        public const char LIVE = '@';
        public const char DEAD = '-';
        public const char SPACE = ' ';

        public readonly int ROW_SIZE = 50;
        public readonly int COL_SIZE = 80;

        // User prompt with description
        public static void GamePrompt()
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("   Welcome to the game of life. This is a simulation of the \n" +
                                " computational phenomenonminvented by British mathematcian \n" +
                                "John Conway. This program follows the standard game of B3/S23. \n" +
                                "       PRESS C TO BEGIN THE SIMULATION");
            Console.WriteLine("****************************************************************");
        }
        public Game()
        {
            //initialize major object here
            gameBoard = new char[ROW_SIZE, COL_SIZE];
            buffBoard = new char[ROW_SIZE, COL_SIZE];

            // initialize the game boards
            InitializeGameBoards();

            // insert the startup pattern or arrangement
            InsertStartupPatterns(24, 20);
        }

        private void DisplayCurrentGameBoard(int gen)
        {
            Console.WriteLine($"Displaying generation #{gen}");
            for (int r = 0; r < ROW_SIZE; r++)
            {
                for (int c = 0; c < COL_SIZE; c++)
                {
                    Console.Write($"{SPACE}{gameBoard[r, c]}");
                }
                Console.WriteLine();
            }
        }

        private void InsertStartupPatterns(int r, int c)
        {
            // after 1 DEAD cell to start
            // insert 8 LIVE cells
            gameBoard[r, c + 1] = LIVE;
            gameBoard[r, c + 2] = LIVE;
            gameBoard[r, c + 3] = LIVE;
            gameBoard[r, c + 4] = LIVE;
            gameBoard[r, c + 5] = LIVE;
            gameBoard[r, c + 6] = LIVE;
            gameBoard[r, c + 7] = LIVE;
            gameBoard[r, c + 8] = LIVE;
            // leave 1 DEAD
            // insert 5 LIVE
            gameBoard[r, c + 10] = LIVE;
            gameBoard[r, c + 11] = LIVE;
            gameBoard[r, c + 12] = LIVE;
            gameBoard[r, c + 13] = LIVE;
            gameBoard[r, c + 14] = LIVE;
            // leave 3 DEAD
            // inserty 3 LIVE
            gameBoard[r, c + 18] = LIVE;
            gameBoard[r, c + 19] = LIVE;
            gameBoard[r, c + 20] = LIVE;
            // after 6 DEAD cell to start
            // insert 7 LIVE cells
            gameBoard[r, c + 27] = LIVE;
            gameBoard[r, c + 28] = LIVE;
            gameBoard[r, c + 29] = LIVE;
            gameBoard[r, c + 30] = LIVE;
            gameBoard[r, c + 31] = LIVE;
            gameBoard[r, c + 32] = LIVE;
            gameBoard[r, c + 33] = LIVE;
            // after 1 DEAD cell to start
            // inserty 5 LIVE cells
            gameBoard[r, c + 35] = LIVE;
            gameBoard[r, c + 36] = LIVE;
            gameBoard[r, c + 37] = LIVE;
            gameBoard[r, c + 38] = LIVE;
            gameBoard[r, c + 39] = LIVE;
        }

        private void InitializeGameBoards()
        {
            for (int r = 0; r < ROW_SIZE; r++)
            {
                for (int c = 0; c < COL_SIZE; c++)
                {
                    gameBoard[r, c] = DEAD;
                    buffBoard[r, c] = DEAD;
                }
            }

        }

        internal void PlayTheGame()
        {
            Console.Write("ENTER the number of generations to display: ");
            int numGenerations = int.Parse(Console.ReadLine());

            for (int generation = 1; generation <= numGenerations; generation++)
            {
                // display the game board
                DisplayCurrentGameBoard(generation);

                // process the gae board - prepare the next generation
                ProcessGameBoard();

                // swap the two boards
                SwapTheGameBoards();
            }

        }

        private void SwapTheGameBoards()
        {
            char[,] tmp = gameBoard;
            gameBoard = buffBoard;
            buffBoard = tmp;
        }

        private void ProcessGameBoard()
        {
            // Iterate through the entire 2 dimensional array
            for (int r = 0; r < ROW_SIZE; r++)
            {
                for (int c = 0; c < COL_SIZE; c++)
                {
                    // (Calculate which state to store in the results board)
                    buffBoard[r, c] = DetermineLifeOrDeath(r, c);
                    // Right click and generate suggested method to develop one listed below this
                }
            }
        }

        private char DetermineLifeOrDeath(int r, int c)
        {
            int count = GetNeighborCount(r, c);

            //////////////////// Better way of doing things /////////////////////////////// 
            if (count == 2) return gameBoard[r, c];
            else if (count == 3) return LIVE;
            else return DEAD;
        }

        private int GetNeighborCount(int r, int c)
        {
            int neighborCount = 0;

            if (r == 0 && c ==0)
            {
                // TOP LEFT corner
                if (gameBoard[r, c+1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c] == LIVE) neighborCount++;
                if (gameBoard[r+1, c+1] == LIVE) neighborCount++;
            }
            else if (r == 0 && c == COL_SIZE - 1)
            {
                // TOP RIGHT corner
                if (gameBoard[r, c-1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c] == LIVE) neighborCount++;
            }
            else if (r == ROW_SIZE - 1 && c == 0)
            {
                // BOTTOM LEFT corner
                if (gameBoard[r-1, c] == LIVE) neighborCount++;
                if (gameBoard[r-1, c+1] == LIVE) neighborCount++;
                if (gameBoard[r, c+1] == LIVE) neighborCount++;
            }
            else if (r == ROW_SIZE - 1 && c == COL_SIZE - 1)
            {
                // BOTTOM RIGHT corner
                if (gameBoard[r-1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r-1, c] == LIVE) neighborCount++;
                if (gameBoard[r, c-1] == LIVE) neighborCount++;
            }
            else if (r == 0)
            {
                // TOP EDGE (not corner)
                if (gameBoard[r, c-1] == LIVE) neighborCount++;
                if (gameBoard[r, c+1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c] == LIVE) neighborCount++;
                if (gameBoard[r+1, c+1] == LIVE) neighborCount++;

            }
            else if (c == COL_SIZE - 1)
            {
                // RIGHT EDGE (not corner)
                if (gameBoard[r-1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r-1, c] == LIVE) neighborCount++;
                if (gameBoard[r, c-1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c] == LIVE) neighborCount++;
            }
            else if (c == 0)
            {
                // BOTTOM EDGE (not corner)
                if (gameBoard[r-1, c] == LIVE) neighborCount++;
                if (gameBoard[r-1, c+1] == LIVE) neighborCount++;
                if (gameBoard[r, c+1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c] == LIVE) neighborCount++;
                if (gameBoard[r+1, c+1] == LIVE) neighborCount++;
            }
            else if (r == ROW_SIZE - 1)
            {
                // LEFT EDGE (not corner)
                if (gameBoard[r-1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r-1, c] == LIVE) neighborCount++;
                if (gameBoard[r-1, c+1] == LIVE) neighborCount++;
                if (gameBoard[r, c-1] == LIVE) neighborCount++;
                if (gameBoard[r, c+1] == LIVE) neighborCount++;
            }
            else
            {
                // nominal case
                if (gameBoard[r-1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r-1, c] == LIVE) neighborCount++;
                if (gameBoard[r-1, c+1] == LIVE) neighborCount++;
                if (gameBoard[r, c-1] == LIVE) neighborCount++;
                // r,c
                if (gameBoard[r, c+1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c-1] == LIVE) neighborCount++;
                if (gameBoard[r+1, c] == LIVE) neighborCount++;
                if (gameBoard[r+1, c+1] == LIVE) neighborCount++;
            }
            return neighborCount;
        }
    }
}
