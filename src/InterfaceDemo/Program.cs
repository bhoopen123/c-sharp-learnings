using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDemo
{

    public interface IBase1
    {
        // int i;                            // interface cannot have datamembers..
        // Because variables and fields are the implementation. 
        // Interfaces are contracts that declare what they do, not how they do it.
        // Interfaces are intended to describe behavior, not implementation.
        // If you want to declare fields, then you need to create a base (possibly abstract) class.
       
        void IMethod1();
        int data { get; set; }            // we can declare a property in Interface, but cannot define it.
    }

    public interface IBase2
    {
        void Imethod2();
    }

    public class Class1 : IBase1, IBase2
    {
        void IBase1.IMethod1()                  // giving the body to the method explicitly to that interface
        {
            Console.WriteLine("IBase1 Interface Method1");
        }

        void IBase2.Imethod2()
        {
            Console.WriteLine("IBase2 Interface Method2");
            // Console.WriteLine(sizeof().ToString());
        }


        public int data
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating the object of the class\n");

            Class1 obj = new Class1();

            Console.WriteLine("call the method of the Interface that has Implemented explicitly");
            ((IBase1)obj).IMethod1();       // If we give the body of the method explicitly then to call that method we hae to type caste the
                                            // object with that interface, then only we can access that method of that interface
            // another way to call the method of interface that has implemented explicitly in the class

            Console.WriteLine("\n  another way to call the method of Explicitly implemented Interface");
            IBase2 Iobj;
            Iobj = obj;
            Iobj.Imethod2();


            Int64 shortInt;
            shortInt = 10000000000000;
            object oo = shortInt;
            Int64 i = (Int16)shortInt;
            Console.WriteLine(i);

        }
    }


}
