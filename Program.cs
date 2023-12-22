namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
        {
                Console.WriteLine($"Введите значение основания треугольника { i + 1}:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Введите значение высоты треугольника { i + 1}:");
                double h = Convert.ToDouble(Console.ReadLine());

                double perimeter = Triangle(a, h);
                Console.WriteLine($"Периметр треугольника { i + 1} равен: { perimeter}");
            }
        }

        static double Triangle(double a, double h)
        { 
            double v = Math.Pow(a/2.0, 2);
            double b = v + Math.Pow(h, 2);
            double perimeter = 2 * Math.Sqrt(b) + a;
            return perimeter;
        }

    }
}