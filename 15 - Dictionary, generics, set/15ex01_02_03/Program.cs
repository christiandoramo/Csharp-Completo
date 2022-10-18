using _15ex01_02_03.src;

namespace _15ex01_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercises Template

            Console.WriteLine("Activity 01".ToUpper());

            //ex01--------------------------------------------------------------------------------------------------
            /*
            Console.WriteLine("\n\nExercise 01\n");
            {
                //C:\Users\chris\Desktop\Courses\C# Course\15 - D,g,s\Arquive.txt
                try
                {
                    Console.Write("Enter the file path with the arquive extension: ");
                    string path = Console.ReadLine();
                    int sum = 0;
                    HashSet<Log> logs = new HashSet<Log>();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!(sr.EndOfStream))
                        {
                            string[] data = sr.ReadLine().Split(" ");
                            string name = data[0];
                            DateTime date = DateTime.Parse(data[1]);
                            logs.Add(new Log(name, date));
                            Console.WriteLine("Login :" + name + ", " + date);
                            sum++;
                        }
                    }
                    Console.WriteLine("Total Logins: "+ sum +"\n\n");
                    foreach (Log logins in logs)
                    {
                        Console.WriteLine(logins.Name);
                    }

                    Console.Write("\nTotal users: " + logs.Count);
                }
                catch (Exception e)
                {
                    throw new Exception("Unexpected error: " + e.Message);
                }
            }
            
            //ex02--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 02\n");
            {

                HashSet<int> list = new();
                Console.Write("How Many Studentes for Course A: ");
                int a = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    Console.Write($"Enter the Id of the A course's student #{i}: ");
                    int id = int.Parse(Console.ReadLine());
                    list.Add(id);
                }
                Console.Write("How Many Studentes for Course B: ");
                int b = int.Parse(Console.ReadLine());
                for (int i = 1; i <= b; i++)
                {
                    Console.Write($"Enter the Id of the B course's student #{i}: ");
                    int id = int.Parse(Console.ReadLine());
                    list.Add(id);
                }
                Console.Write("How Many Studentes for Course C: ");
                int c = int.Parse(Console.ReadLine());
                for (int i = 1; i <= c; i++)
                {
                    Console.Write($"Enter the Id of the C course's student #{i}: ");
                    int id = int.Parse(Console.ReadLine());
                    list.Add(id);
                }
                // Tipos nativos do System normalmente já implementam o IComparer logo usam padronizadamente o CompareTo
                Console.Write("Total Students: "+ list.Count);

            }
            */
            //ex03--------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nExercise 03\n");
            {
                try
                {
                    Console.Write("Enter the votes file's full path: ");
                    //C:\Users\Paulo\Desktop\Csharp-Completo-Nelio-Alves\15 - D,g,s\in\in.txt
                    string path = Console.ReadLine();
                    Dictionary<string, int> lista = new Dictionary<string, int>();
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!(sr.EndOfStream))
                        {
                            string[] data = sr.ReadLine().Split(",");
                            string name = data[0];
                            int votes = int.Parse(data[1]);
                            if (lista.ContainsKey(name))
                            {
                                lista[name] += votes;
                            }
                            else
                            {
                                lista.Add(name, votes);
                            }
                        }
                    }
                    //C:\Users\Paulo\Desktop\Csharp-Completo-Nelio-Alves\15 - D,g,s\out\
                    Console.WriteLine("Enter the votes RELATORY's full path to be created");
                    path = Console.ReadLine();
                    Directory.CreateDirectory(path);

                    using (StreamWriter sw = new(path + @"\relatory.csv"))
                    {
                        foreach (KeyValuePair<string, int> candidate in lista)
                        {
                            sw.WriteLine(candidate.Key + ": " + candidate.Value);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
        }
    }
}