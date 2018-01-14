using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class PrimeFinder
    {
        static void Main(string[] args)
        {
            string no = Console.ReadLine(); // input numbers from user
            args = no.Split(' ');           // split numbers
            foreach (string s in args)           // checking each element separately
            {
                int x = int.Parse(s);            // converting to integer
                bool Prime = true;               // creating boolean (originally true one)
                for (int i = 2; i * i <= x; i++) // sorting out the numbers from 2 to square root of x

                {
                    if (x % i == 0)                   // if the number is divided without a remainder
                    {
                        Prime = false;           // then it's false (not prime)
                        break;                   // finishing the cycle
                    }
                }
                if (Prime == true)                // if total of prime is true
                {
                    Console.WriteLine(x + " is a prime number"); // writing that number and 'is prime number' sign
                    Console.ReadKey();
                }
            }
        }
    }
}
