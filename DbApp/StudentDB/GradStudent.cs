///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-16 - L6oop - GradStudent is a child class of Student which has two
// new properties: TuitionCredit and FacultyAdvisor
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-16 - Jared Howard - File created in class. Properties, contructor,
// ToString() added.
// 2022-02-23 - Jared Howard - Constructor and ToString() methods edited to include ContactInfo
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
    internal class GradStudent : Student
    {
        public decimal TuitionCredit { get; set; }
        public string FacultyAdvisor { get; set; }

        // This is the fully specified constructor
        public GradStudent(string first, string last, double gpa, string email, DateTime enrolled, decimal credit, string advisor)
            : base(new ContactInfo(first, last, email), gpa, enrolled)
        {
            TuitionCredit = credit;
            FacultyAdvisor = advisor;
        }

        // This is the default constructor
        public GradStudent()
        {

        }

        // Expression-bodied method overriding the to string in student - uses a lambda op
        public override string ToString() => base.ToString() + 
            $"    Credit: {TuitionCredit}\n   Advisor: {FacultyAdvisor}";

        // Creates student info string to be printed on output file
        public override string ToStringForOutputFile()
        {
            // 1 - Declare a buffer to build up info about this object
            string str = this.GetType() + "\n";
            // 2 - Build the string buffer
            str += base.ToStringForOutputFile();
            str += $"{TuitionCredit}\n";
            str += $"{FacultyAdvisor}";
            // 3 - Return the string
            return str;
        }
    }
}
