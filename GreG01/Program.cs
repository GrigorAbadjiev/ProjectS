

using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // read figure
        string figure = Console.ReadLine();
        double area = 0;
        if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (figure == "rectangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            area = sideA * sideB;
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine(Math.PI);
        }
        else if (figure == "triangle")
        {
            double side = double.Parse((Console.ReadLine()));
            double h = double.Parse((Console.ReadLine()));
            area = h * side / 2;
        }

        {

            Console.WriteLine($"{area:f2}");
        }





    }
}