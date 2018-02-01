using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    class Circle
    {
        public double radius;
        public double area;
        public double perimeter;
        public double diameter;
        public const double pi = 3.14159;

        public Circle()
        {
            radius = 5;
        }

        public void findArea()
        {
            area = pi * radius * radius;
        }

        public void findPerimeter()
        {
            perimeter = 2 * pi * radius;
        }

        public void findDiameter()
        {
            diameter = 2 * radius;
        }

        public override string ToString()
        {
            return radius + "\n" + area + "\n" + perimeter + "\n" + diameter;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Circle r = new Circle();
                r.findArea();
                r.findDiameter();
                r.findPerimeter();

                Console.WriteLine(r);

            }
        }
    }
}