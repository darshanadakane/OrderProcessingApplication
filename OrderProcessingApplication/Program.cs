using System;
using OrderProcessingApplication.PaymentProcessExecution;
using OrderProcessingApplication.PaymentType_BusinessLogic;

namespace OrderProcessingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Order Processing App");
            Console.WriteLine("===================================");
            Console.WriteLine("Please enter payment type:");
            Console.WriteLine("0: Physical Product\n1: Book\n2: Membership\n3: Upgrade\n4: Learning To Ski Video\n");
            int paytype = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================================");

            switch (paytype)
            {
                case 0:
                    var bookPayProcess = new BookPayProcess(new BookPayment());
                    bookPayProcess.ExecuteBookPaymentProcess();
                    break;
                case 1:
                    var learningToSkiPayProcess = new LearningToSkiVideoPayProcess(new LearningToSkiPayment());
                    learningToSkiPayProcess.ExecuteSkiVideoPaymentProcess();
                    break;
                case 2:
                    var membershipPayProcess = new MembershipPayProcess(new MembershipPayment());
                    membershipPayProcess.ExecuteMembershipPaymentProcess("memberemailid@domain.com");
                    break;
                case 3:
                    var physicalProductPayProcess = new PhysicalProductProcess(new PhysicalProductPayment());
                    physicalProductPayProcess.ExecutePhysicalProductPaymentProcess();
                    break;
                case 4:
                    var upgradeMembershipPayProcess = new UpgradeMembershipProcess(new UpgradeMembershipPayment());
                    upgradeMembershipPayProcess.ExecuteUpgradeMembershipPaymentProcess();
                    break;
                default:
                    Console.WriteLine("Incorrect entry entered.");
                    break;
            }
        }
    }
}
