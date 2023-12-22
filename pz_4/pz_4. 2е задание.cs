using System;

class Program
{
    static void Main()
    {
        char startChar = 'P'; // Стартовая буква
        int n = 5; // Количество символов

        for (int i = 0; i < n; i++)
        {
            Console.Write((char)(startChar + i));
        }
    }
}