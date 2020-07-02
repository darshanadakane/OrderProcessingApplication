using OrderProcessingApp.PaymentType_BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.PaymentProcessExecution
{
    public class PhysicalProductProcess
    {
        private readonly PhysicalProductPayment _physicalProductPayment;

        public PhysicalProductProcess(PhysicalProductPayment physicalProductPayment)
        {
            this._physicalProductPayment = physicalProductPayment;
        }

        public void ExecutePhysicalProductPaymentProcess()
        {
            Console.WriteLine("Payment Process started.");

            _physicalProductPayment.GeneratePackageSlip();
            _physicalProductPayment.GenerateComissionPaymentToAgent();

            Console.WriteLine("Payment Process ended successfully.");
        }
    }
}
