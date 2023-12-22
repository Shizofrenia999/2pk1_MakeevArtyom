using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[10];
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(20, 101);
            if (array[i] % 10 == 0)
            {
                count++;
            }
        }

        int[] newArray = new int[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 10 == 0)
            {
                newArray[index] = array[i];
                index++;
            }
        }

        Console.WriteLine("Исходный массив:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Массив чисел, оканчивающихся на 0:");
        foreach (int number in newArray)
        {
            Console.Write(number + " ");
        }
    }
}