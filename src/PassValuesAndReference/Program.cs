using System;

namespace PassValuesAndReference
{
    class Program
    {
        string myString;

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.myString = "string in main ";
            Console.WriteLine($"Before '{nameof(PassString)}' method calls");
            Console.WriteLine($"myString = '{obj.myString}'");
            Console.WriteLine($"myString hashCode = {obj.myString.GetHashCode()}");

            PassString(obj.myString);

            Console.WriteLine($"After '{nameof(PassString)}' method calls");
            Console.WriteLine($"myString = '{obj.myString}'");
            Console.WriteLine($"myString hashCode = {obj.myString.GetHashCode()}");

            Console.WriteLine($"Before '{nameof(PassStringWithRef)}' method calls");
            Console.WriteLine($"myString = '{obj.myString}'");
            Console.WriteLine($"myString hashCode = {obj.myString.GetHashCode()}");

            PassStringWithRef(ref obj.myString);

            Console.WriteLine($"After '{nameof(PassStringWithRef)}' method calls");
            Console.WriteLine($"myString = '{obj.myString}'");
            Console.WriteLine($"myString hashCode = {obj.myString.GetHashCode()}");


            myclass myobj = new myclass();
            myobj.ssInClass = "String in class";

            Console.WriteLine($"Before {nameof(passClassInstance)} method calls");
            Console.WriteLine($"myobj.ssInClass = {myobj.ssInClass}");

            passClassInstance(myobj);

            Console.WriteLine($"After {nameof(passClassInstance)} method calls");
            Console.WriteLine($"myobj.ssInClass = {myobj.ssInClass}");

            Console.Read();
        }

        static void PassString(string ss)
        {
            Console.WriteLine($"In Method:{nameof(PassString)} before modified ss hashCode = {0}", ss.GetHashCode());
            //
            ss = ss + "Changed";
            Console.WriteLine($"In Method:{nameof(PassString)} after modified ss hashCode = {0}", ss.GetHashCode());

            Console.WriteLine($"In method: {nameof(PassString)}");
            Console.WriteLine($"ss = {ss}");
            // the updated string will not be available in the main method because we have modified the string
            //so a new memory has been allocated the string variable 'ss' which is not been passed to the caller function.
        }

        static void PassStringWithRef(ref string ss)
        {
            Console.WriteLine($"In Method: {nameof(PassStringWithRef)} before modified ss hashCode = {0}", ss.GetHashCode());
            //
            ss = ss + "Changed";
            Console.WriteLine($"In Method: {nameof(PassStringWithRef)}  after modified ss hashCode = = {0}", ss.GetHashCode());

            Console.WriteLine($"In method: {nameof(PassStringWithRef)}");
            Console.WriteLine($"ss = {ss}");
            // the updated string will be available in the main method because we have modified the string
            // and the new memory has been allocated the string variable 'ss' which is now been passed to the caller function using 'ref' keyword.
        }

        static void passClassInstance(myclass obj)
        {
            //
            obj.ssInClass = obj.ssInClass + " cHANGED";

            Console.WriteLine($"In method : {nameof(passClassInstance)}");
            Console.WriteLine("obj.ssInClass = {0}", obj.ssInClass);
        }
    }

    public class myclass
    {
        public string ssInClass;
    }
}
