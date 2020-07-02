using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingApp.Interfaces;

namespace OrderProcessingApp.PaymentType_BusinessLogic
{
    public class PhysicalProductPayment: IPhysicalProduct
    {
        public void GeneratePackageSlip()
        {
            Console.WriteLine("A package slip is generated.");
        }

        public void GenerateComissionPaymentToAgent()
        {
            Console.WriteLine("Comission payment to the agent is generated.");
        }
    }
}
