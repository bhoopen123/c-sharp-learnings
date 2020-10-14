using System.Collections.Generic;

namespace CoAndContra_Variance
{
    public class Manager : Employee
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
