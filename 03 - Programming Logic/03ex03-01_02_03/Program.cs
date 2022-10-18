using System;
using System.Globalization;

namespace _03ex03_01_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Exercise template
            Console.WriteLine("03 Exercise 03".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            Console.WriteLine("\n\nExercise 03_01\n");
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

                //ex02--------------------------------------------------------------------------------------------------
                //Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
                //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
                //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).
                Console.WriteLine("\n\nExercise 03_02\n");
                {
                    bool truexy = true;
                    while (truexy)
                    {
                        Console.WriteLine("Enter the Axis X position and Axis Y, respectively, separated by space:");
                        string[] xy = Console.ReadLine().Split(" ");
                        try { truexy = xy[0] != null && xy[1] != null; }
                        catch { continue; }
                        if (truexy)
                        {
                            string position = "";
                            double x, y;
                            try
                            {
                                x = double.Parse(xy[0], CultureInfo.InvariantCulture);
                                y = double.Parse(xy[1], CultureInfo.InvariantCulture);
                                if (x != 0 && y != 0)
                                {
                                    if (x > 0) position = x > 0 && y > 0 ? "Quadrant 1" : "Quadrant 4";
                                    if (x < 0) position = x < 0 && y < 0 ? "Quadrant 3" : "Quadrant 2";
                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid Quadrant\n End of Program");
                                    break;
                                }
                                Console.Write($"Your quadrant for ({x}, {y}) is... ----> ");
                                Console.WriteLine(position + "\n\n");
                            }
                            catch
                            {
                                Console.WriteLine($"Type VALID positions ( 2 numeric values only )\n\n");
                                continue;
                            }

                        }
                        else Console.WriteLine("Invalid Quadrant"); Console.WriteLine("End of Program");

                    }

                    //ex03--------------------------------------------------------------------------------------------------
                    //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
                    //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
                    //4.Fim).Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
                    // que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
                    //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
                    //exemplo.
                    Console.WriteLine("\n\n\nExercise 03_03\n");
                    {

                        int p_1 = 0, p_2 = 0, p_3 = 0;
                        bool run = true;
                        Console.WriteLine($"1:Alcohol\n2:Gas\n3:Diesel\n4:End Program");
                        Console.Write("What is the customers' preferences [1, 2, 3, 4]: ");
                        while (run)
                        {
                            try
                            {
                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1:
                                        p_1++;
                                        break;
                                    case 2:
                                        p_2++;
                                        break;
                                    case 3:
                                        p_3++;
                                        break;
                                    case 4:
                                        run = false;
                                        break;
                                    default:
                                        Console.WriteLine("This code is not entered");
                                        break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Type a valid code [1,2,3,4].\n");
                                continue;
                            }


                        }
                        Console.WriteLine($"\nThank You!!!\n1:Alcohol-> {p_1}\n2:Gas-> {p_2}\n3:Diesel-> {p_3}\n");
                    }

                }
            }
        }
    }
}