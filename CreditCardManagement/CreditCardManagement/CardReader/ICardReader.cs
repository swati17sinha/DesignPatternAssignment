using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardManagement.CardReader
{
    interface ICardReader
    {
        CardDetails ReadCardDetail();
    }

    public class CardReaderUtil : ICardReader
    {
        public CardDetails ReadCardDetail()
        {
            // Read detail from file
            CardDetails cardDetails = new CardDetails()
            { CardHolderName = "XYZ", CardNumber = "5234567890123123", ExpiryDate = "05/22" };
            //if (cardDetails.VerifyCreditCardNumber())
            return cardDetails;
            //else throw new Exception("Card Number is invalid");
        }
    }
}
