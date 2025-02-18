﻿using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _5_ConstantReadonlyStatic
{
    class Program
    {
        //Constant fields or local variables must be assigned a value at the time of declaration 
        //and after that they cannot be modified. 
        public const int CONSTInt = 10;
        // const int con; // this will be a compile time error.
        //By default constant are static, hence you cannot define a constant type as static.
        //As below
        //public static const string StaticCONSTInt = "55";
        
        //A const field is a compile-time constant. 
        //A constant field or local variable can be initialized with a constant expression 
        //which must be fully evaluated at compile time.
        void Calculate(int Z)
        {
            const int X = 10, X1 = 50;
            const int Y = X + X1; //no error, since its evaluated a compile time
            //const int Y1 = X + Z; //gives error, since its evaluated at run time
        }

        //You can apply const keyword to built-in value types 
        //(byte, short, int, long, char, float, double, decimal, bool), enum, a string literal, or a reference type 
        //which can be assigned with a value null.
        const MyClass obj1 = null;//no error, since its evaluated a compile time
        //const MyClass obj2 = new MyClass();//gives error, since its evaluated at run time
        
        //Constants can be marked as public, private, protected, internal, or protected internal access modifiers.
        //Use the const modifier when you sure that the value a field or local variable would not be changed.
        
        static void Main(string[] args)
        {
        }
    }

    public class MyClass
    {
        //A readonly field can be initialized either at the time of declaration or with in the constructor of same class. 
        //Therefore, readonly fields can be used for run-time constants.
       
        readonly int X = 10; // initialized at the time of declaration
        readonly int X1;

        public MyClass(int x1)
        {
            X1 = x1; // initialized at run time
        }

        //Explicitly, you can specify a readonly field as static since, like constant by default it is not static. 
        //Readonly keyword can be apply to value type and reference type (which initialized by using the new keyword) both. 
        //Also, delegate and event could not be readonly.
        //Use the readonly modifier when you want to make a field constant at run time.



        //The static keyword is used to specify a static member, which means static members are common to all the objects 
        //and they do not tied to a specific object. 
        //This keyword can be used with classes, fields, methods, properties, operators, events, and constructors, 
        //but it cannot be used with indexers, destructors, or types other than classes.

        static int staticX = 10;
        int Y = 20;
        public static void Show()
        {
            Console.WriteLine(staticX);
            //Console.WriteLine(Y); //error, since you can access only static members
        }

        //If the static keyword is applied to a class, all the members of the class must be static.
        //Static methods can only access static members of same class. Static properties are used to get or set the value of static fields of a class.
        //Static constructor can't be parameterized and public. Static constructor is always a private default constructor which is used to initialize static fields of the class.
    }
}
