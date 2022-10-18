using System;

public class ConversorDeMoedas
{
    public double Qte, Cotacao;
    public static double Iof { get; private set; } = 6.0; // Static não precisa de um objeto para ser usado
    // No caso de um Private só será usado nessa classe

    public double ValorPago()
    {
        double valor = (Qte * Cotacao) + (Qte * Cotacao * Iof / 100);
        return valor;
    }
}
