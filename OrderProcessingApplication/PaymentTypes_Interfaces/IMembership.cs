using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Interfaces
{
    public interface IMembership
    {
        void ActivateMembership();
        void EmailToOwnerAcknowledgement(string ownerEmail);
    }
}
