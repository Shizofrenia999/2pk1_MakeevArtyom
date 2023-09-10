using System;

namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число А: ");
            double a= double.Parse(Console.ReadLine()); //ввод первого числа (а)

            Console.WriteLine("введите число В: ");
            double b = double.Parse(Console.ReadLine()); //ввод второго числа (b)

            Console.WriteLine("введите число С: ");
            double c = double.Parse(Console.ReadLine()); //ввод третьего числа (c)

            double result1, result2, result3, result4, result5, result6, result7, result8; //переменные для решения по частям

            result1 = 3 * (Math.Log(8, a)); //1 действие (1 дробь, числитель)
            result2 = Math.Sin(b / (3 * a)); //2 действие (1 дробь, знаменатель)
            result3 = result1 / result2; //3 действие (ответ 1ой дроби)
            result4 = Math.Pow(((5 * Math.Pow(a, 2))+7), (1 / 3.0)); //4 действие (вычисляем корень 3ей степени) 
            result5 = 4 * (Math.Abs(c - 2 * a + 1));//5 действие (числитель второй дроби, с модулем)
            result6 = Math.Sqrt(8 * a);//6 действие (знаменатель 2ой дроби. Квадратный корень)
            result7 = result5 / result6;//7 действие (ответ второй дроби)
            result8 = result3 - result4 + result7; //получаем конечный ответ

            Console.WriteLine($"Ответ: { result8} "); //вывод ответа


        }
    }
}