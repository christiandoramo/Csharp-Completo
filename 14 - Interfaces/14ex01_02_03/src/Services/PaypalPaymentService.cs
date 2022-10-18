using System;
using System.Collections.Generic;

namespace _14ex01_02_03.src
{
    internal class PaypalPaymentService : PaymentService
    {
        public PaypalPaymentService(int number, DateTime date, double totalValue, int installments) : base(number, date, totalValue, installments)
        {
            Interest = 1.0000;
            Fee = 2.0000;
        }

        public PaypalPaymentService(int number, DateTime date, double totalValue, double fee, int installment, double interest) : base(number, date, totalValue, fee, installment, interest)
        {
        }
    }
}
