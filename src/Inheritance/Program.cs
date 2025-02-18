using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }
    }
}
