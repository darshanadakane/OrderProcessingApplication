using OrderProcessingApp.PaymentType_BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.PaymentProcessExecution
{
    public class UpgradeMembershipProcess
    {
        private readonly UpgradeMembershipPayment _upgradeMembershipPayment;

        public UpgradeMembershipProcess(UpgradeMembershipPayment upgradeMembershipPayment)
        {
            this._upgradeMembershipPayment = upgradeMembershipPayment;
        }

        public void ExecuteUpgradeMembershipPaymentProcess()
        {
            Console.WriteLine("Payment Process started.");

            _upgradeMembershipPayment.ApplyUpgrade();

            Console.WriteLine("Payment Process ended successfully.");
        }

    }
}
