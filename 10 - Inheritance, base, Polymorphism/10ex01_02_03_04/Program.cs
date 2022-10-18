using System;
using System.Globalization;
using _10ex01_02_03_04.src.Entities;
using System.Collections.Generic;
using _10ex01_02_03_04.src.Entities.Enums;

namespace _10ex01_02_03_04
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
                List<Employee> employees = new List<Employee>();
                Console.Write("Enter the number of employees: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"---------Employee #{i} data----------");
                    Console.Write($"Outsourced(y / n) :");
                    char outSourced = char.Parse(Console.ReadLine());
                    Console.Write($"Name: ");
                    string name = Console.ReadLine();
                    Console.Write($"Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write($"Value per hour: ");
                    double valuePerHours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    if (outSourced == 'y') {
                        Console.Write($"Additional charge: ");
                        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        employees.Add(new OutSourcedEmployee(name, hours, valuePerHours,additionalCharge));
                        continue;
                    }
                    //Lembrar do Upcasting - OutsourcedEmployee como subclasse de Employee naturalmente é referenciado
                    // ou convertido por uma variavel superclasse, já o contrário é mais dificil  o Downcasting
                    employees.Add(new Employee(name, hours, valuePerHours));
                }

                Console.WriteLine("Payments".ToUpper());
                foreach (Employee register in employees)
                {
                    Console.Write(register);
                }
            }
            
            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {
                List<Product> products = new List<Product>();
                Console.Write("Enter the number of products: ");
                int n = int.Parse(Console.ReadLine());
                for (int index = 1; index <= n; index++)
                {
                    Console.WriteLine($"---------Product #{index} data----------");
                    Console.Write($"Common, used or imported: ");

                    // usando ENUMS convertebdo string para enum
                    ProductType type = Enum.Parse<ProductType>(Console.ReadLine());

                    // tipo usando CHAR + TABELA ASCII
                    //Console.Write($"Common, used or imported (c/u/i): ");
                    //int type = (int)char.Parse(Console.ReadLine());

                    Console.Write($"Name: ");
                    string name = Console.ReadLine();
                    Console.Write($"Price: ");
                    double price = double.Parse(Console.ReadLine());

                    // usando ENUMS
                    switch (type)
                    {
                        case ProductType.Common:
                            products.Add(new Product(name, price, type));
                            break;
                        case ProductType.Used:
                            Console.Write("Manufacture Date : ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            products.Add(new UsedProduct(name, price, type, manufactureDate));
                            break;
                        case ProductType.Imported:
                            Console.Write("Customs fee: ");
                            double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            products.Add(new ImportedProduct(name, price, type, customFee));
                            break;
                    }

                    // versao usando CHAR + TABELA ASCII
                    //switch (type)
                    //{
                    //    case 99: // c
                    //        products.Add(new Product(name, price));
                    //        break;
                    //    case 117: // u
                    //        Console.Write("Manufacture Date : ");
                    //        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    //        products.Add(new UsedProduct(name, price, manufactureDate));
                    //        break;
                    //    case 105: // i
                    //        Console.Write("Customs fee: ");
                    //        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //        products.Add(new ImportedProduct(name, price, customFee));
                    //        break;
                    //    default:
                    //        break;
                    //
                    //}
                }
                Console.WriteLine("\nPRICE TAGS");
                foreach (Product index in products) Console.WriteLine(index.PriceTag());
            }
            
            //ex03--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nExercise 03\n");
            {
                Console.Write("Enter the number of shapes: ");
                int n = int.Parse(Console.ReadLine());
                List<Shape> shapes = new List<Shape>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Shape #{i + 1} data");
                    Console.Write("Rectangle or Circle (r/c)?");
                    string shape = Console.ReadLine().ToLower();
                    Console.Write("Color (Black/Blue/Red):");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    if (shape == "r")
                    {
                        Console.Write("Width:");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Height:");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Rectangle(color, width, height));

                    }
                    else if (shape == "c")
                    {
                        Console.Write("Radius:");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Circle(color, radius));
                    }
                    else
                    {
                        //fake try, catch exception
                        i--;
                        Console.WriteLine("Type r/R or c/R for Rectangle or Circle\n");
                    }

                }
                Console.WriteLine("-------SHAPE DISCRIPTIONS-------");
                foreach (Shape shape in shapes) Console.WriteLine(shape);

            }
            */
            //ex04--------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n\nExercise 04\n");
            {
                List<TaxPayer> payers = new List<TaxPayer>();
                Console.WriteLine("Enter the number of tax payers:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Tax payer #{i} data:");
                    Console.WriteLine("Individual or company(i/I or c/C):");
                    char c_i = char.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anual income:");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (c_i == 'c' || c_i == 'i')
                    {
                        if (c_i == 'i')
                        {
                            Console.WriteLine("Health expenditures:");
                            double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            payers.Add(new Individual(name, income, health));
                        }
                        if (c_i == 'c')
                        {
                            Console.WriteLine("Number of employees:");
                            int number = int.Parse(Console.ReadLine());
                            payers.Add(new Company(name, income, number));
                        }
                    }
                    else
                    {
                        //fake exception treatment
                        i--;
                        Console.WriteLine("\nPlease, enter 'c' for Company and 'i' for Individual\n\n");
                    }
                }

                Console.WriteLine("----------TAXES PAID----------");
                double total = 0;
                foreach (TaxPayer payer in payers)
                {
                    Console.WriteLine(payer);
                    total += payer.Tax();
                }
                Console.WriteLine($"TOTAL TAXES: ${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
