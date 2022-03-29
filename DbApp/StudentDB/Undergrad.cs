///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-16 - L6oop - Undergrad is a child class of student which has two
// new properties: Rank and DegreeMajor
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-16 - Jared Howard - File created in class. Properties, contructor,
// ToString() added.
// 2022-02-23 - Jared Howard - Constructor edited to include ContactInfo
// 2022-03-04 - Jared Howard - Spacing and comments touched up
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
    // Enumerated type for C# that represents the year/class in school
    public enum YearRank
    {
        Freshman = 1,
        Sophmore = 2,
        Junior = 3,
        Senior = 4
    }

    internal class Undergrad : Student
    {
        // Concept of the year in school
        public YearRank Rank { get; set; }

        // The undergraduate major - string
        public string DegreeMajor { get; set; }

        // This is the fully specified constructor
        public Undergrad(string first, string last, double gpa, string email, DateTime enrolled, YearRank year, string major)
            : base(new ContactInfo(first, last, email), gpa, enrolled)
        {
            Rank = year;
            DegreeMajor = major;
        }

        // This is the default constructor
        public Undergrad()
        {

        }

        // Expression-bodied method overriding the to string in student - uses a lambda op
        public override string ToString() => base.ToString() + $"      Year: {Rank}\n     Major: {DegreeMajor}";

        // Creates student info string to be printed on output file
        public override string ToStringForOutputFile()
        {
            // 1 - Create a buffer to hold the built up info for printing
            string str = this.GetType() + "\n";
            
            // 2 - Build up the buffer with the object(s) data
            str += base.ToStringForOutputFile();
            str += $"{Rank}\n";
            str += $"{DegreeMajor}";

            // 3 - Return the buffer as a string
            return str;
        }
    }
}
