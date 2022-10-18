using System;
using System.Globalization;

namespace _01ex01_01_02_03_04_05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Exercise template
            Console.WriteLine("Exercise 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            Console.WriteLine("\n\nExercise 01\n");
            {
                Console.WriteLine("Enter the part code 1, the quantity of the parts and their unit value, respectively. Enter values separately by space.");
                string[] entries1 = Console.ReadLine().Split(' ');
                int cp1 = int.Parse(entries1[0]), qp1 = int.Parse(entries1[1]);
                double pp1 = double.Parse(entries1[2], CultureInfo.InvariantCulture);
                Console.WriteLine("Enter the part code 2, the quantity of the parts and their unit value, respectively. Enter values separately by space.");
                string[] entries2 = Console.ReadLine().Split(' ');
                int cp2 = int.Parse(entries2[0]), qp2 = int.Parse(entries2[1]);
                double pp2 = double.Parse(entries2[2], CultureInfo.InvariantCulture);
                double total = pp1 * qp1 + pp2 * qp2;
                Console.WriteLine($"Part {cp1} - ({qp1}) units\nPart {cp2} - ({qp2}) units\nTOTAL PRICE: ${total:F2}");

            }

            //ex02--------------------------------------------------------------------------------------------------
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            //casas decimais conforme exemplos.
            Console.WriteLine("\n\nExercise 02\n");
            {
                Console.Write("Enter the radius of the circle and find the value of the area: ");
                double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double area = Math.Pow(r, 2) * 3.14129;
                Console.WriteLine();
                Console.WriteLine($"The Area of the Circle is: {area.ToString("F2", CultureInfo.InvariantCulture)}");
            }


            //ex03--------------------------------------------------------------------------------------------------
            //Com base na tabela de preços ao lado, faça 
            //um programa que leia o código de um item e a
            //quantidade  deste item.  A seguir, calcule  e
            //mostre o valor da conta a pagar
            Console.WriteLine("\n\n\nExercise 03\n");
            {
                Console.WriteLine("\nPlease, order 1 snack(A integer) and the x " +
                    "Quantity(a integer)!!!\n(Obs: Numbers Separated By space)" +
                    "\n1: Hot Dog\n2: X-Salad\n3: X-Bacon\n4: Plain Toast\n5: Soft Drink");
                string[] entries = Console.ReadLine().Split(' ');
                double p_Snack = 0.0;
                string snack = "";
                int quantity = int.Parse(entries[1]);
                switch (double.Parse(entries[0]))
                {
                    case 1:
                        snack = "Hot Dog";
                        p_Snack = 4.00;
                        break;
                    case 2:
                        snack = "X-Salad";
                        p_Snack = 4.50;
                        break;
                    case 3:
                        snack = "X-Bacon";
                        p_Snack = 5.00;
                        break;
                    case 4:
                        snack = "Plain Toast";
                        p_Snack = 2.00;
                        break;
                    case 5:
                        snack = "Soft Drink";
                        p_Snack = 1.50;
                        break;
                }
                double total = p_Snack * quantity;
                Console.WriteLine($"You ordered {quantity} {snack}(s)\n" +
                    $"Total: ${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            //ex04--------------------------------------------------------------------------------------------------
            //Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau ( ax² + bx + c = 0)
            //Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja 
            //abaixo). Se a equação não possuir raízes(o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
            //negativo), mostrar uma mensagem "Impossivel calcular"
            Console.WriteLine("\nExercise 04\n");
            {
                Console.WriteLine("Find the roots of the equation ax² + bx + c = 0");
                Console.WriteLine("Enter the values a, b and c respectively, each value separated by a space");
                string[] equation = Console.ReadLine().Split(' ');
                double a = double.Parse(equation[0], CultureInfo.InvariantCulture);
                double b = double.Parse(equation[1], CultureInfo.InvariantCulture);
                double c = double.Parse(equation[2], CultureInfo.InvariantCulture);
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0 || a == 0)
                {
                    if (a == 0) Console.WriteLine("a = 0");
                    if (d == 0) Console.WriteLine("▲ = 0"); // ▲ = press alt + 30
                    Console.WriteLine("Impossible to calculate");
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(d)) / 2 * a, x2 = (-b + Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine($"x¹ = {x1:F2}\nx² = {x2:F2}");
                }
            }

            //ex05--------------------------------------------------------------------------------------------------
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            Console.WriteLine("\nExercise 05\n");
            {
                int password = 0;
                int tentativas = 0;
                while (password != 2002)
                {
                    if (tentativas > 6)
                    {
                        Console.WriteLine("Hint: 2002");
                        Console.WriteLine($"Attempts: {tentativas++}");
                    }
                    else if (tentativas > 3)
                    {
                        Console.WriteLine("Hint: the password is 4 numbers");
                        Console.WriteLine($"Attempts: {tentativas++}");

                    }
                    else if (tentativas > 1)
                    {
                        Console.WriteLine($"Attempts: {tentativas++}");
                    }
                    else
                    {
                        tentativas++;
                    }

                    Console.Write("Type the correct password (numeric): ");
                    try
                    {
                        password = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Type a valid password Integers numbers only\n");
                        continue;
                    }
                    if (password == 2002)
                    {
                        Console.WriteLine("\nThe Password is Correct!!!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nWrong Password\n\n");

                    }
                }
            }

            //ex06--------------------------------------------------------------------------------------------------
            //Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            Console.WriteLine("\nExercise_06\n");
            {
                Console.Write("Enter the amount of N integer values you will add and test if it is in the secret range: ");
                int n = int.Parse(Console.ReadLine());
                int inN = 0; int outN = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x <= 20 && x >= 10) inN++;
                    else outN++;
                }
                Console.WriteLine($"{inN} in\n{outN} out\nInterval -> [10,20]");
            }
        }
    }
}
