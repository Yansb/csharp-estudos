using System;
using System.Globalization;
namespace Primeiro;

class Program
{
    static void Main(string[] args)
    {
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();
        
        Console.WriteLine("Entre com as medidas do triângulo X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com as medidas do triângulo Y:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var areaX = x.Area();
        var areaY = y.Area();

        Console.WriteLine("Area de x = "+ areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Area de y = "+ areaY.ToString("F4", CultureInfo.InvariantCulture));

        Console.WriteLine(areaX > areaY ? "Maior área é: X" : "Maior área é: Y");
    }
}
