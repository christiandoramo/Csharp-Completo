using System;

public class Pessoa
{
    public string Nome;
    public int Idade;

    public static string MaisVelha(Pessoa pessoa1, Pessoa pessoa2)
    {
        string maisVelha;
        if (pessoa1.Idade == pessoa2.Idade) maisVelha = "Ambos possuem a mesma idade em anos";
        else maisVelha = pessoa1.Idade > pessoa2.Idade ? pessoa1.Nome : pessoa2.Nome;
        return maisVelha;
    }
}
