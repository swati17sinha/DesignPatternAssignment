using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardManagement
{
    public abstract class CreditCard
    {
        public CreditCard(CardDetails cardDetails)
        {
            CardHolderName = cardDetails.CardHolderName;
            CardNumber = cardDetails.CardNumber;
            ExpiryDate = cardDetails.ExpiryDate;
        }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string  CardHolderName { get; set; }

        public abstract bool MakePayment();
    }
}
