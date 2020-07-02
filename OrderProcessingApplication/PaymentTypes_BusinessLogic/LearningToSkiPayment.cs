using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingApp.Interfaces;

namespace OrderProcessingApp.PaymentType_BusinessLogic
{
    public class LearningToSkiPayment : ILearningToSkiVideo
    {
        public void AddFirstAidVideo()
        {
            Console.WriteLine("First Aid video is added to the packing slip.");
        }
    }
}
