// See https://aka.ms/new-console-template for more information
var mainThread = Thread.CurrentThread;
Console.WriteLine($"Hello, World! on threadId : {mainThread.ManagedThreadId}, threadName : {mainThread.Name}");

//Thread thread1 = new Thread(new ThreadStart(new DemoPrinter().Print));
//thread1.Start();

//Thread thread2 = new Thread(new ThreadStart(new DemoPrinter().Print));
//thread2.Start();

for (int i = 0; i < 10; i++)
{
    Thread thread = new Thread(new ParameterizedThreadStart(new DemoPrinter().Print));
    // Pass the values to the thread
    thread.Start(i);
}

Console.WriteLine("Done");

public class DemoPrinter
{
    public void Print()
    {
        var thread = Thread.CurrentThread;
        Console.WriteLine($"Hello, World! on threadId : {thread.ManagedThreadId}, threadName : {thread.Name}");
    }

    public void Print(object? value)
    {
        int i = (int)value;
        var thread = Thread.CurrentThread;
        Console.WriteLine($"print {i} on threadId : {thread.ManagedThreadId}, threadName : {thread.Name}");
    }
}