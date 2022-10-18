using System;
using System.Collections.Generic;
public class Alugueis
{
    public int Number;
    public string Nome;
    public string Email;

    public Alugueis(int number, string nome, string email)
    {
        Number = number;
        Nome = nome;
        Email = email;
    }
    public Alugueis()
    {

    }
    public static string Listagem(Alugueis[] vetorQuartos)
    {
        string result = "";
        foreach (Alugueis Index in vetorQuartos)
        {
            if (Index != null) result += $"Quarto: {Index.Number}, Nome: {Index.Nome}, Email: {Index.Email}\n";
        }
        return result;
    }
}
