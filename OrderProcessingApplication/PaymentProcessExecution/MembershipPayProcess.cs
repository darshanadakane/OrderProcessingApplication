using OrderProcessingApp.PaymentType_BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.PaymentProcessExecution
{
    public class MembershipPayProcess
    {
        private readonly MembershipPayment _membershipPayment;

        public MembershipPayProcess(MembershipPayment membershipPayment)
        {
            this._membershipPayment = membershipPayment;
        }

        public void ExecuteMembershipPaymentProcess(string emailID)
        {
            Console.WriteLine("Payment Process started.");

            _membershipPayment.ActivateMembership();
            _membershipPayment.EmailToOwnerAcknowledgement(emailID);

            Console.WriteLine("Payment Process ended successfully.");
        }
    }
}
