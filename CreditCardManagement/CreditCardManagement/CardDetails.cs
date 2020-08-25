using CreditCardManagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardManagement
{
    public class CardDetails
    {
        public CardType CardType { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CardHolderName { get; set; }

        public bool VerifyCreditCardNumber()
        {
            // Check digit length for card number

            // check right most digit

            // if both condition are true, 
            return true;
        }
    }
}
