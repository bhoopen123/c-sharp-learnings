using System;

namespace Destructors_Example
{

    class A
    {
        public A()
        {
            Console.WriteLine("Creating A");
        }
        ~A()
        {
            Console.WriteLine("Destroying A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("Creating B");
        }
        ~B()
        {
            Console.WriteLine("Destroying B");
        }

    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("Creating C");
        }

        ~C()
        {
            Console.WriteLine("Destroying C");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Console.WriteLine("Object Created ");
            Console.WriteLine("Press enter to Destroy it");
            //Console.ReadLine();
            // we set the object of class C to null. But the destructors are not executing ..!!?? 
            // As we already said, the programmer has no control on when the destructor is going to be executed because 
            // the Garbage Collector determines this. But the destructors are called when the program exits.
            c = null;
            //GC.Collect();
            Console.Read();

            // So, what do you do if you want to call the destructors once you are finished using the object?
            // 1- Call the Garbage collector to clean up.
            // 2- Implement Dispose method of IDisposable interface.

            // 1- You can force the garbage collector to do clean up by calling the GC.Collect method, but in most cases, 
               //this should be avoided because it may result in performance issues.
            // 2- The IDisposable interface contains only one public method with signature void Dispose(). 
               //We can implement this method to close or release unmanaged resources such as files, streams, 
               //and handles held by an instance of the class that implements this interface. 
               //This method is used for all tasks associated with freeing resources held by an object. 
               //When implementing this method, objects must seek to ensure that all held resources are freed by propagating 
               //the call through the containment hierarchy. 

            // When we implement IDisposable interface, we require discipline to ensure that Dispose is called properly.

            #region using keyword to free memory

            //Even though we have spent some time implementing the IDisposable interface, what if the client doesn’t call them properly? 
            //C# has a cool solution for this. The ‘using’ block. It looks like this:

            using (MyClass objCls = new MyClass())
            {

            }

            // When the control exits from the using block either by running successfully and reaching the closing braces or by 
            //throwing an exception, the IDispose.Dispose() of MyClass will be executed. Remember the object you instantiate must 
            //implement the System.IDisposable interface. The using statement defines a scope at the end of which an object will be disposed.
            
            #endregion
        }
    }

    #region Destructor and IDisposable interface together
    public class MyClass : IDisposable
    {
        private bool IsDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool Diposing)
        {
            if (!IsDisposed)
            {
                if (Diposing)
                {
                    //Clean Up managed resources
                }
                //Clean up unmanaged resources
            }
            IsDisposed = true;
        }
        ~MyClass()
        {
            Dispose(false);
        }
    }

    //Here the overload of Dispose(bool) does the cleaning up, and all the cleaning up code is written only in this method. 
    //This method is called by both the destructor and the IDisposable.Dispose(). 
    //We should take care that the Dispose(bool) is not called from any where else except from the IDisposable.Dispose() 
    //and the destructor.
    //When a client calls IDisposable.Dispose(), then the client deliberately wants to clean up the managed and unmanaged 
    //resource, and so the cleaning up is done. One thing you must have noticed is that we called GC.SupressFinalize(this) 
    //immediately after we cleaned up the resource. This method tells the Garbage Collector that there is no need to call 
    //its destructor because we have already done the clean up.
    //Notice that in the above example, the destructor calls the Dispose with parameter as false. Here, we are ensuring that the 
    //Garbage collector collects the managed resources. We only do the cleaning up of unmanaged resource.
    #endregion 


    //In order to produce high performance scalable applications, 
    //it is important to use your resources in an optimized manner. 
    //One tip is that use your resource as late as you can and free it at the earliest after your use. 
    //My intention here is to describe the object cleaning up mechanism used in C#.


    // ‘Destructors’ are used to destruct instances of classes. When we are using destructors in C#, 
    // we have to keep in mind the following things:
    // Destructors cannot be defined in structs. They are only used with classes.
    // A class can only have one destructor.
    // Destructors cannot be inherited or overloaded.
    // Destructors cannot be called. They are invoked automatically.
    // A destructor does not take modifiers or have parameters.

    public class Car
    {
        ~Car()  // destructor
        {
            // cleanup statements...
        }
    }

    // The programmer has no control over when the destructor is called because this is determined by the garbage collector. 
    // The garbage collector checks for objects that are no longer being used by the application. 
    // If it considers an object eligible for destruction, it calls the destructor (if any) and reclaims the memory used to store the object. 
    // Destructors are also called when the program exits.

    // When a destructor executes what is happening behind the scenes is that the destructor implicitly calls 
    // the Object.Finalize method on the object's base class. 
    // Therefore, the preceding destructor code is implicitly translated to:
        //protected override void Finalize()
        //{
        //   try
        //   {
        //      // Cleaning up .
        //   }
        //   finally
        //   {
        //      base.Finalize();
        //   }
        //}




}
