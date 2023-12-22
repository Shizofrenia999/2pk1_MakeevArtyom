using System;

class Program
{
    static void Main()
    {
        int n = 4; // количество знаков в строке
        int m = 7; // количество строк
        
        for (int i=0; i<m; i++)
        {
            for (int j=0; j<n; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine(); // переход на новую строку
        }
    }
}