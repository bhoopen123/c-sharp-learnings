using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassReferenceByReference
{
    class Products
    {
        public int Pro_No;
        public string Pro_Name;
        public Products(string prName, int prNo)
        {
            Pro_Name = prName;
            Pro_No = prNo;
        }
    }

    class Program
    {
        static void PassRefByValue(ref Products p1)
        {
            p1.Pro_No = 1001;

            p1 = new Products("Send By ref", 10001);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("create the object of Class");
            Products pr1 = new Products("Santoor", 101);
            Console.WriteLine("Print the value Before Pass Reference By ref");
            Console.WriteLine("pr1.Pro_No =" + pr1.Pro_No);
            Console.WriteLine("pr1.Pro_Name =" + pr1.Pro_Name);
            Console.WriteLine("Pass reference by value");
            PassRefByValue(ref pr1);
            Console.WriteLine("Print the value After Pass Reference By ref");
            Console.WriteLine("pr1.Pro_No =" + pr1.Pro_No);
            Console.WriteLine("pr1.Pro_Name =" + pr1.Pro_Name);
            Console.Read();
        }
    }
}
