using System;

namespace Inheritance
{
    class Base1
    {
        public Base1(int b)
        {
            Console.WriteLine("Base class Constructor");
            FunBase();
        }

        public void baseMethod()
        {
            Console.WriteLine("Base Method call");

        }

        public virtual void FunBase()
        {
            Console.WriteLine("Base Class FunBase");

        }
    }

    class Derived : Base1
    {
        public Derived(int d) : base(25)
        {
            Console.WriteLine("Derived Class Constructor");
            FunBase();
        }

        public void baseMethod(int a)
        {
            Console.WriteLine("Child Method call");
        }

        public override void FunBase()
        {
            Console.WriteLine("Child Class FunBase");
        }
    }


    class ClassA
    {
        public virtual void Print()
        {
            Console.WriteLine("ClassA");
        }
    }

    class ClassB : ClassA
    {
        public override void Print()
        {
            Console.WriteLine("ClassB");
        }
    }

    class ClassC : ClassB
    {
        public new void Print()
        {
            Console.WriteLine("ClassC");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassB a = new ClassC();
            a.Print();

            Derived d1 = new Derived(20);

            //string myConnection = "";

            //using (myConnection)
            //{

            //}

            //d1.baseMethod(5);

            //Base1 b1=new Base1(2);
            //d1.FunBase();
            //b1.FunBase();

            Console.Read();

            // we create the obj of Drived Class
            drived obj = new drived();
            Console.ReadKey();
        }
    }


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

    class drived : Base
    {
        public drived() : base(5)   // we have to give the value of the paremeter of the base class 
        {                         // using the base keyword in the constructor of the child class
            Console.WriteLine("Drived Constructor Call");
        }
    }
}
