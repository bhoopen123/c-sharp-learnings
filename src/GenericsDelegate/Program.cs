using System;

namespace GenericsDelegate
{
    // You can define a generic delegate with type parameters. For example:

    delegate T NumberChanger<T>(T num);

    class Program
    {

        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }


        static void Main(string[] args)
        {

            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
            //calling the methods using the delegate objects
            //nc1(25);

            Console.WriteLine("Value of Num: {0} Called AddNum", nc1(25).ToString());
            //nc2(5);

            Console.WriteLine("Value of Num: {0} Called MultNum", nc2(5).ToString());
            Console.ReadKey();
        }
    }
}
