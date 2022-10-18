using _17ex01_02_03_04_05_06.src;
using System.Globalization;

namespace _17ex01_02_03_04_05_06
{
    internal class Program
    {
        delegate Product Selector(Product x); //um delegate próprio criado deve ter os mesmos parametros dã função recebida!!!
        delegate bool Match(Product p); // delegate 01
        delegate void Action(Product p); // delegate 02
        delegate double Sum(List<Product> list, Func<Product, bool> test); // delegate 03

        delegate void Avg(List<Product> l, Func<Product, double> f); // delegate 05
        delegate void Emailss(List<Employee> eL, double cV); //delegate 06
        delegate double SumMDelegate(List<Employee> l, Func<char, char> f); //delegate 07
        static void Main(string[] args)
        {
            // Exercises Template
            /*
            Console.WriteLine("Activity 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 01\n");
            {
              
                List<Product> list = new List<Product>();
                list.Add(new Product("Tv", 900.00));
                list.Add(new Product("Mouse", 50.00));
                list.Add(new Product("Tablet", 350.50));
                list.Add(new Product("HD Case", 80.90));

                //usando expressão lambda
                //list.RemoveAll(p => p.Price >= 100 );

                // usando um proprio delegate + metodo estatico obs: Predicate só aceita um parametro
                //Match match = new Match(Product.BoolByPrice);
                //list.RemoveAll(match.Invoke);

                // usando o predicate do .NET + metodo estático que retorna o desejado
                Predicate<Product> match = new Predicate<Product>(Product.BoolByPrice);
                list.RemoveAll(match);
                //LEMBRANDO: Só os tipos delegates convertem uma função ou expressão lambda em um valor bool
                foreach (Product produtos in list) Console.WriteLine(produtos);
            }

            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {
                List<Product> list = new List<Product>();
                list.Add(new Product("Tv", 900.00));
                list.Add(new Product("Mouse", 50.00));
                list.Add(new Product("Tablet", 350.50));
                list.Add(new Product("HD Case", 80.90));

                //usando expressão lambda
                list.ForEach(x => { x.Price *= 1.1; }); // usa-se { } para a expressão lambda não retornar valor!!!

                // usando um proprio delegate + metodo estatico obs: Predicate só aceita um parametro
                //Action action = new Action(Product.ValueAugment);
                //list.RemoveAll(match.Invoke);

                // usando o predicate do .NET + metodo estático que retorna o desejado
                //Action<Product> action = new Action<Product>(Product.ValueAugment);
                //list.ForEach(action); // quando se usa o delegate próprio, ao invés do Action<obj T> do .NET é preciso usar .invoke
                //LEMBRANDO: Só os tipos delegates convertem uma função ou expressão lambda em um valor ex: bool

                foreach (Product produtos in list) Console.WriteLine(produtos);
            }


            //ex03--------------------------------------------------------------------------------------------------
            */
            Console.WriteLine("\n\nExercise 03\n");
            {
                //Fazer um programa que, a partir de uma lista de produtos, gere uma
                //nova lista contendo os nomes dos produtos em caixa alta.

                // Usando Delegate próprio + Coleção IEnumerable ou um UpCasting + metodo static e Select gerando objeto a objeto
                //Selector selector = Product.ReturnToUpper;
                //list = list.Select(selector.Invoke).ToList(); //To.List<T>() Converte do Return IEnumerable para List

                //Selector selector = Product.ReturnToUpper;
                // Func está usando tipos <in T(product), out TResult(product)> e um parametro Product 
                //Func<Product,Product> func = selector.Invoke; // que é preenchido PELO USO da Função Product.ReturnUpper EM list.Select pelo delegate
                //list = list.Select(func).ToList();

                // uso de um Func <In T, out T> (T arg) + expressao Lambda
                //Func<Product, Product> func = p => new Product(p.Name.ToUpper(),p.Price);
                //list = list.Select(func).ToList();

                foreach (Product product in list)
                    Console.WriteLine(product);
            }
            /*
            //ex04--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 04\n");
            {
                //Fazer um programa que, a partir de uma lista de produtos, calcule a
                //soma dos preços somente dos produtos cujo nome começa com "T".
                List<Product> list = new List<Product>();
                list.Add(new Product("Tv", 900.00));
                list.Add(new Product("Mouse", 50.00));
                list.Add(new Product("Tablet", 350.50));
                list.Add(new Product("HD Case", 80.90));

                // in T   in Out  ( in T arg = Product p) (return p.Name[0] == 'T')
                Func<Product, bool> func = p => p.Name[0] == 'T';
                Sum sum = Product.SumT;
                Console.WriteLine(sum(list,func.Invoke).ToString("F2", CultureInfo.InvariantCulture));
            }
            
            //ex05--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 05\n");

            {
                //Fazer um programa para ler um conjunto de produtos a partir de um
                //arquivo em formato .csv(suponha que exista pelo menos um produto).

                Console.WriteLine("enter the full file path ==>> ");
                //C:\Users\chris\Desktop\Courses\C# Course\17 - Lambda, LINQ, Delegates\in\arquive.csv
                string path = Console.ReadLine();
                List<Product> list = new List<Product>();
                try
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!(sr.EndOfStream))
                        {
                            string[] data = sr.ReadLine().Split(",");
                            string name = data[0];
                            double price = double.Parse(data[1], CultureInfo.InvariantCulture);
                            list.Add(new Product(name, price));
                        }
                    }
                    //Em seguida mostrar o preço médio dos produtos. Depois, mostrar os
                    //nomes, em ordem decrescente, dos produtos que possuem preço
                    //inferior ao preço médio.
                    ProductService ps = new ProductService();
                    Func<Product, double> func = p => p.Price; // função com retorno double e arg Product
                    Avg avg = ps.Average;
                    avg.Invoke(list, func.Invoke);
                }
                catch (FormatException e)
                {
                    throw new Exception("Format: " + e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception("Unexpected: " + e.Message);
                }

            }
            
            //ex06--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise _06\n");
            {
                //Fazer um programa para ler os dados(nome, email e salário)
                //de funcionários a partir de um arquivo em formato.csv.


                Console.WriteLine("Enter the full path");
                //path = C:\Users\chris\Desktop\Courses\C# Course\17 - Lambda, LINQ, Delegates\in2\arquive.csv
                string path = Console.ReadLine();
                List<Employee> employeeList = new List<Employee>();
                double salary;
                // Abrindo o arquivo.csv
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] data = sr.ReadLine().Split(",");
                        string name = data[0];
                        string email = data[1];
                        salary = double.Parse(data[2], CultureInfo.InvariantCulture);
                        employeeList.Add(new Employee(name, email, salary));
                    }
                }

                Console.Write("Enter salary :");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Email of people whose salary is more than " + salary);
                EmployeeService employeeService = new EmployeeService();
                //employeeService.ShowEmails(employeeList,salary); // <--faster
                Emailss emails = employeeService.ShowEmails;
                emails(employeeList, salary);
                SumMDelegate sumM = EmployeeService.SumM;
                Func<char, char> employeeF = c => c;
                string summ = sumM.Invoke(employeeList, employeeF).ToString("F2", CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.Write("Sum of salary of people whose name starts with 'M': " + summ);

            }
            */
        }
    }
}