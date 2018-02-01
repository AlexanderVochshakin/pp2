using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin_NO
{
    class Program
    {
        static int Mini(List<string> a)
        {
            int min = int.Parse(a[0]);
            foreach (string s in a)
            {

                int temp = int.Parse(s);
                if (temp < min)
                    min = temp;
            }
            return min;
        }

        static int Maxi(List<string> a)
        {
            int max = int.Parse(a[0]);
            foreach (string s in a)
            {

                int temp = int.Parse(s);
                if (temp > max)
                    max = temp;
            }
            return max;
        }


        static void FindMinMax()
        {
            FileStream file = new FileStream(@"C:\Users\tleusher\Desktop\Git_Juxtapose\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader num = new StreamReader(file);

            List<string> array = num.ReadLine().Split().ToList();

            Console.WriteLine("the minimum in the file is {0}", Mini(array));
            Console.WriteLine("the minimum in the file is {0}", Maxi(array));

            num.Close();
            file.Close();

        }

        static void Main(string[] args)
        {

            FindMinMax();

            Console.ReadKey();

        }
    }
}