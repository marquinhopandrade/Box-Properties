using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    internal class Box
    {
        private int length = 3;
        private int height;
       // public int width;
        public int volume;


        public int Width { get; set; }

        //public int width
        //{
        //    get
        //    {
        //        return this.width;
        //    }
        //    set
        //    {
        //        this.width = value;
        //    }
        //}
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
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
        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Box length is {0}, height is {1} and width is {2}, so volume is: {3} ",this.length, this.height, this.Width,GetVolume());
        }
    }
}
