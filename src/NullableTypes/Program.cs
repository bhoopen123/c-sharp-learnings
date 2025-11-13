using System;

namespace NullableTypes
{
    class Program
    {
        //// by default we cannot assign null to all values type datatype
        ////as 
        //int myInt = null;           // compile time error
        //bool myBool = null;         // compile time error

        // To define a nullable variable type, the question mark (?) is suffixed to the underlying datatype..
        // Do note that this syntax is only legal when applied to value types or an array of value types.
        // Like a non-nullable variable, local nullable variable must be assigned to an initial value:

        // Define some local nullabe types 
        int? nullabeInt = 10;
        bool? nullableBool = null;
        char? nullableChar = 'a';
        int?[] nullableArray = new int?[5];

        //// error ! String are reference types!
        ////string? str = "OOPs";

        // in c#, the ? suffix notation is shorthand for creating a variable of the generic System.Nullable<T> sructure type,
        // for example, int? is a shorthand for System.Nullable<int>

        // it is important to understand that system.nullable<T> type provides a set of members that all nullable types can make use of.
        // For Example , u are able to programatically discover if the nullable variable indeed has been assigned a null Value 
        // using the `HasValue` property or the != operator. The assigned value of a nullable type may be obtained directly or 
        // via the Value property..

        // Nullable datatypes can be particularly usefull when you are interecting with databases, given that columns in the data table 
        // may be intentionally empty (e.g., undefined).

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with nullable Data ******");
            DatabaseReader dr = new DatabaseReader();

            // get int from 'Database'
            int? i = dr.GetIntFromDatabase();


            if (i.HasValue)
            {
                Console.WriteLine("Value of i is {0} ", i);
            }
            else
            {
                Console.WriteLine("Value of i is undefined.");
            }


            // get bool from 'Database'
            bool? b = dr.GetBoolFromDatabase();

            if (b != null)
            {
                Console.WriteLine("Value of b is {0} ", b);
            }
            else
            {
                Console.WriteLine("Value of b is undefined.");
            }

            #region The ?? Operator

            // The ?? Operator -- This operator allows you to assign a value to a nullable type if the retrived value is in fact null.
            // Example, assume u wish to assign a local variable to 100 if the value returned from GetIntFromDatabase() is null

            // if the value from GetIntFromDatabase() is null assign local variable to 100.
            int? mydata = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", mydata);

            #endregion

            Console.Read();
        }
    }

    class DatabaseReader
    {
        // Nullable data field
        public int? numbericValue;
        public bool? boolValue = true;

        // Note the nullable return type
        public int? GetIntFromDatabase()
        {
            return numbericValue;
        }

        // Note the nullable return type
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
