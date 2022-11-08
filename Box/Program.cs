using System;

namespace Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(4);
            box.Height = -4;
            box.Width = 5;
            Console.WriteLine("Box volume is:  " + box.GetVolume());
            box.DisplayInfo();
        }
    }
}
