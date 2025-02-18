using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();
            listInt.Add(1);
            listInt.Add(10);
            listInt.Add(20);
            listInt.Add(30);
            listInt.Add(40);

            Console.WriteLine("Number of members in the list : {0}",listInt.Count);

            int value = listInt[0];

            Console.WriteLine("value at index 0 is : {0}",value);

            int i = listInt.Find(findMethod);


            if (i == 0)
            {
                Console.WriteLine(" no value is greater then 30");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the value of find(>30) id : {0}", i);
                Console.ReadLine();
            }

        }

       public static bool findMethod(int val)
        {
            return (val > 30);
        }

    }
}
