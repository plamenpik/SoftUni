﻿using System;

class PassedOrFailed
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
        else if (grade < 3.00)
        {
            Console.WriteLine("Failed!");
        }
    }
}
