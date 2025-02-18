using System;
using System.Collections.Generic;

namespace GenericsBasics
{
    // Defination :
    // Generics allow you to delay the specification of the datatype of programming elements in a class or a method, 
    // until it is actually used in the program. 
    // In other words, 
    // generics allow you to write a class or method that can work with any data type.

    // You write the specifications for the class or the method, with substitute parameters for data types. 
    // When the compiler encounters a constructor for the class or a function call for the method, 
    // it generates code to handle the specific data type. 
    // A simple example would help understanding the concept:

    # region  
   
    /// <summary>
    /// Generic Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }


    // Features of Generics

    // Using generics is a technique that enriches your programs in the following ways:
    // It helps you to maximize code reuse, type safety, and performance.
    // You can create generic collection classes. 
    // The .NET Framework class library contains several new generic collection classes in the System.Collections.Generic namespace. 
    // You may use these generic collection classes instead of the collection classes in the System.Collections namespace.
    // You can create your own generic interfaces, classes, methods, events and delegates.
    // You may create generic classes constrained to enable access to methods on particular data types.
    // You may get information on the types used in a generic data type at run-time by means of reflection.


    # endregion

    class Program
    {
        /// <summary>
        /// we can declare a generic method with a type parameter. 
        /// The following program illustrates the concept:
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {

            /// Generic Class Test 
            //declaring an int array
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            //setting values
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }
            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }
            Console.WriteLine();
            //declaring a character array
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            //setting values
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }
            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();

            // ***********************************************************************************
            // To Call Generic Method...
            // ***********************************************************************************
            int a, b;
            char c1, d1;
            a = 10;
            b = 20;
            c1 = 'I';
            d1 = 'V';

            //display values before swap:
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c1, d1);

            //call swap // which is a generic method
            Swap<int>(ref a, ref b);
            Swap<char>(ref c1, ref d1);

            //display values after swap:
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c1, d1);
            Console.ReadKey();
        }
    }
}
