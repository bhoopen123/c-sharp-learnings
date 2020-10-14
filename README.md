# C# Learnings
Documented items of what I have learned related to C#

### [Yield Keyword](/docs/YieldDemos.md)

### [Generics](/docs/Generics.md)

### `Task.Wait` vs `await`
		
An [`await`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/await) expression does not block the thread on which it is executing. Instead, it causes the compiler to sign up the rest of the `async` method as a continuation on the awaited task. Control then returns to the caller of the `async` method. When the task completes, it invokes its continuation, and execution of the `async` method resumes where it left off.

To wait for a single [task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task?view=netframework-4.7.2#WaitingForOne) to complete, you can call its `Task.Wait` method. A call to the Wait method blocks the calling thread until the single class instance has completed execution. The parameterless Wait() method is used to wait unconditionally until a task completes. The task simulates work by calling the `Thread.Sleep` method to sleep for two seconds, [source](https://stackoverflow.com/questions/13140523/await-vs-task-wait-deadlock).

### `Task.Run()` vs `Task.Factory.StartNew()`

`Task.Run` is actually implemented in terms of the same logic used for Task.Factory.StartNew, just passing in some default parameters.

So, `Task.Run(someAction);` is exactly equivalent to: 

`Task.Factory.StartNew(someAction, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);`

