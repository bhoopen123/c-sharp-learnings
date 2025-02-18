using System;

namespace UseOfEnvironmentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current OS : {0} ",Environment.OSVersion);

            Console.WriteLine("Current Directory : {0}",Environment.CurrentDirectory);

            string[] drives = Environment.GetLogicalDrives();
            for (int i = 0; i < drives.Length;i++ )
            {
                Console.WriteLine("Drive {0} : {1}",i,drives[i]);
            }

            Console.WriteLine("Executing Version of .NET: {0}",Environment.Version);

            Console.WriteLine("Machine Name: {0}",Environment.MachineName);

            Console.WriteLine("Processsor Count; {0}",Environment.ProcessorCount);

            Console.WriteLine("System Directory : {0}",Environment.SystemDirectory);

            Console.WriteLine("UserName : {0}",Environment.UserName);

            Console.ReadKey();

        }
    }
}
