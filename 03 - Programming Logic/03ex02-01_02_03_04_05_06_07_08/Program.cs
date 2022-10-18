using System;
using System.Globalization;

namespace _03ex02_01_02_03_04_05_06_07_08
{
    class Program
    {
        static void Main(string[] args)
        {

            //Start Exercise template
            Console.WriteLine("03 Exercise 02".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            {
                Console.WriteLine("\n\nExercise 02_01\n");

                Console.WriteLine("Digite um número para ser se é negativo");
                int n = 0;
                while (n == 0)
                {
                    try
                    {
                        n = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Digite um número INTEIRO");
                        continue;
                    }
                }
                if (n < 0)
                {
                    Console.WriteLine($"O número {n} é Negativo");
                }
                else
                {
                    Console.WriteLine($"O número {n} NÃO é Negativo");
                }

            }
            //ex02--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nExercise 02_02\n");
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
            {

                Console.WriteLine("See if a number is even.\nEnter an Integer Value");
                int EvenorNot = int.Parse(Console.ReadLine());
                if (EvenorNot % 2 == 0) { Console.WriteLine("Yeah! It's an Even Number"); }
                else { Console.WriteLine("It isn't an Even Number. It's an Odd Number"); }

            }
            //ex03--------------------------------------------------------------------------------------------------
            //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            //ordem crescente ou decrescente.
            {
                Console.WriteLine("\n\n\nExercise 02_03\n");
                Console.WriteLine("See if the 2 numbers are Multiples.\nType two numbers separated by space");
                string[] AB = Console.ReadLine().Split(' ');
                int A = int.Parse(AB[0]), B = int.Parse(AB[1]);
                if (A > B)
                {
                    if (A % B == 0)
                    {
                        Console.WriteLine($"{A} is multiple of {B}");
                    }
                    else
                    {
                        Console.WriteLine($"There's no multiples");
                    }
                }
                else if (A < B)
                {
                    if (B % A == 0)
                    {
                        Console.WriteLine($"{B} is multiple of {A}");
                    }
                    else
                    {
                        Console.WriteLine($"There's no multiples");
                    }
                }
                else
                {
                    Console.WriteLine($"There's no multiples");
                }

            }


            //ex04--------------------------------------------------------------------------------------------------
            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.


            Console.WriteLine("\nExercise 02_04\n");

            {
                Console.WriteLine("Discover game duration.\n Type two integers separated by space " +
                    "equivalent to the beginning hour and end hour respectively of the game (enter just 1-24 hours)");
                string[] g_StartEnd = Console.ReadLine().Split(' ');
                int g_Start = int.Parse(g_StartEnd[0]), g_End = int.Parse(g_StartEnd[1]);
                int g_Duration = 0;
                if (g_End > g_Start)
                {
                    g_Duration = g_End - g_Start;


                }
                else if (g_Start > g_End)
                {
                    g_Duration = (g_End + 24 - g_Start);
                }

                //forced output if put [end 0 start 0] [start 0 end 24] [start 24 end 0] [start 24 end 24]
                if (g_Duration == 0)
                {
                    g_Duration = 24;
                }

                Console.WriteLine($"The game has lasted {g_Duration} hours");
            }
            //ex05--------------------------------------------------------------------------------------------------
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            //seguir, calcule e mostre o valor da conta a pagar.

            Console.WriteLine("\nExercise 02_05\n");
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

            //ex06--------------------------------------------------------------------------------------------------
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
            //seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
            Console.WriteLine("\nExercise 02_06\n");
            {
                Console.WriteLine("Enter the value of your position between the interval (a numeric value)");
                double number = double.Parse(Console.ReadLine());
                if (number <= 100 && number > 75)
                {
                    Console.WriteLine($"{number} is Between [75 - 100]");
                }
                else if (number > 50)
                {
                    Console.WriteLine($"{number} is Between [50 - 75]");
                }
                else if (number > 25)
                {
                    Console.WriteLine($"{number} is Between [25 - 50]");
                }
                else if (number > 0)
                {
                    Console.WriteLine($"{number} is Between [0 - 25]");
                }
                else
                {
                    Console.WriteLine($"{number} is not in any of the ranges");
                }
            }

            //ex07--------------------------------------------------------------------------------------------------
            Console.WriteLine("\nExercise 02_07\n");
            //Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas 
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //situação.
            {
                Console.WriteLine("Enter two double values separated by 1 space (x, y)\nSee your Quadrant in cartesian plane");
                string[] Coordenates = Console.ReadLine().Split(' ');
                double x = double.Parse(Coordenates[0]), y = double.Parse(Coordenates[1]);
                string position = "";
                if (x != 0 && y != 0)
                {
                    if (x > 0 && y > 0) position = "Quadrant 1";
                    if (x < 0 && y > 0) position = "Quadrant 2";
                    if (x < 0 && y < 0) position = "Quadrant 3";
                    if (x > 0 && y < 0) position = "Quadrant 4";
                }
                else if (x == 0 && y == 0) position = "Origin";
                else position = x == 0 ? "X Axis" : "Y Axis";

                Console.WriteLine($"\n({x}, {y}) is in {position}.");

            }

            //ex08--------------------------------------------------------------------------------------------------
            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
            //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            //qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
            //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
            //de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com
            //duas casas decimais.
            //0 - 2000 isento | 2000 - 3000 8%(sobre o valor acima de 2000 e abaixo 3000)
            //3000 - 4500 18% | 4500 acima 28% (sempre incidindo no valor entre os delimitadores)

            Console.WriteLine("\nExercise 02_08\n");
            {
                Console.WriteLine("Find out how much you'll pay in tax");
                Console.WriteLine($"Below 2000 (exempt|\nAbove 2000 below 3000 (8%|\n" +
                    $"Above 3000 below 4500 (18%|\nAbove 4500(28%|");
                Console.Write("Enter your income:");
                double totalRent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double tax = 0.0;
                //Income Tax Calculation
                if (totalRent > 4500)
                {
                    tax += (totalRent - 4500) * 28 / 100;
                    tax += (4500 - 3000) * 18 / 100;
                    tax += (3000 - 2000) * 8 / 100;
                }
                else if (totalRent > 3000)
                {
                    tax += (totalRent - 3000) * 18 / 100;
                    tax += (3000 - 2000) * 8 / 100;
                }
                else if (totalRent > 2000)
                {
                    tax += (totalRent - 2000) * 8 / 100;
                }
                else
                    tax = 0.0;

                if (tax > 0)
                    Console.WriteLine($"\nYou'll pay R$ {tax.ToString("F2", CultureInfo.InvariantCulture)} as tax");
                else
                    Console.WriteLine($"Income tax exempt");

            }
        }
    }
}
