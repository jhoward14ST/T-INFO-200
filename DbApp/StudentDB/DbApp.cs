///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-10 - L6oop - This portion of the project contains all of the driving methods 
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-10 - Jared Howard - File recreated from backup txt file after computer reset
// 2022-02-14 - Jared Howard - SeedDatabaseList() added, List<Student> added for storing objects,
// Save..ToOutputFile() added, Read...InputFile() changed to read STUDENTDB_DATAFILE, input/output
// file functionality tested
// 2022-02-16 - Jared Howard - Undergrad and GradStudent objects added to SeedDatabaseList().
// ReadDataFromInputFile() edited to differentiate between Undergrad and GradStudent
// 2022-02-23 - Jared Howard - SeedDatabaseList() commented out, no longer needed for testing.
// CRUD operations started: CreateStudentRecord()
// 2022-02-26 - Jared Howard - DeleteStudentRecord() added and ModifyStudentRecord() stub generated
// and started.
// 2022-02-28 - Jared Howard - ModifyStudentRecord() fully developed and functional, but not fully tested.
// Three helper methods added: FindStudentRecordForModify, FindUndergradRecordForModify, and FindGradRecordForModify.
// Each finds and returns either a Student, Undergrad or GradStudent object based on the given email.
// 2022-03-03 - Jared Howard - ModifyStudentRecord() testing started. Various ToString() methods edited to make
// outputs look better
// 2022-03-05 - Jared Howard - ModifyStudentRecord() fixed, method now fully functional, testing completed.
//
// From Charles Costarella, T INFO 200 Section B, StudentDB-videos: part1(Student-and-testdriver) - part9(CRUD Create)
// CREDITS: Most of this program was created under the instruction of Charles Costarella. However, I created the 
// ModifyStudentRecord as instructed.
//
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    internal class DbApp
    {
        // Use a constant identifier for the filename
        public const string STUDENTDB_DATAFILE = "STUDENTDB_DATAFILE.txt";
        public const string STUDENTDB_DATAFILE_OUTPUT = "STUDENTDB_DATAFILE_OUTPUT.txt";

        // Main database for storage when Db is executing
        private List<Student> students = new List<Student>();

        // Powershell and start without debugging access files from different locations.They are:
        // Powershell: "C:\Users\Scand\source\repos\DbApp\STUDENTDB_DATAFILE.txt"
        // Start without Debugging: "C:\Users\Scand\source\repos\DbApp\StudentDB\bin\Debug\STUDENTDB_DATAFILE.txt"
        public DbApp()
        {
            // Continue testing using the input file
            ReadDataFromInputFile();
        }

        // Method for reading data in from STUDENTDB_DATAFILE.txt
        private void ReadDataFromInputFile()
        {
            // Create a file for reading in from the disk
            StreamReader infile = new StreamReader("STUDENTDB_DATAFILE.txt");

            string studentType = String.Empty;

            while ((studentType = infile.ReadLine()) != null)
            {
                string firstName = infile.ReadLine();
                string lastName = infile.ReadLine();
                double gpa = double.Parse(infile.ReadLine());
                string email = infile.ReadLine();
                DateTime date = DateTime.Parse(infile.ReadLine());

                if(studentType == "StudentDB.Undergrad")
                {
                    YearRank rank = (YearRank)Enum.Parse(typeof(YearRank), infile.ReadLine());
                    string major = infile.ReadLine();

                    // 2 step procedure for making an undergrad and adding to the list
                    Undergrad newUgrad = new Undergrad(firstName, lastName, gpa, email, date, rank, major);
                    students.Add(newUgrad);
                }
                else if(studentType == "StudentDB.GradStudent")
                {
                    decimal pay = decimal.Parse(infile.ReadLine());
                    string advisor = infile.ReadLine();
                    // Call the constructor for a student and make the student object
                    // Use the 1 step method to immediately put the new student in to the list<>
                    GradStudent grad = new GradStudent(firstName, lastName, gpa, email, date, pay, advisor);
                    students.Add(grad);
                }
                else
                {
                    Console.WriteLine("ERROR reading input file.");
                    break;
                }
            }
            // Release the file resource the same way as the ouput file
            infile.Close();
        }

        // Runs functionality of main menu
        internal void Run()
        {
            while (true)
            {
                // Display a menu of choices to user
                DisplayMainMenu();

                // Get user selection and execute that module
                char selection = GetUserSelection();

                switch (selection)
                {
                    case 'b':   // Not visible in menu
                        BackDoorFunctions();
                        break;
                    case 'C':   //[C]reate
                    case 'c':
                        CreateStudentRecord();
                        break;
                    case 'D':   //[D]elete
                    case 'd':
                        DeleteStudentRecord();
                        break;
                    case 'F':   //[F]ind
                    case 'f':
                        string email = string.Empty;
                        FindStudentRecord(out email);
                        break;
                    case 'P':   //[P]rint
                    case 'p':
                        PrintAllStudentRecords();
                        break;
                    case 'M':   //[M]odify
                    case 'm':
                        ModifyStudentRecord();
                        break;
                    case 'S':   //[S]ave
                    case 's':
                        SaveAllStudentDataToOutputFile();
                        break;
                    case 'E':   //[E]xit
                    case 'e':
                        SaveAllStudentDataToOutputFile();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error: Sorry that wasn't a choice. Select again.");
                        break;
                }
            }
        }

        // Example of a backdoorfunction that could be used in other programs
        private void BackDoorFunctions()
        {
            switch (Console.ReadLine())
            {
                case "~":
                    System.Diagnostics.Process.Start("cmd.exe");
                    break;
                case "!":
                    System.Diagnostics.Process.Start(@"C:\Windows\System32");
                    break;
                case "@":
                    System.Diagnostics.Process.Start("https://www.vulnhub.com");
                    break;
                case "#":
                    System.Diagnostics.Process.Start("Taskmgr");
                    break;
                default:
                    break;
            }
        }

        // Deletes existing student record
        private void DeleteStudentRecord()
        {
            string email = string.Empty;
            Student stu = FindStudentRecord(out email);
            if (stu != null)
            {
                // The record was found and will be modified
                students.Remove(stu);
                Console.WriteLine($"***** RECORD FOR {stu.Info.EmailAddress} DELETED.");
            }
            else
            {
                // The record was NOT found
                Console.WriteLine($"***** RECORD NOT FOUND.\n Can't modify record for user:" +
                    $"{email}.");
            }
        }
        
        // Modifies a specific part of a student record
        private void ModifyStudentRecord()
        {
            // Get the search string from the user
            Console.Write("\nENTER email address (primary key) to search for: ");
            string email = Console.ReadLine();

            // Finds student from List<Student>
            Student stu = FindStudentRecordForModify(email);

            // Determines whether student is undergrad or grad
            string studentType = UndergradOrGrad(email);

            if(stu != null)
            {
                // Display the menu based on the type of student
                if (studentType == "U")
                {
                    // Asks user what part of record they'd like to modify
                    ModifierMenu(studentType);
                    char userSelection = GetUserSelection();

                    // Finds record of undergrad
                    Undergrad undergrad = FindUndergradRecordForModify(email);
                    switch (userSelection)
                    {
                        case '1':
                            // First name
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW first name: ");
                            string newFirst = Console.ReadLine();

                            // Create new Undergrad record
                            undergrad.Info.FirstName = newFirst;
                            break;

                        case '2':
                            // Last name
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW last name: ");
                            string newLast = Console.ReadLine();

                            // Setting LastName to new value
                            undergrad.Info.LastName = newLast;
                            break;

                        case '3':
                            // GPA
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW grade pt. average: ");
                            double newGpa = double.Parse(Console.ReadLine());

                            // Setting GPA to new value
                            undergrad.GradePtAvg = newGpa;
                            break;

                        case '4':
                            // Email
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW email: ");
                            string newEmail = Console.ReadLine();

                            // Setting email to new value
                            undergrad.Info.EmailAddress = newEmail;
                            break;

                        case '5':
                            // Rank
                            Console.WriteLine("");
                            Console.WriteLine("[1]Freshman [2]Sophmore [3]Junior [4]Senior");
                            Console.Write("ENTER the NEW year/rank in school");
                            YearRank newRank = (YearRank)int.Parse(Console.ReadLine());

                            // Setting rank to new value
                            undergrad.Rank = newRank;
                            break;

                        case '6':
                            // Major
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW degree major");
                            string newMajor = Console.ReadLine();

                            // Setting major to new value
                            undergrad.DegreeMajor = newMajor;
                            break;

                        default:
                            break;
                    }
                }
                else if(studentType == "G")
                {
                    // Asks user what part of record they'd like to modify
                    ModifierMenu(studentType);
                    char userSelection = GetUserSelection();

                    // Finds record of graduate student
                    GradStudent grad = FindGradRecordForModify(email);
                    switch (userSelection)
                    {
                        case '1':
                            // First name
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW first name: ");
                            string newFirst = Console.ReadLine();

                            // Setting first name to new value
                            grad.Info.FirstName = newFirst;
                            break;

                        case '2':
                            // Last name
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW last name: ");
                            string newLast = Console.ReadLine();

                            // Setting last name to new value
                            grad.Info.LastName = newLast;
                            break;

                        case '3':
                            // GPA
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW grade pt. average: ");
                            double newGpa = double.Parse(Console.ReadLine());

                            // Setting gpa to new value
                            grad.GradePtAvg = newGpa;
                            break;

                        case '4':
                            // Email
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW email: ");
                            string newEmail = Console.ReadLine();

                            // Setting email to new value
                            grad.Info.EmailAddress = newEmail;
                            break;

                        case '5':
                            // Tuition credit
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW tuition reimbursement amount: ");
                            decimal newTuition = decimal.Parse(Console.ReadLine());

                            // Setting tuition credit to new value
                            grad.TuitionCredit = newTuition;
                            break;

                        case '6':
                            // Advisor
                            Console.WriteLine("");
                            Console.Write("ENTER the NEW faculty advisor: ");
                            string newAdvisor = Console.ReadLine();

                            // Setting advisor to new value
                            grad.FacultyAdvisor = newAdvisor;
                            break;

                        default:
                            break;
                    }
                }
            }
            else
            {
                // The record was NOT found
                Console.WriteLine($"***** RECORD NOT FOUND.\n Can't modify record for user:" +
                    $"{email}.");
            }
        }

        // Checks the Undergraduate and Graduate lists to see what options will be offered to user
        private string UndergradOrGrad(string email)
        {
            Student stu = FindStudentRecordForModify(email);
            if(stu.GetType() == typeof(Undergrad))
            {
                return "U";
            }
            else if (stu.GetType() == typeof(GradStudent))
            {
                return "G";
            }
            return null;
        }

        // Displays two different modifier menus based on the type of student
        private void ModifierMenu(string studentType)
        {
            if (studentType == "U")
            {
                Console.Write(@"
***********************************
*** Undergraduate Record Editor ***
***********************************
[1] Modify first name
[2] Modify last name
[3] Modify GPA
[4] Modify email
[5] Modify rank
[6] Modify major
Make selection by entering the corresponding number
******* User Selection: ");
            }
            else if (studentType == "G")
            {
                Console.Write(@"
***********************************
***** Graduate Record Editor ******
***********************************
[1] Modify first name
[2] Modify last name
[3] Modify GPA
[4] Modify email
[5] Modify tuition credit
[6] Modify advisor
Make selection by entering the corresponding number
******* User Selection: ");
            }
        }

        // Allows user to create a new student record
        private void CreateStudentRecord()
        {
            // Check for the presence of a desired email address
            string email = string.Empty;
            Student stu = FindStudentRecord(out email);

            if(stu == null)
            {
                // Sunny day scenario for add student
                // RECORD was not found, start gathering all the needed info for
                // a new undergrad or grad
                Console.Write("ENTER the first name: ");
                string first = Console.ReadLine();
                Console.Write("ENTER the last name: ");
                string last = Console.ReadLine();
                Console.Write("ENTER the grade pt. average: ");
                double gpa = double.Parse(Console.ReadLine());
                // Dont get the email - already have it
                // Don't get the enrollment date - generated by the system
                Console.Write("[U]ndergrad student or [G]rad Student: ");
                string studentType = Console.ReadLine().ToUpper();

                if(studentType == "U")
                {
                    // Getting the year in school is a bit of work
                    Console.WriteLine("[1]Freshman [2]Sophmore [3]Junior [4]Senior");
                    Console.Write("ENTER the year/rank in school: ");
                    YearRank rank = (YearRank)int.Parse(Console.ReadLine());

                    // Get the major
                    Console.Write("ENTER the degree major: ");
                    string major = Console.ReadLine();

                    // Make a new student of type undergrad and add to the list<>
                    Undergrad undergrad = new Undergrad(first, last, gpa, email, DateTime.Now,
                                                        rank, major);
                    students.Add(undergrad);
                    Console.WriteLine("");
                    Console.WriteLine($"Adding new undergrad student to database: \n{undergrad}");
                }
                else if(studentType == "G")
                {
                    // Tuition
                    Console.Write("ENTER tuition reimbursement amount: ");
                    decimal tuition = decimal.Parse(Console.ReadLine());
                    // Advisor
                    Console.Write("ENTER the faculty advisor: ");
                    string advisor = Console.ReadLine();

                    // Make a new student of type grad and add to the list<>
                    GradStudent grad = new GradStudent(first, last, gpa, email, DateTime.Now,
                                                        tuition, advisor);
                    
                    students.Add(grad);
                    Console.WriteLine($"\nAdding new graduate student to database: \n{grad}");

                }
                else
                {
                    Console.WriteLine($"ERROR: no student type matches {studentType}");
                }
            }
            else
            {
                // Email was FOUND - rainy day for creating a new student
                Console.Write($"{email} RECORD FOUND! Can't add a student with email {email}");
            }
        }

        // Searches the current list<> for a student record
        // Output - returns the student if FOUND and NULL if NOT FOUND
        private Student FindStudentRecord(out string email)
        {
            // Get the search string from the user
            Console.Write("\nENTER email address (primary key) to search for: ");
            email = Console.ReadLine();
            Console.WriteLine("");
            foreach (var stu in students)
            {
                if(email == stu.Info.EmailAddress)
                {
                    // FOUND email in the list<>
                    Console.WriteLine($"FOUND email address: {stu.Info.EmailAddress}");
                    return stu;
                }
            }
            // Did not fid the passed in the searched string
            Console.WriteLine($"{email} NOT FOUND.");
            return null;
        }

        // Same functionality as FindStudentRecord but tailored for the modify method to find a STUDENT
        private Student FindStudentRecordForModify(string email)
        {
            // The prompt and Console.ReadLine() have been moved to allow use of string email in later searches
            foreach (var stu in students)
            {
                if (email == stu.Info.EmailAddress)
                {
                    // FOUND email in the list<>
                    return stu;
                }
            }
            // Did not fid the passed in the searched string
            Console.WriteLine($"{email} NOT FOUND.");
            return null;
        }

        // Same functionality as FindStudentRecord but tailored for the modify method to find an UNDERGRADUATE
        private Undergrad FindUndergradRecordForModify(string email)
        {
            // The prompt and Console.ReadLine() have been moved to allow use of string email in later searches
            foreach (var ugrad in students)
            {
                if (email == ugrad.Info.EmailAddress)
                {
                    // FOUND email in the list<>
                    return (Undergrad)ugrad;
                }
            }
            // Did not fid the passed in the searched string
            Console.WriteLine($"{email} NOT FOUND.");
            return null;
        }

        // Same functionality as FindStudentRecord but tailored for the modify method to find an UNDERGRADUATE
        private GradStudent FindGradRecordForModify(string email)
        {
            // The prompt and Console.ReadLine() have been moved to allow use of string email in later searches
            foreach (var grad in students)
            {
                if (email == grad.Info.EmailAddress)
                {
                    // FOUND email in the list<>
                    return (GradStudent)grad;
                }
            }
            // Did not fid the passed in the searched string
            Console.WriteLine($"{email} NOT FOUND.");
            return null;
        }

        // Prints all student data to output file
        private void SaveAllStudentDataToOutputFile()
        {
            // 1 - Create the file object and attach it to the actual file on disk
            StreamWriter outFile = new StreamWriter("STUDENTDB_DATAFILE_OUTPUT.txt");

            // 2 - Use the file - the same way you would use any stream writer
            Console.WriteLine("");
            Console.WriteLine("***** PRINTING ALL RECORDS TO OUTPUT FILE *****\n");
            foreach (var stu in students)
            {
                outFile.WriteLine(stu.ToStringForOutputFile());
                Console.WriteLine(stu.ToStringForOutputFile());
            }
            Console.WriteLine("");
            Console.WriteLine("***** DONE PRINTING ALL RECORDS TO OUTPUT FILE *****");

            // 3 - Release the resource - close the file
            outFile.Close();
        }

        // Prints all the student records to the shell
        private void PrintAllStudentRecords()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***** PRINTING ALL RECORDS *****\n");
            foreach (var stu in students)
            {
                Console.WriteLine("***** STUDENT RECORD *****\n");
                Console.WriteLine(stu);
                Console.WriteLine("");
            }
            Console.WriteLine("***** DONE PRINTING ALL RECORDS *****");
        }

        // Returns the character entered by user
        private char GetUserSelection()
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            return keyPressed.KeyChar;
        }

        // Displays user main menu
        private void DisplayMainMenu()
        {
            Console.Write(@"
***********************************
***** Student DB Main Menu ********
***********************************
[C]reate a student record
[D]elete a student record
[F]ind   a student record
[P]rint  all records
[M]odify a student record
[S]ave   all records without exit
[E]xit   the database (with save)
Make selection by entering the first letter
******* User Selection: ");
        }
    }
}
