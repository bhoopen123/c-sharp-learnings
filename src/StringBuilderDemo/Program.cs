using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        // IDE0060: Remove unused parameter 'args'
        // Fix: Remove 'string[] args' since it's not used.
        static void Main()
        {
            // In C#, `StringBuilder` (from the `System.Text` namespace) is a mutable class used to efficiently build and modify strings without creating new string objects each time. It’s ideal for scenarios involving repeated concatenation, insertion, or replacement operations.

            // - Strings are immutable: Every modification creates a new string object, which is costly in terms of memory and performance.

            // - StringBuilder is mutable: It allows in-place modifications, reducing overhead.
            // Especially useful when concatenating strings inside loops or handling large text operations.

            StringBuilder stdbr = new StringBuilder("This is my sentence");        //  "StringBuilder" is the part of `System.Text` namespace.

            Console.WriteLine("Before Append");
            Console.WriteLine(" Capacity of this StringBuilder is : {0}, length = {1}", stdbr.Capacity, stdbr.Length);
            Console.WriteLine("stdbr : {0}", stdbr);

            stdbr.Append(" contains numeric data.");
            stdbr.AppendFormat(" {0} , {1} ", 99, 100);                            // just to append the given content in the given order, using {0},{2} etc

            Console.WriteLine("After Append");
            Console.WriteLine(" Capacity of this StringBuilder is : {0}, length = {1}", stdbr.Capacity, stdbr.Length);
            Console.WriteLine("stdbr : {0}", stdbr);

            Console.WriteLine("Replace some data in the string");
            stdbr.Replace("data.", "data also.");
            Console.WriteLine("After Replace some data");
            Console.WriteLine(" Capacity of this StringBuilder is : {0}, length = {1}", stdbr.Capacity, stdbr.Length);
            Console.WriteLine("stdbr : {0}", stdbr);

            // now adding some more data to see how capacity changes
            stdbr.Append(". Adding more data ");
            Console.WriteLine("After Adding more data");
            Console.WriteLine(" Capacity of this StringBuilder is : {0}, length = {1}", stdbr.Capacity, stdbr.Length);
            Console.WriteLine("stdbr : {0}", stdbr);

            Console.Read();
        }
    }
}
