using System;


namespace ValueTypeContainReferenceType
{

    class Products
    {
       public int ProductNo;
        public Products(int Pro_No)
        {
            ProductNo = Pro_No;
        }
    }

    struct ValueType
    {
       public Products p1;

       public int Rvalue;
       public int Cvalue;

        public ValueType(int pr)
        {
            p1 = new Products(pr);

            Rvalue = 10;
            Cvalue = 20;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create object of struct V1");
            ValueType V1 = new ValueType(101);
            Console.WriteLine("V1.p1.ProductNo = "+V1.p1.ProductNo);
            Console.WriteLine("V1.Rvalue = "+V1.Rvalue);
            Console.WriteLine("Assigning V1 to V2 this to another");
            ValueType v2 = V1;
            Console.WriteLine("change the value of Rvalue using V2");
            v2.Rvalue = 100;
            Console.WriteLine("change the value of ProductNo of Class Products using V2");
            v2.p1.ProductNo = 10001;
            Console.WriteLine("Print the value of V1 & V2");
            Console.WriteLine("V1.p1.ProductNo = " + V1.p1.ProductNo);
            Console.WriteLine("V1.Rvalue = " + V1.Rvalue);
            Console.WriteLine("V2.p1.ProductNo = " + v2.p1.ProductNo);
            Console.WriteLine("V2.Rvalue = " + v2.Rvalue);
            Console.Read();

            // when you change the value of the informational string using the r2 reference, the
            // r1 reference displays the same value. By default, when a value type contains other reference types,
            // assignment results in a copy of the references. In this way, you have two independent structures,
            // each of which contains a reference pointing to the same object in memory (i.e., a “shallow copy”).
        }
    }
}
