using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] info = input.Split();
                string product = info[0];
                double price = double.Parse(info[1]);
                double quantity = double.Parse(info[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new double[2]);
                    // products[product][1] = 0;
                }

                products[product][0] = price;
                products[product][1] += quantity;
                
            }

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Key} -> {p.Value[0] * p.Value[1]:f2}");
            }
        }
    }
    
}