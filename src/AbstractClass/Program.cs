using System;

namespace AbstractClass
{
    public abstract class Abs
    {
        // you can also create the constructor of an ABSTRUCT class
        // when Instance of drived class has been created, this constructor will get called.
        public Abs()
        {
            Console.WriteLine("\n Abstract class Constructor Call");
        }

        public void PublicMethod()  // Simple Public Method of the Abstract Class 
        {
            Console.WriteLine("Public Method of AbsTract Class");
        }

        // you can also make private method in an abstruct class 
        // but the method should have complete body with it, means it should have been defined as well.
        private void PrivateMethod()
        {
            Console.WriteLine("private method of abstract class");
        }

        //abstract void PrivateAbstractMethod()         // An abstract method cannot be Private in abstract class
        //{

        //}

        //public abstract void PublicAbstractMethod()
        //{
        //    Console.WriteLine("Public abstract method Call");   // if u give body of an abstract method then Error will occur
        //}
       
        public abstract void absPubMethod();

       // abstract void absPrivateMethod();           // virtual and abstract method cannot be private

        public virtual void virtualMethod()
        {
            Console.WriteLine("Virtual method of abstract class");
        }
    }

    class Drived : Abs
    {
        public override void absPubMethod()
        {
            Console.WriteLine("Public OVERRIDDEN method of abstract class");
        }
        //public override void absPrivateMethod(      // we must use override keyword when there is virtual or abstract method is 
        //{                                           // declared in parent class.
        //    Console.WriteLine("");
        //}
    }

    // Abstract Class without having 'abstact' or 'Virtual' method
    // It may possible that a Abstract class may have all Non-Abstract Methods.
    public abstract class myAbsClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("Public Metod in Abstract Class");
        }
    }

    // Program Class for Implementation
    class Program
    {
        static void Main(string[] args)
        {
            Drived obj = new Drived();
            obj.PublicMethod();

            Abs obj_abs = new Drived();
            obj_abs.PublicMethod();

            obj_abs.absPubMethod();
            Console.Read();
        }
    }
}
