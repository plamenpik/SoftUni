﻿using System;

class Greeting
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");

    }
}
