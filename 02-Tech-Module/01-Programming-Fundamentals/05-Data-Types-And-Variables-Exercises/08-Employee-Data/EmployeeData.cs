﻿using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Amanda";
        string lastName = "Jonson";
        byte age = 27;
        char gender = 'f';
        long personalId = 8306112507;
        uint employeeNumber = 27563571;

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalId}");
        Console.WriteLine($"Unique Employee number: {employeeNumber}");
    }
}
