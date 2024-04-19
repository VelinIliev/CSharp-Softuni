using System;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            
            string[] input = Console.ReadLine().Split();

            foreach (string word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, word.Length);
                }
            }

            foreach (var word in words)
            {
                if (word.Value % 2 == 0)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }
    }
}