using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardManagement
{
    class VisaCC: CreditCard
    {
        public VisaCC(CardDetails cardDetails) : base(cardDetails)
        {

        }
        public override bool MakePayment()
        {
            Console.WriteLine("Payment using Visa Card");
            return true;
        }
    }
}
