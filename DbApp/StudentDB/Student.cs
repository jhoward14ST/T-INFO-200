///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-10 - L6oop - Student is the parent class for the other two types in this
// program: Undergrad and GradStudent
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-10 - Jared Howard - File recreated from backup txt file after computer reset
// 2022-02-14 - Jared Howard - Validation for gradePtAvg and emailAddress added.
// 2022-02-23 - Jared Howard - ContactInfo added and new class generated
// 2022-03-04 - Jared Howard - Spacing and comments touched up
//
// From Charles Costarella, T INFO 200 Section B, StudentDB-videos: part1(Student-and-testdriver) - part9(CRUD Create)
// CREDITS: Most of this program was created under the instruction of Charles Costarella. However, I created the 
// ModifyStudentRecord as instructed.
//
using System;

namespace StudentDB
{
    internal class Student
    {
        // Auto implemented properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string emailAddress;

        public ContactInfo Info { get; set; }

        private double gradePtAvg;

        public DateTime EnrollmentDate { get; set; }

        // This is the fully specified constructor
        public Student(ContactInfo info, double grades, DateTime enrollment)
        {
            Info = info;
            GradePtAvg = grades;
            EnrollmentDate = enrollment;
        }

        // This is the default constructor
        public Student()
        {
        }

        // Gets and sets GPA if set input is a valid value - otherwise sets it to 0.7
        public double GradePtAvg
        {
            get 
            { 
                return gradePtAvg; 
            }
            set
            {
                if (0 <= value && value <=4)
                {
                    gradePtAvg = value;
                }
                else
                {
                    // Default the value to what is reportable to the registrar's office
                    gradePtAvg = 0.7;
                }
            }
        }

        // Getter and setter for student email with validation
        public string EmailAddress
        {
            get
            {
                // Not changing the get from the auto-implemented version
                return emailAddress;
            }
            set
            {
                // Email addresses must pass our simple tests to be assigned
                if(value.Contains("@") && value.Length > 3)
                {
                    emailAddress = value;
                }
                else
                {
                    emailAddress = "ERROR: Invalid email address.";
                }
            }
        }

        // ToString method with only basic data
        public virtual string ToStringForOutputFile()
        {
            // Creating string to hold data
            string str = string.Empty;

            // Populating the string with properties and data
            str += $"{Info.FirstName}\n";
            str += $"{Info.LastName}\n";
            str += $"{GradePtAvg:F1}\n";
            str += $"{Info.EmailAddress}\n";
            str += $"{EnrollmentDate}\n";

            // Returning string now containing data and properties
            return str;
        }

        // ToString method with data and descriptions
        public override string ToString()
        {
            // Creating string to hold data
            string str = string.Empty;

            // Populating the string with properties and data
            str += $"First name: {Info.FirstName}\n";
            str += $" Last name: {Info.LastName}\n";
            str += $" Grade Avg: {GradePtAvg:F1}\n";
            str += $"     Email: {Info.EmailAddress}\n";
            str += $"  Enrolled: {EnrollmentDate}\n";

            // Returning string now containing data and properties
            return str;
        }
    }
}