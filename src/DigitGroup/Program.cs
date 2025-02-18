using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sTest = "I 2b23 fries & 1.25 cokes l8r ghjbb77 ";

            //int result = count_numbers(sTest);

            //Console.WriteLine(result.ToString());

            int[] array = { 3,3,1,1,2,1,4,4,4 };

            Console.WriteLine("Before Calling Repeated");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+",");
            }
            remove_repeated(ref array);
            
            Console.WriteLine("After Calling Repeated");
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }

            Console.Read();
        }

        // returns the count of groupLetters basically contains digits, 
        // noTe - '.' also saperates groups
        public static int count_numbers(string s)
        {
            int letterDigitGroupCount = 0;

            int sCount = s.Length - 1;

            for (int i = 0; i < sCount; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    while (s[i] != ' ')
                    {
                        // string end Check
                        if (i < sCount)
                        {
                            i++;
                            if (s[i] == '.')
                                letterDigitGroupCount++;
                        }
                        else
                            break;
                    }
                    letterDigitGroupCount++;
                }

            }
            return letterDigitGroupCount;
        }


        public static void remove_repeated(ref int[] array)
        {
            if (array == null || array.Length < 1)
                return;
            
            // will store Non repeated data in this array.
            int[] tempArr = new int[array.Length];
            int start = 0;
            int next = 1;
            int counter = 0;
            bool duplicate = false;

            for (int i = 0; i < array.Length; i++)
            {
                if ((next < array.Length) && (array[start] == array[next]))
                {
                    next++;
                    duplicate = true;
                }
                else if (duplicate)
                {
                    start = next;
                    next++;
                    duplicate = false;
                }
                else
                {
                    tempArr[counter] = array[start];
                    start++;
                    next++;
                    counter++;
                }
            }

            array = tempArr;
            // Calling Resize
            Array.Resize<int>(ref array, counter);
        }
    }
}
