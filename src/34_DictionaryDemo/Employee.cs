namespace _34_DictionaryDemo
{
    internal class Employee : IEqualityComparer<Employee>
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
