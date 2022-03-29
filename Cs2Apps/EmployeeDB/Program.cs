///////////////////////////////////////////////////////////////////////////
// TINFO 200 B, Winter 2022
// UWTacoma SET, Jared Howard
// 2022-02-02 - Cs2 - Program 1 (Employee Class): This program creates three employee objects
// with first and last names and a monthly Salary. Their yearly salaries are displayed before
// and after a 10% raise.
///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-02-02 - Jared Howard - File started. Constructor, setters and getters created including main method. Untested.
// 2022-02-10 - Jared Howard - File recreated. Adjustments made to methods and method calls. Tested in console window
// and output is correct. 
// 2022-02-10 - Jared Howard - Project tested, ouput recorded, built and completed.
// 2022-02-12 - Jared Howard - Fixed some things that were left out. EmployeeDB rebuilt and output remade.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
    internal class Program
    {
        // Converts monthly Salary to annual
        static decimal AnnualSalary(decimal monthly)
        {
            decimal annual = monthly * (decimal)12;
            return annual;
        }
        static void Main(string[] args)
        {
            // Creates 3 employee objects
            Employee employee1 = new Employee("Sean", "Cody", 4100);
            Employee employee2 = new Employee("Gus", "Kenworthy", 5000);
            Employee employee3 = new Employee("Rob", "Kearney", -1);
            // Creating strings for display messages
            string emp1fullName = employee1.FirstName + " " + employee1.LastName;
            string emp2fullName = employee2.FirstName + " " + employee2.LastName;
            string emp3fullName = employee3.FirstName + " " + employee3.LastName;
            // Displaying yearly salaries before raise
            Console.WriteLine($"The yearly Salary for {emp1fullName} is ${ AnnualSalary(employee1.Salary) }");
            Console.WriteLine($"The yearly Salary for {emp2fullName} is ${ AnnualSalary(employee2.Salary) }");
            Console.WriteLine($"The yearly Salary for {emp3fullName} is ${ AnnualSalary(employee3.Salary) }");
            // Giving employees a 10% raise
            employee1.Salary = (employee1.Salary * (decimal)1.1);
            employee2.Salary = (employee2.Salary * (decimal)1.1);
            employee3.Salary = (employee3.Salary * (decimal)1.1);
            // Displaying yearly salaries after raise
            Console.WriteLine($"The yearly Salary for {emp1fullName} after a 10% raise is ${ AnnualSalary(employee1.Salary) }");
            Console.WriteLine($"The yearly Salary for {emp2fullName} after a 10% raise is ${ AnnualSalary(employee2.Salary) }");
            Console.WriteLine($"The yearly Salary for {emp3fullName} after a 10% raise is ${ AnnualSalary(employee3.Salary) }");
        }
        class Employee
        {
            // First name - Last name - Salary
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public decimal Salary { get; set; }

            // Constructor method for employee
            public Employee(string first, string last, decimal input)
            {
                FirstName = first;
                LastName = last;
                if (input > 0)
                {
                    Salary = (decimal)input;
                }
                else
                {
                    Salary = 0;
                }
                
            }
        }
    }
}
