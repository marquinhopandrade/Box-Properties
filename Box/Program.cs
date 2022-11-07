using System;

namespace Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.SetLength(4);
            box.height = 4;
            box.width = 5;
            Console.WriteLine("Box length is " + box.GetLength());
            box.DisplayInfo();
        }
    }
}
