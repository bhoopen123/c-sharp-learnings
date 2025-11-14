using System;
using System.Collections.Generic;

namespace PassingReferenceTypeByValueType
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
        static void PassRefByValue(Product p1)
        {
            Console.WriteLine($"In Method {nameof(PassRefByValue)}");

            // Change the ProductNo of 'p1'?
            p1.ProductNo = 1001;       // these changes will be reflect as till here the object will be same 
            p1.ProductName = "Vimal";  // these changes will be reflect as till here the object will be same 

            // Will the caller see this reassignment?
            p1 = new Product("Send By Pr1", 10001); // but once we asign the reference of a new object 
                                                    // it will create a new object and store the values in that object
                                                    // so these values wil not be updated..

        }

        static void PassListByValue(List<Product> list)
        {
            Console.WriteLine("Modifying the list values");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductName == "pro2")
                {
                    list[i].ProductName = "ProductName has been changed to Changed";

                    Product p1 = new Product("Send By Pr1", 10001);
                    list.Add(p1);
                }
            }

            // it will create a new list and store the list items in that object
            // so these will not be updated in the caller
            list = new List<Product>
            {
                new Product("New_pro1", 11),
            };
        }


        static void Main(string[] args)
        {
            Console.WriteLine("create the object of Class");
            Product pr1 = new Product("Santoor", 101);

            Console.WriteLine($"Print the value Before {nameof(PassRefByValue)}");
            Console.WriteLine("pr1.ProductNo = " + pr1.ProductNo);
            Console.WriteLine("pr1.ProductName = " + pr1.ProductName);
            Console.WriteLine($"Calling {nameof(PassRefByValue)}");

            PassRefByValue(pr1);

            Console.WriteLine($"Print the value After {nameof(PassRefByValue)}");
            Console.WriteLine("pr1.ProductNo = " + pr1.ProductNo);
            Console.WriteLine("pr1.ProductName = " + pr1.ProductName);

            // as the PassRefByValue() method is pointing to the same object as the caller, it is possible to alter the
            // object’s state data. What is not possible is to reassign what the reference is pointing to (slightly akin to a constant pointer in C++).

            List<Product> proList = new List<Product>
            {
                new Product("pro1", 11),
                new Product("pro2", 12),
                new Product("pro3", 13),
                new Product("pro4", 14),
                new Product("pro5", 15),
                new Product("pro6", 16)
            };

            Console.WriteLine($"Before calling {nameof(PassListByValue)}");
            foreach (var item in proList)
            {
                Console.WriteLine(item.ProductName + "  " + item.ProductNo);
            }

            Console.WriteLine($"Calling {nameof(PassListByValue)}");
            PassListByValue(proList);

            Console.WriteLine($"After calling {nameof(PassListByValue)}");
            foreach (var item in proList)
            {
                Console.WriteLine(item.ProductName + "  " + item.ProductNo);
            }

            Console.Read();

        }
    }
}
