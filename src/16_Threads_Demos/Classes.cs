namespace _16_Threads_Demos
{
    public class Adder
    {
        Counter _counter;
        public Adder(Counter counter)
        {
            _counter = counter;
        }

        public void Run()
        {
            for (int i = 0; i < 50000; i++)
            {
                _counter.Value += i;

                //Console.WriteLine($"ThreadId : {Thread.CurrentThread.ManagedThreadId}, Hash : {_counter.GetHashCode()}, InitialValue : {_counter.Value}");
                //Thread.Sleep(100); // Simulate some delay
            }
            //return initialValue.Value;
        }
    }

    public class Subtractor
    {
        Counter _counter;

        public Subtractor(Counter counter)
        {
            _counter = counter;
        }

        public void Run()
        {
            for (int i = 0; i < 50000; i++)
            {
                _counter.Value -= i;

                //Console.WriteLine($"ThreadId : {Thread.CurrentThread.ManagedThreadId}, Hash : {_counter.GetHashCode()}, InitialValue : {_counter.Value}");
                //Thread.Sleep(100); // Simulate some delay
            }
            //return _counter.Value;
        }
    }

    public class Counter
    {
        public int Value { get; set; }
    }
}
