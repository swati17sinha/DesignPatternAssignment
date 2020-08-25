using CreditCardManagement.Enums;
using System;

namespace CreditCardManagement.ChainOfResponsibility.ConcreteCardHandler
{
    class DiscoverValidationHandler : CardValidationHandler
    {
        public DiscoverValidationHandler(CardValidationHandler handler) : base(handler)
        {

        }
        public override CardType Handle(string cardNumber)
        {
            if ((cardNumber.Substring(0, 4) == "6011") &&
                cardNumber.Length.Equals(16))
            {
                Console.WriteLine("Discover type Handler");
                return CardType.Discover;
            }
            else
            {
                return base.Handle(cardNumber);
            }
        }
    }
}
