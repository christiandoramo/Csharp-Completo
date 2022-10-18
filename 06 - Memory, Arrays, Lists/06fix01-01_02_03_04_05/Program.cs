using System;
using System.Globalization;
using System.Collections.Generic;

namespace _06fix01_01_02_03_04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Exercise template
            Console.WriteLine("Exercise 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            /*
            Console.WriteLine("\n\nExercise 01\n");
            {
                Console.Write("Qual o número de alturas diferentes N (inteiro): ");
                double[] alturas = new double[int.Parse(Console.ReadLine())];
                double sumAltura = 0.0;
                for (int i = 0; i < alturas.Length; i++)
                {
                    Console.Write("Altura " + (i + 1) + ": ");
                    alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    sumAltura += alturas[i];
                }
                double avH = sumAltura / alturas.Length;
                Console.WriteLine("Average Height = " + avH);
            }

            //ex02--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nExercise 02\n");
            //Modo 1
            {
                Console.Write("Qual o número N de produtos (inteiro): ");
                int x = int.Parse(Console.ReadLine());
                List<Product> lista = new List<Product>();
                for (int i = 0; i < x; i++)
                {
                    Console.Write("Produto " + (i + 1) + ": ");
                    string Nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Product(Nome,Price));
                }
                Console.WriteLine("Average price = "
                    + Product.AveragePrice(lista).ToString("F2", CultureInfo.InvariantCulture));
            }
            
            // Modo 2
            {
                Console.Write("Qual o número N de produtos (inteiro): ");
                int x = int.Parse(Console.ReadLine());
                string[] products = new string[x];
                double[] prices = new double[x];
                int[] qte = new int[x];
                double sumPrice = 0.0, avgPrice = 0.00;

                for (int i = 0; i < x; i++)
                {
                    Console.Write("Produto " + (i + 1) + ": ");
                    products[i] = Console.ReadLine();
                    Console.Write("Preço: ");
                    prices[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantidade: ");
                    qte[i] = int.Parse(Console.ReadLine());
                    sumPrice += prices[i] * qte[i];
                    avgPrice += prices[i];
                }
                avgPrice /= prices.Length;
                Console.WriteLine("Total price = " + sumPrice.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Average price = " + avgPrice.ToString("F2", CultureInfo.InvariantCulture));
            }
            //ex03--------------------------------------------------------------------------------------------------
            */
            Console.WriteLine("\n\n\nExercise 03\n");
            {
                Console.Write("Insira o Número de Quartos a serem alugados (max:10): ");
                double numQuartos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Alugueis[] vetorQuartos = new Alugueis[10];
                for (int i = 0; i < numQuartos; i++)
                {
                    Console.Write("Aluguel #" + (i + 1) + "\nDigite o número do Quarto (0-9) : ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome do locatário: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o email: ");
                    string email = Console.ReadLine();
                    vetorQuartos[num] = new Alugueis { Number = num, Nome = nome, Email = email };
                }
                Console.WriteLine(Alugueis.Listagem(vetorQuartos));
            }
            //ex04--------------------------------------------------------------------------------------------------
            /*
            Console.WriteLine("\nExercise 04\n");
            {
                Console.WriteLine("How many employees will be registered?");
                int n = int.Parse(Console.ReadLine());
                List<Employee> Employees = new List<Employee>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Employee #" + (i + 1));
                    Console.WriteLine("What is the Id of the Employee");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("What is the Name of the Employee");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("What is the Salary of the Employee");
                    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    //Cria Add objeto Employee a lista Employees pelo Construtor
                    Employees.Add(new Employee(id, name, salary));
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Enter the Employee Id that will have salary increase: ");
                int idIncreased = int.Parse(Console.ReadLine());

                // variavel do tipo objeto que recebe o index do primeiro objeto da lista que tenha esse Id
                Employee EmployeeIncreased = Employees.Find(x => x.Id == idIncreased);
	
                // se não houver Objeto com esse Id, receberá null
                if (EmployeeIncreased != null)
                {

                    Console.WriteLine("Enter the Percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    EmployeeIncreased.increaseSalary(percentage);

                }
                else
                {
                    Console.WriteLine("The Id does not exist");
                }

                Console.WriteLine("Updated List of Employees: ");
                foreach (Employee obj in Employees)
                {
                    Console.WriteLine(obj);
                }
            }

            //ex05--------------------------------------------------------------------------------------------------

            Console.WriteLine("\nExercise 05\n");

            {
                //valores esquerda, direita, baixo, cima numa matriz M,N
                int M = 0, N = 0;
                Console.WriteLine($"Enter the M(Rows) and the N(Columns)" +
                    $"Separated by space");
                string[] matrizMN = Console.ReadLine().Split(" ");
                for (var i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        M = int.Parse(matrizMN[i]);
                    }
                    else
                    {
                        N = int.Parse(matrizMN[i]);
                    }
                }

                int[,] matriz = new int[M, N];

                Console.WriteLine("Enter the values use space for each column and space for row");
                for (var i = 0; i < M; i++)
                {
                    string[] StringRow = Console.ReadLine().Split(" ");
                    for (var j = 0; j < N; j++)
                    {
                        matriz[i, j] = int.Parse(StringRow[j]);
                    }
                }
                Console.WriteLine("Type the number to know what is the position");
                int Chose = int.Parse(Console.ReadLine());
                for (var i = 0; i < M; i++)
                {

                    for (var j = 0; j < N; j++)
                    {
                        if (matriz[i, j] == Chose)
                        {
                            Console.WriteLine($"Position = {i},{j}");

                            if (j > 0)
                            {
                                Console.WriteLine($"Left: {matriz[i, j - 1]}");
                            }
                            if (i > 0)
                            {
                                Console.WriteLine($"Top: {matriz[i - 1, j]}");
                            }
                            if (j < N - 1)
                            {
                                Console.WriteLine($"Right: {matriz[i, j + 1]}");
                            }

                            if (i < M - 1)
                            {
                                Console.WriteLine($"Down: {matriz[i + 1, j]}");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            */
        }
    }
}