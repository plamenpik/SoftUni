﻿using System;

class SmallShop
{
    static void Main(string[] args)
    {

        string product = Console.ReadLine().ToLower();
        string city = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        if (city == "sofia")
        {
            if (product == "coffee")
            {
                Console.WriteLine(quantity * 0.50);
            }
            else if (product == "water")
            {
                Console.WriteLine(quantity * 0.80);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quantity * 1.20);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.45);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.60);
            }
        }

        if (city == "plovdiv")
        {
            if (product == "coffee")
            {
                Console.WriteLine(quantity * 0.40);
            }
            else if (product == "water")
            {
                Console.WriteLine(quantity * 0.70);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quantity * 1.15);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.30);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.50);
            }
        }

        if (city == "varna")
        {
            if (product == "coffee")
            {
                Console.WriteLine(quantity * 0.45);
            }
            else if (product == "water")
            {
                Console.WriteLine(quantity * 0.70);
            }
            else if (product == "beer")
            {
                Console.WriteLine(quantity * 1.10);
            }
            else if (product == "sweets")
            {
                Console.WriteLine(quantity * 1.35);
            }
            else if (product == "peanuts")
            {
                Console.WriteLine(quantity * 1.55);
            }
        }
    }
}
