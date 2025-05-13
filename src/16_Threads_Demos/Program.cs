// See https://aka.ms/new-console-template for more information
var mainThread = Thread.CurrentThread;
Console.WriteLine($"Hello, World! on threadId : {mainThread.ManagedThreadId}, threadName : {mainThread.Name}");
