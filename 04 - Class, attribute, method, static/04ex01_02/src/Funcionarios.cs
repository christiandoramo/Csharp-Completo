using System;

public class Funcionarios
{
    public string Nome;
    public double Salario;

    public static double SalarioMedio(Funcionarios pessoa1, Funcionarios pessoa2)
    {
        double media = (pessoa1.Salario + pessoa2.Salario)/ 2;
        return media;
    }
}
