using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] info = input.Split().ToArray();
                string serialNumber = info[0];
                string name = info[1];
                int quantity = int.Parse(info[2]);
                double price = double.Parse(info[3]);
                double boxPrice = quantity * price;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.ItemName = name;
                box.ItemQuantity = quantity;
                box.ItemPrice = price;
                box.BoxPrice = boxPrice;
                
                boxes.Add(box);
            }

            List<Box> ordered = boxes.OrderByDescending(x => x.BoxPrice).ToList();
            
            foreach (Box b in ordered)
            {
                Console.WriteLine($"{b.SerialNumber}");
                Console.WriteLine($"-- {b.ItemName} - ${b.ItemPrice:f2}: {b.ItemQuantity}");
                Console.WriteLine($"-- ${b.BoxPrice:f2}");
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        public class Box 
        {
            public string SerialNumber { get; set; }
            public string ItemName{ get; set; }
            public int ItemQuantity { get; set; }
            public double ItemPrice { get; set; }
            public double BoxPrice { get; set; }
        }
    }
}