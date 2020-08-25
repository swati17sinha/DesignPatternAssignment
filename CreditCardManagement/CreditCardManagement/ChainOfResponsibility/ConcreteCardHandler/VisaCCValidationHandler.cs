using CreditCardManagement.Enums;
using System;

namespace CreditCardManagement.ChainOfResponsibility.ConcreteCardHandler
{
    class VisaCCValidationHandler: CardValidationHandler
    {
        public VisaCCValidationHandler(CardValidationHandler handler) : base(handler)
        {

        }
        public override CardType Handle(string cardNumber)
        {
            if (cardNumber.Substring(0, 1) == "4" &&
                (cardNumber.Length.Equals(13)) || cardNumber.Length.Equals(16))
            {
                Console.WriteLine("Visa Handler");
                return CardType.VisaCC;
            }
            else
            {
                return base.Handle(cardNumber);
            }
        }
    }
}
