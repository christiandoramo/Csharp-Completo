using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _14ex01_02_03.src
{
    abstract class PaymentService : IPaymentService
    {
        private int Number { get; set; }
        private DateTime Date { get; set; }
        private double TotalValue { get; set; }
        protected int Installments { get; set; }
        protected double Fee { get; set; }
        protected double Interest { get; set; }


        protected PaymentService(int number, DateTime date, double totalValue, double fee, int installments, double interest)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Fee = fee;
            Interest = interest;
            Installments = installments;
        }

        protected PaymentService(int number, DateTime date, double totalValue, int installments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = installments;
        }

        public string ShowInstallments()
        {
            StringBuilder sb = new StringBuilder();


            if (Installments > 0)
            {
                sb.AppendLine("Installments: ");
                double interest = (100.0 + Interest) / 100.0;
                double fee = (Fee + 100.0) / 100.0;
                double installment = (TotalValue / Installments);
                for (var i = 0; i < Installments; i++)
                {
                    double actualinterest = interest + (i * (interest - 1.0));
                    double quota = (installment * actualinterest * fee);
                    Date = Date.AddDays(1);
                    sb.Append($"{Date.ToShortDateString()} - ");
                    sb.AppendLine(quota.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            else
            {
                sb.AppendLine("Unique Value:" + TotalValue);
            }
            return sb.ToString();
        }
    }
}
