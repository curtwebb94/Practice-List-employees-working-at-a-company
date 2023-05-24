using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        // Some readonly properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // List to hold current employees
        private List<Employee> employees;

        // Constructor
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            employees = new List<Employee>(); // Initialize the list of employees
        }

        // Method to add an employee to the company
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // Method to list employees
        public void ListEmployees()
        {
            Console.WriteLine("The Employees for " + Name + "!");
            Console.WriteLine("............................................");
            Console.WriteLine();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}");
            }
        }
    }
}
