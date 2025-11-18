using System;

namespace DigitGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTest = "I 2b23 fries & 1.25 cokes l8r ghjbb77 ";

            int result = count_numbers(sTest);

            Console.WriteLine(result.ToString());

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
    }
}
