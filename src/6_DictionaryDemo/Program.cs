using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace _6_DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("key1", "Value1");
            dict.Add("key2", "Value2");
            dict.Add("key3", "Value3");
            dict.Add("key4", "Value4");
            dict.Add("key5", "Value5");
            dict.Add("key6", "Value6");

            //foreach (string key in dict.Keys)
            //{
            //    Console.WriteLine("values "+dict[key]);
            //}

            //Console.WriteLine("Change Value in Key2");
            //dict["key2"] = "Changed";

            //foreach (string key in dict.Keys)
            //{
            //    Console.WriteLine("values " + dict[key]);
            //}


            // Creating the Array of Employees
            Employee[] employees =  { new Employee("Amit"),
                                    new Employee("Alok"),
                                    new Employee("Ashish"),
                                    new Employee("Amit")};

            Dictionary<Employee, int> empDict = new Dictionary<Employee, int>();
            Console.WriteLine("Storing in empDict");
            foreach (Employee emp in employees)
            {

                if (empDict.Keys.Contains(emp))
                {
                    empDict[emp] += 1;
                }
                else
                {
                    empDict.Add(emp, 1);
                }
                Console.WriteLine("empData Value" + empDict[emp]);
            }

            Console.WriteLine("Print in empDict Data");
            foreach (Employee emp in empDict.Keys)
            {
                Console.WriteLine("Emp Detail " + emp._name + " and its Value " + empDict[emp]);
            }
            Console.Read();


        }

    }

    class Employee : IEqualityComparer<Employee>
    {
        public string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public bool Equals(Employee x, Employee y)
        {
            return (x._name == y._name);
        }

        public int GetHashCode(Employee obj)
        {
            return obj.GetHashCode();
        }
    }
}
