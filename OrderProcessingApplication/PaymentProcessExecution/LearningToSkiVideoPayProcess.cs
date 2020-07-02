using OrderProcessingApp.PaymentType_BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.PaymentProcessExecution
{
    public class LearningToSkiVideoPayProcess
    {
        private readonly LearningToSkiPayment _learningToSkiPayment;

        public LearningToSkiVideoPayProcess(LearningToSkiPayment learningToSkiPayment)
        {
            this._learningToSkiPayment = learningToSkiPayment;
        }

        public void ExecuteSkiVideoPaymentProcess()
        {
            Console.WriteLine("Payment Process started.");
            
            _learningToSkiPayment.AddFirstAidVideo();

            Console.WriteLine("Payment Process ended successfully.");
        }
    }
}
