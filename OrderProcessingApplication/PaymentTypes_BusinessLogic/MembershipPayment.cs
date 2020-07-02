using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingApp.Interfaces;

namespace OrderProcessingApp.PaymentType_BusinessLogic
{
    public class MembershipPayment : IMembership
    {
        public void ActivateMembership()
        {
            Console.WriteLine("Membership is activated.");
        }

        public void EmailToOwnerAcknowledgement(string emailid)
        {
            Console.WriteLine("Mail sent to {0} and informed.",emailid);
        }
    }
}
