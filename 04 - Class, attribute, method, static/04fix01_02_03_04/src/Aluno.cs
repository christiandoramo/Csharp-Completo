using System;
using System.Globalization;

public class Aluno
{
    public string Nome;
    public double Nota1, Nota2, Nota3;

    public bool PassouOuNao()
    {
        bool aprovado = NotaFinal() >= 60 ? true : false;
        return aprovado;
    }
    public double NotaFinal()
    {
        return Nota1 + Nota2 + Nota3;
    }

    public override string ToString()
    {
        string resultado = PassouOuNao() ? $"Nome: {Nome}\nNota Final = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\nAprovado" :
            $"Nome: {Nome}\nNota Final = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\nReprovado\nFaltaram " +
            $"{(60 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)}";
        return resultado;
    }
}
