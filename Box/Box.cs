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
       private int width;
       private int volume;


        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }
        /*Usar essas quando não houver necessidade de adicionar uma lógica à função, apenas o set e o get*/
        //public int Width { get; set; }
        //public int Length { get; set; }
        //public int Height { get; set; }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
            set
            {
                this.volume = value;
            }
        }

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
                    this.height = -value;
                }
                else
                {
                    this.height = value;
                }
            }
        }
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (length < 0)
                {
                    throw new Exception("Length should be higher than 0");
                }
                this.length = value;
            }
        }
        /*public void SetLength(int length)
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
        }*/
        public void DisplayInfo()
        {
            Console.WriteLine("Box length is {0}, height is {1} and width is {2}, so volume is: {3} ",this.length, this.height, this.Width, this.length * this.height * this.Width);
        }
    }
}
