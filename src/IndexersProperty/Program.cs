using System;

namespace IndexersProperty
{
    // An indexer allows an object to be indexed like an array. When you define an indexer for a class, 
    // this class behaves like a virtual array.
    // You can then access the instance of this class using the array access operator ([ ]). 
    class Indexers
    {
        string[] FullName = new string[3];

        public string this[int i]
        {
            get { return FullName[i]; }
            set { FullName[i] = value; }
        }
    }

    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
        // Indexers can be overloaded. 
        // Indexers can also be declared with multiple parameters and each parameter may be a different type. 
        // It is not necessary that the indexes have to be integers. 
        // C# allows indexes to be of other types, for example, a string.

        // The following example demonstrates overloaded indexers:

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create the obj of indexer Class 
            Indexers obj = new Indexers();

            //assigning the values to indexerz

            Console.WriteLine("Read the values from Indexers\n");
            obj[0] = "Bhoopendra";
            obj[1] = "Kumar";
            obj[2] = "Sharma";

            //printing the values of indexer property 
            Console.WriteLine("Print the values from Indexers \n");
            Console.WriteLine("First Name={0}",obj[0]);
            Console.WriteLine("Middle Name={0}", obj[1]);
            Console.WriteLine("Last Name={0}", obj[2]);



            IndexedNames names = new IndexedNames();
             names[0] = "Zara";
             names[1] = "Riz";
             names[2] = "Nuha";
             names[3] = "Asif";
             names[4] = "Davinder";
             names[5] = "Sunil";
             names[6] = "Rubic";

             //using the first indexer with int parameter
             for ( int i = 0; i < IndexedNames.size; i++ )
             {
                Console.WriteLine(names[i]);
             }

             //using the second indexer with the string parameter
             Console.WriteLine(names["Nuha"]);

             Console.ReadKey();
        }
    }
}
