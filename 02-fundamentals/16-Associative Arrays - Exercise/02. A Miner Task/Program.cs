﻿using System;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
            }
            
            foreach (var r in resources)
            {
                Console.WriteLine($"{r.Key} -> {r.Value}");
            }
        }
    }
    
}