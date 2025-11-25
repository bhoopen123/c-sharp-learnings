using System;


namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //// simple program for string and integer typecaste
            //string x = "5";
            //int y = int.Parse(x);   // string is a reference type datatype, so we have to parse it in int before assigning it to integer 
            //                        // type datatype. direct // int y=x; does not work. will end up with compile time error.
            //Console.WriteLine(y);

            //Console.ReadLine();


            // this Main part is for MyExceptionClass inplementation

            //Declare two variable
            int x, y;
            try
            {
                Console.WriteLine("Enter two values for X and Y :");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (y < 10)
                {
                    throw new MyExceptionClass("Value is less than 10");
                }
                else
                {
                    Console.WriteLine("output of X/Y is : {0} ", (x / y).ToString());
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in the program : {0} ", ex.Message);
                Console.ReadLine();
            }

            #region Array can be iterated over it maximum size or not

            // This Program is check whether an array can Iterate over it maximum size or not,
            // In C, C++ an array can be iterate over its maximum limit 

            // declare a array 
            int[] arr = new int[10];
            int i = 0;
            try
            {
                Console.WriteLine("Printing Array Values :-");
                for (; i < 15; i++)
                {
                    arr[i] = i;
                    Console.WriteLine(string.Format("Index {0} - Value {1}", i.ToString(), arr[i].ToString()));
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(string.Format("Error occured at Index {0} with message : {1}",
                                                        i.ToString(), ex.Message.ToString()));
            }

            // Conclusion : Unlike C & C++, you cannot iterate an array out of its index which is declared in C# and Java.
            #endregion

            // Here the name of a variable is declared more than 255 characters... and it is acceptable in c#
            int jhkjhkhhhkhkhksahkhfkhskasjhfakfhsakfjahsfkjahfkajshfakjshfajhsfjahskjhfakjhfakjhfsajhfkjahfskhafhsjhakjshfajhfsakjhfjashfsjfhakjfhskjfhksahfkshfkahshskjfhakhfksahfskjfhdjfhdfjhdfjhdjfhadkjfhdjhfajhfahdkfjhfkahdkfhfjkhdhfahfkdjahfkjngjhasgjgajfgsajhdgjdhsgdjhsgdjdsagjhjggvjvjvjgvjgjvjvjgvjg = 45;

        }
    }


    // create a new exception that will drived from DivideByZero class
    class MyExceptionClass : DivideByZeroException
    {
        public MyExceptionClass(string ss) : base(ss)
        {

        }
    }

}
