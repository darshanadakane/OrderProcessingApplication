using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingApp.Interfaces;

namespace OrderProcessingApp.PaymentType_BusinessLogic
{
    public class BookPayment: IBook
    {
        public void CreateDuplicateSlip()
        {
            Console.WriteLine("A duplicate slip is created for the royalty department");
        }

        public void GenerateComissionPaymentToAgent()
        {
            Console.WriteLine("Comission payment to the agent is generated.");
        }
    }
}
