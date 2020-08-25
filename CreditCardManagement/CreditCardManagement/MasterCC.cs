using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardManagement
{
    internal class MasterCC:CreditCard
    {
        public MasterCC(CardDetails cardDetails): base(cardDetails)
        {
           
        }
        public override bool MakePayment()
        {
            Console.WriteLine("Payment using Master Card");
            return true;
        }
    }
}
