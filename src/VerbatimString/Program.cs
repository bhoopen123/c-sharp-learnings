namespace VerbatimString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Composite Formatting Vs String Interpolation

            // String Composite Formatting Vs String Interpolation
            string Name = "John";
            DateTime today = DateTime.Now;

            // String Composite Formatting
            Console.WriteLine("Hello {0}, Today is {1:dddd, MMMM dd, yyyy}", Name, today);

            // String Interpolation
            Console.WriteLine($"Hello {Name}, Today is {today:dddd, MMMM dd, yyyy}");

            // An interpolated string starts with the '$' symbol before the opening double-quote ( " )

            // An interpolated string can be used to initlized a Constant also, only if all the inpolated expressions within the interpolated strings are constant strings.
            const string SomeName = "John";
            const string Statement = $"Hello {SomeName}, Greetings";

            #endregion


            #region Verbatim Identifier

            // "@" is known as verbatim identifier in c#
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

            // another usages of "@"
            // to use c# keyword as identifier
            int @class = 10;
            Console.WriteLine("Using c# keyword as identifier ", @class);

            #endregion
        }
    }
}
