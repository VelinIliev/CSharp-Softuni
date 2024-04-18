using System;
using System.Linq;

namespace RandomzeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            var random = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                int rnd = random.Next(0, input.Count);
                (input[i], input[rnd]) = (input[rnd], input[i]);
            }
            Console.WriteLine(string.Join("\n", input));
        }
    }
}

