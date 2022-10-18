using System;
using System.Globalization;
using _11ex01.src.Entities;

namespace _11ex01
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
                MyProgram();
                static void MyProgram()
                {
                    try
                    {
                        Console.WriteLine("Enter account data");
                        Console.Write("Number:");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Holder:");
                        string h = Console.ReadLine();
                        Console.Write("Initial balance:");
                        double i = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Withdraw limit:");
                        double wl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Account account = new Account(n, h, i, wl);
                        while (1 != 0) // ctrl + c interrompe o console caso dê um bug
                        {
                            Console.WriteLine("Enter W/w for a Withdraw or D/d for a Deposit");
                            char wdc = char.Parse(Console.ReadLine().ToLower());
                            if (wdc == 'w')
                            {
                                Console.Write("Enter amount for Withdraw:");
                                double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                account.Withdraw(w);
                            }
                            else if (wdc == 'd')
                            {
                                Console.Write("Enter amount for Deposit:");
                                double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                account.Deposit(d);
                            }
                            else
                            {
                                if (wdc == 'c') break;
                                Console.WriteLine("Please, type a valid char (w/d) and (c) to stop program");
                            }
                        }
                    }
                    catch (DomainExceptions e) // em vez de ApplicationException, DomainExceptions trata minhas exceptions
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Format Error: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unexpected Error: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("----------End Of Program----------");
                        Console.WriteLine("\n\n----------Program Restart----------");
                        MyProgram();
                    }
                }
                
            }
        }
    }
}
