# What are Generics in C#?
Generics is a concept which helps us to decouple logic from datatype.
Generics are introduced in C# 2.0. 

## Why use Generics over `Object` datatype?
We can declare our method parameters as `Object` datatype, as every type in .NET is directly or indirectly inherit from `System.Object` type, so this will also work. Then what are the limitations or down side of declaring everything as an `Object`.
 - Using `Object` will degrade the performance due to boxing and unboxing.
 - If a method has more then one parameters and all parameters are of type `Object`, then it will not completely type safe because for example one parameter could be of type `int` while other could be of type `string`.

For Example,

```csharp
    class Comparator
    {
        // making the parameters of this method of type Objects, so any type can be used.
        public static bool AreEquals(object value1, object value2)
        {
            return value1 == value2;
        }
    }
```

Its true that `AreEqual` can take any datatype, but this is not type-safe. Use can pass first parameter as `int` and second parameter as `string`.

How, generics can be beneficial in this scenario.

```csharp
    class Comparator
    {
        // using generics
        public static bool AreEquals<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
```

### Definition

 Generics allow you to delay the specification of the datatype of programming elements in a class or a method, until it is actually used in the program.
 In other words, generics allow you to write a class or method that can work with any data type.

 You write the specifications for the class or the method, with substitute parameters for data types.
 When the compiler encounters a constructor for the class or a function call for the method, it generates code to handle the specific data type. 

### Features of Generics

 Generics is a technique that enriches your programs in the following ways:

 - It helps you to maximize code reusability, type safety, and performance.
 - The `.NET Framework` class library contains several new generic collection classes in the `System.Collections`.Generic namespace.
 - You can create generic collection classes and use instead of the collection classes in the `System.Collections` namespace.
 - You can create your own generic interfaces, class, method, event and delegates.
 - You may create generic classes constrained to enable access to methods on particular data types.
 - You may get information on the types used in a generic data type at run-time by means of reflection.


## References
[msdn](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/)

TODO:
 * [Constraints on type parameters](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters)
 * `in`, `out` keyword in generics type parameters.
 * Generics Class
 * Generics Interface
 * Generics Methods
 * Generics Delegate
