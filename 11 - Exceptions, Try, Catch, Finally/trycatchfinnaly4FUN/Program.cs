using System;
using System.IO;

namespace trycatchfinnaly4FUN
{
    public class TryCatchFinnaly4FUN
    {
        public static void Main()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open); //realmente na minha pasta temp
                StreamReader sr = new(fs);
                string line = sr.ReadLine();
                string line2 = sr.ReadLine();
                Console.WriteLine(line + "\n" + line2);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}