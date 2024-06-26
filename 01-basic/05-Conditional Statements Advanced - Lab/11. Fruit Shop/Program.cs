﻿using System.Diagnostics;

string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;

if (day == "Saturday" || day == "Sunday")
{   
    switch (fruit) 
    {
        case "banana":
            price = 2.7;
            break;
        case "apple":
            price = 1.25;
            break;        
        case "orange":
            price = .90;
            break;        
        case "grapefruit":
            price = 1.60;
            break;       
        case "kiwi":
            price = 3.00;
            break;        
        case "pineapple":
            price = 5.60;
            break;       
        case "grapes":
            price = 4.20;
            break;
    }
}
else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
{
    switch (fruit) 
    {
        case "banana":
            price = 2.5;
            break;
        case "apple":
            price = 1.2;
            break;        
        case "orange":
            price = .85;
            break;        
        case "grapefruit":
            price = 1.45;
            break;       
        case "kiwi":
            price = 2.7;
            break;        
        case "pineapple":
            price = 5.5;
            break;       
        case "grapes":
            price = 3.85;
            break;
    }
}

if (price != 0)
{
    Console.WriteLine((price * quantity).ToString("0.00"));
}
else
{
    Console.WriteLine("error");
}