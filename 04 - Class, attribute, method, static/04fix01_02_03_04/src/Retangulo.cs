using System;

public class Retangulo
{
    private double Largura { get; set; }
    private double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double Area()
    {
        double result = Largura * Altura;
        return result;
    }
    public double Perimetro()
    {
        double result = 2 * Largura + 2 * Altura;
        return result;
    }
    public double Diagonal()
    {
        double result = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        return result;
    }
}
