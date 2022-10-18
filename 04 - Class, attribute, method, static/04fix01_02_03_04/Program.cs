using System;
using System.Globalization;

namespace _04fix01_02_03_04
{
    class Program
    {
        static void Main()
        {
            //Start Exercise template
            Console.WriteLine("Exercise 01".ToUpper());
            
            //ex01--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 01\n");
            {
                Console.WriteLine("Veja o Perimetro, Area e diagonal\nDigite as medidas do Retangulo");
                Console.WriteLine("Digite a largura");
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite a altura");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Retangulo Ret = new Retangulo(largura, altura);
                Console.WriteLine($"AREA = {Ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"PERIMETRO = {Ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"DIAGONAL = {Ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            
            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario bruto: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Imposto: ");
                double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario Fun = new(nome, salario, imposto);
                Console.WriteLine($"Funcionario: {Fun}");
                Console.Write($"Digite a porcentagem para aumentar o salario: ");
                Fun.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine($"Dados atualizados: {Fun}\n");
            }

            
            //ex03--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n\nExercise 03\n");
            {
                Aluno aluno = new Aluno();
                Console.WriteLine("Digite o nome do Aluno");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a nota da Avaliação 1");
                aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite a nota da Avaliação 2");
                aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite a nota da Avaliação 3");
                aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(aluno);
            }
            
            //ex04--------------------------------------------------------------------------------------------------

            Console.WriteLine("\nExercise 04\n");
            {
                ConversorDeMoedas CdM = new();
                Console.Write("Qual é a cotação do dólar: ");
                CdM.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantos dólares você vai comprar: ");
                CdM.Qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.WriteLine($"Iof = {ConversorDeMoedas.Iof}%\nValor a ser pago = " +
                    $"{CdM.ValorPago().ToString("F2", CultureInfo.InvariantCulture)}");

            }
        }
    }
}
