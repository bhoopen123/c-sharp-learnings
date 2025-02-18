using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_SwitchCaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //A switch statement includes one or more switch sections. 
            //Each switch section contains one or more case labels followed by one or more statements. 

            int intcase = 3;
            switch (intcase)
            {
                // Switch Section Start 
                case 1:                 // Case Label
                    Console.Write("Case 1");
                    break;
                // Switch Section Ends 
                case 3:
                    Console.Write("Case 3");
                    break;

                default:
                    Console.Write(" Default");
                    break;
            }

            //Execution of the statement list in switch section begins with the first statement and proceeds through the statement list, 
            //typically until a jump statement, such as a break, goto case, return, or throw, is reached. At that point, control is transferred outside the switch statement or to another case label.
            // Every Case Label should have break, goto case, return or throw.
            switch (intcase)
            {
                // The following switch section causes an error.  
                //case 1:
                //    Console.WriteLine("Case 1...");
                // Add a break or other jump statement here.  
                case 2:
                    Console.WriteLine("... and/or Case 2");
                    break;
            }


            int switchExpression = 3;
            switch (switchExpression)
            {
                // A switch section can have more than one case label.
                case 0:
                case 1:
                    Console.WriteLine("Case 0 or 1");
                    // Most switch sections contain a jump statement, such as
                    // a break, goto, or return. The end of the statement list
                    // must be unreachable.
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                    // The following line causes a warning.
                    Console.WriteLine("Unreachable code");
                // 7 - 4 in the following line evaluates to 3.
                case 7 - 4:
                    Console.WriteLine("Case 3");
                    break;
                // If the value of switchExpression is not 0, 1, 2, or 3, the
                // default case is executed.
                default:
                    Console.WriteLine("Default case (optional)");
                    // You cannot "fall through" any switch section, including
                    // the last one.
                    break;
            }

            Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            // Notice the goto statements in cases 2 and 3. The base cost of 25
            // cents is added to the additional cost for the medium and large sizes.
            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 25;
                    goto case "1";
                case "3":
                case "large":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");
        }

        // Console.ReadLine();
    }
}
