using System;

class Program
{
    static void Main()
    {
        int start = -25;
        int end = 25;
        int step = 25;

        for (int i = start; i <= end; i += step)
        {
            Console.WriteLine(i);
        }
    }
}