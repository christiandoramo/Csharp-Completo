using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _09ex01_02_03.src.Entities.Classes
{
    class Order
    {
        private System.DateTime Moment { get; set; }
        private _09ex01_02_03.src.Entities.Enums.OrderStatus Status { get; set; }
        private Client Client { get; set; }
        // diferentemente do C++ using namespace NomeDoNameSpace no c# se ysa apenas o NomeDoNameSpace
        List<OrderItem> Lista = new List<OrderItem>();

        public Order(DateTime moment, _09ex01_02_03.src.Entities.Enums.OrderStatus status, Client client)
        // diferentemente do C++ using namespace NomeDoNameSpace no c# se ysa apenas o NomeDoNameSpace
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Lista.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Lista.Remove(orderItem);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem orderItem in Lista)
            {
                total += orderItem.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");

            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine($"Order items:");
            foreach (OrderItem orderItem in Lista)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine($"Total Price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }

    }
}

