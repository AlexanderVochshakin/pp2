using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_example
{
    class Complex
    {
        public int a, b;

        public Complex(int a = 1, int b = 1)
        {
            this.a = a;
            this.b = b;
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return (GCD(b, a % b));
        }
        public static Complex operator +(Complex x, Complex y)
        {
            Complex temp = new Complex();
            temp.b = x.b * y.b;
            temp.a = y.b * x.a + y.a * x.b;

            int div = GCD(temp.a, temp.b);
            temp.a /= div;
            temp.b /= div;

            return temp;
        }
        public override string ToString()
        {
            return String.Format("{0}/{1}", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex x_1 = new Complex(4, 8);
            Complex x_2 = new Complex(2, 256);
            Console.WriteLine(x_1 + x_2);
            Console.ReadKey();
        }
    }
}