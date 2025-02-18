﻿using System;


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
        }
    }


    // create a new exception that will drived from DivideByZero class

    class MyExceptionClass : DivideByZeroException
    {
        public MyExceptionClass(string ss):base(ss)
        {

        }
    }

}
