using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassValuesAndReference
{
    class Program
    {
        string myString;

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.myString = "string in main ";
            Console.WriteLine("Before passString method calls");
            Console.WriteLine("myString = {0}", obj.myString.ToString());
            Console.WriteLine("myString hashCode = {0}", obj.myString.GetHashCode());

            passString(ref obj.myString);

            Console.WriteLine("After passString method calls");
            Console.WriteLine("myString = {0}", obj.myString.ToString());
            Console.WriteLine("myString hashCode = {0}", obj.myString.GetHashCode());

            myclass myobj = new myclass();
            myobj.ssInClass = "String in class";

            Console.WriteLine("Before passClassInstance method calls");
            Console.WriteLine("myobj.ssInClass = {0}", myobj.ssInClass.ToString());

            passClassInstance(myobj);

            Console.WriteLine("After passClassInstance method calls");
            Console.WriteLine("myobj.ssInClass = {0}", myobj.ssInClass.ToString());

            Console.Read();
        }

        static void passString (ref string ss)
        {
            Console.WriteLine("In Method: before modified ss hashCode = {0}", ss.GetHashCode());
            //
            ss = ss + " Changed";
            Console.WriteLine("In Method: after modified ss hashCode = {0}", ss.GetHashCode());

            Console.WriteLine("In method");
            Console.WriteLine("ss = {0}", ss.ToString());  
            // the updated string will not be available in the main method because we have modified the string ,
            //so a new memory has been allocated the string variable 'ss' which is not been passed to the caller function.
        }

        static void passClassInstance(myclass obj)
        {
            //
            obj.ssInClass = obj.ssInClass + " cHANGED";

            Console.WriteLine("In method");
            Console.WriteLine("obj.ssInClass = {0}", obj.ssInClass.ToString());
        }

    }


    public class myclass
    {
        public string ssInClass;
    }

}
