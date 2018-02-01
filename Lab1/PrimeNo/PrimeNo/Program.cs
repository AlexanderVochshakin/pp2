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
            string no = Console.ReadLine(); 
            args = no.Split(' ');        
            foreach (string s in args)           
            {
                int x = int.Parse(s);           
                bool Prime = true;               
                for (int i = 2; i * i <= x; i++) 

                {
                    if (x % i == 0)    
                    {
                        Prime = false;     
                        break;
                    }
                }
                if (Prime == true)               
                {
                    Console.WriteLine(x + " is a prime number"); 
                    Console.ReadKey();
                }
            }
        }
    }
}
