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


## Constraints in Generics

Force a type parameter to have certain characteristics, for example, we can force it to,
 - be a reference type or value type
 - to implement an interface
 - be derived from a base class
 - have a default constructor
 - be (or derived from) another generic type parameter

All of these constraints can be applied using `where` keyword in generics, for example,

```csharp
    // this restricts that only reference types can be assigned while defining actual type against `T`
    interface IBuffer<T> where T: class
    {
        // data member and member function declaration here
    }
```

```csharp
    // this restricts that only reference which implements `IItem` interface can be assigned while defining actual type against `T`
    interface IBuffer<T> where T: IItem
    {
        // data member and member function declaration here
    }
```

```csharp
    // this restricts that only reference types having a default constructor can be assigned while defining actual type against `T`
    interface IBuffer<T> where T: new()
    {
        // data member and member function declaration here
    }
```
 > *_Note:_* 
 > * By default you can’t create an instance of a generic `T` using `new` keyword, i.e. `T instance = new T();` is invalid by default. To achieve this, you need to apply `new()` constraint in the generic.
 > * `new()` should be the last keyword to use in generics constraints. `new()` constraints tells that the generic type should have a default constructor.

```csharp
    // multiple generic types with multiple constraints
    interface IBuffer<T1, T2> where T1: new(), where T2: class, IItem
    {
        // data member and member function declaration here
    }
```
 
 > *_Note:_*
 > * When applying multiple constraints on a generic type `class` constraint should be first.
 > * `struct` and `class` both can’t be the type constraint type for a generic.


## References
 * [msdn](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/)
 * [Constraints on type parameters](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters)
  
TODO:

 * `in`, `out` keyword in generics type parameters.
 * Generics Class
 * Generics Interface
 * Generics Methods
 * Generics Delegate
