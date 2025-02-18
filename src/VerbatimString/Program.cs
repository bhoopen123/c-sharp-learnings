using System;

namespace VerbatimString
{
    class Program
    {
        static void Main(string[] args)
        {

            // The Following string is printed verbatim
            // thus, all escape characters are displayed
            Console.WriteLine(@"c:\gjgj\hhjg\kkkjgjh");

            // white space is preserved with verbatim string
            string longstring = @"gggaffgsa
aggafggfgf
                dfsfsfsfasf
                            xxfsdggfdgdf";

            Console.WriteLine(longstring);

            // you can also insert a double quote into a literal string by doubing the " token,
            Console.WriteLine(@"Cerebus said ""Darr! Pret-ty sun_sets""");
            Console.Read();
        }
    }
}
