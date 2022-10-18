using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _13ex01.src.Entities
{
    internal class Order
    {
        private string Name { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }

        public Order(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name},");
            sb.Append($"{Quantity},");
            sb.Append($"{Price.ToString("F2", CultureInfo.InvariantCulture)},");
            sb.Append($"{TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}