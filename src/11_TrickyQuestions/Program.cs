using System;
using System.Linq;
using System.Text;

namespace _11_TrickyQuestions
{
    public class Person
    {
        public string Name { get; set;}

        public int Age { get; set; }
    }

    class Program
    {
        public static int x = 100;

        static void Main(string[] args)
        {
            #region Question 1 : what would be the output of following program

            byte num1 = 100;
            byte num2 = 200;

            byte totalAsByte = (byte)(num1 + num2);
            int totalAsInt = ((int)num1 + (int)num2);
            Console.WriteLine("totalAsByte = {0} totalAsInt = {1}", totalAsByte, totalAsInt);

            // Answer : this will a compile time error at line "byte total = num1 + num2;"
            // Any math performed on "byte" or "short" types is implicitly cast back to an integer. the solution is to explicitly cast the result back to a byte.
            // byte total = (byte)(num1 + num2);
            // you will not get expected arithmatic result using this expession, because the compiler is treating the num1 and num2 as bits and not integers. To get the expected result typecast the bytes to int before performing arithmatic operation.

            // If there are overloaded methods one with Int and other With Byte as parameter types, then while calling method which has Byte parameter we have to type caste the value in Byte as in below example.
            // Calling the method with the int parameter:  
            SampleMethod(5);
            // Calling the method with the byte parameter:  if we do not typecaste then by default 5 will be considred as int and Dotnet runtime will call SampleMethod having Int parameter.
            // Same thing applies with Short datatype.
            SampleMethod((byte)5);

            // Note : If we have only one method with byte type parameter then we do not need to typecaste the value while calling the method.
            

            // when assign more then max value in byte type.
            //byte maxTest = 256; // this will be a compile time error.
            byte maxTest = (byte)(totalAsInt + 200); // value of totalAsInt is more than 255. this will not throw error but result will not be correct.
            Console.WriteLine("Max test value : {0}", maxTest);

            Console.ReadKey();
            #endregion 

            #region Question 2 : What would be the output of the following program

            Console.WriteLine(" Switch case with break Example");
            for (int i = -5; i <= 5; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("India");
                        break;                   // the break statement will break only the Switch block and not For loop.
                }

                if (i < 0)
                    Console.Write("B");
                else if (i > 0)
                    Console.Write("V");
            }

            Console.ReadLine();
            #endregion

            #region Question 3 : Static variable and non static variable in one class with same name.
            int y = 200;
            int x = 300;

            Console.WriteLine(Program.x.ToString() + "  " + x.ToString() + "  " + y.ToString());

            Console.ReadLine();

            #endregion 

            //var x = null;            //The compiler will not accept var x = null because it doesn't associate the null with any type - not even Object. 
            //Using the above approach, var x = (Object)null would "work".

            new Person(); // this is also a valid statement, what happens here is basically allocates the memory on the heap first.

            Person p = new Person(); // while in this case, variable type p is allocated into stack and contains the pointer to the memory on the heap.

            Console.WriteLine("checking Febonacci");
            int[] febonacciNumbers = GetFebonacci(10);

            Console.WriteLine("Print Numbers");
            foreach (var number in febonacciNumbers)
            {
                Console.Write(number + "->");
            }

            Console.ReadLine();
        }

        static int[] GetFebonacci(int tillNumber)
        {
            int[] febonacciNumbers = new int[tillNumber];
            int previousNumber = 0;
            int currentNumber = 1;
            int temp = 0;

            if (tillNumber == 0)
            {
                return null;
            }
            if (tillNumber == 1)
            {
                febonacciNumbers[0] = 1;
                return febonacciNumbers;
            }
            
            // 
            for (int i = 0; i < tillNumber; i++)
            {
                febonacciNumbers[i] = currentNumber;
                temp = currentNumber;
                currentNumber = previousNumber + currentNumber;
                previousNumber = temp;
            }

            return febonacciNumbers;
        }

        #region Question 1

        //When calling overloaded methods, a cast must be used. Consider, for example, 
        //The following overloaded methods that use byte and int parameters:
        public static void SampleMethod(int i)
        {
            Console.WriteLine("int i ");
        }
        public static void SampleMethod(byte b) {
            Console.WriteLine("byte i ");
        }

        #endregion
    }
}
