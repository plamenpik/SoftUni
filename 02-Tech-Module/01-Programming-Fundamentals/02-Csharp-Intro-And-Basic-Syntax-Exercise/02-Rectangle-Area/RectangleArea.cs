﻿using System;

class RectangleArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double area = a * b;

        Console.WriteLine($"{area:F2}");
    }
}
