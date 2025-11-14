// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, params demo!");
        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#params-modifier

        //int[] arr = {25,12,45,13};      // this is the way by which we can pass the array to the method 
        //ParamFun(arr);                  // but we want to pass these values to the method parametres directly, and not as an array
        // that can be done by using the PARAMS keyword in the Function

        // using PARAMS keyword
        ParamFun("firstStringValue", 36, 25, 01, 45, 58);       // as many parametres as we can pass while callling the Function
                                                                // but all the parametre type must be same..


        // No other parameters are permitted after the "params" keyword in a method declaration, and only one "params" keyword is permitted in a method declaration.
        // When you call a method with a params parameter, you can pass in:
        // A comma-separated list of arguments of the type of the array elements.
        FirstParamsDemo(1, 2, 3, 4);
        ParamsModifierObjectExample(1, 'a', "test");


        // Can be called as, A collection of arguments of the specified type
        int[] arr = { 10, 20, 30, 40, 50 };
        FirstParamsDemo(arr);      // this is also valid way to call the method with params keyword

        object[] myObjArray = { 2, 'b', "test", "again" };
        ParamsModifierObjectExample(myObjArray);

        // If you send no arguments, the length of the params list is zero.
        FirstParamsDemo();

        // to call the funtion with out parameter 
        int Sum, Diff, Mult;
        OutParaFun(25, 5, out Sum, out Diff, out Mult);

        Console.WriteLine($"Input are 25 and 5");
        Console.WriteLine($"Sum = {Sum}, Diff = {Diff}, Mult = {Mult}");

        Console.Read();
    }


    public static void OutParaFun(int num1, int num2, out int sum, out int diff, out int mult)
    {
        sum = num1 + num2;
        diff = num1 - num2;
        mult = num1 * num2;
    }

    static void FirstParamsDemo(params int[] values)
    {
        Console.WriteLine($"Called {nameof(FirstParamsDemo)} with values");

        foreach (int i in values)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
    }

    public static void ParamsModifierObjectExample(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            System.Console.Write(list[i] + " ");
        }
        System.Console.WriteLine();
    }

    public static void ParamFun(string Strfirst, int first, params int[] arr)     // we use PARAMS // if we want to access a specific parameter value then 
    {                                                           // put the parameter before Param keyword 
        int sum = 0;
        foreach (int ar in arr)
        {
            sum = sum + ar;
        }
        Console.WriteLine("Sum of the Numbers = " + sum.ToString() + " And the first value is " + first.ToString());
    }
}
