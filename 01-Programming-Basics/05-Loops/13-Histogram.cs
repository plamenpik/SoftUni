﻿using System;

class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double p1 = 0.0;
        double p2 = 0.0;
        double p3 = 0.0;
        double p4 = 0.0;
        double p5 = 0.0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num < 200)
            {
                p1 += 1.0;
            }
            else if (num >= 200 && num < 400)
            {
                p2 += 1.0;
            }
            else if (num >= 400 && num < 600)
            {
                p3 += 1.0;
            }
            else if (num >= 600 && num < 800)
            {
                p4 += 1.0;
            }
            else
            {
                p5 += 1.0;
            }
        }
        Console.WriteLine(Math.Round(p1 / n * 100, 2) + "%");
        Console.WriteLine(Math.Round(p2 / n * 100, 2) + "%");
        Console.WriteLine(Math.Round(p3 / n * 100, 2) + "%");
        Console.WriteLine(Math.Round(p4 / n * 100, 2) + "%");
        Console.WriteLine(Math.Round(p5 / n * 100, 2) + "%");
    }
}
