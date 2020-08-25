using System;

namespace CreditCardManagement
{
    class AmExCC: CreditCard
    {
        public AmExCC(CardDetails cardDetails) : base(cardDetails)
        {

        }
        public override bool MakePayment()
        {
            Console.WriteLine("Payment using American Express Card");
            return true;
        }
    }
}
