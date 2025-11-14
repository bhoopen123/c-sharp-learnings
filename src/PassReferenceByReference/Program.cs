using System;

namespace PassReferenceByReference
{
    class Product
    {
        public int ProductNo;
        public string ProductName;
        public Product(string prName, int prNo)
        {
            ProductName = prName;
            ProductNo = prNo;
        }
    }

    class Program
    {
        static void PassRefTypeBy_ref(ref Product p1)
        {
            // Change some data of 'p1'.
            p1.ProductNo = 1001;

            // 'p1' is now pointing to a new object on the heap!
            p1 = new Product("Send By ref", 10001);    // Whatever the changes we will do will be reflect in the object
                                                       // as both the object will share the same memory.

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Create the object of Class");
            Product pr1 = new Product("Santoor", 101);

            Console.WriteLine($"Print the value Before {nameof(PassRefTypeBy_ref)}");
            Console.WriteLine("pr1.ProductNo = " + pr1.ProductNo);
            Console.WriteLine("pr1.ProductName = " + pr1.ProductName);

            Console.WriteLine("Pass reference by value");

            PassRefTypeBy_ref(ref pr1);

            Console.WriteLine($"Print the value After {nameof(PassRefTypeBy_ref)}");
            Console.WriteLine("pr1.ProductNo = " + pr1.ProductNo);
            Console.WriteLine("pr1.ProductName = " + pr1.ProductName);
            Console.Read();

            // The golden rule to keep in mind when passing reference types by reference is as follows:
            // If a reference type is passed by reference, the callee may change the values of the object’s state
            // data as well as the object it is referencing.
        }
    }
}
