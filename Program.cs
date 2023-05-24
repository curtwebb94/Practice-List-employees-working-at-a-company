using System;

// //namespace
// To use a class defined in a different file or module, 
// you need to make sure that both files are part of the same namespace or 
// that the necessary using directives are in place.


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Acme, Inc.", DateTime.Now);

            // Create three employees
            Employee employee1 = new Employee("John", "Doe", "Manager", new DateTime(2015, 3, 23));
            Employee employee2 = new Employee("Jane", "Smith", "Developer", new DateTime(2017, 6, 10));
            Employee employee3 = new Employee("Mike", "Johnson", "Designer", new DateTime(2019, 2, 15));
            Employee employee4 = new Employee("Sarah", "Davis", "Accountant", new DateTime(2020, 9, 1));
            Employee employee5 = new Employee("David", "Wilson", "Sales Representative", new DateTime(2018, 5, 12));
            Employee employee6 = new Employee("Emily", "Brown", "Marketing Specialist", new DateTime(2019, 7, 8));
            Employee employee7 = new Employee("Daniel", "Miller", "Software Engineer", new DateTime(2016, 10, 15));
            Employee employee8 = new Employee("Olivia", "Wilson", "Financial Analyst", new DateTime(2020, 4, 3));
            Employee employee9 = new Employee("William", "Taylor", "Human Resources Manager", new DateTime(2018, 9, 22));
            Employee employee10 = new Employee("Sophia", "Anderson", "Project Coordinator", new DateTime(2017, 2, 14));



            // Assign the employees to the company
            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            company.AddEmployee(employee3);
            company.AddEmployee(employee4);
            company.AddEmployee(employee5);
            company.AddEmployee(employee6);
            company.AddEmployee(employee7);
            company.AddEmployee(employee8);
            company.AddEmployee(employee9);
            company.AddEmployee(employee10);


            // Iterate the company's employee list and generate the simple report
            company.ListEmployees();
        }
    }
}
