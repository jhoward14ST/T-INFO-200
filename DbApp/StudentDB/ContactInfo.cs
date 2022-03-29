///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-23 - L6oop - ContactInfo consolidates some student information into
// one object which is then constructed and called at varios points in the program.
// 
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-23 - Jared Howard - File created in class, generated from class Student.
// Properties, constructors, validation, and ToString methods added
//
// From Charles Costarella, T INFO 200 Section B, StudentDB-videos: part1(Student-and-testdriver) - part9(CRUD Create)
// CREDITS: Most of this program was created under the instruction of Charles Costarella. However, I created the 
// ModifyStudentRecord as instructed.
//
namespace StudentDB
{
    public class ContactInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string emailAddress { get; set; }

        // This is the fully specified constructor
        public ContactInfo(string first, string last, string email)
        {
            FirstName = first;
            LastName = last;
            EmailAddress = email;
        }

        // Getters and setters with some validation
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
                if (value.Contains("@") && value.Length > 3)
                {
                    emailAddress = value;
                }
                else
                {
                    emailAddress = "ERROR: Invalid email address.";
                }
            }
        }

        // Lamba expression-bodied method for utility printing out a contact info obj
        public override string ToString() => $"{FirstName} {LastName}\n{EmailAddress}\n";

        // Same as ToString but with legal formatting
        public string ToStringLegal() => $"{LastName}, {FirstName}, {EmailAddress}\n";
    }
}