using System;

namespace OverLoaded_Indexer_Methods_and_Indexer_on_Interface
{
    class Program
    {
        public static void Add(int one, int two)
        {
            Console.WriteLine(one + two);
        }

        public static void Add(int one, string two)
        {
            Console.WriteLine(one + two);
        }

        public static void Add(string one, int two)
        {
            Console.WriteLine(one + two);
        }

        public static void Add(string one, string two)
        {
            Console.WriteLine(one + two);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Add of two numbers: (Both are integers) "); Add(10, 15);
            Console.WriteLine("Add of two numbers: (one integer and two is string) "); Add(10, "15");
            Console.WriteLine("Add of two numbers: (one string and two is integer) "); Add("10", 15);
            Console.WriteLine("Add of two numbers: (Both are strings) "); Add("10", "15");

            MyStrings obj1 = new MyStrings();

            Console.WriteLine(" Obj1[0] = {0} and obj[1] = {1}", obj1[0], obj1[1]);

            Console.WriteLine("Creating the new object of the Mystring");
            MyStrings obj2 = new MyStrings();
            Console.WriteLine(" Obj2[0] = {0} and obj2[1] = {1}", obj2[0], obj2[1]);

            Console.WriteLine("Changing the values of Indexers obj1 ");
            obj1[0] = "New Value First";
            obj1[1] = "New value Second";

            Console.WriteLine("Print the values of obj1 and obj2");
            Console.WriteLine(" Obj1[0] = {0} and obj[1] = {1}", obj1[0], obj1[1]);
            Console.WriteLine(" Obj2[0] = {0} and obj2[1] = {1}", obj2[0], obj2[1]);

            Console.ReadLine();
        }
    }

    public interface IStringContainer<key>
    {
        string this[int key] { get; set; }
    }

    public class MyStrings : IStringContainer<int>
    {
        string[] strs = { "First", "Second" };

        public string this[int key]
        {
            get
            {
                return strs[key];
            }
            set
            {
                strs[key] = value;
            }
        }
    }

    //public sealed class DataTableCollection
    //{
    //    // OverLoaded Indexer

    //    public DataTable this[string name] { get; }

    //    public DataTable this[string name, string tableNameSpace] { get; }

    //    public DataTable this[int index] { get; }
    //}

    // Indexer Defination on Interface type,

}
