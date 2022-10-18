using System.Globalization;

namespace _09ex01_02_03.src.Entities.Classes
{
    class OrderItem
    {
        private int Quantity { get; set; }
        private double Price { get; set; }
        public Product Product { get; private set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product}, Quantity: {Quantity}, SubTotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
