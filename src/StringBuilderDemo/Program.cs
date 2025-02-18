using System;
using System.Text;


namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stdbr=new StringBuilder("This is my sentence");        // StringBuilder is the part of System.Text; Namespace
            
            Console.WriteLine("Before Append");
            Console.WriteLine(" Capacity of this StringBuilder is : {0}",stdbr.Capacity);
            Console.WriteLine("stdbr : {0}",stdbr);
            
            stdbr.Append(" contains numeric data.");
            stdbr.AppendFormat(" {0} , {1} ",99,100);                            // just to append the given content in the given order, using {0},{2} etc

            Console.WriteLine("After Append");
            Console.WriteLine(" Capacity of this StringBuilder is : {0}", stdbr.Capacity);
            Console.WriteLine("stdbr : {0}", stdbr);

            Console.WriteLine("Replace some data in the string");
            stdbr.Replace("data.", "data also.");
            Console.WriteLine("After Replace some data");
            Console.WriteLine(" Capacity of this StringBuilder is : {0}", stdbr.Capacity);
            Console.WriteLine("stdbr : {0}", stdbr);

            Console.Read();

        }
    }
}
