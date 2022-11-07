using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    internal class Box
    {
        public int length = 3;
        public int height;
        public int width;
        public int volume;

        public int GetLength()
        {
            return this.length;
        }
        public void SetLength(int length)
        {
            //this.length refere-se ao length da classe, e não ao parâmetro da função
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }
        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Box length is {0}, height is {1} and width is {2}, so volume is: {3} ",this.length, this.height, this.width,GetVolume());
        }
    }
}
