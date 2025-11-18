using _21_RemoveRepeated;

namespace _12_RemoveRepeated
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int[]> arrays =
                [
                    new int[] { 3, 1 },
                    new int[] { 3, 1, 2 },
                    new int[] { 3, 1, 1, 2, 1, 4 },
                    new int[] { 3, 1, 1, 2, 1, 4, 4 },
                    new int[] { 3, 1, 1, 2, 1, 4, 4, 4 },
                    new int[] { 3, 1, 1, 2, 2, 1, 1, 4, 4 },
                    new int[] { 3, 1, 1, 2, 1, 1, 4, 4 },
                    new int[] { 3, 1, 1, 2, 1, 1, 4, 4, 4 },
                    new int[] { 3, 3, 1, 1, 2, 1, 4, 4, 4 },
                ];

                for (int i = 0; i < arrays.Count; i++)
                {
                    int[] array = arrays[i];
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Before removing repeated");
                    PrintArray(array);
                    Console.WriteLine();

                    //RemoveRepeated(ref array);
                    array = Approach1.RemoveRepeated(array);

                    Console.WriteLine("After removing repeated");
                    PrintArray(array);
                    Console.WriteLine();
                    Console.WriteLine("=========================================");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            Console.Write("{");
            foreach (int item in array)
            {
                Console.Write(item + ", ");
            }
            Console.Write("}");
        }

        static void RemoveRepeated(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int startIndex = 0;
                int endIndex = 0;
                int counter = i;
                bool dupFound = false;
                startIndex = i;

                while (array[counter] == array[++counter])
                {
                    endIndex = counter;
                    dupFound = true;

                    if (counter >= array.Length - 1)
                        break;
                }

                if (dupFound)
                {
                    int consecutiveDupCount = endIndex - startIndex + 1;
                    int sourceIndex = counter;
                    for (int targetIndex = startIndex; sourceIndex < array.Length; targetIndex++)
                    {
                        array[targetIndex] = array[sourceIndex];
                        sourceIndex++;
                    }

                    Array.Resize(ref array, array.Length - consecutiveDupCount);

                    i--;
                }
            }
        }

        //static void RemoveRepeated(ref int[] array)
        //{
        //    int uniqueCount = 0;
        //    bool dupFound = false;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int startIndex = i;
        //        int counter = i;
        //        int endIndex = 0;
        //        int dupCount = 0;

        //        if (counter == (array.Length - 1) && !dupFound)
        //        {
        //            uniqueCount++;
        //            break;
        //        }

        //        while (array[counter] == array[++counter])
        //        {
        //            if (!dupFound)
        //            {
        //                dupCount = 2;
        //            }
        //            else
        //            {
        //                dupCount++;
        //            }

        //            dupFound = true;
        //            endIndex = counter;
        //        }

        //        if (dupFound)
        //        {
        //            if (endIndex == (array.Length - 1))
        //            {
        //                Array.Resize(ref array, startIndex);
        //                break; // breaking from main loop
        //            }
        //            i = startIndex - 1;
        //            for (endIndex = endIndex + 1; endIndex < array.Length; endIndex++)
        //            {
        //                array[startIndex] = array[endIndex];
        //                startIndex++;
        //            }

        //            Array.Resize(ref array, (array.Length - dupCount));
        //        }
        //        else
        //        {
        //            uniqueCount++;
        //        }
        //    }


        //    Array.Resize(ref array, uniqueCount);
        //}
    }
}