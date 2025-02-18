using System;

namespace _10_StringConcatProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(" Enter First String : ");
            string str1 = Console.ReadLine();

            Console.WriteLine(" Enter Second String : ");
            string str2 = Console.ReadLine();

            string mergeString = Merge(str1, str2);

            Console.WriteLine("Merged String :" + mergeString);
            Console.ReadLine();

        }

        private static string Merge(string str1, string str2)
        {
            // convert both the strings in Char arrays,
            char[] str1AsCharArray = str1.ToCharArray();
            char[] str2AsCharArray = str2.ToCharArray();
            char[] mergStringAsArray = (str1 + str2).ToCharArray();

            string mergeStr = string.Empty;

            int indexStr2 = str1AsCharArray.Length;

            for (int i = 1; i < str1AsCharArray.Length; i++)
            {

                if (i > str2AsCharArray.Length)
                {
                    break;
                }
                char temp = mergStringAsArray[i];
                mergStringAsArray[i] = mergStringAsArray[indexStr2];
                mergStringAsArray[indexStr2] = temp;
                indexStr2++;
            }
            mergeStr = new string(mergStringAsArray);

            return mergeStr;
        }
    }
}
