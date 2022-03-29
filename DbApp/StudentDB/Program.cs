///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-10 - L6oop - This is the driver class of the project
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-10 - Jared Howard - File recreated from backup txt file after computer reset
// 2022-02-14 - Jared Howard - Student constructors, Console.WriteLine and ToStringForOutputFile() tests added
// 2022-02-23 - Jared Howard - TestMain1() removed, no longer needed
// 2022-03-05 - Jared Howard - Powershell and start without debugging access files from different locations. They are:
// Powershell: "C:\Users\Scand\source\repos\DbApp\STUDENTDB_DATAFILE.txt"
// Start without Debugging: "C:\Users\Scand\source\repos\DbApp\StudentDB\bin\Debug\STUDENTDB_DATAFILE.txt"
//
// From Charles Costarella, T INFO 200 Section B, StudentDB-videos: part1(Student-and-testdriver) - part9(CRUD Create)
// CREDITS: Most of this program was created under the instruction of Charles Costarella. However, I created the 
// ModifyStudentRecord as instructed.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    // This is the driving program of our project
    internal class Program
    {
        // This is the driving method of our project
        // Powershell and start without debugging access files from different locations.They are:
        // Powershell: "C:\Users\Scand\source\repos\DbApp\STUDENTDB_DATAFILE.txt"
        // Start without Debugging: "C:\Users\Scand\source\repos\DbApp\StudentDB\bin\Debug\STUDENTDB_DATAFILE.txt"
        static void Main(string[] args)
        {
            // Create the application object
            DbApp database = new DbApp();

            // Execute the application main run
            database.Run();
        }
    }
}
