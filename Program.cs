using System;

class Program
{
    static void Main()
    {
        // Ввод сторон треугольника
        Console.Write("Введите сторону a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите сторону c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Проверка на отрицательные значения
        if (a < 0 || b < 0 || c < 0)
        {
            Console.WriteLine("Error");
            return;
        }

        // Проверка, является ли треугольник прямоугольным
        bool isRightTriangle = (a * a + b * b == c * c) ||
                               (a * a + c * c == b * b) ||
                               (b * b + c * c == a * a);

        Console.WriteLine(isRightTriangle);
    }
}