namespace Primeiro;

public class Triangulo
{
    public double A;
    public double B;
    public double C;

    public double Area()
    {
        var p = (A + B + C) / 2.0;
        var area = Math.Sqrt(p * (p - A) * (p - B) * (p-C));
        return area;
    }
}