using System;

namespace UseOfConsoleClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // Set or Get the Height/Width of the console Buffer area,
            Console.BufferHeight = 5000;
            Console.BufferWidth = 500;

            //Set or Get the Background Color and ForeGround Color of the console
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //this method clears the Buffer and the Console display area..
            Console.Clear();
            Console.WriteLine("Console.BufferHeight :{0} ", Console.BufferHeight);
            Console.WriteLine("Console.BufferWidth :{0} ", Console.BufferWidth);

            //this property sets or gets the title of the display.
            Console.Title = "Bhoopendra";

            //these properties controls the dimensions of the console in relation to the established buffer.
            Console.WindowHeight = 50;
            Console.WindowWidth = 50;
            Console.WriteLine("Console.Backcolor :{0} ", Console.BackgroundColor);
            Console.WriteLine("Console.Title :{0} ", Console.Title);
            Console.WriteLine("Console.WindowHeight :{0} ", Console.WindowHeight);
            Console.WriteLine("Console.WindowWidth :{0} ", Console.WindowWidth);

            Console.WindowTop = 10;                             // points the cursor at the 10th position from the top
            Console.WindowLeft = 100;                           // points the cursor at the 100th position from the left of the window.
            Console.WriteLine("Console.WindowTop :{0} ", Console.WindowTop);

            Console.WriteLine("Console.WindowLeft :{0} ", Console.WindowLeft);

            Console.ReadLine();

        }
    }
}
