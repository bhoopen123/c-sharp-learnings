namespace _6_DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new()
            {
                { "key1", "Value1" },
                { "key2", "Value2" },
                { "key3", "Value3" },
                { "key4", "Value4" },
                { "key5", "Value5" },
                { "key6", "Value6" }
            };

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

        public bool Equals(Employee x, Employee y) => x._name == y._name;

        public int GetHashCode(Employee obj)
        {
            return obj.GetHashCode();
        }
    }
}
