using System;
using System.Globalization;

namespace _04ex01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Exercise template
            Console.WriteLine("Exercise 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            
            Console.WriteLine("\n\nExercise 01\n");
            {
                Pessoa p1 = new(), p2 = new();
                Console.WriteLine("Dados da primeira pessoa:");
                Console.Write("Nome: ");
                p1.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                p1.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Dados da segunda pessoa:");
                Console.Write("Nome: ");
                p2.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                p2.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Pessoa mais velha: {Pessoa.MaisVelha(p1, p2)}");
            }
            
            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {
                Funcionarios f1 = new(), f2 = new();
                Console.WriteLine("Dados do primeiro funcionario:");
                Console.Write("Nome: ");
                f1.Nome = Console.ReadLine();
                Console.Write("Salario: ");
                f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da segunda pessoa:");
                Console.Write("Nome: ");
                f2.Nome = Console.ReadLine();
                Console.Write("Salario: ");
                f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Saláio Médio: {Funcionarios.SalarioMedio(f1, f2).ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
