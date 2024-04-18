using System.Numerics;
using System;
using System.Linq;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            BigInteger result = 1;
            
            for(int i = n; i > 0; i--) 
                result *= i; 
            Console.WriteLine(result);
        }   
    }
}


