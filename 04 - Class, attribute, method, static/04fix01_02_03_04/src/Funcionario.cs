using System;
using System.Globalization;

public class Funcionario
{
    private string Nome;
    private double SalarioBruto;
    private double Imposto;

    public Funcionario(string nome, double salarioBruto, double imposto)
    {
        Nome = nome;
        SalarioBruto = salarioBruto;
        Imposto = imposto;
    }

    public double SalarioLiquido()
    {
        double result = SalarioBruto - Imposto;
        return result;
    }
    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += SalarioBruto * porcentagem / 100;
    }

    public override string ToString()
    {
        return $"{Nome}, $ {SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
    }
}
