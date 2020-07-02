using OrderProcessingApplication.Interfaces;
using OrderProcessingApplication.PaymentProcessExecution;
using OrderProcessingApplication.PaymentType_BusinessLogic;


namespace UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void ExecuteMembershipPaymentProcess_EmailAck_ShouldSendSuccessfully()
        {
            var membershipPayProcess = new FakeMembershipPayment();
            var mailIdCheck = membershipPayProcess.EmailToOwnerAcknowledgement("memberemailid@domain.com");
            Assert.AreEqual(1, mailIdCheck);
        }
    }

    public class FakeMembershipPayment : IMembership
    {
        public void ActivateMembership()
        {
            //throw new System.NotImplementedException();
        }

        public int EmailToOwnerAcknowledgement(string ownerEmail)
        {
            if (ownerEmail.Equals("memberemailid@domain.com"))
                return 0;
            else
                return 1;
        }
    }
}
