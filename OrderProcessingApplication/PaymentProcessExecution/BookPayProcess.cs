using OrderProcessingApp.PaymentType_BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp
{
    public class BookPayProcess
    {
        private readonly BookPayment _bookPayment;

        public BookPayProcess(BookPayment bookPayment)
        {
            this._bookPayment = bookPayment;
        }

        public void ExecuteBookPaymentProcess()
        {
            Console.WriteLine("Payment Process started.");

            _bookPayment.CreateDuplicateSlip();
            _bookPayment.GenerateComissionPaymentToAgent();

            Console.WriteLine("Payment Process ended successfully.");
        }


    }
}
