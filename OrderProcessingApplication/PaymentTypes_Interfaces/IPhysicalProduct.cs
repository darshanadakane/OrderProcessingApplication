using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Interfaces
{
    public interface IPhysicalProduct
    {
        void GeneratePackageSlip();
        void GenerateComissionPaymentToAgent();
    }
}
