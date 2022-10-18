using System;
using System.Collections.Generic;

public class Product
{
    public string Nome;
    public double Price;

    public Product(string nome, double price)
    {
        Nome = nome;
        Price = price;
    }
    public Product()
    {

    }

    public static double AveragePrice(List<Product> lista)
    {
        double result = 0.0;
        for (int i = 0; i < lista.Count; i++)
        {
            result += lista[i].Price;
        }
        result /= lista.Count;
        return result;
    }
}
