using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Write your age:");
        byte age = byte.Parse(Console.ReadLine());

        if (age > 0)
        {
            Console.WriteLine(age + 10);
        }

    }
}

