using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите фигуру (круг, прямоугольник, треугольник):");
        string shape = Console.ReadLine().ToLower();

        double area = 0;

        switch (shape)
        {
            case "круг":
                Console.WriteLine("Введите радиус круга:");
                double radius = Convert.ToDouble(Console.ReadLine());
                area = Math.PI*(radius*radius);
                break;
            case "прямоугольник":
                Console.WriteLine("Введите ширину прямоугольника:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту прямоугольника:");
                double height = Convert.ToDouble(Console.ReadLine());
                area = width*height;
                break;
            case "треугольник":
                Console.WriteLine("Введите основание треугольника:");
                double triangleBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту треугольника:");
                double triangleHeight = Convert.ToDouble(Console.ReadLine());
                area = 0.5*triangleBase*triangleHeight;
                break;
            default:
                Console.WriteLine("Вы ввели фигуру не из списка");
                return;
        }

        Console.WriteLine("Площадь выбранной фигуры: " + area);
    }
}