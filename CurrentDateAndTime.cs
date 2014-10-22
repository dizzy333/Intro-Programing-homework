using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime time = DateTime.Now;
        string format = "MM/dd/yyyy HH:mm:mmm ";
        Console.WriteLine(time.ToString(format));
    }
}

