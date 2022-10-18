using System;
using System.Globalization;

namespace _03ex01_01_02_03_04_05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03 Exercise 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nExercise 01_01\n");
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            //mensagem explicativa, conforme exemplos

            Console.WriteLine("Sum of A + B\nEnter the value A");
            int va1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value B");
            int va2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum {va1} + {va2} is equal to {va1 + va2}");

            //ex02--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nExercise 01_02\n");
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            //casas decimais conforme exemplos

            const double pi = 3.14129;
            Console.Write("\n\nSee the Area of the Circle\nType the circle radius: ");
            double radius1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area1 = Math.Pow(radius1, 2) * pi;
            Console.WriteLine($"The Circle area is: {area1:F2}");

            //ex03--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nExercise 01_03\n");
            //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)

            Console.WriteLine("See the difference between A*B and C*D\nType the Value of A: ");
            int A1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the Value of B: ");
            int B1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the Value of C: ");
            int C1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the Value of D: ");
            int D1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nDifference: {A1 * B1 - C1 * D1}");

            //ex04--------------------------------------------------------------------------------------------------
            Console.WriteLine("\nExercise 01_04\n");
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.
            Console.Write("Type the number of the Employee: ");
            int employee1 = int.Parse(Console.ReadLine());
            Console.Write("Type the number of hours worked: ");
            double hours1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Type the earned value per hour of work: ");
            double moneyHour1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary1 = hours1 * moneyHour1;
            Console.WriteLine($"Employee: {employee1}\nSalary: ${salary1:F2}");



            //ex05--------------------------------------------------------------------------------------------------
            Console.WriteLine("\nExercise 01_05\n");
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
            Console.Write("Type the number of the first part: ");
            int part1 = int.Parse(Console.ReadLine());
            Console.Write($"Type the number of parts with this same number {part1}: ");
            int parts1 = int.Parse(Console.ReadLine());
            Console.Write("Type the unit value of this part: ");
            double unitValue1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Type the number of the second part: ");
            int part2 = int.Parse(Console.ReadLine());
            Console.Write($"Type the number of parts with this same number {part2}: ");
            int parts2 = int.Parse(Console.ReadLine());
            Console.Write("Type the unit value of this part: ");
            double unitValue2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalValue1 = parts1 * unitValue1 + parts2 * unitValue2;

            Console.WriteLine($"Total Value: {totalValue1:F2}");



            //ex06--------------------------------------------------------------------------------------------------
            Console.WriteLine("\nExercise 01_06\n");
            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
            //mostre: 
            //a) a área do triângulo retângulo que tem A por base e C por altura. 
            //b) a área do círculo de raio C. (pi = 3.14159) 
            //c) a área do trapézio que tem A e B por bases e C por altura. 
            //d) a área do quadrado que tem lado B. 
            //e) a área do retângulo que tem lados A e B

            Console.Write("See the figures measurements\nEnter the value of A, B and C separated by 1 space: ");
            string[] vars = Console.ReadLine().Split(' ');
            double A2 = double.Parse(vars[0], CultureInfo.InvariantCulture);
            double B2 = double.Parse(vars[1], CultureInfo.InvariantCulture);
            double C2 = double.Parse(vars[2], CultureInfo.InvariantCulture);
            double triangle1 = Math.Round(A2 * C2 / 2, 3);
            double circle1 = Math.Round(Math.Pow(C2, 2) * 3.14159, 3);
            double trapeze = Math.Round((A2 + B2) * C2 / 2, 3);
            double square = Math.Pow(B2, 2);
            double rectangle = A2 * B2;

            Console.WriteLine($"\nTRIANGLE: {triangle1.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCLE: {circle1.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZE: {trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"SQUARE: {square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RECTANGLE: {rectangle.ToString("F3", CultureInfo.InvariantCulture)}\n");

        }
    }
}
