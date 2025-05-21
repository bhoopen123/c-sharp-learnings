// See https://aka.ms/new-console-template for more information
using System.Threading;

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

var t1 = Task.Run(() => ReadValue(10));
var t2 = Task.Run(() => ReadValue(20));
var t3 = Task.Run(() => ReadValue(30));

//Task.WaitAll(t1, t2, t3);
// No need to use WaitAll , as we are using Result property
Console.WriteLine("Sum: {0}", t1.Result + t2.Result + t3.Result);


Console.WriteLine("Done");

static int ReadValue(int input)
{
    Console.WriteLine($"Hello, value = {input} from threadId : {Thread.CurrentThread.ManagedThreadId}, threadName : {Thread.CurrentThread.Name}");

    Console.WriteLine($"Sleep ThreadId : {Thread.CurrentThread.ManagedThreadId}, threadName : {Thread.CurrentThread.Name}");

    Thread.Sleep(1000);
    return input;
}

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