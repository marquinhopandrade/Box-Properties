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
        public int height;
        public int width;
        public int volume;

        public int GetLength()
        {
            return this.length;
        }
        private void SetLength(int length)
        {
            //this.length refere-se ao length da classe, e não ao parâmetro da função
            this.length = length;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("The box volume is: {0}",volume = length * height * width);
        }
    }
}
