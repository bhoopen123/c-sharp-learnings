namespace ArrayDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple Array
            int[] arr = { 5, 2, 3, 6, 4, 8, 65 };

            // can also be declared like this
            // int[] arr = [ 5, 2, 3, 6, 4, 8, 65 ];
            foreach (int ar in arr)
            {
                Console.WriteLine(ar);
            }

            int[] arr2 = new int[5];
            arr2[0] = 3;
            arr2[1] = 5;
            arr2[2] = 7;
            arr2[3] = 9;
            arr2[4] = 12;
            int ii = 0;
            foreach (int element in arr2)
            {
                Console.WriteLine("\n arr[" + ii + "]= " + element.ToString());
                ii++;
            }

            // Declaring array in a different way
            string[] strArr = new string[3];
            strArr[0] = "This is";
            strArr[1] = " DotNet";
            strArr[2] = " Framwork 4.0";

            foreach (string s in strArr)
            {
                Console.Write(s);
            }

            //Declaring multiDimension Array
            int[,] multiDim = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    multiDim[i, j] = i * j;
                }
            }

            // Print the multiDim Array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(multiDim[i, j] + "  ");
                }
                Console.WriteLine();
            }

            // Jagged Array 
            int[][] jagArray = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                //create a jagged Array...
                jagArray[i] = new int[i + 3];
            }

            // print each row of jagged Array(remember, each element is defaulted to zero)
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Length of row {0} is {1} :\t", i, jagArray[i].Length);
                for (int j = 0; j < jagArray[i].Length; j++)
                {
                    Console.Write(jagArray[i][j] + "  ");
                }
                Console.WriteLine();
            }

            //Some Property & methods of Array
            // Clear()-- This static method sets a range of elements in the array to empty values
            // (0 for value types ; null for reference types)
            // Rank -- This Property returns the number of Dimensions of the Current array
            // Reverse() -- This static method reverses the contents of a one Dimensional array..
            // Sort() -- This method sorts a one Dimensional array of intrinsic types. If the 
            // elements in the array implement the IComparer interface, you can also sort your custom types..

            // Use of above property & method
            // Declare a Array..
            string[] names = new string[3];
            // Assigning the values to the array
            names[0] = "Alok";
            names[1] = "Amit";
            names[2] = "Amir";
            // print the Rank of the array
            Console.WriteLine("The Rank of the array is : {0}", names.Rank);

            // print the above array
            Console.WriteLine("The declared array is :");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name {0}-\t{1}", i, names[i]);
            }
            Console.WriteLine();

            // reverse the array & print
            Console.WriteLine("After Reverse The Array");
            Array.Reverse(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name {0}-\t{1}", i, names[i]);
            }
            Console.WriteLine();

            // sort the array & print
            Console.WriteLine("After sort The Array");
            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name {0}-\t{1}", i, names[i]);
            }
            Console.WriteLine();
            // Clear out all but Baldy..
            Console.WriteLine("After Clears The Array");
            Array.Clear(names, 1, 2);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name {0}-\t{1}", i, names[i]);
            }
            Console.WriteLine();
            Console.Read();

        }
    }
}
