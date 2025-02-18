using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TestArrayIndex
{
    /// <summary>
    /// This Program is check whether an array can Iterate over it maximum size or not,
    /// In C, C++ an array can be iterate over its maximum limit 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // declare a array 
            int[] arr = new int[10];
            int i =0;
            try
            {
                Console.WriteLine("Printing Array Values :-");
                for (; i < 15; i++)
                {
                    arr[i] = i;
                    Console.WriteLine(string.Format("Index {0} - Value {1}",i.ToString(),arr[i].ToString()));
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(string.Format("Error occured at Index {0} with message : {1}",
                                                        i.ToString(), ex.Message.ToString()));
            }

            // Conclusion : Unlike C & C++, you cannot iterate an array out of its index which is declared in C# and Java.
            Console.Read();

            // Here the name of a variable is declared more than 255 characters... and it is acceptable in c#
            int jhkjhkhhhkhkhksahkhfkhskasjhfakfhsakfjahsfkjahfkajshfakjshfajhsfjahskjhfakjhfakjhfsajhfkjahfskhafhsjhakjshfajhfsakjhfjashfsjfhakjfhskjfhksahfkshfkahshskjfhakhfksahfskjfhdjfhdfjhdfjhdjfhadkjfhdjhfajhfahdkfjhfkahdkfhfjkhdhfahfkdjahfkjngjhasgjgajfgsajhdgjdhsgdjhsgdjdsagjhjggvjvjvjgvjgjvjvjgvjg = 45;
        }
    }
}
