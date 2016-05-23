using System;

namespace Problem22RectangleProperties
{
    class RectangleProperties
    {

        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(Perimeter(width, height));
            Console.WriteLine(Area(width, height));
            Console.WriteLine(Diagonal(width, height));
        }
        static double Perimeter(double width, double height)
        {
            double perimeter = (double)(2 * (width + height));
            return perimeter;
        }
        static double Area(double width, double height)
        {
            double area = (double)(width * height);
            return area;
        }
        static double Diagonal(double width, double height)
        {
            double diagonal = (double)(Math.Sqrt(width * width + height * height));
            return diagonal;
        }


    }
}
