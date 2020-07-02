using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Interfaces
{
    public interface IBook
    {
        void CreateDuplicateSlip();
        void GenerateComissionPaymentToAgent();
    }
}
