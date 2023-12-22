using System;

class Program
{
    static void Main()
    {
        int start = 0;
        int end = 200;
        int divisor = 2;
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % divisor == 0)
            {
                Console.Write(i + " ");
                count++;
            }
        }

        Console.WriteLine("\nКоличество кратных чисел: " + count);
    }
}
