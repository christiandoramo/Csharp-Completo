// first .NET 6.0 (New .NET) in visual studio 2022
using System.Globalization;
using _13ex01.src.Entities;
using System.Text;

try
{
    //Creating a DATA for the Arquives
    List<Order> orders = new List<Order>();
    Console.WriteLine("----------Order some Products----------");
    Console.Write("How Many Products: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Order #{i + 1}: ");
        Console.Write("Enter the Product Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the unit Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Enter the Quantity: ");
        int qte = int.Parse(Console.ReadLine());
        orders.Add(new Order(name, price, qte));
    }
    //Creating the TXT folder, arquive and folder names.

    //Principal Folder Path
    Console.WriteLine("Initial Path folder for the TXT and CSV arquive:");
    //initial folder path for the 2 folders TXT folder and CSV folder
    string initialPath = Path.GetDirectoryName(Console.ReadLine());
    //ATENÇÃO é necessário colocar + 1 '\' no final do Path senão é lido a pasta anterior

    //File name
    Console.Write("TXT arquive Name: ");
    string txtFileName = Console.ReadLine();
    //Folder name
    Console.Write("TXT arquive Folder Name: ");
    string txtFolderName = Console.ReadLine();
    Console.WriteLine();

    //The TXT folder path
    string txtFolderPath = initialPath + @"\" + $"{txtFolderName}";
    //File Path for TXT
    string txtFilePath = txtFolderPath + @"\" + $"{txtFileName}.txt";

    //Creating Folder for TXT
    Directory.CreateDirectory(txtFolderPath);

    //Creating the CSV folder, arquive and folder names.
    //File name
    Console.Write(@"CSV arquive Name:");
    string csvFileName = Console.ReadLine();
    //Folder name
    Console.Write(@"CSV arquive Folder Name");
    string csvFolderName = Console.ReadLine();

    //The CSV folder path
    string csvFolderPath = initialPath + @"\" + $"{csvFolderName}";
    //File Path for CSV
    string csvFilePath = csvFolderPath + @"\" + $"{csvFileName}.csv";

    //Creating Folder for CSV
    Directory.CreateDirectory(csvFolderPath);



    // Creating the txt Arquive in path txtFilePath
    using (StreamWriter sw = File.AppendText(txtFilePath))
    {
        foreach (Order order in orders)
        {
            sw.WriteLine(order);
        }
    }

    // array lines index each line in the arquive with .txt
    string[] lines = File.ReadAllLines(txtFilePath);

    //Creating a CSV arquive using the TXT arquive in csvFilePath
    using (StreamWriter sw = File.AppendText(csvFilePath))
    {
        // for each lines in the .txt
        foreach (string line in lines)
        {
            //Getting the data using the COMMON SEPARATED VALUES - csv 
            // to create a .csv file 'o' :D
            string[] values = line.Split(",");
            StringBuilder sb = new StringBuilder();
            sb.Append($"{values[0]},");
            sb.Append($"{values[1]},");
            sb.Append($"{values[2]},");
            sb.Append($"{values[3]}");
            sw.WriteLine(sb.ToString());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format Exception: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected: " + e.Message);
}