namespace pz_13
{
    internal class Program
    {
        //Даны два целых числа A и В (каждое в отдельной строке). Выведите все числа от A до B включительно, используя рекурсию, в порядке возрастания, если A<B, или в порядке убывания в противном случае b1=58 q=-26
        static void Main(string[] args)
        {
            int a = 87;
            int b = -87;

            if (a < b)
            {
                numbvv(a, b);
            }
            else
            {
                numbnn(a, b);
            }
        }
        static void numbvv(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                numbvv(a + 1, b);
            }
        }
        static void numbnn(int a, int b)
        {
            if (a >= b)
            {
                Console.WriteLine(a);
                numbnn(a - 1, b);
            }
        }

        ////С помощью рекурсии вычислить n-й член геометрической прогрессии, значения первого элемента b1=14 и знаменатель прогрессии q=0.15
        //static void Main(string[] args)
        //{
        //    int ne = Convert.ToInt32(Console.ReadLine());
        //    int b1 = 14;
        //    double q = 0.15;

        //    double nth = Geonetric(ne, b1, q);
        //    Console.WriteLine($"Геометрическая прогрессия {nth}");
        //}
        //static double Geonetric(int ne, double b1, double q)
        //{
        //    if (ne == 1)
        //    {
        //        return b1;
        //    }
        //    else
        //    {
        //        return q * Geonetric(ne - 1, b1, q);
        //    }
        //}


        //С помощью рекурсии вычислите n-й член арифметической прогрессии, значения первого элемента a1 и шаг d в табл. 1. вар 14 а1=10 d=0,1
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Введи число");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        double nt = Calcut(n);
        //        Console.WriteLine($"Арифметическая прогрессия {nt}");
        //    }
        //    static double Calcut(int n)
        //    {
        //        if (n == 1)
        //        {
        //            return 10;
        //        }
        //        else
        //        {
        //            double prev = Calcut(n - 1);
        //            return prev + 0.1;
        //        }
        //    }
    }
}

