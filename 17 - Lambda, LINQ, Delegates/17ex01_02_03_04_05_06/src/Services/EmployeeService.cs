
namespace _17ex01_02_03_04_05_06.src
{
    internal class EmployeeService
    {
        //Em seguida mostrar, em ordem alfabética, o email dos
        //funcionários cujo salário seja superior a um dado valor
        //fornecido pelo usuário.
        public EmployeeService()
        {
        }
        public void ShowEmails(List<Employee> employeeList, double comparedValue)
        {
            List<string> emailsList = new List<string>();
            foreach (Employee employee in employeeList)
            {
                if (employee.Salary > comparedValue)
                {
                    emailsList.Add(employee.Email);
                }
            }
            //emailsList.Sort(); <-- fast and comparison by default
            //Func<string, string> funcOrde = x => x; //<-- fast
            emailsList = emailsList.OrderBy(funcOrde).ToList(); // <-- just for exercising
            foreach (string email in emailsList) Console.WriteLine(email);
        }
        private static string funcOrde(string s)
        {
            return s;
        }

        //Mostrar também a soma dos salários dos funcionários cujo
        //nome começa com a letra 'M'.
        //agora usando static
        public static double SumM(List<Employee> lista, Func<char, char> func)
        {
            double sum = 0.0;
            foreach (Employee employee in lista)
            {
                //Func<char, char> fun = x => x[0] == 'M';
                if (func(employee.Name[0]) == 'M')
                {
                    sum += employee.Salary;
                }
            }
            return sum;
        }
    }
}
