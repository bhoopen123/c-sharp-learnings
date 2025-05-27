namespace _16_Threads_Demos
{
    public class Adder
    {
        Counter _counter;
        Mutex? _mutex; // Declare _mutex as nullable
        public Adder(Counter counter, Mutex? mutex = null)
        {
            _counter = counter;
            _mutex = mutex; // Assign the nullable mutex directly
        }

        public void Run()
        {

            for (int i = 0; i < 500000; i++)
            {
                _mutex?.WaitOne(); // Acquire the mutex lock
                _counter.Value += i;
                _mutex?.ReleaseMutex(); // Release the mutex lock
            }

        }
    }

    public class Subtractor
    {
        Counter _counter;
        Mutex? _mutex; // Declare _mutex as nullable
        public Subtractor(Counter counter, Mutex? mutex = null)
        {
            _counter = counter;
            _mutex = mutex; // Assign the nullable mutex directly
        }

        public void Run()
        {
            for (int i = 0; i < 500000; i++)
            {
                _mutex?.WaitOne(); // Acquire the mutex lock
                _counter.Value -= i;
                _mutex?.ReleaseMutex(); // Release the mutex lock
            }
        }
    }

    public class Counter
    {
        public int Value { get; set; }
    }
}
