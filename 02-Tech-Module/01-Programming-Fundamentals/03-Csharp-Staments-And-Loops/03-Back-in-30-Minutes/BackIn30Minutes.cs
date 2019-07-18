﻿using System;

class BackIn30Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;

        if (minutes > 59)
        {
            minutes -= 60;
            hours++;
        }
        if (hours > 23)
        {
            hours = 0;
        }

        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}
