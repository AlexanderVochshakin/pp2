using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"C:\Test\RandomNums.txt", FileMode.Open);
            StreamReader read = new StreamReader(input);

            string[] nums = read.ReadLine().Split(' ');
            int[] primes = new int[nums.Length];
            int g = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int n = int.Parse(nums[i]);
                if (IsPrime(n))
                {
                    primes[g] = n;
                    g++;
                }
            }

            int minPrime = primes[0];

            for (int i = 1; i < g; i++)
            {
                if (primes[i] < minPrime)
                    minPrime = primes[i];
            }
            Console.WriteLine(minPrime);
            Console.ReadKey();
        }
    }
}
