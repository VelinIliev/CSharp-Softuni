using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charsCounter = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char x in input)
            {
                if (x != ' ')
                {
                    if (charsCounter.ContainsKey(x))
                    {
                        charsCounter[x]++;
                    }
                    else
                    {
                        charsCounter.Add(x, 1);
                    }
                }
            }

            foreach (var x in charsCounter)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
    
}