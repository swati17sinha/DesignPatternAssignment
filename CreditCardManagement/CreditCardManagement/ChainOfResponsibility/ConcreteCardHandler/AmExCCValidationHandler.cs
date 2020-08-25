using CreditCardManagement.Enums;
using System;

namespace CreditCardManagement.ChainOfResponsibility.ConcreteCardHandler
{
    class AmExCCValidationHandler: CardValidationHandler
    {
        public AmExCCValidationHandler(CardValidationHandler handler) : base(handler)
        {

        }
        public override CardType Handle(string cardNumber)
        {
            if (cardNumber.Substring(0, 1) == "3" &&
                (cardNumber[1] == '4' || cardNumber[1] == '7')
                 && cardNumber.Length.Equals(15))
            {
                Console.WriteLine("American Express Handler");
                return CardType.AmExCC;
            }
            else
            {
                return base.Handle(cardNumber);
            }
        }
    }
}
