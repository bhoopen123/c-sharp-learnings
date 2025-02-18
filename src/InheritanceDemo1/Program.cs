using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceDemo1
{

    class Base
    {
        protected string Name;      // u cannot access protected data from object instance..

        // if base class has only the parametrised constructor then we will have to 
        // give the value of the parameter of the base class 
        // by using the 'Base' Keyword in the Constructor of the Drived Class 
        public Base(int i)
        {
            Console.WriteLine("Base Constructor Call");
        }
    }

    class drived:Base
    {
        public drived():base(5)   // we have to give the value of the paremeter of the base class 
        {                         // using the base keyword in the constructor of the child class
            Console.WriteLine("Drived Constructor Call");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // we create the obj of Drived Class
            drived obj = new drived();
            Console.ReadKey();
        }
    }
}