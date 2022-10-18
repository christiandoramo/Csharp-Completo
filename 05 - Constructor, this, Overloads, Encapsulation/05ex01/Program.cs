using System;

namespace _05ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Session pessoa = new Session();
            pessoa.Cadastrar();
            pessoa.Depositar();
            Console.WriteLine("Deseja Sacar? S/s N/n");
            string Alt = Console.ReadLine().ToUpper();
            if (Alt == "S")
            {
                pessoa.Sacar();
            }
            else
            {
                pessoa.DadosConta();
            }
            Console.WriteLine("\nFim do Programa");
        }
    }
}
