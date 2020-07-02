using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingApp.Interfaces;

namespace OrderProcessingApp.PaymentType_BusinessLogic
{
    public class UpgradeMembershipPayment : IUpgrade
    {
        public void ApplyUpgrade()
        {
            Console.WriteLine("Upgrade to the membership is applied.");
        }
    }
}
