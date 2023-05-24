# Practice-List-employees-working-at-a-company

# Employee Management System

This is a simple Employee Management System implemented in C#. It allows you to create a company, add employees to the company, and generate a report displaying the employee names and titles.

## Getting Started

To get started with the Employee Management System, follow these steps:

1. Clone the repository or download the source code files.

2. Open the solution in your preferred C# IDE (Integrated Development Environment).

3. Build the solution to compile the code.

4. Run the program and observe the output in the console.

## Usage

The program consists of three main classes:

1. `Company`: Represents a company and manages a list of employees. It has methods to add employees and list all employees.

2. `Employee`: Represents an employee with properties such as first name, last name, title, and start date.

3. `Program`: Contains the `Main` method where you can create a company, create employees, assign employees to the company, and display a report of the employees.

To use the Employee Management System, you can modify the `Main` method in the `Program` class. Here's an example of how to use the system:

```csharp
static void Main(string[] args)
{
    // Create an instance of a company
    Company company = new Company("Acme, Inc.", DateTime.Now);

    // Create employee objects
    Employee employee1 = new Employee("John", "Doe", "Manager", new DateTime(2015, 3, 23));
    Employee employee2 = new Employee("Jane", "Smith", "Developer", new DateTime(2017, 6, 10));
    
    // Add employees to the company
    company.AddEmployee(employee1);
    company.AddEmployee(employee2);

    // Display the list of employees
    company.ListEmployees();
}

