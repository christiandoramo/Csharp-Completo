using System;
using System.Globalization;

namespace _03fix01_02
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
                string produto1 = "Computador";
                string produto2 = "Mesa de escritório";
                byte idade = 30;
                int codigo = 5290;
                char genero = 'M';
                double preco1 = 2100.0;
                double preco2 = 650.50;
                double medida = 53.234567;

                Console.WriteLine(" Produtos:");
                Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F1}");
                Console.WriteLine($"{produto2}, cujo preco é ${preco2:F2}");
                Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
                Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
                Console.WriteLine($"Arredondado(três casas decimais): {Math.Round(medida, 3)}");
                Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
                // O "F" tbm arredonda 
            }
            Console.WriteLine("\n\nExercise 02\n");
            {
                Console.WriteLine("Entre com seu nome completo:");
                string name = Console.ReadLine();
                Console.WriteLine("Quantos quartos tem na sua casa?");
                int rooms = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o preço de um produto:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Entre seu último nome, idade e altura(mesma linha):");
                string[] entries = Console.ReadLine().Split(' ');
                string last_name = entries[0];
                int age = int.Parse(entries[1]);
                double height = double.Parse(entries[2], CultureInfo.InvariantCulture);
                Console.WriteLine(name);
                Console.WriteLine(rooms);
                Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(last_name);
                Console.WriteLine(age);
                Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
