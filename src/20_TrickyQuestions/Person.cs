// See https://aka.ms/new-console-template for more information
public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    //When calling overloaded methods, a cast must be used. Consider, for example, 
    //The following overloaded methods that use byte and int parameters:
    public static void SampleMethod(int i)
    {
        Console.WriteLine("int i ");
    }

    public static void SampleMethod(byte b)
    {
        Console.WriteLine("byte i ");
    }
}
