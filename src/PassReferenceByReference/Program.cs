using System;

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
        static void PassRefTypeBy_ref(ref Products p1)
        {
            // Change some data of 'p1'.
            p1.Pro_No = 1001;
            
            // 'p1' is now pointing to a new object on the heap!
            p1 = new Products("Send By ref", 10001);    // Whatever the changes we will do will be reflect in the object
                                                        // as both the object will share the same memory.

        }

        public void MyFun(dynamic sdf)
        {
            var vv = "dgfgd";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("create the object of Class");
            Products pr1 = new Products("Santoor", 101);
            Console.WriteLine("Print the value Before Pass Reference Type By ref");
            Console.WriteLine("pr1.Pro_No =" + pr1.Pro_No);
            Console.WriteLine("pr1.Pro_Name =" + pr1.Pro_Name);
            Console.WriteLine("Pass reference by value");
            PassRefTypeBy_ref(ref pr1);
            Console.WriteLine("Print the value After Pass Reference Type By ref");
            Console.WriteLine("pr1.Pro_No =" + pr1.Pro_No);
            Console.WriteLine("pr1.Pro_Name =" + pr1.Pro_Name);
            Console.Read();
            
            // The golden rule to keep in mind when passing reference types by reference is as follows:
            // If a reference type is passed by reference, the callee may change the values of the object’s state
            // data as well as the object it is referencing.
        }
    }
}
