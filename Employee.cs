using System;

namespace Classes
{
    public class Employee
    {
        // Properties .... grabs the employees properties from the Program.cs module
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        // Constructor.... By following the order of the constructor parameters, the code ensures that the correct values are assigned to the corresponding properties of the Employee class.
        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = startDate;
        }
    }
}
