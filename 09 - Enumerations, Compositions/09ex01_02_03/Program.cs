using System;
using System.Globalization;
using _09ex01_02_03.src.Entities.Classes;
using _09ex01_02_03.src.Entities.Enums;


namespace _09ex01_02_03
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
                Console.WriteLine("Enter department's name:");
                Department department = new Department(Console.ReadLine());
                Console.WriteLine("\nEnter worker data:");
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Level( JUNIOR / MID_LEVEL / SENIOR ): ");
                string level = Console.ReadLine();
                Console.WriteLine("Base salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Worker worker = new Worker(name, Enum.Parse<WorkerLevel>(level), salary, department);

                Console.WriteLine("How many contracts to this worker: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                    Console.WriteLine("Date(DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Value per hour: ");
                    double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Duration(hours):");
                    int hours = int.Parse(Console.ReadLine());
                    worker.AddContract(new HourContract(date, valuePerHours, hours));
                }

                Console.WriteLine("Enter month and year to calculate income(MM/YYYY): ");
                string year_Month = Console.ReadLine();
                int month = int.Parse(year_Month.Substring(0, 2));// a partir da posição/index 0 corte 2 chars
                int year = int.Parse(year_Month.Substring(3)); // corta e retorna tudo a partida do index 3

                Console.WriteLine(worker);
                Console.WriteLine($"Income for { month}/{year} : " +
                    $"{worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}\n");
            }

            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {
                string title = "Traveling to New Zealand";
                int likes = 12;
                DateTime moment = DateTime.Parse("21/06/2018 13:05:44");
                string content = "I'm going to visit this wonderful country!";
                string comment1 = "Have a nice trip";
                string comment2 = "Wow that's awesome!";

                Post p1 = new Post(moment, title, content, likes);
                p1.AddComment(new Comment(comment1));
                p1.AddComment(new Comment(comment2));

                title = "Good night guys";
                likes = 5;
                moment = DateTime.Parse("28/07/2018 23:14:19");
                content = "See you tomorrow";
                comment1 = "Good night";
                comment2 = "May the Force be with you";

                Post p2 = new Post(moment, title, content, likes);
                p2.AddComment(new Comment(comment1));
                p2.AddComment(new Comment(comment2));

                Console.WriteLine(p1);
                Console.WriteLine(p2);
            }

            //ex03--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n\nExercise 03\n");
            {
                Console.WriteLine("Enter client data:");
                Console.Write("Name: ");
                string clientName = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Birth date (DD/MM/YYYY): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Status (PENDING_PAYMENT / PROCESSING / SHIPPED / DELIVERED)");
                OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

                Order order = new Order(DateTime.Now, status, new Client(clientName, email, birthDate));

                Console.Write("How many items to this order: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; ++i)
                {
                    Console.WriteLine($"Enter #{i} item data:");
                    Console.Write("Product name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Product price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Quantity: ");
                    int qte = int.Parse(Console.ReadLine());
                    order.AddItem(new OrderItem(qte, price, new Product(productName, price)));
                }

                Console.WriteLine(order);
            }
        }
    }
}
