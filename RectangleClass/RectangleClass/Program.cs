using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    class Rectangle
    {
        public int width;
        public int height;
        public int area;
        public int perimeter;

        public Rectangle()
        {
            width = 4;
            height = 5;
        }

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public Rectangle(int h)
        {
            width = 10;
            height = h;
        }

        public void findArea()
        {
            area = width * height;
        }

        public void findPerimeter()
        {
            perimeter = (width + height) * 2;
        }

        public override string ToString()
        {
            return width + " " + height + " " + area + " " + perimeter;
        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.findArea();
            r.findPerimeter();

            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}