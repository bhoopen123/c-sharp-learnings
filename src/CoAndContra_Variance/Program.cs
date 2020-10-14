using System;
using System.Collections.Generic;

namespace CoAndContra_Variance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IOperations<Employee> employeeOperations = new Operations<Employee>();

            AddEmployee(employeeOperations);
            // we are achieving this using Conta-variance (i.e. 'in' keyword)
            AddManager(employeeOperations);

            
            PrintEmployees(employeeOperations);
            // we are achieving this using Covariance (i.e. 'out' keyword)
            PrintPersons(employeeOperations);
        }

        private static void PrintPersons(IReadOperations<Person> employeeOperations)
        {
            IEnumerable<Person> persons = employeeOperations.GetAll();

            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }

        private static void PrintEmployees(IReadOperations<Employee> employeeOperations)
        {
            IEnumerable<Employee> employees = employeeOperations.GetAll();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }

        static void AddEmployee(IWriteOperations<Employee> operations)
        {
            operations.Add(new Employee());
        }

        static void AddManager(IWriteOperations<Manager> operations)
        {
            operations.Add(new Manager());
        }
    }
}
